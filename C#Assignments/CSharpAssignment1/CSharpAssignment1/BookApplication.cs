using System;

namespace CSharpAssignment1
{
    struct Book
    {
        public string bookId;
        public string title;
        public string price;
        public enum bookType
        {
            Magazine = 1,
            Novel = 2,
            ReferenceBook = 3,
            Miscellaneous = 4
        }
        public void getValue(string id, string t, string p, bookType type)
        {
            bookId = id;
            title = t;
            price = p;
            string bookType = type.ToString();
            Console.WriteLine(bookType);
            Console.WriteLine($"Book Id: {bookId} \t Book Title: {title}\t Book Price: {price}\t Book Type: {bookType}");
        }

    }
    class BookApplication
    {
        public static void Main()
        {
            Book book = new Book();
            string bookId, title, price;
            Console.WriteLine("Welcome to Book Application");
            Console.Write("Enter Book Id: ");
            bookId = Console.ReadLine();
            Console.Write("Enter Book Title: ");
            title = Console.ReadLine();
            Console.Write("Enter Book price: ");
            price = Console.ReadLine();
            Loop:
            Console.Write("Choose your book type:\n 1. Magazine\t 2. Novel\t 3. Reference Book\t 4. Miscellaneous\n Enter your choice in number (1,2,3 or 4):");
            int choice = Convert.ToInt32(Console.ReadLine());
           switch (choice)
            {
                case 1:
                    book.getValue(bookId, title, price, Book.bookType.Magazine);
                    break;
                case 2:
                    book.getValue(bookId, title, price, Book.bookType.Novel);
                    break;
                case 3:
                    book.getValue(bookId, title, price, Book.bookType.ReferenceBook);
                    break;
                case 4:
                    book.getValue(bookId, title, price, Book.bookType.Miscellaneous);
                    break;
                default:
                    Console.WriteLine("Invalid Book Type. PLease select from the given options");
                    goto Loop;
            }
            }
        }
    }
