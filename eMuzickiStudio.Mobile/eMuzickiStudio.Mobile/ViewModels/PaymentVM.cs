using System;
using System.Collections.Generic;
using System.Text;
using Acr.UserDialogs;
using eMuzickiStudio.Mobile.Models;
using eMuzickiStudio.Mobile.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using eMuzickiStudio.Model.Requests;
using eMuzickiStudio.Model;
using System.Windows.Input;
using Stripe;


namespace eMuzickiStudio.Mobile.ViewModels
{
    public class PaymentVM : BindableBase
    {
        private readonly APIService _serviceRezervacije = new APIService("Rezervacije");
        private readonly APIService _serviceKlijenti = new APIService("Klijenti");


        private CreditCardModel _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;
        private bool _isCarcValid;
        private bool _isTransectionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;


        private int _rezervacijaId;
        private int _klijentId;

        public Rezervacija _rezervacija;
        public Rezervacija Rezervacija
        {
            get { return _rezervacija; }
            set { SetProperty(ref _rezervacija, value); }
        }
      
        public Klijenti _klijent;
        public Klijenti Klijent
        {
            get { return _klijent; }
            set { SetProperty(ref _klijent, value); }
        }

        private string StripeTestApiKey = "pk_test_51HWNyUEVaAhw9o75SOUGuUelljk3h6q8qsETHaJi8FFLXUa0wbrYaXdZR5kvyJMUsio6J3jQRlxES4Fr1YAHbrXc00yMFgITZz";
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }

        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }

        public bool IsTransectionSuccess
        {
            get { return _isTransectionSuccess; }
            set { SetProperty(ref _isTransectionSuccess, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }

        public CreditCardModel CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }

        private readonly INavigation Navigation;

        public PaymentVM(int RezervacijaId, int KlijentId, INavigation nav)
        {
            _rezervacijaId = RezervacijaId;
            _klijentId = KlijentId;
            this.Navigation = nav;
            CreditCardModel = new CreditCardModel();
            Title = "Card Details";
            
        }

        public PaymentVM()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            await UcitajPodatkeZaUplatu();
        }

        private async Task UcitajPodatkeZaUplatu()
        {
            
            var temp = await _serviceRezervacije.GetById<Model.Rezervacija>(_rezervacijaId);
          
            Rezervacija = temp;
            var username = APIService.Username;
            var klijenti = await _serviceKlijenti.Get<List<Model.Klijenti>>(new KlijentiSearchRequest()
            {
                KorisnickoIme = username
            });
            var klijent = klijenti[0];
            Klijent = klijent;
        }

        public  DelegateCommand SubmitCommand => new DelegateCommand(async () =>
        {
            //int expirationMonth;
            //int expirationYear;
            bool isNumber = int.TryParse(ExpMonth, out int expirationMonth);
            bool isNumber2 = int.TryParse(ExpYear, out int expirationYear);
            if (isNumber)
            {
                CreditCardModel.ExpMonth = expirationMonth;
            }
            else
            {
                UserDialogs.Instance.Alert("Unesite ispravnu vrijednost mjeseca.");
                return;
            }
            if (isNumber2)
            {
                CreditCardModel.ExpYear = expirationYear;
            }
            else
            {
                UserDialogs.Instance.Alert("Unesite ispravnu vrijednost godine.");
                return;
            }
            CreditCardModel.ExpMonth = Convert.ToInt64(ExpMonth);
            CreditCardModel.ExpYear = Convert.ToInt64(ExpYear);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                UserDialogs.Instance.ShowLoading("Payment processing..");
                await Task.Run(async () =>
                {

                    var Token = CreateTokenAsync();
                    Console.Write("eMuzickiStudio" + "Token :" + Token);
                    if (Token.ToString() != null)
                    {
                        IsTransectionSuccess = await MakePaymentAsync(Token.Result);
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Bad card credentials", null, "OK");
                    }
                });
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");
                Console.Write("eMuzickiStudio" + ex.Message);
            }
            finally
            {
                if (IsTransectionSuccess)
                {
                    var rezervacija = await _serviceRezervacije.GetById<Model.Rezervacija>(_rezervacijaId);
                    rezervacija.Status = true;
                    await _serviceRezervacije.Update<Model.Rezervacija>(rezervacija.RezervacijaId, rezervacija);
                    await Navigation.PopToRootAsync();
                    Console.Write("eMuzickiStudio" + "Payment Successful ");
                    UserDialogs.Instance.HideLoading();
                }
                else
                {

                    UserDialogs.Instance.HideLoading();
                    UserDialogs.Instance.Alert("Oops, something went wrong", "Payment failed", "OK");
                    Console.Write("eMuzickiStudio" + "Payment Failure ");
                }
            }

        });

        private async Task<string> CreateTokenAsync()
        {
            await UcitajPodatkeZaUplatu();
            try
            {
                StripeConfiguration.ApiKey = StripeTestApiKey;
                var service = new ChargeService();
                var Tokenoptions = new TokenCreateOptions
                {
                    Card = new CreditCardOptions
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name = Klijent.KorisnickoIme,
                        AddressLine1 = "Lastvanska",
                        AddressLine2 = "37",
                        AddressCity = Klijent.Grad.ToString(),
                        AddressZip = "88000",
                        AddressState = "Trebinje",
                        AddressCountry = "Bosna i Hercegovina",
                        Currency = "bam",
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> MakePaymentAsync(string token)
        {
            await UcitajPodatkeZaUplatu();
            var stringUkupnaCijena = Convert.ToInt32(Rezervacija.Cijena);
            string kpnCijena = stringUkupnaCijena.ToString();
            string opisRezervacije = "Uplata za " + Rezervacija.BrojRezervacije + " : " + Rezervacija.DatumRezervacije.ToShortDateString();
            try
            {
                StripeConfiguration.ApiKey = "sk_test_51HWNyUEVaAhw9o75fjBO4IcASVresjdKc5bALhpLBVoaBQhYQDwYRkXUlbr5V3ZPhLkxye8bDwcWQWYuUbCrUPCm00bgLMx1Ly";
                var options = new ChargeCreateOptions();

                options.Amount = (long)float.Parse(kpnCijena)*100;
                options.Currency = "bam";
                options.Description = opisRezervacije + "klijent: " + GlobalKlijent.Username;
                options.Source = stripeToken.Id;
                options.StatementDescriptor = "Custom descriptor";
                options.Capture = true;
                options.ReceiptEmail = Klijent.Email.ToString();
                //Make Payment
                var service = new ChargeService();
                Charge charge = service.Create(options);
                UserDialogs.Instance.Alert("Uspješno ste platili rezervaciju. ");
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("eMuzickiStudio (CreateCharge)" + ex.Message);
                throw ex;
            }
        }

        private bool ValidateCard()
        {
            if (CreditCardModel.Number.Length == 16 && ExpMonth.Length == 2 && ExpYear.Length == 2 && CreditCardModel.Cvc.Length == 3)
            {
            }
            return true;
        }
    }
}