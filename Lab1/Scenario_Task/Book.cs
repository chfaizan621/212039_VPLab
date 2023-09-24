using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Scenario_Task
{
    public partial class Book
    {
        private string title;
        private string author;
        private string isbn;
        private int publicationYear;

        public Book(string title, string author, string isbn, int publicationYear)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.publicationYear = publicationYear;
        }
        public Book()
        {
            this.title = "Untitled";
            this.author = "Unknown";
            this.isbn = "0000000000";
            this.publicationYear = 1900;
        }
    }
    public partial class Book
    {
        public void DisplayInformation()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"ISBN: {isbn}");
            Console.WriteLine($"Publication Year: {publicationYear}");
        }
    }
}
