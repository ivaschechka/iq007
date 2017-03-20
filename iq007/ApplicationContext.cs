using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iq007.Model;

namespace iq007
{
    class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection")
        {

        }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<Record> Records{ get; set; }
        public DbSet<Payment> Payments{ get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<PupilsBranch> PupilsBranches{ get; set; }
        public DbSet<Teacher> Teachers{ get; set; }
    }
}
