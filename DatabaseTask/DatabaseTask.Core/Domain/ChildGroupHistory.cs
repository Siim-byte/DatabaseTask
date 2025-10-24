using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class ChildGroupHistory
    {
        [Key]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Group> Groupid { get; set; }
    }
}
