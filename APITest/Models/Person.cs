using System.ComponentModel.DataAnnotations;

namespace APITest.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Address { get; set; }
        [Required]
        public int Age { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public int SalaryId { get; set;}
        public Salary Salary { get; set; }

        public int PersonDetailsId { get; set; }
        public PersonDetails Details { get; set; }
    }
}
