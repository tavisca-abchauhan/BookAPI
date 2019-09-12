using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicWebAPI.Model;

namespace BasicWebAPI.Data
{
    public class BookData
    {
         public static List<Book> booklist=null;

        public static List<Book> GetBookStore()
        {
            if (booklist == null)
                booklist = new List<Book>() { new Book { name = "CleanCode1", price = 100, pages = 350, author = "NoOne", id = 1 } };
            return booklist;
        }
        public void AddBook(Book book)
        {
            booklist = GetBookStore();
            if (book.id>=0&&book.price>=0&& book.name.All(Char.IsLetter)&& book.author.All(Char.IsLetter))
            booklist.Add(book);           
        }
        public List<Book> getlist()
        {
            return booklist;
        }
        public string getbyid(int id)
        {
            if(id<0)
            {
                return "Invalid Id, Id should be a positive number";
            }
           foreach(Book book in booklist)
            {
                if (book.id == id) 
                    return book.name+" "+book.price+" "+book.author;
            }
            return "Book Not found";
        }
    }
}
