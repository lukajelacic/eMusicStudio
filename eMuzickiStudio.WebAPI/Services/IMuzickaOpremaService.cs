using eMuzickiStudio.Model.Requests;
using eMuzickiStudio.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMuzickiStudio.WebAPI.Services
{
    public interface IMuzickaOpremaService
    {
        List<Model.MuzickaOprema> Get(MuzickaOpremaSearchRequest request);
        Model.MuzickaOprema GetById(int id);
        Model.MuzickaOprema Insert(MuzickaOpremaInsertRequest request);
    }
}
