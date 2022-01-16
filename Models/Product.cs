using System.Drawing;
using Microsoft.OData.Edm;

namespace odataQuery.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
        public double TaxRate { get; set; }
        public Address Location { get; set; }
        public List<Sale> Sales { get; set; }
    }
}