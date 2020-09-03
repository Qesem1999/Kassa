using BeinPos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeinPos.Interfaces
{
    interface IDocSaleTransactions
    {
        List<DocSale> GetList(string token);

        void Create(string token, DocSale docSale);
    }
}
