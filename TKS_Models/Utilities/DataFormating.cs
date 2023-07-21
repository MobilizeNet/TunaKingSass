using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilize.WebMap.Common.Attributes;

namespace TKS_Models.Utilities
{

   [Observable]
   public class DataFormating
   {

      public static string GetNullParameter(object parameter)
      {
         return parameter == null ? "NULL" : $"{parameter}";
      }

      public static string GetNullParameterStr(string parameter)
      {
         return parameter == null ? "NULL" : $"'{parameter}'";
      }

      public static string GetNullParameterDate(DateTime parameter)
      {
         var str = parameter.ToShortDateString();
         return parameter == null ? "NULL" : $"'{str}'";
      }

   }

}