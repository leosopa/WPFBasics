using System.Text.Json.Serialization;

namespace SopaAPI.Model
{
    public class Department : BaseEntity
    {

        public Department()
        {
            Positions = new HashSet<Position>();
        }
        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<Position> Positions { get; set; }
    }
}
