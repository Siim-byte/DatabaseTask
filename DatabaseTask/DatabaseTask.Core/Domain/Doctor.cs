using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string Profession { get; set; }
        public int PhoneNuber { get; set; }
        public string Title {  get; set; }
        public ICollection<MedicalVisit> MedicalVisits { get; set; }

    }
}
