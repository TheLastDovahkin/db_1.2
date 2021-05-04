using System;
using System.Collections.Generic;
using System.Text;

namespace db__1._2.Entitites
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Company { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
