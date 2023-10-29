using System;
using System.Data.SqlClient;
using System.Linq;

namespace CallStoredProcUsingEntityFramework6x
{
   public class CallStoredProcUsingExecuteStatement
   {
      private readonly CustomerEntities ce = null;

      public CallStoredProcUsingExecuteStatement()
      {
         ce = new CustomerEntities();
      }

      public void InsertCustomer()
      {
         try
         {
            //using SqlParameter() class
            var result = ce.Database.ExecuteSqlCommand("EXEC dbo.InsertCustomer @CompanyName,@ContactName,@Address,@Country,@Phone",
                new SqlParameter("CompanyName", "TNT Bookstore"),
                new SqlParameter("ContactName", "Mr T."),
                new SqlParameter("Address", "Lincoln Village"),
                new SqlParameter("Country", "UK"),
                new SqlParameter("Phone", "42333"));

            if (result == 1)
            {
               Console.WriteLine("Insert Record Successful!");
            }
         }
         catch (Exception)
         {
            //do something here
         }
      }

      public void UpdateCustomer()
      {
         try
         {
            //using SqlParameter() class
            var result = ce.Database.ExecuteSqlCommand("EXEC dbo.UpdateCustomer @CustomerID, @CompanyName,@ContactName,@Address,@Country,@Phone",
                new SqlParameter("CustomerID", 1),
                new SqlParameter("CompanyName", "TNT Bookstore"),
                new SqlParameter("ContactName", "Mr M."),
                new SqlParameter("Address", "New Orleans"),
                new SqlParameter("Country", "USA"),
                new SqlParameter("Phone", "43567"));

            if (result == 1)
            {
               Console.WriteLine("Update Record Successful!");
            }
         }
         catch (Exception)
         {
            //do something here
         }
      }

      public void DeleteCustomer()
      {
         try
         {
            var result = ce.Database.ExecuteSqlCommand("EXEC dbo.DeleteCustomer @CustomerID",
                new SqlParameter("CustomerID", 1));
            if (result == 1)
            {
               Console.WriteLine("Delete Record Successful!");
            }
         }
         catch (Exception)
         {
            //do something here
         }
      }

      public void GetAllCustomers()
      {
         var results = ce.Database.SqlQuery<Customer>("GetAllCustomers", "").ToList();
         foreach (var item in results)
         {
            Console.WriteLine("ID:{0}, Company Name:{1}, Contact:{2}, Address: {3}, Country: {4}, Phone:{5}",
                item.CustomerID, item.CompanyName, item.ContactName, item.Address, item.Country, item.Phone);
            Console.Write("");
         }
      }

      public void GetCustomerByID()
      {
         var result = ce.Database.SqlQuery<Customer>("GetCustomerById @CustomerID", new SqlParameter("CustomerID", 1)).FirstOrDefault();

         if (result != null)
         {
            Console.WriteLine("ID:{0}, Company Name:{1}, Contact:{2}, Address: {3}, Country: {4}, Phone:{5}",
            result.CustomerID, result.CompanyName, result.ContactName, result.Address, result.Country, result.Phone);
            Console.Write("\n\n");
         }
      }
   }
}