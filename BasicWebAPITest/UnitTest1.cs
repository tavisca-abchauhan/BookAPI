using System;
using BasicWebAPI.Data;
using BasicWebAPI.Model;
using Xunit;
namespace BasicWebAPITest
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetById()
        {
            BookData bookdata;
            bookdata=new BookData();           
            //Assert.Equal("Invalid Id, Id should be a positive number", bookdata.getbyid(-1));

            Assert.Equal("Book Not found", bookdata.getbyid(4));
        }

        [Fact]
        public void TestGetList()
        {
            BookData bookdata;
            bookdata = new BookData();
            Assert.Equal(3, bookdata.getlist().Count);
        }

        [Fact]
        public void TestAddBook()
        {
            BookData bookdata;
            bookdata = new BookData();
            Book book = new Book() { name = "CleanCode1", price = 100, pages = 350, author = "NoOne", id = 4 };
            bookdata.AddBook(book);
            Assert.Equal(3,bookdata.getlist().Count);
        }
    }
}
