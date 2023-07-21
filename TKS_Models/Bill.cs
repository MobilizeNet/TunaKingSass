using System.Collections.Generic;
using Mobilize.WebMap.Common.Attributes;

namespace TKS_Models
{

   [Observable]
   public class Bill
   {

      [Intercepted]
      public string Office { get; set; }

      [Intercepted]
      public Dictionary<string, string> DocumentType { get; set; }

      [Intercepted]
      public string EconomicActivity { get; set; }

      [Intercepted]
      public string SerialNumber { get; set; }

   }

}