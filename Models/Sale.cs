using Microsoft.OData.Edm;

namespace odataQuery.Models
{
    public class Sale
    {
        public int Id{get;set;}
        public Date SaleDate { get; set; }
        public int ProductId { get; set; }
        public decimal Amount { get; set; }
    }
}