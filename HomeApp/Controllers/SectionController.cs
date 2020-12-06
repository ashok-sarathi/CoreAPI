using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeBusiness.Model.Master;
using HomeBusiness.Service.Master;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionController : ControllerBase
    {
        ISectionService _service;
        public SectionController(ISectionService service)
        {
            _service = service;
        }

        [HttpGet("[action]")]
        public IEnumerable<SectionModel> GetAll()
        {
            return _service.GetAll();
        }
    }
}
