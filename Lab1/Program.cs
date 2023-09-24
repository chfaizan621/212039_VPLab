using Lab1.Task1_Task2;
using Lab1.Task3;
using Lab1.Task4;
using Lab1.Task5;
using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Person person1 = new Person("Faizan", 20);

            //Task 1
            Console.WriteLine("Task 1: ");
            Console.WriteLine("Name: " + person1.GetName());
            Console.WriteLine("Age: " + person1.GetAge());
            
            //Task 2
            Console.WriteLine("\nTask 2: ");
            Person person2 = new Person("M.Faizan");
            Person person3 = new Person(19);

            Console.WriteLine("Name: " + person2.GetName());
            Console.WriteLine("Age: " + person3.GetAge());

            //Task3
            Console.WriteLine("\nTask 3: ");
            Student student = new Student(212039, "M.Faizan", 19);
            student.GetStudentInfo();

            //Task4
            Console.WriteLine("\nTask 4:");
            Person2 obj1 = new Person2("Faizan", 20);
            Console.WriteLine("Name: " + person1.GetName());
            Console.WriteLine("Age: " + person1.GetAge());

            //Task5
            Console.WriteLine("\nTask 5:");
            Dog dog = new Dog("Jackie", "woof - woof", "German Shepherd");
            Console.WriteLine("Dog Name: {0} \nSound: {1}\nBreed: {2}", dog.name, dog.sound, dog.breed);

        }
    }
}