using System.ComponentModel.DataAnnotations;
using Unit2A3.Shared.Enums;


namespace Unit2A3.Shared.ViewModels
{
    public class StudentViewModel
    {
        [Display(Name = "Name: ")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Display(Name = "Age: ")]
        public string Age { get; set; }
        [Display(Name = "Major: ")]
        public string Major { get; set; }
        [Display(Name = "Gender: ")]
        public GenderEnums Gender { get; set; }
        public string GenderString => Gender.ToString();
    }
}
