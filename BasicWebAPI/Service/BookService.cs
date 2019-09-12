using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicWebAPI.Data;
using BasicWebAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace BasicWebAPI.Service
{
    public class BookService : IService
    {
        BookData bookdata;
        public BookService()
        {
            bookdata = new BookData();
        }
        public void AddNewBook( Book book)
        {
              bookdata.AddBook(book);
        }

        public string GetBookById(int id)
        {
            return bookdata.getbyid(id);
        }

        public List<Book> GetBookList()
        {
            return bookdata.getlist();
        }

    }
}
