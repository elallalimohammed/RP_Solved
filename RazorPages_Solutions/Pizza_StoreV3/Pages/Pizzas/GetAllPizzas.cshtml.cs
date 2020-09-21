using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizza_StoreV3.Models;
using Pizza_StoreV3.PizzaCatalogs;

namespace Pizza_StoreV3
{
    public class GetAllPizzasModel : PageModel
    {
        private PizzaCatalog catalog;
        public GetAllPizzasModel()
        {
            catalog = PizzaCatalog.Instance;
        }
        public Dictionary<int, Pizza> Pizzas { get; private set; }
       
        public IActionResult OnGet()
        {
            Pizzas = catalog.AllPizzas();           
            return Page();
        }
    }
}