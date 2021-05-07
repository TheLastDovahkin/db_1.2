using System;
using System.Collections.Generic;
using System.Text;

namespace db__1._2.Entitites
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string NameOfProject { get; set; }
        public decimal Budget { get; set; }
        public DateTime InitialDate { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public List<EmployeeProject> EmployeeOfProjects { get; set; } = new List<EmployeeProject>();
    }
}
