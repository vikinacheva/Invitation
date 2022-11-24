using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Invitation.Models
{
    public class Responses
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Item Name")]
        [Required]
        public string FullName { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public bool Attendance { get; set; }
    }
}
