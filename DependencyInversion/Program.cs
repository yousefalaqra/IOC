using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {


            Owner Owner = new Owner
            {     
                ContactNumber = "+970-59-567-5811",
                EmailAdress = "yousif.arqa@gmail.com",
                FirstName = "Jo",
                SecondName = "Aqra"
            };

            Phone phoneItme = new Phone(10)
            {
                Name = "IPhone 11",
                Owner = Owner
            };


            phoneItme.PurchaseItme(Int32.Parse(args[0]));


        }
    }
}
