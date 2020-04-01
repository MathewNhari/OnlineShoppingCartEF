using OSCBOL;
using System.Collections.Generic;
using System.Linq;

namespace OSCDAL
{
    public class CustomerDb
    {
        OSCDbContext OSCDbContext;
        public CustomerDb()
        {
            OSCDbContext = new OSCDbContext();
        }

        public IEnumerable<Customer> GetAll()
        {
            IEnumerable<Customer> customers = OSCDbContext.Customers.ToList();
            return customers;
        }
        public Customer GetById(int id)
        {
            Customer customer = OSCDbContext.Customers.Find(id);
            return customer;
        }
        public void Add(Customer customer)
        {
            OSCDbContext.Customers.Add(customer);

        }
        public void Update(Customer customer)
        {
            OSCDbContext.Customers.Update(customer);
        }
        public void Delete(Customer customer)
        {
            OSCDbContext.Customers.Remove(customer);
        }
        public void Save()
        {
            OSCDbContext.SaveChanges();
        }
    }
}
