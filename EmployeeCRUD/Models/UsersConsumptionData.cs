using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD.Models
{
    public class UsersConsumptionData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public string TYPE { get; set; }
        public string RESOURCEGROUP { get; set; }
        public string Customer { get; set; }
        public string Environment { get; set; }
        public string SplitPercentage { get; set; }
        public string SplitGroup { get; set; }

        public string Consumed { get; set; }
        public string Unit { get; set; }
        public DateTime? RecordCreatedOn { get; set; }

    }

    //public class UsersConsumptionDataviewModel
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    [Required]
    //    [Display(Name = "Name")]
    //    public string Name { get; set; }
    //    public string TYPE { get; set; }
    //    public string RESOURCEGROUP { get; set; }
    //    public string Customer { get; set; }
    //    public string Environment { get; set; }
    //    public string SplitPercentage { get; set; }
    //    public string SplitGroup { get; set; }

    //    public string Consumed { get; set; }
    //    public string Unit { get; set; }
    //    public DateTime? RecordCreatedOn { get; set; }
    //    public SelectListItem Emps { get; set; }
    //}
}
