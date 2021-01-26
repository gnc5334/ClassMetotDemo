using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Customer customer1 = new Customer();
                customer1.Id = 1;
                customer1.Name = "Ali";
                customer1.Surname = "Kaya";
                customer1.DateOfBirth = Convert.ToDateTime("31.08.1993");
                customer1.City = "Ankara";
                customer1.CreditCardNumber = "7382 6748 4939 3111";

                Customer customer2 = new Customer();
                customer2.Id = 1;
                customer2.Name = "Veli";
                customer2.Surname = "Çetin";
                customer2.DateOfBirth = Convert.ToDateTime("31.08.1993");
                customer2.City = "İstanbul";
                customer2.CreditCardNumber = "5566 0029 4939 8490";



                CustomerManager customerManager = new CustomerManager();
                customerManager.Add(customer1);
                customerManager.Add(customer2);

               
                customerManager.List();


                Console.Read();
            }
            catch (Exception ex)
            {
                string hata = ex.InnerException.ToString();
            }
            
        }
    }
}
