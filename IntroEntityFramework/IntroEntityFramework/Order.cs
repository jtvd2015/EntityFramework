using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroEntityFramework
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Total { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderDescription { get; set; }

        public virtual Customer Customer { get; set; }  //read-only column
    }
}