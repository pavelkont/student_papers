using Microsoft.EntityFrameworkCore;
using VKR_Kontorin.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace VKR_Kontorin.Models
{
    //[Keyless]
    public class Tech
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Tipe_id { get; set; }
        public int Brand_id { get; set; }
        public int Mark_id { get; set; }
        public int Owner_id { get; set; }
        public int City_id { get; set; }
        public string? Distr { get; set; }
        public int Price { get; set; }
        public bool Free { get; set; }
        public string? Cust { get; set; }
        public string? Time { get; set; }
        public bool Block { get; set; }
    }

}
