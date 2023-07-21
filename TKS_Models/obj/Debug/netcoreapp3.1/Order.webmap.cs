#pragma warning disable
#line 1 "Order.cs"
#pragma warning disable
#line 1 "Order.cs"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilize.WebMap.Common.Attributes;

namespace TKS_Models
{

   [Observable]
   public partial class Order
      : IQueryFormater
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int Id_k__BackingField;
#line 17


      [Intercepted]
      public int Id 
#line 17
                    { 
#line 17
                      get                         
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Id_k__BackingField;} 
#line 17

#line 17
                           set                              
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Id;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Id_k__BackingField=(int)value;} 
#line 17
                                }

#line 18

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int CustomerId_k__BackingField;
#line 20


      [Intercepted]
      public int CustomerId 
#line 20
                            { 
#line 20
                              get                                 
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.CustomerId_k__BackingField;} 
#line 20

#line 20
                                   set                                      
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_CustomerId;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.CustomerId_k__BackingField=(int)value;} 
#line 20
                                        }

#line 21

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private byte OrderStatus_k__BackingField;
#line 23


      [Intercepted]
      public byte OrderStatus 
#line 23
                              { 
#line 23
                                get                                   
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.OrderStatus_k__BackingField;} 
#line 23

#line 23
                                     set                                        
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_OrderStatus;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.OrderStatus_k__BackingField=(byte)value;} 
#line 23
                                          }

#line 24

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private System.DateTime OrderDate_k__BackingField;
#line 26


      [Intercepted]
      public DateTime OrderDate 
#line 26
                                { 
#line 26
                                  get                                     
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.OrderDate_k__BackingField;} 
#line 26

#line 26
                                       set                                          
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_OrderDate;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.OrderDate_k__BackingField=(System.DateTime)value;} 
#line 26
                                            }

#line 27

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private System.DateTime RequiredDate_k__BackingField;
#line 29


      [Intercepted]
      public DateTime RequiredDate 
#line 29
                                   { 
#line 29
                                     get                                        
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.RequiredDate_k__BackingField;} 
#line 29

#line 29
                                          set                                             
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_RequiredDate;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.RequiredDate_k__BackingField=(System.DateTime)value;} 
#line 29
                                               }

#line 30

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private System.DateTime ShippedDate_k__BackingField;
#line 32


      [Intercepted]
      public DateTime ShippedDate 
#line 32
                                  { 
#line 32
                                    get                                       
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.ShippedDate_k__BackingField;} 
#line 32

#line 32
                                         set                                            
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_ShippedDate;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.ShippedDate_k__BackingField=(System.DateTime)value;} 
#line 32
                                              }

#line 33

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int StoreId_k__BackingField;
#line 35


      [Intercepted]
      public int StoreId 
#line 35
                         { 
#line 35
                           get                              
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.StoreId_k__BackingField;} 
#line 35

#line 35
                                set                                   
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_StoreId;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.StoreId_k__BackingField=(int)value;} 
#line 35
                                     }

#line 36

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int StaffId_k__BackingField;
#line 38


      [Intercepted]
      public int StaffId 
#line 38
                         { 
#line 38
                           get                              
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.StaffId_k__BackingField;} 
#line 38

#line 38
                                set                                   
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_StaffId;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.StaffId_k__BackingField=(int)value;} 
#line 38
                                     }

#line 39

      public Dictionary<string, string> GetQueryValues()
      {
         return new Dictionary<string, string>()
            {
               { "customer_id", Utilities.DataFormating.GetNullParameter(this.CustomerId) },
               { "order_status", Utilities.DataFormating.GetNullParameter(this.OrderStatus) },
               { "order_date", Utilities.DataFormating.GetNullParameterDate(this.OrderDate) },
               { "required_date", Utilities.DataFormating.GetNullParameterDate(this.RequiredDate) },
               { "shipped_date", Utilities.DataFormating.GetNullParameterDate(this.ShippedDate) },
               { "staff_id", Utilities.DataFormating.GetNullParameter(this.StaffId) },
               { "store_id", Utilities.DataFormating.GetNullParameter(this.StoreId) },
            }
            ;
      }

   }

}
#pragma warning restore
