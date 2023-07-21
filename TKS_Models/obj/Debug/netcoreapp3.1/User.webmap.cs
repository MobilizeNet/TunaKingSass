#pragma warning disable
#line 1 "User.cs"
#pragma warning disable
#line 1 "User.cs"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilize.WebMap.Common.Attributes;

namespace TKS_Models
{

   [Observable]
   public partial class User
      : IQueryFormater
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string Name_k__BackingField;
#line 17


      [Intercepted]
      public string Name 
#line 17
                         { 
#line 17
                           get                              
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Name_k__BackingField;} 
#line 17

#line 17
                                set                                   
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Name;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Name_k__BackingField=(string)value;} 
#line 17
                                     }

#line 18

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private TKS_Models.UserPermissions Permissions_k__BackingField;
#line 20


      [Intercepted]
      public UserPermissions Permissions 
#line 20
                                         { 
#line 20
                                           get                                              
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Permissions_k__BackingField;} 
#line 20

#line 20
                                                set                                                   
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Permissions;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Permissions_k__BackingField=(TKS_Models.UserPermissions)value;} 
#line 20
                                                     }

#line 21

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string Password_k__BackingField;
#line 23


      [Intercepted]
      public string Password 
#line 23
                             { 
#line 23
                               get                                  
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Password_k__BackingField;} 
#line 23

#line 23
                                    set                                       
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Password;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Password_k__BackingField=(string)value;} 
#line 23
                                         }

#line 24

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string Email_k__BackingField;
#line 26


      [Intercepted]
      public string Email 
#line 26
                          { 
#line 26
                            get                               
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Email_k__BackingField;} 
#line 26

#line 26
                                 set                                    
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Email;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Email_k__BackingField=(string)value;} 
#line 26
                                      }

#line 27

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
#pragma warning restore
