using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeCRUD.Models
{
    public class ExisitingUserConsumptionData
    {
        [DisplayName("ExisitingUser")]
        [Key]
        public int UserId { get; set; }
        [NotMapped]
        public List<SelectListItem> ListofName { get; set; }
    }
}
