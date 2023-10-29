using System;

namespace CallStoredProcUsingEntityFramework6x
{
   internal class Program
   {
      static void Main(string[] args)
      {
         DemoUsingEntityObject();
         //DemoUsingExecuteStatement();

         Console.ReadLine();
      }

      /// <summary>
      /// Call individual methods here. Make sure to supply correct values
      /// for the customerId of existing record(s) from the database for the GetCustomerByID()
      /// UpdateCustomer() and DeleteCustomer() methods.
      /// </summary>
      private static void DemoUsingEntityObject()
      {
         CallStoredProcUsingEntityObject entityObject = new CallStoredProcUsingEntityObject();

         //entityObject.InsertCustomer();
         //entityObject.GetCustomerByID();
         //entityObject.UpdateCustomer();
         //entityObject.GetAllCustomers();
         //entityObject.DeleteCustomer();
      }

      /// <summary>
      /// Call individual methods here. Make sure to supply correct values
      /// for the customerId of existing record(s) from the database for the GetCustomerByID()
      /// UpdateCustomer() and DeleteCustomer() methods
      /// </summary>
      private static void DemoUsingExecuteStatement()
      {
         CallStoredProcUsingExecuteStatement execObject = new CallStoredProcUsingExecuteStatement();

         //execObject.InsertCustomer();
         //execObject.GetCustomerByID();
         //execObject.UpdateCustomer();
         //execObject.GetAllCustomers();
         //execObject.DeleteCustomer();
      }
   }
}
