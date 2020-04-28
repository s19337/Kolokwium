using Kolokwium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.DTOs.Requests
{
    public class MedicamentRequest
    {
        [Require]
        List<Medicament> listMed { get; set; }

    }
}
