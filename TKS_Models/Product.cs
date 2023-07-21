using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilize.WebMap.Common.Attributes;

namespace TKS_Models
{

   [Observable]
   public class Product
      : IQueryFormater
   {

      [Intercepted]
      public int Id { get; set; }

      [Intercepted]
      public string Name { get; set; }

      [Intercepted]
      public int Brand { get; set; }

      [Intercepted]
      public int Category { get; set; }

      [Intercepted]
      public short ModelYear { get; set; }

      [Intercepted]
      public decimal Price { get; set; }

      public Dictionary<string, string> GetQueryValues()
      {
         return new Dictionary<string, string>()
            {
               { "product_name", Utilities.DataFormating.GetNullParameterStr(this.Name) },
               { "brand_id", Utilities.DataFormating.GetNullParameter(this.Brand) },
               { "category_id", Utilities.DataFormating.GetNullParameter(this.Category) },
               { "model_year", Utilities.DataFormating.GetNullParameter(this.ModelYear) },
               { "list_price", Utilities.DataFormating.GetNullParameter(this.Price) },
            }
            ;
      }

   }

}