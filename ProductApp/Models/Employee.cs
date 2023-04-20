using System.ComponentModel.DataAnnotations;

namespace ProductApp.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public int Salary { get; set; }
    }
}
