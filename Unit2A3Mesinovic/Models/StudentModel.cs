using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Unit2A3.Shared.Enums;
using Unit2A3.Shared.ViewModels;

namespace Unit2A3Mesinovic.Models
{
    public class StudentModel
    {
        [Display(Name = "Name: ")]
        public string FirstName { get; set; }
        [Display(Name = "")]
        public string LastName { get; set; }
        [Display(Name = "Age: ")]
        public string Age { get; set; }
        [Display(Name = "Major: ")]
        public string Major { get; set; }
        [Display(Name = "Gender: ")]
        public GenderEnums Gender { get; set; }
        public String GenderString => Gender.ToString();
        public List<StudentViewModel> StudentsList { get; set; }
    }
}