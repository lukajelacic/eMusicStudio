using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMuzickiStudio.Model.Requests;
using eMuzickiStudio.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eMuzickiStudio.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RezervacijeController : ControllerBase
    {
        private readonly IRezervacijeService _service;
        public RezervacijeController(IRezervacijeService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Model.Rezervacija>> Get([FromQuery]RezervacijeSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public ActionResult<Model.Rezervacija> GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public ActionResult<Model.Rezervacija> Insert(RezervacijeUpsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public ActionResult<Model.Rezervacija> Update(int id,RezervacijeUpsertRequest request)
        {
            return _service.Update(id, request);
        }
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}