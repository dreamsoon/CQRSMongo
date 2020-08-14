using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using CQRS.Core.Domains;
using CQRS.Service.Serviceses.Student.SQLService;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Controllers
{
    [EnableCors("http://localhost:4200","*","*")]
    [Route("[controller]")]
    [ApiController]
    public class EntryController : ControllerBase
    {
        #region Fields
        private readonly ISQLEntryService _EntryService = null;

        #endregion
        public EntryController(ISQLEntryService entryService)
        {
            _EntryService = entryService;
        }
        [HttpGet("get")]
        public IActionResult Get()
        {
            return Ok(_EntryService.GetAll());
        }

    }
}