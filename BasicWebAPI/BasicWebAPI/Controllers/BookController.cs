using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BasicWebAPI.Model;
using System.Net.Http;
using BasicWebAPI.Service;
using BasicWebAPI.Response;

namespace BasicWebAPI.Controllers
{
    
    [Route("api/Book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        // GET: api/Book
        IService _service;
        private ResponseStatus response;
        public BookController()
        {
            _service = new BookService();
            response = new ResponseStatus();
        }
        [HttpGet]
        public IActionResult Get()
        {
            List<Book> booklist=_service.GetBookList();
            if (booklist.Count==0)
            {
                response.Model = null;
                response.Status.statusCode = 400;
                response.Status.statusMessage = "NO Books Available..!!";
                return BadRequest(response);
            }
            else
            {
                response.Model = booklist;
                response.Status.statusCode = 200;
                response.Status.statusMessage = "Successfully returned book list..!!";
            }
            return Ok(response);
        }

        // GET: api/Book/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return _service.GetBookById(id);
           
        }

        // POST: api/Book
        [HttpPost]
        public string Post([FromBody] Book book)
        {
              return _service.AddNewBook(book);
        }

        //// PUT: api/Book/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Book book)
        {
            return _service.UpdateBook(id,book.name);
        }

        ///DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _service.DeleteBook(id);
        }
    }
}
