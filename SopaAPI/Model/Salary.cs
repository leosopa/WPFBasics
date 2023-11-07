using System.Text.Json.Serialization;

namespace SopaAPI.Model
{
    public class Salary : BaseEntity
    {

        public Salary()
        {
             Persons = new HashSet<Person>();
        }
        public int Amount { get; set; }
        [JsonIgnore]
        public virtual ICollection<Person> Persons { get; set; }   
    }
}
