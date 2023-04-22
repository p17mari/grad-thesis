using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldXamarin
{
    public class Teacher// classes should be public the default makes it internal
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; } 
        public string FirstName { get; set; }    
        public string LastName { get; set; }
    }
}
