using System;
using System.Collections.Generic;
using System.Text;

namespace db__1._2.Entitites
{
    public class EmployeeProject
    {
        public int EmployeeOfProjectId { get; set; }
        public decimal Rate { get; set; }
        public DateTime StartDate { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}
