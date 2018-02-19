using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAssignment
{
    class Book
    {
        private int pages;
        private string author;
        private string title;
        private string genre;

        #region Props

        
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }
        #endregion

        public Book()
        {

        }
        public Book(string _author, string _title, string _genre, int _pages)
        {
            Author = _author;
            Title = _title;
            Genre = _genre;
            Pages = _pages;
        }
    }
}
