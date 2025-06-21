using System.ComponentModel.DataAnnotations;

namespace VKR_Kontorin.Models
{
    public class Owner
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string? Tlf { get; set; }
    }
}