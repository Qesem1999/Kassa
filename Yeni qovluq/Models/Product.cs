using BeinPos.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeinPos.Models
{
    public class ResponseProduct
    {
        public Header Headers { get; set; }
        public List<Product> Body { get; set; }
       

    }

    
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string BarCode { get; set; }
        public float Price { get; set; }
        public float MinPrice { get; set; }
        public bool IsWait { get; set; }
        public float BalanceOnStock { get; set; }


    }
}
