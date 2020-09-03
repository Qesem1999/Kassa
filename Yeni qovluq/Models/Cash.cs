using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeinPos.Application.Models;


namespace BeinPos.Models
{
    class ResponseCash
    {
        public Header Headers { get; set; }
        public Cash Body { get; set; }

    }
    class Cash
    {
        public string Id { get; set; }
        public float Balance { get; set; }
    }
}
