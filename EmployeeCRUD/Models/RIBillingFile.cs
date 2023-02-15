

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeCRUD.Models
{
    public class RIBillingFile
    {
        [Key]
        public int Id { get; set; }
        public string filepath { get; set; }
        [NotMapped]
        public IFormFile formFile { get; set; }
    }
}
