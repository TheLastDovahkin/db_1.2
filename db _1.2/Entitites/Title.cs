using System;
using System.Collections.Generic;
using System.Text;

namespace db__1._2.Entitites
{
    public  class Title
    {
        public int TitleId { get; set; }
        public string NameOfTitle { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
