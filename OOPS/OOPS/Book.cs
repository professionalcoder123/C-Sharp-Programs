using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Book
    {
        internal int bid { get; set; }
        internal string bname {  get; set; }
        internal double bprice {  get; set; }

        public Book(int id,string name,double price)
        {
            bid = id;
            bname = name;
            bprice = price;
        }

        public override string ToString()
        {
            return $"Book ID : {bid}, Book Name : {bname}, Book Price : {bprice}";
        }
    }
    internal class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book {book.bid} added to the library");
        }

        public void RemoveBook(int id)
        {
            var book=books.Find(b=>b.bid.Equals(id));
            if(book != null)
            {
                books.Remove(book);
                Console.WriteLine("Book " + id + " removed from the library");
            }
            else
            {
                Console.WriteLine("Book with id "+id+" not found in the library!");
            }
        }

        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("The library is empty");
            }
            else
            {
                Console.WriteLine("Total " + books.Count + " books found in the library :");
                foreach(var book in books)
                {
                    Console.WriteLine(book);
                    Console.WriteLine("-------------------------");
                }
            }
        }
    }
}