using Microsoft.EntityFrameworkCore;
using VKR_Kontorin.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace VKR_Kontorin.Models
{
    public class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
    }

}
