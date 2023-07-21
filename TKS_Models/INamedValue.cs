using Mobilize.WebMap.Common.Attributes;

namespace TKS_Models
{

   [Observable]
   public class NamedValue
   {

      [Intercepted]
      public string Id { get; set; }

      [Intercepted]
      public string Name { get; set; }

   }

}