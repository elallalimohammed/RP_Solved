using Pizza_StoreV8.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_StoreV8.Helpers
{
    public class JsonFileWritter
    {
        public static void WriteToJson(Dictionary<int, Pizza> pizzas, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(pizzas, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
    }

}
