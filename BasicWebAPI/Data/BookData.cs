using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicWebAPI.Model;

namespace BasicWebAPI.Data
{
    public class BookData
    {
         public static List<Book> booklist;
        public BookData()
        {
            booklist = new List<Book>() {
            new Book { name = "CleanCode1", price = 100, pages = 350, author = "NoOne", id = 1 },
            new Book { name = "CleanCode2", price = 200, pages = 400, author = "NoOne", id = 2 },
            new Book { name = "CleanCode3", price = 300, pages = 450, author = "NoOne", id = 3 }
                                        };
        }
        public void AddBook(Book book)
        {
            booklist = getlist();
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
