using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarderobaStoreApi.Models
{
    public enum SizeType { S, M, L, X, XL }
    public class Product
    {

        
        [Key]
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string PhotoURL { get; set; }
        public SizeType Size { get; set; }
    }
}
