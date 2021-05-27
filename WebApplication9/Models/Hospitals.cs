using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class Hospitals
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Waiting name")][Display(Name = "Name")] public string name { get; set; }

        [Required(ErrorMessage = "Waiting adress")][Display(Name = "Adress")] public string adress { get; set; }

        [Required(ErrorMessage = "Waiting phone")][Display(Name = "Phones")][DataType(DataType.PhoneNumber)] public string phones { get; set; }
    }
}
