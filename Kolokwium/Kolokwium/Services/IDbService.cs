using Kolokwium.DTOs.Requests;
using Kolokwium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Services
{
   public interface IDbService
    {

        IEnumerable<Prescription> GetPrescription(string lastName);
        Prescription AddMedicament(MedicamentRequest request);
    }

   



}
