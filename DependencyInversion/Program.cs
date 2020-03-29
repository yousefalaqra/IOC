using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {


            IPerson Owner = Factory.CreatePerson();
            Owner.ContactNumber = "+970-59-567-5811";
            Owner.EmailAdress = "yousif.arqa@gmail.com";
            Owner.FirstName = "Jo";
            Owner.SecondName = "Aqra";

            IProduct phoneItme = Factory.CreateProduct();
            phoneItme.Name = "IPhone 11";
            phoneItme.Owner = Owner;


            phoneItme.PurchaseItme(Int32.Parse(args[0]));


        }
    }
}
