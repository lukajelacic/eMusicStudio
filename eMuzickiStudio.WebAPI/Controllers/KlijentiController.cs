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
    public class KlijentiController : ControllerBase
    {
        private readonly IKlijentiService _service;
        public KlijentiController(IKlijentiService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Model.Klijenti>> Get([FromQuery]KlijentiSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet("{id}")]
        public ActionResult<Model.Klijenti> GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpGet("GetKlijenta/{id}")]
        public ActionResult<Model.Requests.KlijentBanovanRequest> GetKlijenta(int id)
        {
            return _service.GetKlijenta(id);
        }
        [HttpPost]
        public ActionResult<Model.Klijenti> Insert(KlijentiInsertRequest request)
        {
            return _service.Insert(request);
        }
        [HttpPut("{id}")]
        public ActionResult<Model.Klijenti> Update(int id,KlijentiInsertRequest request)
        {
            return _service.Update(id, request);
        }
        [HttpPut("UpdateBanovan/{id}")]
        public ActionResult<Model.Klijenti> UpdateBanovan(int id,KlijentBanovanRequest request)
        {
            return _service.UpdateBanovan(id, request);
        }
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}