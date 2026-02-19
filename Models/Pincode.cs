using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationFormApp.Models
{
    public class Pincode
    {
        public int Id { get; set; }

        [Required]
        public string? Code { get; set; }

        [Required]
        public string? District { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }
        public City? City { get; set; }
    }
}
