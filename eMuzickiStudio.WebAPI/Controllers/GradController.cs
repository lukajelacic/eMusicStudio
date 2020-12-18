using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMuzickiStudio.Model;
using eMuzickiStudio.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eMuzickiStudio.WebAPI.Controllers
{

    public class GradController : BaseController<Model.Grad, object>
    {
        public GradController(IService<Grad, object> service) : base(service)
        {
        }
    }
}