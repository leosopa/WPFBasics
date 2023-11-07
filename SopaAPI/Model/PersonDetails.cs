using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SopaAPI.Model
{
    public class PersonDetails : BaseEntity
    {

        public string City { get; set; }
        public DateTime Birthday { get; set; }
        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }

        [JsonIgnore]
        public Person Person { get; set; }
    }
}
