using ProjectManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Repository
{
    public class ProjectManagerDbContext : DbContext
    {
        public ProjectManagerDbContext() :
          base("ProjectManager")
        {
        }

        public DbSet<Project> Projects { get; set; }
    }
}
