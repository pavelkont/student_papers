using System.ComponentModel.DataAnnotations.Schema;

namespace VKR_Kontorin.Models
{
    public class Brand
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
    }

}
