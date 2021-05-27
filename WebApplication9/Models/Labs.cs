using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class Labs
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Waiting adress")][Display(Name = "Name")] public string name { get; set; }

        [Required(ErrorMessage = "Waiting adress")][Display(Name = "Adress")] public string adress { get; set; }
    }
}
