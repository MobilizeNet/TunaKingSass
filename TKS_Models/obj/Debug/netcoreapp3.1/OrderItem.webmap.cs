#pragma warning disable
#line 1 "OrderItem.cs"
#pragma warning disable
#line 1 "OrderItem.cs"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilize.WebMap.Common.Attributes;

namespace TKS_Models
{

   [Observable]
   public partial class OrderItem
      : IQueryFormater
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int OrderId_k__BackingField;
#line 17


      [Intercepted]
      public int OrderId 
#line 17
                         { 
#line 17
                           get                              
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.OrderId_k__BackingField;} 
#line 17

#line 17
                                set                                   
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_OrderId;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.OrderId_k__BackingField=(int)value;} 
#line 17
                                     }

#line 18

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int Id_k__BackingField;
#line 20


      [Intercepted]
      public int Id 
#line 20
                    { 
#line 20
                      get                         
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Id_k__BackingField;} 
#line 20

#line 20
                           set                              
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Id;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Id_k__BackingField=(int)value;} 
#line 20
                                }

#line 21

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int ProductId_k__BackingField;
#line 23


      [Intercepted]
      public int ProductId 
#line 23
                           { 
#line 23
                             get                                
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.ProductId_k__BackingField;} 
#line 23

#line 23
                                  set                                     
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_ProductId;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.ProductId_k__BackingField=(int)value;} 
#line 23
                                       }

#line 24

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int Quantity_k__BackingField;
#line 26


      [Intercepted]
      public int Quantity 
#line 26
                          { 
#line 26
                            get                               
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Quantity_k__BackingField;} 
#line 26

#line 26
                                 set                                    
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Quantity;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Quantity_k__BackingField=(int)value;} 
#line 26
                                      }

#line 27

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private decimal ListPrice_k__BackingField;
#line 29


      [Intercepted]
      public decimal ListPrice 
#line 29
                               { 
#line 29
                                 get                                    
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.ListPrice_k__BackingField;} 
#line 29

#line 29
                                      set                                         
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_ListPrice;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.ListPrice_k__BackingField=(decimal)value;} 
#line 29
                                           }

#line 30

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private decimal Discount_k__BackingField;
#line 32


      [Intercepted]
      public decimal Discount 
#line 32
                              { 
#line 32
                                get                                   
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Discount_k__BackingField;} 
#line 32

#line 32
                                     set                                        
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Discount;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Discount_k__BackingField=(decimal)value;} 
#line 32
                                          }

#line 33

      public Dictionary<string, string> GetQueryValues()
      {
         return new Dictionary<string, string>()
            {
               { "item_id", Utilities.DataFormating.GetNullParameter(this.Id) },
               { "order_id", Utilities.DataFormating.GetNullParameter(this.OrderId) },
               { "product_id", Utilities.DataFormating.GetNullParameter(this.ProductId) },
               { "quantity", Utilities.DataFormating.GetNullParameter(this.Quantity) },
               { "list_price", Utilities.DataFormating.GetNullParameter(this.ListPrice) },
               { "discount", Utilities.DataFormating.GetNullParameter(this.Discount) },
            }
            ;
      }

   }

}
#pragma warning restore
