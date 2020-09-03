using BeinPos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeinPos.Interfaces
{
    public interface ICustomerTransactions
    {
        List<Customer> GetList(string token);

        void Create(string token, Customer customer);
    }
}
