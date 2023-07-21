using System.Collections.Generic;
using Mobilize.WebMap.Common.Attributes;

namespace TKS_Models
{

   public interface IQueryFormater
   {

      Dictionary<string, string> GetQueryValues();

   }

}