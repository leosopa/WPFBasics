using System.ComponentModel.DataAnnotations;

namespace APITest.Models
{
    public class Department
    {

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
