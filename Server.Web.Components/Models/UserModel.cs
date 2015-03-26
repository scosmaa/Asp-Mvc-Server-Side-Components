using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server.Web.Components.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public User()
        {
            Name = "John";
            Surname = "Doe";
            Age = 30;
        }
    }
}