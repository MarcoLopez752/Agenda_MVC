

namespace MVC_Address.Models
{
    using System.ComponentModel.DataAnnotations;

    public enum TypeContact    
    {
        Telephone,
        Email,
        Facebook,
        Twitter,
        Instagram,
        dblink
    }

    public class Book
    {
        [Key]
        public int bookID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public TypeContact type { get; set; }
        [Required]
        public string contact { get; set; }

    }
}