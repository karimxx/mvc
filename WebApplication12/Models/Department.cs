using System.ComponentModel.DataAnnotations;

namespace WebApplication12.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MaxLength(50, ErrorMessage = "Max Length Name is 50 Chars")]
        public string Name { get; set; }


        public DateTime DateOfCreation { get; set; }

        public virtual List<Employee> Employees { get; set; }

    }
}
