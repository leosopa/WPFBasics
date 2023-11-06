namespace SopaAPI.Model
{
    public class Salary : BaseEntity
    {

        public Salary()
        {
             Persons = new HashSet<Person>();
        }
        public int Amount { get; set; }

        public virtual ICollection<Person> Persons { get; set; }   
    }
}
