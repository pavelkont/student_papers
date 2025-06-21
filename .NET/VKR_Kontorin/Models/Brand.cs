using Microsoft.EntityFrameworkCore;
using VKR_Kontorin.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace VKR_Kontorin.Models
{
    //[Keyless]
    public class Brand
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
    }

}
