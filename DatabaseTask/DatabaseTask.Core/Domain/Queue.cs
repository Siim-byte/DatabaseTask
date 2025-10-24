using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Queue
    {
        [Key]
        public DateTime RegDate { get; set; }
        public ICollection<Child> id { get; set; }
        public ICollection<Group> GroupId { get; set; }
    }
}
