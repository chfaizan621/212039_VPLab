using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Scenario_Task
{
    public class LibraryBook : Book
    {
        private DateTime dueDate;
        private bool isCheckedOut;

        public LibraryBook(string title, string author, string isbn, int publicationYear, DateTime dueDate)
            : base(title, author, isbn, publicationYear)
        {
            this.dueDate = dueDate;
            this.isCheckedOut = false;
        }

        public LibraryBook(string title, string author, string isbn, DateTime dueDate)
            : base("Untitled", "Unknown", isbn, 1900) // Default values for title, author, and publicationYear
        {
            this.dueDate = dueDate;
            this.isCheckedOut = false;
        }

        public bool CheckOut()
        {
            if (isCheckedOut)
            {
                Console.WriteLine("This book is already checked out.");
            }
            else
            {
                isCheckedOut = true;
                Console.WriteLine("Book checked out successfully.");
            }
            return isCheckedOut;
        }

        public void Return()
        {
            if (isCheckedOut)
            {
                isCheckedOut = false;
                Console.WriteLine("Book returned successfully.");
            }
            else
            {
                Console.WriteLine("This book is not checked out.");
            }
        }
        public new void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"Due Date: {dueDate.ToShortDateString()}");
            Console.WriteLine($"Status: {(isCheckedOut ? "Checked Out" : "Available")}");
        }
    }

}
