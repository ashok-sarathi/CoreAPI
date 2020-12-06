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
        StudentModel GetSingle(Guid id);
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

        public StudentModel GetSingle(Guid id)
        {
            var data = _uow.Student.GetSingle(id);
            return new StudentModel()
            {
                Id = data.Id,
                Name = data.Name,
                SectionId = data.SectionId
            };
        }
    }
}
