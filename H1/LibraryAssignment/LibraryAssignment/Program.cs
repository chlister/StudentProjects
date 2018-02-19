using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAssignment
{
    class Program
    {
        static List<Book> books = new List<Book>
            {
                new Book("Georg R. R. Martin", "Game of Thrones", "Medevil Fantasy", 350),
                new Book("J. K. Rowlings", "Harry Potter", "Witchcraft", 256),
                new Book("Helle Helle", "Novelle Samlinger", "Gymnasie Totur", 666),
                new Book("Columbus", "Imperier: fra oldtid til nutid", "Faglitteratur", 269),
                new Book("Steen Steensen Blicher", "En landsbydegns dagbog", "Skønlitteratur", 86),
                new Book("Knud Aagesen", "Sømænd er ikke bange for modvind : de lærer at sejle mod den!", "Skønlitteratur", 580),
                new Book("KL", "De udsatte børn: Nøgletal", "Faglitteratur", 35)
            };
        static Stack<Book> borrowedBooks = new Stack<Book>();
        static void Main(string[] args)
        {
            try
            {
                Library();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled exception");
                Console.WriteLine("Helplink: " + ex.HelpLink);
                Console.WriteLine("Message: "+ex.Message);
                Console.WriteLine("Source: "+ex.Source);
                Console.WriteLine("StackTrace: "+ex.StackTrace);
                Console.WriteLine("TargetSite: "+ex.TargetSite);
                Console.ReadLine();
            }
        }
        static void BorrowBooks()
        {
            int booknum;
            try
            {
                Console.Write("What book do you want to borrow? Please input the shelf number: ");
                booknum = Int32.Parse(Console.ReadLine()) - 1;
                string book = books[booknum].Title;
                Console.WriteLine("you choose: {0}", book);
                borrowedBooks.Push((books[booknum]));
                books.RemoveAt(booknum);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Must be a valid shelf number");
            }
            catch (FormatException)
            {

            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Must be a valid shelf number");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            Console.ReadLine();
        }
        static void CheckBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine("Title: {0}\r\nAuthor: {1}\r\nShelf number: {2}", book.Title, book.Author,(books.IndexOf(book)+1));
            }
            Console.ReadLine();
        }
        static void ReturnBooks()
        {
            try
            {
                while (borrowedBooks.Count() != 0)
                {
                    foreach (Book item in borrowedBooks)
                    {
                        Console.WriteLine("My books: {0}", item.Title);
                    }
                    books.Add(borrowedBooks.Pop());
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public static void Library()
        {
            
            Console.Title = "Library";
            bool inLibrary = true;
            do
            {
                Console.Clear();
                LibraryTopScreen();
                try
                {
                    Console.WriteLine("1) Check books");
                    Console.WriteLine("2) Borrow books");
                    Console.WriteLine("3) Return books");
                    Console.WriteLine("4) Leave library");
                    int input = Int32.Parse(Console.ReadLine());
                        if (input > 4)
                        {
                            Console.WriteLine("Input a number between 1 - 4");
                            Console.ReadLine();
                        }
                    switch (input)
                    {
                        case 1:
                            CheckBooks();
                            break;
                        case 2:
                            BorrowBooks();
                            break;
                        case 3:
                            ReturnBooks();
                            break;
                        case 4:
                            inLibrary = false;
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input doesn't match the critia.");
                    Console.ReadLine();
                }
            } while (inLibrary);
        }
        public static void LibraryTopScreen()
        {
            string welcomeText = "Welcome to the Library. Choose an action.";
            int windowWidth = Console.WindowWidth;
            for (int i = 0; i < windowWidth; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine("\r\n");
            Console.SetCursorPosition((windowWidth - welcomeText.Length) / 2, Console.CursorTop);
            Console.WriteLine(welcomeText);
            Console.WriteLine("\r\n");
            for (int i = 0; i < windowWidth; i++)
            {
                Console.Write("=");
            }
        }
    }
    
}
