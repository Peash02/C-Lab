using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Exceptions;

namespace Lib
{
    internal class LibM
    {
        int BookId;
        string BookName;
        Dictionary<int,string> books = new Dictionary<int, string>();

        public LibM(int BookId,string BookName)
        {
            this.BookId = BookId;
            this.BookName = BookName;
            books.Add(BookId, BookName);
        }

        public void borw(int BookId)
        {
            try
            {
                if (books.ContainsKey(BookId))
                {
                    books[BookId] = BookName;
                }
                else
                {
                    throw new BookNotFoundException();
                }

            }
            catch(BookNotFoundException e) 
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
