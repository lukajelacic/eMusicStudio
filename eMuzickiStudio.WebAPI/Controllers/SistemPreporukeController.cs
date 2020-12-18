using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMuzickiStudio.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eMuzickiStudio.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemPreporukeController : ControllerBase
    {
        private readonly ISistemPreporuke _service;
        public SistemPreporukeController(ISistemPreporuke service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Model.MuzickaOprema> Get(int id)
        {
            return _service.Get(id);
        }
    }
}
