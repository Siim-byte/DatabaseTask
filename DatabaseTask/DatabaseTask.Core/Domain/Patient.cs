using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Patient
    {
        public int PatientID { get; set; }
        public int IdentificationNum { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        public string Aadress { get; set; }

    }
}
