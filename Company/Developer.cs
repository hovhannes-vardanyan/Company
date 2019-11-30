using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    enum State
    {
        Open,
        Closed
    }
    struct Project
    {
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public string Details { get; set; }
        public State  ProjectState { get; set; }
        public Project(string projectName, DateTime startDate, string details, State projectState)
        {
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.ProjectState = projectState;
            this.Details = details;
        }

    }

    class Developer : Employee
    {
        public List<Project> Projects { get ; set ; }
        
        public Developer(int id, string name, string lastname, int salary, Departament dep, List<Project> projects) 
            :base(id, name, lastname, salary, dep)
        {
            this.Projects = projects;
        }
        // Veradarcnum e Projecti masin tvyalnery stringi tesqov
        public string GetProjects()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("His/Her Project\n");
            foreach (var project in Projects)
            {
                sb.Append($"{project.ProjectName},{project.StartDate},{project.ProjectState.ToString()}\n");
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return "Developer " + base.ToString() +  GetProjects();
        }

    }
}
