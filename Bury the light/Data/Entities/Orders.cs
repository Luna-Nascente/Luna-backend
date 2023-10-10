using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Bury_the_light.Data.Entities
{
    public class Orders
    {
        [Key]
        public int Order_id { get; private set; }
        public DateTime? Order_date { get; set; }
        public int Client_id { get; set; }
        public int? Total_price { get; set; }
        public int Point_of_delivery_address { get; set; }
        public string Order_status { get; set; }
    }
}
