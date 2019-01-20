using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using ProjectManager.Models;
using ProjectManager.Repository;

namespace ProjectManager.Web.Controllers
{
    [EnableCors("http://localhost:54511", "*", "*")]
    public class ProjectsController : ApiController
    {
        private IProjectRepository projectRepository;

        public ProjectsController(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Project>> GetProjects()
        {
            return await projectRepository.GetAllAsync();
        }
        
        [HttpPost]
        [ResponseType(typeof(Project))]
        public async Task<IHttpActionResult> PostProject(Project project)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            projectRepository.Create(project);
            await projectRepository.SaveAsync();

            return CreatedAtRoute("DefaultApi", new { id = project.Id }, project);
        }
    }
}