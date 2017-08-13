using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCContactList.Models
{
    public static class DataManager
    {

        private static List<Customer> customers = new List<Customer>();

        public static void AddCustomer(Customer customer)
        {
            customer.Id = Customer.IdGenerator++;
            customers.Add(customer);
           
        }

        public static Customer[] GetCustomers()
        {
            return customers.ToArray();
        }

        public static Customer GetCustomerById(int id)
        {
            return customers
                .SingleOrDefault(c => c.Id == id);
        }


        internal static void EditCustomer(int oldId, Customer customer)
        {
            //RemoveCustomer(oldId);
            //customers.Add(customer);

            // --- Alt 2 ---

            var oldCustomer = GetCustomerById(oldId);
            oldCustomer.CompanyName = customer.CompanyName;
            oldCustomer.Address = customer.Address;
            oldCustomer.EmployeeCount = customer.EmployeeCount;
        }

        public static void RemoveCustomer(int id)
        {
            var oldCustomer = customers
                .SingleOrDefault(c => c.Id == id);

            customers.Remove(oldCustomer);
        }
    }
}
