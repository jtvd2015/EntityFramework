using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;  //this had to be added so that [Required] would not cause an error when a build is performed
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroEntityFramework
{
    public class Customer
    {
        public int Id { get; set; }
        [Required] [MaxLength(80)] public string Name { get; set; }
        [Required] [MaxLength(80)] public string City { get; set; }
        [Required] [MaxLength(2)] public string State { get; set; }
    }
}