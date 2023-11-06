using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SopaAPI.Model
{
    public class Person : BaseEntity
    {
        public Person()
        {
        }

        
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Password{ get; set;}
        public string Address { get; set; }
        [ForeignKey(nameof(Position))]
        public int PositionId { get; set; }
        public Position Position { get; set; }
        [ForeignKey(nameof(Salary))]
        public int SalaryId {  get; set; }
        public Salary Salary { get; set; }

        public PersonDetails Details { get; set; }


    }
}
