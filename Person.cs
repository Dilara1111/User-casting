using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_casting
{
    public class Person
    {
        public Person() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        private static int firstId = 0;
        public Person(string name, string surname, byte age)
        {
            Name = name;
            Surname = surname;  
            Age = age;
            Id = ++firstId;
        }
    }
    
}
