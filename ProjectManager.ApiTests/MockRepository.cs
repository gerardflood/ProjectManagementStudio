using ProjectManager.Models;
using ProjectManager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Web.ControllersTests
{
    public class MockRepository : IProjectRepository
    {
        List<Project> projects;

        public bool FailGet { get; set; }

        public MockRepository()
        {
            projects = new List<Project>() {
            new Project(){Id=1, Title="Title1", Description="Description 1"},
            new Project(){Id=2, Title="Title2", Description="Description 2"},
            new Project(){Id=3, Title="Title3", Description="Description 3"},
            new Project(){Id=4, Title="Title4", Description="Description 4"}
        };
        }

        public async Task<IEnumerable<Project>> GetAllAsync()
        {
            if (FailGet)
            {
                throw new InvalidOperationException();
            }

            await Task.Delay(300);

            return projects;
        }

        public Task<Project> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Project entity)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
