using Library;

Book book = new Book();
// This is info for the book class
book.Title = "C# for beginners";
book.Author = "Bill Gates";
book.ISBN = 12345678;
book.DisplayInfo();

// Add another book
Book book1 = new Book();
book1.Title = "Methods and classes";
book1.Author = "Microsoft";
book1.ISBN = 234556;
book1.DisplayInfo();
