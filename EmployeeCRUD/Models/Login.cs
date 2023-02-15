using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD.Models
{
    public class Login
    {
        public int id { get; set; }
        public string UserName { get; set; }   
        public string Password { get; set; }
    }
    public class SignUp
    {
        public int id { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string UserName { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string Password { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Compare("Password",ErrorMessage ="Password must be equal")]
        public string Confirm_Password { get;set; }
    }
}
