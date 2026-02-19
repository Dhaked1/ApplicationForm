using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationFormApp.Models
{
    public class City
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [ForeignKey("State")]
        public int StateId { get; set; }
        public State? State { get; set; }

        public ICollection<Pincode>? Pincodes { get; set; }
    }
}
