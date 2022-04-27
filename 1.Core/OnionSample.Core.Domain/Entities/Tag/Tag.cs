using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionSample.Core.Domain
{
    public class Tag : BaseEntity
    {
        public string TagName { get; set; }
        public List<Course> Courses { get; set; }
    }
}
