using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P01_HospitalDatabase.Data.Models
{
    [Table("Diagnoses")]
    public class Diagnose
    {
        /// <summary>
        /// Id of diagnosis
        /// </summary>
        [Key]
        public int DiagnoseId { get; set; }

        /// <summary>
        /// Name of diagnosis
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// Comments about diagnosis
        /// </summary>
        [Required]
        [StringLength(250)]
        
        public string Comments { get; set; }

        public int PatientId { get; set; }

        /// <summary>
        /// Diagnosed patient
        /// </summary>
        [ForeignKey(nameof(PatientId))]
        
        public Patient Patient { get; set; }
    }
}
