using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        //Add() Indivudial Customer
        public void Add(IndividualCustomer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + "isimli bireysel müşteri başarıyla eklendi.");
        }
        //Add Corporate Customer
        public void Add2(CorporateCustomer customer)
        {
            Console.WriteLine(customer.CompanyName + " " + "isimli kurumsal müşteri başarıyla eklendi.");
        }
        //Update() Indivudial Customer
        public void Update(IndividualCustomer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + "başarıyla güncellendi.");
        }
        //Update() Corporate Customer
        public void Update2(CorporateCustomer customer)
        {
            Console.WriteLine(customer.CompanyName + " " + "başarıyla güncellendi.");
        }
        //Delete() Indivudial Customer
        public void Delete(IndividualCustomer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + "başarıyla silindi.");
        }
        //Delete() Corporate Customer
        public void Delete2(CorporateCustomer customer)
        {
            Console.WriteLine(customer.CompanyName + " " + "başarıyla silindi.");
        }
    }
}
