using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Department
    {
        public Guid DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string Location { get; set; }
        public int PhoneNumber { get; set; }
        public ICollection<Doctor> DoctorID { get; set; }

    }
}
