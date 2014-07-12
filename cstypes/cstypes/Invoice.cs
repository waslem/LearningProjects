using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cstypes
{
    public class Invoice
    {
        public Invoice()
        {

        }
        public Invoice(int ID, string Description, decimal Amount)
        {
            this.ID = ID;
            this.Description = Description;
            this.Amount = Amount;
        }

        public int ID { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
