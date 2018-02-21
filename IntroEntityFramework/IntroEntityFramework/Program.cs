using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroEntityFramework
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IntroDBContext db = new IntroDBContext();

            Order[] orders = db.Order.ToArray();
            foreach (Order order in orders)
            {
                string message = $"Id ={order.Id} || Total={order.Total} || Cust_Name={order.Customer.Name} || Date={order.OrderDate} || Description={order.OrderDescription}";
                Console.WriteLine(message);
            }

            //Customer Jude = db.Customers.Find(2);
            //if (Jude == null)
            //{
            //    Console.WriteLine($"Id ={Jude.Id}, Name ={ Jude.Name}, City / State ={ Jude.City}, { Jude.State}");
            //}
            //else
            //{
            //    string message = $"Id ={Jude.Id}, Name ={ Jude.Name}, City / State ={ Jude.City}, { Jude.State}";
            //    Console.WriteLine(message);
            //}

            //Customer[] custs = db.Customers
            //    .Where(cust => cust.State == "OH")  //Selects customers from the State of OH
            //    .OrderByDescending(cust => cust.Name)  //Orders customers by Descending Order (Order By goes after Where in the SQL query statement)
            //    .ToArray();  //ToArray is the last thing in the statement
            //foreach (Customer cust in custs)
            //{
            //    string message = $"Id={cust.Id}, Name={cust.Name}, City/State={cust.City}, {cust.State}";
            //    Console.WriteLine(message);
            //}

            //Customer[] customers = db.Customers.OrderByDescending(cust => cust.Name).ToArray();  //this will be sorted in descending order (.OrderBy) by customer Name
            //foreach (Customer cust in customers)
            //{
            //    string message = $"Id={cust.Id}, Name={cust.Name}";
            //    Console.WriteLine(message);
            //}

            //Customer[] customers = db.Customers.OrderBy(cust => cust.Name).ToArray();  //this will be sorted (.OrderBy) by customer Name
            //foreach (Customer cust in customers)
            //{
            //    string message = $"Id={cust.Id}, Name={cust.Name}";
            //    Console.WriteLine(message);
            //}

            //Customer[] custs = db.Customers.Where(cust => cust.State == "KY").ToArray();
            //foreach (Customer cust in custs)
            //{
            //    string message = $"Id={cust.Id}, Name={cust.Name}, City/State={cust.City}, {cust.State}";
            //    Console.WriteLine(message);
            //}

            //List<Customer> custs = db.Customers.Where(c => c.Name == "Dora" && c.City == "Independence").ToList();
            //if (custs.Count == 0)
            //    if (custs.Count == 0)
            //    {
            //        Console.WriteLine("Error - cannot be found");
            //    }
            //    else
            //    {
            //        string message = $"Found {custs[0].Name}";
            //        Console.WriteLine(message);
            //    }
            Console.ReadKey();
        }
    }
}