using System.Text.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq;

namespace RubyAPI
{
    class Product
    {
        public int Id { get; set; }
        public string StoneShape { get; set; }
        public string StoneSize { get; set; }
        public string MetalQuality { get; set; }
        public double FingerSize { get; set; }
        public DateTime DateAdded { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public int? InventoryCount { get; set; }

        public Product(int Id, string StoneShape, string StoneSize, string MetalQuality, double FingerSize, DateTime DateAdded, double Price, double Weight, int InventoryCount)
        {
            this.Id = Id;
            this.StoneShape = StoneShape;
            this.StoneSize = StoneSize;
            this.MetalQuality = MetalQuality;
            this.FingerSize = FingerSize;
            this.DateAdded = DateAdded;
            this.Price = Price;
            this.Weight = Weight;
            this.InventoryCount = InventoryCount;
        }

    }

    // Read the JSON file
    var json = File.ReadAllText("MOCK_DATA.json");

    // Parse the JSON file into a JObject
    var jsonObject = JObject.Parse(json);

    // Use LINQ to query the data
    var query = from p in jsonObject["property"].Children()
                where (int)p["subproperty"] > 10
                select (string)p["another_subproperty"];

    // Execute the query
    foreach (var item in query)
    {
        System.Console.WriteLine(item);
    }
}
