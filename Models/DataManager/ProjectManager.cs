using ProjectManagement.API.Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace ProjectManagement.API.Models.DataManager
{
    public class ProjectManager : IDataRepository<Project, long>
    {
        ApplicationContext ctx;
        public ProjectManager(ApplicationContext c)
        {
            ctx = c;
        }

        public Project Get(long id)
        {
            var project = ctx.Projects.FirstOrDefault(b => b.ProjectId == id);
            return project;
        }

        public IEnumerable<Project> GetAll()
        {
            var projects = ctx.Projects.ToList();
            return projects;
        }

        public long Add(Project project)
        {
            ctx.Projects.Add(project);
            long projectID = ctx.SaveChanges();
            return projectID;
        }

        public long Delete(long id)
        {
            int projectID = 0;
            var project = ctx.Projects.FirstOrDefault(b => b.ProjectId == id);
            if (project != null)
            {
                ctx.Projects.Remove(project);
                projectID = ctx.SaveChanges();
            }
            return projectID;
        }

        public long Update(long id, Project item)
        {
            long projectID = 0;
            var project = ctx.Projects.Find(id);
            if (project != null)
            {
                project.ProjectName = item.ProjectName;
                project.ProjectCode = item.ProjectCode;
                project.StartDate = item.StartDate;
                project.EndDate = item.EndDate;
                project.Status = item.Status;
                project.Description = item.Description;

                projectID = ctx.SaveChanges();
            }
            return projectID;
        }
    }
}
