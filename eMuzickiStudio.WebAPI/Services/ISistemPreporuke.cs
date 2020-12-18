using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMuzickiStudio.WebAPI.Services
{
    public interface ISistemPreporuke
    {
        List<Model.MuzickaOprema> Get(int id);
    }
}
