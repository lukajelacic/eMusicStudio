    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eMuzickiStudio.Model.Requests;
using eMuzickiStudio.WebAPI.Database;

namespace eMuzickiStudio.WebAPI.Services
{
    public class MuzickaOpremaService : BaseCRUDService<Model.MuzickaOprema,MuzickaOpremaSearchRequest,Database.MuzickaOprema,MuzickaOpremaUpsertRequest,MuzickaOpremaUpsertRequest>
    {
        public MuzickaOpremaService(_150192V1Context context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Model.MuzickaOprema> Get(MuzickaOpremaSearchRequest search)
        {
            var query = _context.Set<Database.MuzickaOprema>().AsQueryable();
            if (search?.VrstaId.HasValue == true)
            {
                query = query.Where(x => x.VrstaId == search.VrstaId);
            }
            query = query.OrderBy(x => x.Naziv);
            var list = query.ToList();
            return _mapper.Map<List<Model.MuzickaOprema>>(list);
        }

    }
}
