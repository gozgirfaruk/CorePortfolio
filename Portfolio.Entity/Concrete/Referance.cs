using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Entity.Concrete
{
    public class Referance
    {
        public int ReferanceID { get; set; }
        public string ClientName { get; set; }
        public string? CompanyName { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }

    }
}
