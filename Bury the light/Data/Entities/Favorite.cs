using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Bury_the_light.Data.Entities
{
    public class Favorite
    {
        [Key]
        public int Favorites_id { get; private set; }
        public int Client_idf { get; set; }
        public int Product_idf { get; set; }
    }
}
