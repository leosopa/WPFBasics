namespace SopaAPI.Model
{
    public class Salary
    {

        public Salary()
        {
             Persons = new HashSet<Person>();
        }
        public int Id { get; set; }
        public int Amount { get; set; }

        public virtual ICollection<Person> Persons { get; set; }   
    }
}
