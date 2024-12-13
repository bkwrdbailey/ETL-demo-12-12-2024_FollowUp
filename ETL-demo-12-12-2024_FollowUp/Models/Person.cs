using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETL_demo_12_12_2024_FollowUp.Models
{
    public class Person
    {
        private int Id { get; set; }
        private string Name { get; set; } = string.Empty;
        private int Age { get; set; }
        private string City { get; set; } = string.Empty;

        // Base Constructor
        public Person(int id, string name, int age, string city)
        {
            Id = id;
            Name = name;
            Age = age;
            City = city;
        }

        public override string? ToString()
        {
            string stringOutput = $"Id: {Id}, Name: {Name}, Age: {Age}, City: {City}";
            return stringOutput;
        }
    }
}
