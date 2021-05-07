using System;
using System.Collections.Generic;
using System.Text;

namespace db__1._2.Entitites
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime HiredDate { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public int TitleId { get; set; }
        public virtual Title Title { get; set; }

        public int OfficeId { get; set; }
        public virtual Office Office { get; set; }

        public virtual List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    }
}
