using System;

public class Class1
{
	public Class1()
	{
        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Security.Cryptography;
        using System.Text;
        using System.Threading.Tasks;

namespace task_students
{
    public class Students
    {
        private string Name;
        private string Surname;
        private int ID;

        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetName() { return Name; }


        public void SetSurname(string surname)
        {
            this.Surname = surname;
        }
        public string GetSurname() { return Surname; }


        public void SetID(int id)
        {
            this.ID = id;
        }
        public int GetID() { return ID; }


        public void Display()
        {
            Console.WriteLine("{0} {1}'s ID: {2}", Surname, Name, ID);
        }

    }
}

using System;

namespace task_students
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Students");
            Console.WriteLine("----------");
            Students amina = new Students();
            amina.SetName("Amina");
            Console.Write(amina.GetName() + " ");
            amina.SetSurname("Mammadzade");
            Console.WriteLine(amina.GetSurname());
            amina.SetID(001);
            amina.Display();
            Console.WriteLine("----------");
            Students zehra = new Students();
            zehra.SetName("Zehra");
            Console.Write(zehra.GetName() + " ");
            zehra.SetSurname("Israfilova");
            Console.WriteLine(zehra.GetSurname());
            zehra.SetID(002);
            zehra.Display();
            Console.WriteLine("----------");
        }
    }
}

    }
}
