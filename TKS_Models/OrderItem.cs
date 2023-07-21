using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilize.WebMap.Common.Attributes;

namespace TKS_Models
{

   [Observable]
   public class OrderItem
      : IQueryFormater
   {

      [Intercepted]
      public int OrderId { get; set; }

      [Intercepted]
      public int Id { get; set; }

      [Intercepted]
      public int ProductId { get; set; }

      [Intercepted]
      public int Quantity { get; set; }

      [Intercepted]
      public decimal ListPrice { get; set; }

      [Intercepted]
      public decimal Discount { get; set; }

      public Dictionary<string, string> GetQueryValues()
      {
         return new Dictionary<string, string>()
            {
               { "item_id", Utilities.DataFormating.GetNullParameter(this.Id) },
               { "order_id", Utilities.DataFormating.GetNullParameter(this.OrderId) },
               { "product_id", Utilities.DataFormating.GetNullParameter(this.ProductId) },
               { "quantity", Utilities.DataFormating.GetNullParameter(this.Quantity) },
               { "list_price", Utilities.DataFormating.GetNullParameter(this.ListPrice) },
               { "discount", Utilities.DataFormating.GetNullParameter(this.Discount) },
            }
            ;
      }

   }

}