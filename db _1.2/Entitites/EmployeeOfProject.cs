using System;
using System.Collections.Generic;
using System.Text;

namespace db__1._2.Entitites
{
    public class EmployeeOfProject
    {
        public int EmployeeOfProjectId { get; set; }
        public decimal Rate { get; set; }
        public DateTime DayOfStart { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
