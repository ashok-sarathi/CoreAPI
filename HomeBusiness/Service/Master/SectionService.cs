using HomeBusiness.Model.Master;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace HomeBusiness.Service.Master
{
    public interface ISectionService
    {
        IEnumerable<SectionModel> GetAll();
    }
    public class SectionService :  ISectionService
    {
        IUow _uow;
        public SectionService(IUow uow)
        {
            _uow = uow;
        }

        public IEnumerable<SectionModel> GetAll()
        {
            return _uow.Section.GetAll().Select( o => new SectionModel()
            {
                Id = o.Id,
                Name = o.Name,
            }).ToList();
        }
    }
}
