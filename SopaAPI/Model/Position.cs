using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SopaAPI.Model
{
    public class Position : BaseEntity
    {

        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<Person> Persons { get; set; }
        [ForeignKey(nameof(Department))]
        public int DepartamentId { get; set; }
        public Department Department { get; set; }

        public Position()
        {
            Persons = new HashSet<Person>();
        }
    }
}
