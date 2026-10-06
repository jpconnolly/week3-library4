using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        // Private fields
        private string _title;
        private string _author;
        private int _isbn;

        // Public properties
        public string Title
        {
            get { return _title; } 
            set 
            {
                // Check if any incoming char is a digit
                if (!value.Any(char.IsDigit))
                {
                    _title = value;
                }
                else
                {
                    Console.WriteLine("Cannot enter number for title");
                }
            
            }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }


        // Constructor
        public Book(string bookTitle, string bookAuthor, int bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        // Methods

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
        }

       

    }


}
