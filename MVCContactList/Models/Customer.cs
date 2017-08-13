using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCContactList.Models
{
    public class Customer
    {
        public static int IdGenerator = 0;

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public int EmployeeCount { get; set; }
    }
}
