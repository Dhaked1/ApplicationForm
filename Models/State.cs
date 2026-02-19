using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationFormApp.Models
{
    public class State
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country? Country { get; set; }

        public ICollection<City>? Cities { get; set; }
    }
}
