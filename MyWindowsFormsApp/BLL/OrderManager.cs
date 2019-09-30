using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MyWindowsFormsApp.Repository;

namespace MyWindowsFormsApp.BLL
{
    class OrderManager
    {
        OrderRepository _orderRepository = new OrderRepository();
        public bool Add(string customerName, string itemName, int quantity, int price)
        {
            return _orderRepository.Add(customerName, itemName, quantity, price);
        }

        public bool IsNameExists(string name)
        {
            return _orderRepository.IsNameExists(name);
        }

        public DataTable Display()
        {
            return _orderRepository.Display();
        }

    
        public DataTable Search(string name)
        {
            return _orderRepository.Search(name);
        }


        public bool Update(string customerName, string itemName, int quantity, int price, int id)
        {
            return _orderRepository.Update(customerName, itemName, quantity, price, id);
        }

        public bool Delete(int id)
        {
            return _orderRepository.Delete(id);
        }

    }

}
