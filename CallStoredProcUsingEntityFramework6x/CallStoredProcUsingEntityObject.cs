using System;
using System.Linq;

namespace CallStoredProcUsingEntityFramework6x
{
   public class CallStoredProcUsingEntityObject
   {
      private readonly CustomerEntities ce = null;

      public CallStoredProcUsingEntityObject()
      {
         ce = new CustomerEntities();
      }

      public void GetAllCustomers()
      {
         var results = ce.GetAllCustomers().ToList();
         foreach (var item in results)
         {
            Console.WriteLine("ID:{0}, Company Name:{1}, Contact:{2}, Address: {3}, Country: {4}, Phone:{5}",
                item.CustomerID, item.CompanyName, item.ContactName, item.Address, item.Country, item.Phone);
            Console.Write("");
         }
      }

      public void GetCustomerByID()
      {
         var results = ce.GetCustomerById(3).ToList();
         foreach (var item in results)
         {
            Console.WriteLine("ID:{0}, Company Name:{1}, Contact:{2}, Address: {3}, Country: {4}, Phone:{5}",
                item.CustomerID, item.CompanyName, item.ContactName, item.Address, item.Country, item.Phone);
            Console.Write("\n\n");
         }
      }

      public void InsertCustomer()
      {
         try
         {
            int result = ce.InsertCustomer("BCD", "Mike", "Manila", "Philippines", "999-0001");
            if (result == 1)
            {
               Console.WriteLine("Insert Record Successful!");
            }
         }
         catch (Exception e)
         {
            //do something here
         }
      }

      public void UpdateCustomer()
      {
         try
         {
            int result = ce.UpdateCustomer(3, "Jerang", "Lara", "Kuala Lumpur", "Malaysia", "333-3333");
            if (result == 1)
            {
               Console.WriteLine("Update Record Successful!");
            }
         }
         catch (Exception e)
         {
            //do something here
         }
      }

      public void DeleteCustomer()
      {
         try
         {
            int result = ce.DeleteCustomer(3);
            if (result == 1)
            {
               Console.WriteLine("Delete Record Successful!");
            }
         }
         catch (Exception e)
         {
            //do something here
         }
      }
   }
}
