using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        public int ChildCount { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int RoomNr { get; set; }
    }
}
