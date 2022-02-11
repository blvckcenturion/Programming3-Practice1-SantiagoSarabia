using System;
namespace SantiagoSarabia1
{
    public class Person
    {
        public string Name {get;set;}
        public int Age { get; set; }

        public Person(int age, string name)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
