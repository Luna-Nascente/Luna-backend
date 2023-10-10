using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Bury_the_light.Data.Entities
{
    public class Clients
    {
        [Key]
        public int Client_id { get; private set; }
        public DateTime? Client_birthday { get; set; }
        public string Client_name { get; set; }
        public string Client_email { get; set; }
        public string Client_address { get; set; }
        public string Client_password { get; set; }
    }
}
