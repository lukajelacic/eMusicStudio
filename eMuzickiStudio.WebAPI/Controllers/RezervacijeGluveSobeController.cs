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

    public class RezervacijeGluveSobeController : BaseCRUDController<Model.RezervacijeGluveSobe, RezervacijaGluveSobeSearchRequest, Model.RezervacijeGluveSobe, Model.RezervacijeGluveSobe>
    {
        public RezervacijeGluveSobeController(ICRUDService<RezervacijeGluveSobe, RezervacijaGluveSobeSearchRequest, RezervacijeGluveSobe, RezervacijeGluveSobe> service) : base(service)
        {
        }
    }
}
