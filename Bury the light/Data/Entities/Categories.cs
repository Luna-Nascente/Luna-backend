using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Bury_the_light.Data.Entities
{
    public class Categories
    {
        public string Category_name { get; set; }
        [Key]
        public int Category_id { get; private set; }
    }
}
