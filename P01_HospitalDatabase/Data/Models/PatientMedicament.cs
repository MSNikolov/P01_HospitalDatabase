using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P01_HospitalDatabase.Data.Models
{
    [Table("PatientMedicaments")]
    public class PatientMedicament
    {
        /// <summary>
        /// Id of patient
        /// </summary>
        
        public int PatientId { get; set; }


        /// <summary>
        /// Id of medication
        /// </summary>
        
        public int MedicamentId { get; set; }


        /// <summary>
        /// Treated patient
        /// </summary>
        [ForeignKey(nameof(PatientId))]
        public Patient Patient { get; set; }

        /// <summary>
        /// Prescribed medication
        /// </summary>

        [ForeignKey(nameof(MedicamentId))]
        public Medicament Medicament { get; set; }
    }
}
