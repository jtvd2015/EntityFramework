using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;  //this had to be added so that [Required] would not cause an error when a build is performed
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroEntityFramework
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public int? CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        [Required] [MaxLength(50)] [MinLength(10)] public string OrderDescription { get; set; }  //[MinLength] does not show on the SQL columns; the MinLength will show when we start using MVC and will generate an error, if the description is < 10 characters

        public virtual Customer Customer { get; set; }  //read-only column
    }
}