using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class PaymentModel
    {
        public int Payment_id { get; set; }
        public string Status { get; set; }
        public string Amount { get; set; }
        public System.DateTime Date { get; set; }
    }
}
