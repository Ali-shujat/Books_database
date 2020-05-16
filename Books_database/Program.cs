using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_database
{
    public struct Book
    {
        public string Title;
        public string Author;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Books database!");
            // DISCRIPTION: Create a small database, which will be used to store data about books.
            //For a certain book, we want to keep the following information:
            //• Title
            //• Author
            //The program must be able to store 1000 books, and the user will be allowed to:
            //• Add data for one book
            //• Display all the entered books(just title and author, in the same line)
            //• Search for the book(s) with a certain title
            //• Delete a book at a known position(for example, book number 6)
            //• Exit the program

            Book[] book = new Book[10];
            int opt;
            do
            {
                Console.WriteLine("\n--------MENU---------");
                Console.WriteLine("\n1- Add data for one book");
                Console.WriteLine("2- Display all the entered books");
                Console.WriteLine("3- Search for the book(s) with a certain title");
                Console.WriteLine("4- Delete a book at a known position");
                Console.WriteLine("5- Exit the program");
                Console.WriteLine("\n Please Select an option: ");

                try
                {
                    opt = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Wrong! Only Number");
                    Console.WriteLine("\n" + e);
                    Console.ReadKey(true);
                    return;
                }
                switch (opt)
                {
                    case 1: //• Add data for one book
                        Console.WriteLine("Please Enter Book title : ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Please Enter Author Name : ");
                        string author = Console.ReadLine();
                        for (int i = 0; i < book.Length; i++)
                        {
                            if (book[i].Title == null || book[i].Title == "")
                            {
                                book[i].Title = title;
                                book[i].Author = author;
                                break;
                            }
                            else Console.WriteLine("Database is full ");

                        }
                        Console.WriteLine(" ");
                        break;
                    case 2:
                        for (int i = 0; i < book.Length; i++)
                        {
                            if (book[i].Title != null)
                           Console.WriteLine("[{0}] Title: {1} > Author :{2}  \t", i, book[i].Title, book[i].Author); 
                        }
                        Console.WriteLine(" ");
                        break;
                    case 3:   //• Search for the book(s)
                        Console.WriteLine("Search Book name : ");
                        string sTitle = Console.ReadLine();
                        for (int i = 0; i < book.Length; i++)
                        {
                            if (book[i].Title == sTitle )
                            {
                                 book[i].Title = sTitle;
                                book[i].Author = sTitle;
                                Console.WriteLine("Book available [{0}] Title: {1} > Author :{2}  \t", i, book[i].Title, book[i].Author);

                            }
                            else Console.WriteLine("Book not found");
                        }
                        Console.WriteLine("");
                        break;
                    case 4:   //• Delete a book
                        Console.WriteLine("Delete Book name : ");
                        string delTitle = Console.ReadLine();
                        for (int i = 0; i < book.Length; i++)
                        {
                            if (book[i].Title == delTitle)
                            {
                                book[i].Title = null;
                                book[i].Author = null;
                                Console.WriteLine("Book deleted");

                            }
                            //else Console.WriteLine("Book not found");
                        }
                        Console.WriteLine(" ");
                        break;
                    case 5:
                        Console.WriteLine("\n THE END.");
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
            } while (opt != 5);
            Console.ReadKey();

        }
    }
}
