namespace SopaAPI.Model
{
    public class Department
    {

        public Department()
        {
            Positions = new HashSet<Position>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Position> Positions { get;}
    }
}
