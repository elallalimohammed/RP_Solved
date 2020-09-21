using Newtonsoft.Json;
using Pizza_StoreV8.Models;
using System.Collections.Generic;
using System.IO;

namespace Pizza_StoreV8.Helpers
{
    public class JsonFileReader
    {
        public static Dictionary<int, Pizza> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            return JsonConvert.DeserializeObject<Dictionary<int,Pizza>>(jsonString);
        }
    }

}
