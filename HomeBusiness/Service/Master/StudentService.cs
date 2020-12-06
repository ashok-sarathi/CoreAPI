using HomeBusiness.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace HomeBusiness.Service.Master
{
    public interface IStudentService
    {
        IEnumerable<StudentModel> GetAll();
    }
    public class StudentService :  IStudentService
    {
        IUow _uow;
        public StudentService(IUow uow)
        {
            _uow = uow;
        }

        public IEnumerable<StudentModel> GetAll()
        {
            return _uow.Student.GetAll().Select( o => new StudentModel()
            {
                Id = o.Id,
                Name = o.Name,
                SectionId = o.SectionId
            }).ToList();
        }
    }
}
