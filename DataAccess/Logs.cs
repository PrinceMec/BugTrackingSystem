using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Logs
    {
        public int Id { get; set; }
        public int BugID { get; set; }
        public string? Text { get; set; }
        public DateTime CreationDate { get; set; }


        public virtual Bug Bug { get; set; }
    }
}
