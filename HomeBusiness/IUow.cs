using System;
using System.Collections.Generic;
using System.Text;
using HomeData.Repository.Master;
using HomeEntity.Master;

namespace HomeBusiness
{
    public interface IUow : IDisposable
    {
        public IStudentRepository Student { get; }
        public ISectionRepository Section { get; }
    }
}
