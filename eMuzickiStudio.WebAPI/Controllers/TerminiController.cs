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

    public class TerminiController : BaseCRUDController<Model.Termini, TerminiSearchRequest, TerminiInsertRequest, TerminiInsertRequest>
    {
        public TerminiController(ICRUDService<Termini, TerminiSearchRequest, TerminiInsertRequest, TerminiInsertRequest> service) : base(service)
        {
        }
    }
}