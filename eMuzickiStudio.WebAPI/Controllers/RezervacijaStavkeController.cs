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
    [Route("api/[controller]")]
    [ApiController]
    public class RezervacijaStavkeController : ControllerBase
    {
        private readonly IRezervacijeStavkeService _service;
        public RezervacijaStavkeController(IRezervacijeStavkeService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Model.RezervacijaStavke>> Get([FromQuery] RezervacijaStavkeSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpPost]
        public ActionResult<Model.RezervacijaStavke> Insert(Model.RezervacijaStavke request)
        {
            return _service.Insert(request);
        }
      
    }
}