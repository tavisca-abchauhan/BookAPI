using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicWebAPI.Model;
using Microsoft.AspNetCore.Mvc;
namespace BasicWebAPI.Service
{
    interface IService
    {
        List<Book> GetBookList();
        string GetBookById(int id);
        void AddNewBook([FromBody] Book book);
    }
}
