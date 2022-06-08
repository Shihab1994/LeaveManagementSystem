using System.ComponentModel.DataAnnotations;

namespace LeaveManagementWeb.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name ="Leave Type Name")]
        [Required(ErrorMessage ="Please enter leave type name!")]
        public string Name { get; set; }

        [Display(Name = "Default number of days")]
        [Required(ErrorMessage ="Please enter default number of days!")]
        public int DefaultDays { get; set; }
    }
}
