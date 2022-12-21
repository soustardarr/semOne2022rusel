using System;


namespace ConsoleApp9
{
    class Program
    {
        public static void Main()
        {
            Person person = new Person { Name = "Tom"};
            Person emp = new Employee { Name = "Bob"};
            person.Print(); 
            emp.Print();

        }
    }
}