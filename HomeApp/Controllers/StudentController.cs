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
    public class StudentController : ControllerBase
    {
        IStudentService _service;
        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet("[action]")]
        public IEnumerable<StudentModel> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("[action]/{id}")]
        public StudentModel GetSingle(Guid id)
        {
            return _service.GetSingle(id);
        }

    }
}
