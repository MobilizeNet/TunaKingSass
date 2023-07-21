#pragma warning disable
#line 1 "Customer.cs"
#pragma warning disable
#line 1 "Customer.cs"
using System;
using System.Collections.Generic;
using Mobilize.WebMap.Common.Attributes;

namespace TKS_Models
{

   [Observable]
   public partial class Customer
      : User, IQueryFormater
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int Id_k__BackingField;
#line 14


      [Intercepted]
      public int Id 
#line 14
                    { 
#line 14
                      get                         
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Id_k__BackingField;} 
#line 14

#line 14
                           set                              
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Id;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Id_k__BackingField=(int)value;} 
#line 14
                                }

#line 15

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string LastName_k__BackingField;
#line 17


      [Intercepted]
      public string LastName 
#line 17
                             { 
#line 17
                               get                                  
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.LastName_k__BackingField;} 
#line 17

#line 17
                                    set                                       
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_LastName;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.LastName_k__BackingField=(string)value;} 
#line 17
                                         }

#line 18

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string Phone_k__BackingField;
#line 20


      [Intercepted]
      public string Phone 
#line 20
                          { 
#line 20
                            get                               
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Phone_k__BackingField;} 
#line 20

#line 20
                                 set                                    
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Phone;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Phone_k__BackingField=(string)value;} 
#line 20
                                      }

#line 21

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string Street_k__BackingField;
#line 23


      [Intercepted]
      public string Street 
#line 23
                           { 
#line 23
                             get                                
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Street_k__BackingField;} 
#line 23

#line 23
                                  set                                     
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Street;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Street_k__BackingField=(string)value;} 
#line 23
                                       }

#line 24

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string City_k__BackingField;
#line 26


      [Intercepted]
      public string City 
#line 26
                         { 
#line 26
                           get                              
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.City_k__BackingField;} 
#line 26

#line 26
                                set                                   
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_City;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.City_k__BackingField=(string)value;} 
#line 26
                                     }

#line 27

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string State_k__BackingField;
#line 29


      [Intercepted]
      public string State 
#line 29
                          { 
#line 29
                            get                               
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.State_k__BackingField;} 
#line 29

#line 29
                                 set                                    
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_State;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.State_k__BackingField=(string)value;} 
#line 29
                                      }

#line 30

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string ZipCode_k__BackingField;
#line 32


      [Intercepted]
      public string ZipCode 
#line 32
                            { 
#line 32
                              get                                 
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.ZipCode_k__BackingField;} 
#line 32

#line 32
                                   set                                      
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_ZipCode;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.ZipCode_k__BackingField=(string)value;} 
#line 32
                                        }

#line 33

      public Dictionary<string, string> GetQueryValues()
      {
         return new Dictionary<string, string>()
            {
               { "first_name", Utilities.DataFormating.GetNullParameterStr(this.Name) },
               { "last_name", Utilities.DataFormating.GetNullParameterStr(this.LastName) },
               { "phone", Utilities.DataFormating.GetNullParameterStr(this.Phone) },
               { "email", Utilities.DataFormating.GetNullParameterStr(this.Email) },
               { "street", Utilities.DataFormating.GetNullParameterStr(this.Street) },
               { "city", Utilities.DataFormating.GetNullParameterStr(this.City) },
               { "state", Utilities.DataFormating.GetNullParameterStr(this.State) },
               { "zip_code", Utilities.DataFormating.GetNullParameterStr(this.ZipCode) },
            }
            ;
      }

   }

}
#pragma warning restore
