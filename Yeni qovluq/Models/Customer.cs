using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeinPos.Application.Models;


namespace BeinPos.Models
{
    public class ResponseCustomer
    {
        public Header Headers { get; set; }
        public List<Customer> Body { get; set; }


    }
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public float Discount { get; set; }
        public float Bonus { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Card { get; set; }






    }
}
