using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectManager.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Web.ControllersTests
{
    [TestClass()]
    public class ProjectsControllerTests
    {
        [TestMethod()]
        public void GetProjectsTest()
        {
            // Arrange
            var repository = new MockRepository();
            var controller = new ProjectsController(repository);

            // Act
            var result = controller.GetProjects().Result;

            // Assert
            Assert.AreEqual(4, result.Count());
        }
    }
}