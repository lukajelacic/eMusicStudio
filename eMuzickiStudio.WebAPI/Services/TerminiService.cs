using AutoMapper;
using eMuzickiStudio.Model.Requests;
using eMuzickiStudio.WebAPI.Database;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMuzickiStudio.WebAPI.Services
{
    public class TerminiService : BaseCRUDService<Model.Termini, TerminiSearchRequest, Database.Termini, TerminiInsertRequest, TerminiInsertRequest>
    {
        public TerminiService(_150192V1Context context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.Termini> Get(TerminiSearchRequest search)
        {
            var query = _context.Set<Database.Termini>().AsQueryable();
            if (search?.Datum.HasValue == true)
            {
                DateTime date = new DateTime();
                date = search.Datum.Value;
                query = query.Where(x => x.Datum.Date.CompareTo(date.Date) == 0);
            }
            if (search?.Aktivan.HasValue == true)
            {
                query = query.Where(x => x.Aktivan == true);
            }
            var list = query.ToList();
            return _mapper.Map<List<Model.Termini>>(list);

        }
    }
}
