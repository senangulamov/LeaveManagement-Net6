using System.ComponentModel.DataAnnotations;

namespace LeaveManagementV2.Web.Models
{
    public class LeaveTypeVM
    {

        [Display(Name = "Number of Row")]
        public int Id { get; set; }
        [Display(Name = "Name for Leave Type")]
        public string Name { get; set; }

        [Display(Name = "Default Number of Days")]
        public int DefaultDays { get; set; }
    }
}
