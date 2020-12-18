using AutoMapper;
using eMuzickiStudio.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMuzickiStudio.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>().ReverseMap();
            CreateMap<Database.Korisnici, KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.Uloge, Model.Uloge>().ReverseMap();
            CreateMap<Database.Klijenti, Model.Klijenti>().ReverseMap();
            CreateMap<Database.Klijenti, KlijentiInsertRequest>().ReverseMap();
            CreateMap<Database.MuzickaOprema, MuzickaOpremaInsertRequest>().ReverseMap();
            CreateMap<Database.Vrsta, Model.Vrsta>().ReverseMap();
            CreateMap<Database.Vrsta, VrstaInsertRequest>().ReverseMap();
            CreateMap<Database.MuzickaOprema, Model.MuzickaOprema>().ReverseMap();
            CreateMap<Database.MuzickaOprema, MuzickaOpremaUpsertRequest>().ReverseMap();
            CreateMap<Database.Rezervacije, Model.Rezervacija>().ReverseMap();
            CreateMap<Database.Rezervacije, RezervacijeUpsertRequest>().ReverseMap();
            CreateMap<Database.RezervacijaStavke, Model.RezervacijaStavke>().ReverseMap();
            CreateMap<Database.Termini, Model.Termini>().ReverseMap();
            CreateMap<Database.Termini, TerminiInsertRequest>().ReverseMap();
            CreateMap<Database.RezervacijeGluveSobe, Model.RezervacijeGluveSobe>().ReverseMap();
            CreateMap<Database.Ocjene, Model.Ocjene>().ReverseMap();
            CreateMap<Database.Ocjene, OcjenaInsertRequest>().ReverseMap();
            CreateMap<Database.Klijenti, Model.Requests.KlijentBanovanRequest>().ReverseMap();


        }
    }
}
