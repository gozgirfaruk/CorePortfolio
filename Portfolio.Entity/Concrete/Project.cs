using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Entity.Concrete
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Name { get; set; }
        public string  Platform { get; set; }
        public string ImageUrl { get; set; }
        public string ProjectUrl { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public bool Status { get; set; }
        public int Values { get; set; }

    }
}
