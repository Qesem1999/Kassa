using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeinPos.Models
{
    class DocSale
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Moment { get; set; }
        public string CustomerId { get; set; }
        public float Discount { get; set; }
        public float UseBonus { get; set; }
        public float Bank { get; set; }
        public float Amount { get; set; }


        public List<Position> Positions { get; set; }


        public DocSale()
        {
            this.Positions = new List<Position>();
        }



    }
}
