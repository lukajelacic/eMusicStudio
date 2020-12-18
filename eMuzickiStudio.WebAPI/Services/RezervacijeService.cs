using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using eMuzickiStudio.Model;
using eMuzickiStudio.Model.Requests;
using eMuzickiStudio.WebAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace eMuzickiStudio.WebAPI.Services
{
    public class RezervacijeService : IRezervacijeService
    {
        private readonly _150192V1Context _context;
        private readonly IMapper _mapper;
        public RezervacijeService(_150192V1Context context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool Delete(int id)
        {
            var entity = _context.Rezervacije.Find(id);
            _context.Rezervacije.Remove(entity);
            _context.SaveChanges();
            return true;
        }

        public List<Model.Rezervacija> Get(RezervacijeSearchRequest request)
        {
            var query = _context.Rezervacije.Include(x=>x.Klijent).AsQueryable();
            if (request.Status.HasValue)
            {
                query = query.Where(x => x.Status == request.Status);
            }
            if (request.KlijentId != 0)
            {
                query = query.Where(x => x.KlijentId == request.KlijentId);
            }
            
            var list = query.ToList();
           // var list = _context.Rezervacije.Include(x=>x.Klijent).Where(x=>x.Status==request.Status).ToList();
            return _mapper.Map<List<Model.Rezervacija>>(list);
        }

        public List<Model.Rezervacija> GetByDatum(RezervacijeSearchRequest request)
        {
            var query = _context.Rezervacije.Include(x => x.Klijent).AsQueryable();
            //if (request.Status.HasValue)
            //{
            //    query = query.Where(x => x.Status == request.Status);
            //}
            //if (request.KlijentId != 0)
            //{
            //    query = query.Where(x => x.KlijentId == request.KlijentId);
            //}
            if (request.DatumRezervacije != null)
            {
                query = query.Where(x => x.DatumRezervacije.Date == request.DatumRezervacije.Date);
            }
            var list = query.ToList();
            // var list = _context.Rezervacije.Include(x=>x.Klijent).Where(x=>x.Status==request.Status).ToList();
            return _mapper.Map<List<Model.Rezervacija>>(list);
        }

        public Model.Rezervacija GetById(int id)
        {
            var result = _context.Rezervacije.Find(id);
            return _mapper.Map<Model.Rezervacija>(result);
        }

        public Model.Rezervacija Insert(RezervacijeUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Rezervacije>(request);
            _context.Rezervacije.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Rezervacija>(entity);
        }

        public Model.Rezervacija Update(int id,RezervacijeUpsertRequest request)
        {
            var entity = _context.Rezervacije.Find(id);
            _context.Rezervacije.Attach(entity);
            _context.Rezervacije.Update(entity);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Rezervacija>(entity);
        }
    }
}
