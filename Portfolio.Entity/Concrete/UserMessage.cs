using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Entity.Concrete
{
	public class UserMessage
	{
		public int UserMessageID { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime Date { get; set; }
		public bool Status { get; set; }

        public int UserSysID { get; set; }
        public UserSys UserSys { get; set; }
    }
}
