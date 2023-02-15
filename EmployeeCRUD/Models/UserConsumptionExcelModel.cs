using DocumentFormat.OpenXml.Wordprocessing;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD.Models
{
    public class UserConsumptionExcelModel
    {

        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = "";
        public string TYPE { get; set; } = "";
        public string RESOURCEGROUP { get; set; } = "";
        public string Customer { get; set; } = "";
        public string Environment { get; set; } = "";
        public string SplitPercentage { get; set; } = "";
        public string SplitGroup { get; set; } = "";

        public string Consumed { get; set; } = "";
        public string Unit { get; set; } = "";
        public DateTime? RecordCreatedOn { get; set; }
    }
}


