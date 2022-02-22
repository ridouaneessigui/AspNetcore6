using System.ComponentModel.DataAnnotations;

namespace WebAppMVCCore6.Models
{
    public class Produit
    {
        [Key]
        public int id { get; set; }
        public string? reference { get; set; }
        public int? quantite { get; set; }
        public decimal prix { get; set; }
 

        
    }
}
