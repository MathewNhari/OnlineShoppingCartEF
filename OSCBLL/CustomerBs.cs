using System;
using System.Collections.Generic;
using System.Text;
using OSCDAL;
using OSCBOL;

namespace OSCBLL
{
    class CustomerBs
    {
         
        CustomerDb CustomerDb;
        public CustomerBs()
        {
            CustomerDb = new CustomerDb();
        }
        public IEnumerable<Customer> GetAll()
        {
            return CustomerDb.GetAll();
        }
        public Customer GetById(int id)
        {
            return CustomerDb.GetById(id);
        }
        public void Add(Customer customer)
        {
            CustomerDb.Add(customer);
        }
        public void Update(Customer customer)
        {
            CustomerDb.Update(customer);
        }
        public void Delete(Customer customer)
        {
            CustomerDb.Delete(customer);
        }
        public void Save()
        {
            CustomerDb.Save();
        }
    }
}

