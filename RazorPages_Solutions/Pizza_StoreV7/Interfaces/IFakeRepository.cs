using Pizza_StoreV7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_StoreV7.Interfaces
{
    public interface IPizzaRepository
    {
        Dictionary<int, Pizza> AllPizzas();
        Dictionary<int, Pizza> FilterPizza(string crtiteria);
        void DeletePizza(Pizza pizza);
        void AddPizza(Pizza pizza);
        void UpdatePizza(Pizza pizza);
        Pizza GetPizza(int id);
    }
}
