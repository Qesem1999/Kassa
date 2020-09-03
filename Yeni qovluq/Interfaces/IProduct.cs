using BeinPos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeinPos.Interfaces
{
    public interface IProductTransactions
    {
         List<Product> GetList(string token);
    }
}
