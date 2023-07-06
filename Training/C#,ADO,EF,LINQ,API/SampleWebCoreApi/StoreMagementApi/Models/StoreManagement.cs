using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace StoreMagementApi.Models
{
    public class StoreManagement
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.None)] public int Product_id { get; set; }
        public string Product_name { get; set; } = string.Empty;

        public int Quantity_available { get; set; }

        public double Cost { get; set; }
    }
}
