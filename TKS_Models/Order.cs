using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilize.WebMap.Common.Attributes;

namespace TKS_Models
{

   [Observable]
   public class Order
      : IQueryFormater
   {

      [Intercepted]
      public int Id { get; set; }

      [Intercepted]
      public int CustomerId { get; set; }

      [Intercepted]
      public byte OrderStatus { get; set; }

      [Intercepted]
      public DateTime OrderDate { get; set; }

      [Intercepted]
      public DateTime RequiredDate { get; set; }

      [Intercepted]
      public DateTime ShippedDate { get; set; }

      [Intercepted]
      public int StoreId { get; set; }

      [Intercepted]
      public int StaffId { get; set; }

      public Dictionary<string, string> GetQueryValues()
      {
         return new Dictionary<string, string>()
            {
               { "customer_id", Utilities.DataFormating.GetNullParameter(this.CustomerId) },
               { "order_status", Utilities.DataFormating.GetNullParameter(this.OrderStatus) },
               { "order_date", Utilities.DataFormating.GetNullParameterDate(this.OrderDate) },
               { "required_date", Utilities.DataFormating.GetNullParameterDate(this.RequiredDate) },
               { "shipped_date", Utilities.DataFormating.GetNullParameterDate(this.ShippedDate) },
               { "staff_id", Utilities.DataFormating.GetNullParameter(this.StaffId) },
               { "store_id", Utilities.DataFormating.GetNullParameter(this.StoreId) },
            }
            ;
      }

   }

}