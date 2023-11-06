namespace SopaAPI.Model
{
    public class Department : BaseEntity
    {

        public Department()
        {
            Positions = new HashSet<Position>();
        }
        public string Name { get; set; }

        public ICollection<Position> Positions { get; set; }
    }
}
