using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 8115;
            customer1.CostumerId = 1;
            customer1.TcNo = 12345678901;
            customer1.FirstName = "Yakup";
            customer1.LastName = "İLBEY";


            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 4040;
            customer2.CostumerId = 2;
            customer2.CompanyName = "İLBEY Bilişim Hizmetleri A.Ş.";
            customer2.TaxNo = 25802580;



            IndividualCustomer customer3 = new IndividualCustomer();
            CorporateCustomer customer4 = new CorporateCustomer();




           CustomerManager customerManager = new CustomerManager();

            //Individual Customer Operations
            customerManager.Add(customer1);
            customerManager.Update(customer1);
            customerManager.Delete(customer1);

            Console.WriteLine("\n");
            //Corporate Customer Operate
            customerManager.Add2(customer2);
            customerManager.Update2(customer2);
            customerManager.Delete2(customer2);






        }
    }
}
