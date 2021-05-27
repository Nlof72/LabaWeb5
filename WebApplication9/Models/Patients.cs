using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class Patients
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Waiting name")] [Display(Name = "Name")] public string name { get; set; }
        [Required(ErrorMessage = "Waiting disease")] [Display(Name = "Disease")]  public string disease { get; set; }
    }
}
