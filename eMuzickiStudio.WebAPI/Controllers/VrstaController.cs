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

    public class VrstaController : BaseController<Model.Vrsta, object>
    {
        public VrstaController(IService<Vrsta, object> service) : base(service)
        {
        }
    }
}