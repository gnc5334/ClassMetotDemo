using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Müşteri Adı");
            }
            catch (Exception ex)
            {
                string hata = ex.InnerException.ToString();
            }
            
        }
    }
}
