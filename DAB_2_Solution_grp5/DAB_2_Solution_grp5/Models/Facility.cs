using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB_2_Solution_grp5.Models
{
    public class Facility
    {


        [Key]
        public int id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public string? Bookable { get; set; }
        public string? Item { get; set; }




    }
}
