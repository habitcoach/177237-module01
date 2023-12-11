using System.ComponentModel.DataAnnotations;

namespace _177237module01demo.Model
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
        public int Price { get; set; }
    }
}
