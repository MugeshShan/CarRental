using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem
{
    public class CustomerPageModel
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Mobile { get; set; }
        public string License { get; set; }
        public string DOB { get; set; }
        public string Issue_date { get; set; }

        public string Address { get; set; }
    }
}
