using BookRestAPI.Managers;
using MandatoryTechClassLibrary;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookRestAPI.Controllers
{
    //api/Books
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private BooksManager _manager = new BooksManager();
        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<BooksController>/5
        [HttpGet("{isbn}")]
        public Book Get(string isbn)
        {
            return _manager.GetBook(isbn);
        }

        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            _manager.AddBook(book);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{isbn}")]
        public void Put(string isbn, [FromBody] Book book)
        {
            _manager.UpdateBook(book, isbn);
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{isbn}")]
        public void Delete(string isbn)
        {
            _manager.DeleteBook(isbn);
        }
    }
}
