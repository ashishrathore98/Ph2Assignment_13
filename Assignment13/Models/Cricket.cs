using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment13.Models
{
    [Table("Cricket")]
    public class Cricket
    {
        [Key]
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public int NoWc { get; set; }


    }
}
 
  