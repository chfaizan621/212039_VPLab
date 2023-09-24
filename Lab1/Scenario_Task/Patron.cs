using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Scenario_Task
{
    public partial class Patron
    {
        private string name;
        private int age;
        private string libraryCardNumber;
        private System.Collections.Generic.List<LibraryBook> checkedOutBooks;

        public Patron(string name, int age, string libraryCardNumber)
        {
            this.name = name;
            this.age = age;
            this.libraryCardNumber = libraryCardNumber;
            this.checkedOutBooks = new List<LibraryBook>();
        }

        public Patron(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.libraryCardNumber = GenerateLibraryCardNumber();
            this.checkedOutBooks = new List<LibraryBook>();
        }

        public void CheckOutBook(LibraryBook book)
        {
            if (book == null)
            {
                Console.WriteLine("Book not found.");
            }
            else if (book.CheckOut())
            {
                Console.WriteLine("This book is already checked out.");
            }
            else
            {
                book.CheckOut();
                checkedOutBooks.Add(book);
                Console.WriteLine("Book checked out successfully.");
            }
        }

        public void ReturnBook(LibraryBook book)
        {
            if (book == null)
            {
                Console.WriteLine("Book not found.");
            }
            else if (book.CheckOut() == false)
            {
                Console.WriteLine("This book is not checked out.");
            }
            else
            {
                book.Return();
                checkedOutBooks.Remove(book);
                Console.WriteLine("Book returned successfully.");
            }
        }

    }


    public partial class Patron
    {
        public void DisplayInformation()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Library Card Number: {libraryCardNumber}");
        }

        public void ViewCheckedOutBooks()
        {
            if (checkedOutBooks.Count == 0)
            {
                Console.WriteLine("You have not checked out any books.");
            }
            else
            {
                Console.WriteLine($"{name}'s Checked Out Books:");
                foreach (var book in checkedOutBooks)
                {
                    book.DisplayInformation();
                    Console.WriteLine();
                }
            }
        }
        private string GenerateLibraryCardNumber()
        {
            Random random = new Random();
            int cardNumber = random.Next(100000, 999999);
            return cardNumber.ToString();
        }
    }
}
