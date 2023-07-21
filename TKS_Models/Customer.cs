using System;
using System.Collections.Generic;
using Mobilize.WebMap.Common.Attributes;

namespace TKS_Models
{

   [Observable]
   public class Customer
      : User, IQueryFormater
   {

      [Intercepted]
      public int Id { get; set; }

      [Intercepted]
      public string LastName { get; set; }

      [Intercepted]
      public string Phone { get; set; }

      [Intercepted]
      public string Street { get; set; }

      [Intercepted]
      public string City { get; set; }

      [Intercepted]
      public string State { get; set; }

      [Intercepted]
      public string ZipCode { get; set; }

      public Dictionary<string, string> GetQueryValues()
      {
         return new Dictionary<string, string>()
            {
               { "first_name", Utilities.DataFormating.GetNullParameterStr(this.Name) },
               { "last_name", Utilities.DataFormating.GetNullParameterStr(this.LastName) },
               { "phone", Utilities.DataFormating.GetNullParameterStr(this.Phone) },
               { "email", Utilities.DataFormating.GetNullParameterStr(this.Email) },
               { "street", Utilities.DataFormating.GetNullParameterStr(this.Street) },
               { "city", Utilities.DataFormating.GetNullParameterStr(this.City) },
               { "state", Utilities.DataFormating.GetNullParameterStr(this.State) },
               { "zip_code", Utilities.DataFormating.GetNullParameterStr(this.ZipCode) },
            }
            ;
      }

   }

}