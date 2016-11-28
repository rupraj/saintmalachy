using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaintMalachy.Models
{
    public class ErrorLog
    {
        public int Id { get; set; }
        public string stackTrace { get; set; }
        public string model { get; set; }
        public string modulename { get; set; }
        public DateTime createdon { get; set; }
    }
}