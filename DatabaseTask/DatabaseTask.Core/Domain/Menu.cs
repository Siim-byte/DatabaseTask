using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Menu
    {
        [Key]
        public string Morning {  get; set; }
        public string MorningSnack {  get; set; }
        public string Lunch {  get; set; }
        public string DinnerSnack {  get; set; }
        public string Dinner {  get; set; }
        public DateTime Date {  get; set; }
        public int Portions {  get; set; }
    }
}
