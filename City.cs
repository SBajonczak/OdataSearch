using System.ComponentModel.DataAnnotations.Schema;

namespace odataQuery
{
    [Table("Article")]
    public class Article
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public decimal Price{get;set;}
        public int Quantity {get;set;}
        
    }
}
