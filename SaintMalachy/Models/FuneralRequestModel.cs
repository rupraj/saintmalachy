using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaintMalachy.Models
{
    public class FuneralRequestModel
    {
        public int FuneralRequestModelId { get; set; }
        public string NameOfDeceased { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfDeath { get; set; }
        public string KinRelationship { get; set; }
        public string KinAddress { get; set; }
        public string KinPhoneNumber { get; set; }
        public string FuneralHome { get; set; }
        public string FuneralHomeAddress { get; set; }
        public string FuneralHomeUrl { get; set; }
        public string DateOfFuneral { get; set; }
        public string TimeOfFuneral { get; set; }
        public string DateOfWake { get; set; }
        public string TimeOfWake { get; set; }
        public string Cemetry { get; set; }
        public string Comments { get; set; }
    }
}