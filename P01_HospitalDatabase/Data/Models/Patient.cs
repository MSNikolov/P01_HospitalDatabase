using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P01_HospitalDatabase.Data.Models
{
    [Table("Patients")]
    public class Patient
    {
        /// <summary>
        /// PatientId
        /// </summary>
        [Key]
        public int PatientId { get; set; }

        /// <summary>
        /// Patient First Name
        /// </summary>
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        /// <summary>
        /// Patient Last Name
        /// </summary>
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        /// <summary>
        /// Patient address
        /// </summary>
        [Required]
        [StringLength(250)]
        public string Address { get; set; }

        /// <summary>
        /// Patient Email
        /// </summary>
        [Required]
        [StringLength(80)]
        public string Email { get; set; }

        /// <summary>
        /// Whether patients has health insurance
        /// </summary>
        public bool HasInsurance { get; set; }


        public HashSet<Diagnose> Diagnoses { get; set; }

        public HashSet<Visitation> Visitations { get; set; }

        public HashSet<PatientMedicament> Prescriptions { get; set; }
    }
}
