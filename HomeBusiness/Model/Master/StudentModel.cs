using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBusiness.Model.Master
{
    public class StudentModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Guid SectionId { get; set; }
    }
}
