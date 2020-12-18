using eMuzickiStudio.Model.Requests;
using eMuzickiStudio.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMuzickiStudio.WebAPI.Services
{
    public interface IKlijentiService
    {
        List<Model.Klijenti> Get(KlijentiSearchRequest request);
        Model.Klijenti GetById(int id);
        Model.Klijenti Insert(KlijentiInsertRequest request);
        Model.Klijenti Update(int id, KlijentiInsertRequest request);
        Model.Klijenti UpdateBanovan(int id, KlijentBanovanRequest request);
        Model.Klijenti Authenticiraj(string username, string password);
        Model.Requests.KlijentBanovanRequest GetKlijenta(int id);
        bool Delete(int id);
    }
}
