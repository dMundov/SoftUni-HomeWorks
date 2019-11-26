using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _01.HospitalDatabase.Data.Models
{
    public class Medicament
    {

        public Medicament()
        {
            this.Prescriptions = new List<PatientMedicament>();
        }
        public int MedicamentId { get; set; }

        
        public string Name { get; set; }

        public ICollection<PatientMedicament> Prescriptions { get; set; }

    }
}
