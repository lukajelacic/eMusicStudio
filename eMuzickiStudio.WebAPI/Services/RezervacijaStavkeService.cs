using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eMuzickiStudio.Model;
using eMuzickiStudio.Model.Requests;
using eMuzickiStudio.WebAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace eMuzickiStudio.WebAPI.Services
{
    public class RezervacijaStavkeService : IRezervacijeStavkeService 
    {
       
        private readonly _150192V1Context _context;
        private readonly IMapper _mapper;
        public RezervacijaStavkeService(_150192V1Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public  List<Model.RezervacijaStavke> Get(RezervacijaStavkeSearchRequest request)
        {
            var list = _context.RezervacijaStavke.Include(x=>x.MuzickaOprema).Where(x => x.RezervacijaId == request.RezervacijaId).ToList();
            return _mapper.Map<List<Model.RezervacijaStavke>>(list);
        }

        public Model.RezervacijaStavke Insert(Model.RezervacijaStavke request)
        {
            var entity = _mapper.Map<Database.RezervacijaStavke>(request);
            _context.RezervacijaStavke.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.RezervacijaStavke>(entity);
        }
    }
}
