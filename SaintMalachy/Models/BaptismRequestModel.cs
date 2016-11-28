using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SaintMalachy.Models
{
    public class BaptismRequestModel
    {
        public int BaptismRequestModelId { get; set; }
        public string BaptismDate { get; set; }
        public string DinnerDate { get; set; }
        public string ChildLastName { get; set; }
        public string ChildName { get; set; }
        public string ChildDateOfBirth { get; set; }
        public string ChildPlaceOfBirth { get; set; }
        public string FatherFullName { get; set; }
        public string MotherFirstName { get; set; }
        public string MotherMaidenName { get; set; }
        public string ParentsMarried { get; set; }
        public string ChurchMarriage { get; set; }
        public string ParentsConfirmed { get; set; }
        public string Address { get; set; }
        public string CityState { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string GodfatherName { get; set; }
        public string GodfatherReligion { get; set; }
        public string GodfatherConfirmed { get; set; }
        public string GodmotherName { get; set; }
        public string GodmotherReligion { get; set; }
        public string GodmotherConfirmed { get; set; }
        public string CommentsQuestions { get; set; }
        public string CreatedOn { get; set; } = DateTime.Now.ToString();
    }
}