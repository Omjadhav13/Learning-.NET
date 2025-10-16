using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Employee Id is required")]
        public int EmpID {  get; set; }

        [Required(ErrorMessage = "Employee Name is required")]
        [StringLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Employee Age is required")]
        [Range(18,50,ErrorMessage = "Employee Age ishould be between 18-50")]
        public int Age{ get; set; }


        [Required(ErrorMessage = "Department Id is required")]
       
        public int DeptId {  get; set; }
    }
}
