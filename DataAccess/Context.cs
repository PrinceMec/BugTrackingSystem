using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Context: DbContext
    {
        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Logs> Logs { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Severity> Severity { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=LAPTOP-H7UTGEOV\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; initial catalog=BugTrackingSystem");
        }
    }
}
