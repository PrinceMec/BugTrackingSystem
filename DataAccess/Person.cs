using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string? JobTitle { get; set; }

        public int Salary { get; set; }

        public int YearsOfExperience { get; set; }

        public DateTime HiredDate { get; set; }
        public string Address { get; set; }

        public string? Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<Bug> Bugs { get; set; }




        
    }
}

