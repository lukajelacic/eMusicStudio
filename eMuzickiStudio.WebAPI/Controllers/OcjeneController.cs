using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMuzickiStudio.Model;
using eMuzickiStudio.Model.Requests;
using eMuzickiStudio.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eMuzickiStudio.WebAPI.Controllers
{

    public class OcjeneController : BaseCRUDController<Model.Ocjene, object, OcjenaInsertRequest, OcjenaInsertRequest>
    {
        public OcjeneController(ICRUDService<Ocjene, object, OcjenaInsertRequest, OcjenaInsertRequest> service) : base(service)
        {
        }
    }
}
