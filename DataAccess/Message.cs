using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Message
    {

        public int Id { get; set; }
        public int BugId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime CreationDate { get; set; }
        public int CreatorId { get; set; }



        public Bug Bug { get; set; }
    }
}
