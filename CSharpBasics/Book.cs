using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;

        // #2 this way it is not mandatory to give arguments to the class
        public Book()
        {

        }

        // #1 this is a constructor & it is possible to have more than one
        public Book(string aTitle, string anAuthor, int pagesAmount)
        {
            title = aTitle;
            author = anAuthor;
            pages = pagesAmount;
        }
    }
}
