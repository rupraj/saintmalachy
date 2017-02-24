using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SaintMalachy.Models
{
    public class RaceForGrace
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string DateOfBirth { get; set; }
        public string Interest { get; set; }
        public string CreatedDate { get; set; } = DateTime.Now.ToString();
    }
}