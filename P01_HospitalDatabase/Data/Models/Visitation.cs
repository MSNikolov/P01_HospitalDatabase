using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P01_HospitalDatabase.Data.Models
{
    [Table("Visitations")]
    public class Visitation
    {
        /// <summary>
        /// Visitation Id
        /// </summary>
        [Key]
        public int VisitationId { get; set; }

        /// <summary>
        /// Date of visitation
        /// </summary>
        [Required]
        public DateTime Date { get; set; }

        /// <summary>
        /// Comments about visitation
        /// </summary>
        [Required]
        [StringLength(250)]
        public string Comments { get; set; }

        public int PatientId { get; set; }

        [ForeignKey(nameof(PatientId))]
        public Patient Patient { get; set; }


        /// <summary>
        /// Id of doctor
        /// </summary>
        public int DoctorId { get; set; }

        /// <summary>
        /// Visiting doctor
        /// </summary>
        [ForeignKey(nameof(DoctorId))]
        public Doctor Doctor { get; set; }
    }
}
