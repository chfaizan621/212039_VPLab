using System;

namespace Lab1.Task1_and_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Person person1 = new Person("Faizan", 20);

            Console.WriteLine("Task 1: ");
            Console.WriteLine("Name: " + person1.GetName());
            Console.WriteLine("Age: " + person1.GetAge());

            Console.WriteLine("\nTask 2: ");
            Person person2 = new Person("M.Faizan");
            Person person3 = new Person(19);

            Console.WriteLine("Name: " + person2.GetName());
            Console.WriteLine("Age: " + person3.GetAge());


        }
    }
}