using Pizza_StoreV9.Models;
using Pizza_StoreV9.Interfaces;
using Pizza_StoreV9.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_StoreV9.Services
{
    public class PizzaJson : IPizzaRepository
    {
        string JsonFileName = @"C:\Users\EASJ\Source\Repos\RP_Solved\RazorPages_Solutions\Pizza_StoreV9\Data\JsonPizzas.json";

        public void AddPizza(Pizza pizza)
        {
            Dictionary<int, Pizza> pizzas = AllPizzas();
            pizzas.Add(pizza.Id, pizza);
            JsonFileWritter.WriteToJson(pizzas,JsonFileName);
        }

        public Dictionary<int, Pizza> AllPizzas()
        {
            return JsonFileReader.ReadJson(JsonFileName);
        }
        public Dictionary<int, Pizza> FilterPizza(string criteria)
        {
            Dictionary<int, Pizza> pizzas = AllPizzas();
            Dictionary<int, Pizza> filteredPizzas = new Dictionary<int, Pizza>();
            foreach ( var p in pizzas.Values)
            {
                if (p.Name.StartsWith(criteria))
                {
                    filteredPizzas.Add(p.Id, p);
                }
            }
            return filteredPizzas; 
        }

        public Pizza GetPizza(int id)
        {
            Dictionary<int, Pizza> pizzas = AllPizzas();
            Pizza foundPizza = pizzas[id];
            return foundPizza;
        }

        public void UpdatePizza(Pizza pizza)
        {
            Dictionary<int, Pizza> pizzas = AllPizzas();
            Pizza foundPizza = pizzas[pizza.Id];
            foundPizza.Id = pizza.Id;
            foundPizza.Name = pizza.Name;
            foundPizza.Description = pizza.Description;
            foundPizza.Price = pizza.Price;
            foundPizza.ImageName = pizza.ImageName;
            JsonFileWritter.WriteToJson(pizzas, JsonFileName);
        }

        public void DeletePizza(int id)
        {
            Dictionary<int, Pizza> pizzas = AllPizzas();
            pizzas.Remove(id);
            JsonFileWritter.WriteToJson(pizzas, JsonFileName);
        }
    }
}
