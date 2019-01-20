using ProjectManager.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManager.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private ProjectManagerDbContext context;

        public ProjectRepository(ProjectManagerDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Project>> GetAllAsync()
        {
            return await context.Projects.ToListAsync();
        }

        public async Task<Project> GetById(int id)
        {
            return await context.Projects.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Create(Project entity)
        {
            context.Projects.Add(entity);
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
