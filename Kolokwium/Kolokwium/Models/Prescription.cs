using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Models
{
    public class Prescription
    {
        [Required]
        public string Date { get; set; }

        [Required]
        public string DueDate { get; set; }
    }
}
