using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eMuzickiStudio.WebAPI.Database;

namespace eMuzickiStudio.WebAPI.Services
{
    public class GradService : BaseService<Model.Grad, object, Database.Grad>
    {
        public GradService(_150192V1Context context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
