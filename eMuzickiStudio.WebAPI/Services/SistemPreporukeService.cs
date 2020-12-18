using AutoMapper;
using eMuzickiStudio.Model;
using eMuzickiStudio.WebAPI.Database;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMuzickiStudio.WebAPI.Services
{
    public class SistemPreporukeService : ISistemPreporuke
    {
        private readonly _150192V1Context _context;
        private readonly IMapper _mapper;
        Dictionary<int, List<Database.Ocjene>> proizvodi = new Dictionary<int, List<Database.Ocjene>>();
        public SistemPreporukeService(_150192V1Context context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.MuzickaOprema> Get(int id)
        {
            UcitajOpremu(id);
            List<Database.Ocjene> ocjenePosmatranogInstrumenta = _context.Ocjene.Where(x => x.MuzickaOpremaId == id).OrderBy(x => x.KlijentId).ToList();
            List<Database.Ocjene> zajednickeOcjene1 = new List<Database.Ocjene>();
            List<Database.Ocjene> zajednickeOcjene2 = new List<Database.Ocjene>();
            List<Model.MuzickaOprema> preporuceniProizvodi = new List<Model.MuzickaOprema>();
            foreach(var item in proizvodi)
            {
                foreach(var o in ocjenePosmatranogInstrumenta)
                {
                    if (item.Value.Where(x => x.KlijentId == o.KlijentId).Count() > 0)
                    {
                        zajednickeOcjene1.Add(o);
                        zajednickeOcjene2.Add(item.Value.Where(x => x.KlijentId == o.KlijentId).First());
                    }
                }
                double slicnost = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);
                if (slicnost > 0.5)
                {
                    var temp = _context.MuzickaOprema.Find(item.Key);
                    Model.MuzickaOprema opremaTemp = _mapper.Map<Model.MuzickaOprema>(temp);
                    preporuceniProizvodi.Add(opremaTemp);
                }
                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();
            }

            return preporuceniProizvodi;
        }

        private double GetSlicnost(List<Database.Ocjene> zajednickeOcjene1, List<Database.Ocjene> zajednickeOcjene2)
        {
            if (zajednickeOcjene1.Count != zajednickeOcjene2.Count)
                return 0;
            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;

            for (int i = 0; i < zajednickeOcjene1.Count; i++)
            {
                brojnik = zajednickeOcjene1[i].Ocjena * zajednickeOcjene2[i].Ocjena;
                nazivnik1 = zajednickeOcjene1[i].Ocjena * zajednickeOcjene1[i].Ocjena;
                nazivnik2 = zajednickeOcjene2[i].Ocjena * zajednickeOcjene2[i].Ocjena;
            }
            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);
            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0)
            {
                return 0;
            }
            else
            {
                return brojnik / nazivnik;
            }
        }

        private void UcitajOpremu(int id)
        {
            List<Database.MuzickaOprema> muzickaOprema = _context.MuzickaOprema.Where(x => x.MuzickaOpremaId != id).ToList();
            List<Database.Ocjene> ocjene;
            foreach(Database.MuzickaOprema item in muzickaOprema)
            {
                ocjene = _context.Ocjene.Where(x => x.MuzickaOpremaId == item.MuzickaOpremaId).OrderBy(x => x.KlijentId).ToList();
                if (ocjene.Count > 0)
                    proizvodi.Add(item.MuzickaOpremaId, ocjene);
            }
        }
    }
}
