using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Medicine
    {
        public int MedicineID { get; set; }
        public string Name { get; set; }
        public string Ingredient { get; set; }
        public int Dose { get; set; }
        public ICollection<Doctor> Doctors { get; set; }

    }
}
