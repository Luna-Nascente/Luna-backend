using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Bury_the_light.Data.Entities
{
    public class Products
    {
        [Key]
        public int Product_id { get; private set; }
        public string Product_name { get; set; }
        public int Product_price { get; set; }
        public int? Category_of_product { get; set; }
        public string? Product_image { get; set; }
    }
}
