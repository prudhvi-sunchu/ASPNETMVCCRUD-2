using System.ComponentModel.DataAnnotations;

namespace ASPNETMVCCRUD.Models
{
    public class AddEmployeeViewModel
    {
        [Required(ErrorMessage = "Please enter name")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter email")]
        [StringLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter salary")]
        [StringLength(100)]
        public int Salary { get; set; }

        [Required(ErrorMessage = "Please enter department")]
        [StringLength(100)]
        public string Department { get; set; }
    }
}
