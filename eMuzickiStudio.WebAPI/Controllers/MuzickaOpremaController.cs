using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMuzickiStudio.Model;
using eMuzickiStudio.Model.Requests;
using eMuzickiStudio.WebAPI.Database;
using eMuzickiStudio.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eMuzickiStudio.WebAPI.Controllers
{

    public class MuzickaOpremaController : BaseCRUDController<Model.MuzickaOprema, MuzickaOpremaSearchRequest, MuzickaOpremaUpsertRequest, MuzickaOpremaUpsertRequest>
    {
        public MuzickaOpremaController(ICRUDService<Model.MuzickaOprema, MuzickaOpremaSearchRequest, MuzickaOpremaUpsertRequest, MuzickaOpremaUpsertRequest> service) : base(service)
        {
        }
    }
}