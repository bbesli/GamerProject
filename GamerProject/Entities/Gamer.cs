using System;
using System.Collections.Generic;
using System.Text;

namespace GamerProject.Entities
{
    public class Gamer
    {
        public int Id { get; set; }
        public long Identity { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
