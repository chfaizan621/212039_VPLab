//212039 Muhammad Faizan
using Lab1.Scenario_Task;
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

            //Scenario Task (Library Management System)
            Console.WriteLine("\nScenario Task (Library Management System):");
            Book book1 = new Book("The Catcher in the Rye", "J.D. Salinger", "9780316769488", 1951);
            Book book3 = new Book();

            Patron patron1 = new Patron("John Doe", 30, "123456");
            Patron patron2 = new Patron("Alice Smith", 25);

            Console.WriteLine("\nBook 1 Information:\n");
            book1.DisplayInformation();
            Console.WriteLine("\nBook 2 (default) Information:\n");
            book3.DisplayInformation();

            Console.WriteLine("\nPatron 1 (with provided library number) Information:\n");
            patron1.DisplayInformation();
            Console.WriteLine("\nPatron 2 (with Auto-generated library number) Information:\n");
            patron2.DisplayInformation();

            LibraryBook libraryBook1 = new LibraryBook("The Hobbit", "J.R.R. Tolkien", "9780547928227", 1937, DateTime.Now.AddDays(14));
            LibraryBook libraryBook2 = new LibraryBook("1984", "George Orwell", "9780451524935", 1949, DateTime.Now.AddDays(21));

            Console.WriteLine("\nLibrary Book 1 Information:\n");
            libraryBook1.DisplayInformation();
            Console.WriteLine("\nLibrary Book 2 Information (with default values):\n");
            libraryBook2.DisplayInformation();
            
            Console.WriteLine("\nChecking Out Library Book 1 :\n");
            patron1.CheckOutBook(libraryBook1);
            Console.WriteLine("\nChecking Out Library Book 2 :\n");
            patron2.CheckOutBook(libraryBook2);

            Console.WriteLine("\nDue Dates After Checking Out Library Book 1:\n");
            libraryBook1.DisplayInformation();
            Console.WriteLine("\nDue Dates After Checking Out Library Book 2:\n");
            libraryBook2.DisplayInformation();

            Console.WriteLine("\nReturning Library Book 1: \n");
            patron1.ReturnBook(libraryBook1);
            Console.WriteLine("\nReturning Library Book 2: \n");
            patron2.ReturnBook(libraryBook2);

            Console.WriteLine("\nDue Date After Returning Library Book 1:\n");
            libraryBook1.DisplayInformation();
            Console.WriteLine("\nDue Date After Returning Library Book 1:\n");
            libraryBook2.DisplayInformation();

            Console.WriteLine("\nChecked-Out Books by Patron 1:\n");
            patron1.ViewCheckedOutBooks();
            Console.WriteLine("\nChecked-Out Books by Patron 2:\n");
            patron2.ViewCheckedOutBooks();

        }
    }
}