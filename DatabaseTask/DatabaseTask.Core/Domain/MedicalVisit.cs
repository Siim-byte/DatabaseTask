using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class MedicalVisit
    {
        [Key]
        public int MedicineID { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public ICollection<Doctor> Doctors {  get; set; }
        public ICollection<Patient> Patients { get; set; }

    }
}
