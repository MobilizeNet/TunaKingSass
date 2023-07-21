using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TKS_DB;
using Mobilize.WebMap.Common.Attributes;

namespace TKS
{

   [Observable]
   public class ValidationCommon
   {

      public static bool IsValidNameCase(Mobilize.Web.Control control)
      {
         // This code Should be moving to the FE.
         return String.IsNullOrEmpty(control.Text) || !Char.IsUpper(control.Text[0]);
      }

      public static bool IsValidEmailDomian(string email)
      {
         if ( !string.IsNullOrWhiteSpace(email) && Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase) )
         {
            var handler = new DataHandler();
            var domain = email.Split('@')[1];
            var list = handler.GetListDataSource<string>("domains_id", "roles.domains");
            return list.Contains(domain, StringComparer.OrdinalIgnoreCase);
         }
         return false;
      }

      public static bool IsValidUserName(string id)
      {
         var handler = new DataHandler();
         var userId = handler.GetUserById(id);
         return string.IsNullOrEmpty(userId);
      }

      public bool IsValidPassword(string pass)
      {
         return System.Text.RegularExpressions.Regex.IsMatch(pass, @"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$");
      }

   }

}