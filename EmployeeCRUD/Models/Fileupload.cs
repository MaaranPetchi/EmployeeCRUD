using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeCRUD.Models
{
    public class Fileupload
    {
        
          public int Id { get; set; }
        public string filepath { get;set; }
        [NotMapped]
        public IFormFile formFile { get; set; }
    }
  
}
