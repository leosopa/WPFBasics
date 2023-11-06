﻿namespace SopaAPI.Model
{
    public class Position : BaseEntity
    {

        public string Name { get; set; }

        public ICollection<Person> Persons { get; set; }
        public int DepartamentId { get; set; }
        public Department Department { get; set; }

        public Position()
        {
            Persons = new HashSet<Person>();
        }
    }
}