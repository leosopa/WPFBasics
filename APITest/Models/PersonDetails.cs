using System.ComponentModel.DataAnnotations.Schema;

namespace APITest.Models
{
    public class PersonDetails
    {

        public string City { get; set; }
        public DateTime Birthday { get; set; }
        public int PersonId { get; set; }

    }
}