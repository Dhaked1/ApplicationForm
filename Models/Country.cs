using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApplicationFormApp.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public ICollection<State>? States { get; set; }
    }
}
