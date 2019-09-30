using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MyWindowsFormsApp.Repository;

namespace MyWindowsFormsApp.BLL
{
    class CustomerManager

    {
        CustomerRepository _customerRepository = new CustomerRepository();

        public bool Add(string name, string phone, string address)
        {
            return _customerRepository.Add(name, phone, address);
        }

        public bool IsNameExists(string name)
        {
            return _customerRepository.IsNameExists(name);
        }

        public bool Update(string name, string phone, string address, int id)
        {
            return _customerRepository.Update(name, phone, address, id);
        }
        public bool Delete(int id)
        {
            return _customerRepository.Delete(id);
        }

        public DataTable Display()
        {
            return _customerRepository.Display();
        }
    }
}
