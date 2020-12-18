using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMuzickiStudio.Model.Requests;
using eMuzickiStudio.WebAPI.Database;
using eMuzickiStudio.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eMuzickiStudio.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Model.Korisnici>> Get([FromQuery]KorisniciSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public ActionResult<Model.Korisnici> GetById(int id)
        {
            return _service.GetById(id); 

        }
        [Authorize(Roles ="1")]
        [HttpPost]
        public ActionResult<Model.Korisnici> Insert(KorisniciInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public ActionResult<Model.Korisnici> Update(int id,KorisniciInsertRequest request)
        {
            return _service.Update(id,request);
        }
        [Authorize(Roles ="1")]
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}