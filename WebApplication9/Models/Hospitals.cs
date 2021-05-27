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

        [Required(ErrorMessage = "waiting name")]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "waiting adress")]
        [Display(Name = "Adress")]
        public string adress { get; set; }

        [Required(ErrorMessage = "waiting phone")]
        [Display(Name = "Phones")]
        //[RegularExpression(@"^(?([0-9]{3}))?[-. ]?([0-9]{3})[-. ]?([0-9]{5})$", ErrorMessage = "Wrong phone")]
        [DataType(DataType.PhoneNumber)]
        public string phones { get; set; }
    }
}
