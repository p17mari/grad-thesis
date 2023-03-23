using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace HelloWorldXamarin
{
    public class Formtest //this will connect with database
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
      //  public string email { get; set; }
      //  public string password { get; set; }
    }
}
