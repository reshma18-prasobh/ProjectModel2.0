using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectManagement.API.Models;
using ProjectManagement.API.Models.Repository;
using ProjectManagement.API.Models.DataManager;



namespace ProjectManagement.API.Controllers
{
    [Route("api/[controller]")]
    public class ProjectController : Controller
    {
        private IDataRepository<Project, long> _iRepo; 
        public ProjectController(IDataRepository<Project, long> repo)
        {
            _iRepo = repo;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Project> Get()
        {
            return _iRepo.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Project Get(int id)
        {
            return _iRepo.Get(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Project project)
        {
            _iRepo.Add(project);
        }

        // POST api/values
        [HttpPut]
        public void Put([FromBody]Project project)
        {
            _iRepo.Update(project.ProjectId,project);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public long Delete(int id)
        {
            return _iRepo.Delete(id);
        }
    }
}
