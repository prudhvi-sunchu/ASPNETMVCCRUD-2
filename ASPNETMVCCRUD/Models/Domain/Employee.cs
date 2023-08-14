using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ASPNETMVCCRUD.Models.Domain
{
    public class Employee
    {
       
        public Guid Id { get; set; } //nothing to return unique identifier

        [Required(ErrorMessage = "Enter Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Salary")]
        [Display(Name = "Salary")]
        public int Salary { get; set; }

        [Required(ErrorMessage = "Enter Department")]
        [Display(Name = "Department")]
        public string Department { get; set; }
    }
}
