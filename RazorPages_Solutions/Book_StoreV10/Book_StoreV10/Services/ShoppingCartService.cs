using Book_StoreV10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_StoreV10.Services
{
    public class ShoppingCartService
    {
        List<Book>  _cartItems;
        public ShoppingCartService()
        {
            _cartItems = new List<Book>();
        }

        public void Add(Book book)
        {
            _cartItems.Add(book);
        }

        public List<Book> GetOrderedBooks()
        {
            return _cartItems;
        }

       public void RemoveBook(string isbn)
        {
            foreach (var book in _cartItems)
            {
                if (book.ISBN ==isbn)
                {
                    _cartItems.Remove(book);
                    break;
                }
            }
        }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0.00M;

            foreach (var v in _cartItems)
            {
                totalPrice = totalPrice + (decimal)v.Price ;
            }
            return totalPrice;
        }
        
    }
}
