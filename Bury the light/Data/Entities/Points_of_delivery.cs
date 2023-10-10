using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Bury_the_light.Data.Entities
{
    public class Points_of_delivery
    {
        [Key]
        public int Point_of_delivery_id { get; private set; }
        public string Point_of_delivery_address { get; set; }
        public string Point_of_delivery_phone { get; set; }
    }
}
