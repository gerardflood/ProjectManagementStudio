using ProjectManager.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectManager.Repository
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> GetAllAsync();

        Task<Project> GetById(int id);

        void Create(Project entity);

        Task SaveAsync();
    }
}