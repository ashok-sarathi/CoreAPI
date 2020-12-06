using HomeData.Context;
using HomeEntity.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeData.Repository.Master
{
    public interface IStudentRepository : IRepository<Student>
    {
    }
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(HomeDbContext context) : base(context) { }
    }
}
