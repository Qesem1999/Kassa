using BeinPos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeinPos.Interfaces
{
    interface ISettingTransactions
    {
        void Set(Settings setting);

        Settings Get();
    }
}
