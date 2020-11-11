using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_StoreV10.Models;
using Book_StoreV10.Repositories;
using Book_StoreV10.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Book_StoreV10
{
    public class CheckOutModel : PageModel
    {
       private JsonOrderRepository repository;
        private ShoppingCartService cart;
        
        [BindProperty]
        public Student Student { get; set; }   
        public Order Order { get; set; }

        public CheckOutModel(JsonOrderRepository repo, ShoppingCartService cartService)
        {
            repository = repo;
            cart = cartService;
        }
        public void OnGet()
        {
            //Student s = Student;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Order order = new Order();
            order.OrderID = 12;
            order.Student = Student;
            order.Books =  cart.GetOrderedBooks();
            order.DateTime= DateTime.Now ;
            repository.AddOrder(order);
            return RedirectToPage("Order", Student);
        }
    }
}