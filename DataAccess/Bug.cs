using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Bug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int CreatorID { get; set; }
        public int PriorityID { get; set; }
        public int SeverityID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string Solved { get; set; }


        public Person Creator { get; set; }

        public Priority Priority { get; set; }

        public Severity Severity { get; set; }
        public List<Message> Messages { get; set; }

        public List<Logs> Logs { get; set; }
    }
}
