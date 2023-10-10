using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Bury_the_light.Data.Entities
{
    public class Deliveries
    {
        [Key]
        public int Delivery_id { get; private set; }
        public int Point_of_delivery_address { get; set; }
        public int Product_id { get; set; }
        public int Product_name { get; set; }
    }
}
