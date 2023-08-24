using System;


namespace person
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public void Display()
        {
            Console.WriteLine("The name: {0}", Name);
            Console.WriteLine("The age: {0}", Age);
            Console.WriteLine("The gender: {0}", Gender);
        }

        class Program
        {
            static void Main(string[] args)
            {
                Person person1 = new Person("Amina",18,"Female");
                person1.Display();
                Console.WriteLine("-------");
                Person person2 = new Person("Saleh", 14, "Male");
                person2.Display();

            }
        }

    }
}
