using HomeData.Context;
using HomeEntity.Master;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeData.Repository.Master
{
    public interface ISectionRepository : IRepository<Section>
    {
    }
    public class SectionRepository : Repository<Section>, ISectionRepository
    {
        public SectionRepository(HomeDbContext context) : base(context) { }
    }
}
