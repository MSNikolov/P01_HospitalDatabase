using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P01_HospitalDatabase.Data.Models
{
    [Table("Medicaments")]
    public class Medicament
    {
        /// <summary>
        /// Id of medication
        /// </summary>
        [Key]
        public int MedicamentId { get; set; }

        /// <summary>
        /// Name of medication
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public HashSet<PatientMedicament> Prescriptions { get; set; }
    }
}
