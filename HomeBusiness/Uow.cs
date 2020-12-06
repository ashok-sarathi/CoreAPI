using HomeData.Context;
using HomeData.Repository.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBusiness
{
    public class Uow : IUow
    {
        HomeDbContext _context = default(HomeDbContext);
        public Uow(HomeDbContext dbContext)
        {
            _context = dbContext;
        }

        private IStudentRepository _studentRepository;
        public IStudentRepository Student
        {
            get
            {
                return _studentRepository = _studentRepository ?? new StudentRepository(_context);
            }
        }

        private ISectionRepository _sectionRepository;
        public ISectionRepository Section
        {
            get
            {
                return _sectionRepository = _sectionRepository ?? new SectionRepository(_context);
            }
        }

        public async void Dispose()
        {
            await _context.DisposeAsync();
        }
    }
}
