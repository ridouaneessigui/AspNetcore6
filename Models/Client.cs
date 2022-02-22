using System.ComponentModel.DataAnnotations;

namespace WebAppMVCCore6.Models
{
    public class Client
    {
        [Key]
        public int id { get; set; }
        public  string? rcs { get; set; }
        public  string? adresseVille { get; set; }
        public  string? tel { get; set; }
        public  string? email { get; set; }
        

    }
}
