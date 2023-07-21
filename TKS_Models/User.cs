using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilize.WebMap.Common.Attributes;

namespace TKS_Models
{

   [Observable]
   public class User
      : IQueryFormater
   {

      [Intercepted]
      public string Name { get; set; }

      [Intercepted]
      public UserPermissions Permissions { get; set; }

      [Intercepted]
      public string Password { get; set; }

      [Intercepted]
      public string Email { get; set; }

      public Dictionary<string, string> GetQueryValues()
      {
         return new Dictionary<string, string>()
            {
               { "user_id", Utilities.DataFormating.GetNullParameterStr(this.Name) },
               { "user_password", Utilities.DataFormating.GetNullParameterStr(this.Password) },
               { "user_email", Utilities.DataFormating.GetNullParameterStr(this.Email) },
               { "user_roles", Utilities.DataFormating.GetNullParameterStr(Permissions.ToString()) },
            }
            ;
      }

   }

}