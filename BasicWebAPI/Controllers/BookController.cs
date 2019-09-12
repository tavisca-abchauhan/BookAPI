using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BasicWebAPI.Model;
using System.Net.Http;
using BasicWebAPI.Service;

namespace BasicWebAPI.Controllers
{
    
    [Route("api/Book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        //List<Book> booklist = new List<Book>();
        //public BookController()
        //{
        //    booklist.Add(new Book { name = "CleanCode1", price = 221, pages = 445, author = "NoOne",id=1 });
        //    booklist.Add(new Book { name = "CleanCode2", price = 321, pages = 455, author = "NoOne",id=2 });
        //    booklist.Add(new Book { name = "CleanCode3", price = 421, pages = 465, author = "NoOne",id=3 });
        //}
        // GET: api/Book
        IService service;
        public BookController()
        {
            service = new BookService();
        }
        [HttpGet]
        public List<Book> Get()
        {
            return service.GetBookList();
        }

        // GET: api/Book/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
           
            return service.GetBookById(id);
        }

        // POST: api/Book
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            // booklist.Add(book);
            //return booklist;
              service.AddNewBook(book);
        }

        //// PUT: api/Book/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //    foreach (Book b in booklist)
        //    {
        //        if (b.id == id)
        //        {
        //            b.name = value;
        //            break;
        //        }
        //    }
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public List<Book> Delete(int id)
        //{
        //    //var response = new System.Net.Http.HttpResponseMessage();
        //   // response.Headers.Add("Id not found");
        //    foreach (Book b in booklist)
        //    {
               
        //        if (b.id == id)
        //        {
        //            booklist.Remove(b);
        //            //response.Headers.Add("DeleteMessage", "Succsessfuly Deleted Book With Id = "+id);
        //            break;
        //        }              
        //    }
        //    return booklist;
        //}
    }
}
