using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> customerList = new List<Customer>();
       
        public void Add(Customer customer)
        {

            Console.WriteLine("Yeni Müşteri: " + customer.Name + " " + customer.Surname + " eklendi.");
            customerList.Add(customer);
        }

        public void List()
        {
            Console.WriteLine("");
            Console.WriteLine(" ------ MÜŞTERİ LİSTESi ------ ");
            foreach (var customerItem in customerList)
                Console.WriteLine(customerItem.CreditCardNumber + " -  " + customerItem.Name + " " + customerItem.Surname);

        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " müşterisi silindi.");
        }


    }
}
