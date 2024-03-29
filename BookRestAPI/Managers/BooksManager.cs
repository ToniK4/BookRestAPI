﻿using MandatoryTechClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookRestAPI.Managers
{
    public class BooksManager
    {
        private static List<Book> _books = new List<Book>()
        {
            new Book{ISBN13 = "9780345418913", Author = "Douglas Adams", PageNumber = 208, Title = "The Hitchhiker's Guide to the Galaxy"},
            new Book{ISBN13 = "9789531400619", Author = "Sanja Polak", PageNumber = 194, Title = "Dnevnik Pauline P."}
        };
        public List<Book> GetAll()
        {
            return new List<Book>(_books);
        }

        public Book GetBook(string isbn)
        {
            return _books.Find(book => book.ISBN13.Contains(isbn));
        }

        public void AddBook(Book book)
        {
            if(!_books.Exists(x => x.ISBN13 == book.ISBN13))
            {
                _books.Add(book);
            }
        }

        public void UpdateBook(Book book, string ISBN13)
        {
            var index = _books.FindIndex(x => x.ISBN13 == ISBN13);
            _books[index] = book;
        }

        public void DeleteBook(string ISBN13)
        {
            var index = _books.FindIndex(x => x.ISBN13 == ISBN13);
            _books.RemoveAt(index);
        }
    }
}
