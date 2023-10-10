using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Bury_the_light.Data.Entities
{
    public class Shopping_cart
    {
        public int Client_emailf { get; set; }
        public int? Product_count { get; set; }
        public int? Product_idf { get; set; }
        [Key]
        public int Shopping_cart_id { get; private set; }
        public int Product_size { get; set; }
    }
}
