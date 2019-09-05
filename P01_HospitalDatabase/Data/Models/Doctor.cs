using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P01_HospitalDatabase.Data.Models
{

    [Table("Doctors")]
    public class Doctor
    {
        /// <summary>
        /// Id of doctor
        /// </summary>
        [Key]
        public int DoctorId { get; set; }

        /// <summary>
        /// Name of doctor
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        /// <summary>
        /// Specialty of doctor
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Specialty { get; set; }

        public HashSet<Visitation> Visitations { get; set; }
    }
}
