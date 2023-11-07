using System.ComponentModel.DataAnnotations.Schema;

namespace APITest.Models
{
    public class Position
    {

        public string Name { get; set; }
        public int DepartamentId { get; set; }
        public Department Department { get; set; }

    }
}
