#pragma warning disable
#line 1 "Product.cs"
#pragma warning disable
#line 1 "Product.cs"
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilize.WebMap.Common.Attributes;

namespace TKS_Models
{

   [Observable]
   public partial class Product
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
private string Name_k__BackingField;
#line 20


      [Intercepted]
      public string Name 
#line 20
                         { 
#line 20
                           get                              
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Name_k__BackingField;} 
#line 20

#line 20
                                set                                   
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Name;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Name_k__BackingField=(string)value;} 
#line 20
                                     }

#line 21

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int Brand_k__BackingField;
#line 23


      [Intercepted]
      public int Brand 
#line 23
                       { 
#line 23
                         get                            
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Brand_k__BackingField;} 
#line 23

#line 23
                              set                                 
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Brand;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Brand_k__BackingField=(int)value;} 
#line 23
                                   }

#line 24

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private int Category_k__BackingField;
#line 26


      [Intercepted]
      public int Category 
#line 26
                          { 
#line 26
                            get                               
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Category_k__BackingField;} 
#line 26

#line 26
                                 set                                    
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Category;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Category_k__BackingField=(int)value;} 
#line 26
                                      }

#line 27

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private short ModelYear_k__BackingField;
#line 29


      [Intercepted]
      public short ModelYear 
#line 29
                             { 
#line 29
                               get                                  
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.ModelYear_k__BackingField;} 
#line 29

#line 29
                                    set                                       
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_ModelYear;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.ModelYear_k__BackingField=(short)value;} 
#line 29
                                         }

#line 30

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private decimal Price_k__BackingField;
#line 32


      [Intercepted]
      public decimal Price 
#line 32
                           { 
#line 32
                             get                                
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Price_k__BackingField;} 
#line 32

#line 32
                                  set                                     
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Price;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Price_k__BackingField=(decimal)value;} 
#line 32
                                       }

#line 33

      public Dictionary<string, string> GetQueryValues()
      {
         return new Dictionary<string, string>()
            {
               { "product_name", Utilities.DataFormating.GetNullParameterStr(this.Name) },
               { "brand_id", Utilities.DataFormating.GetNullParameter(this.Brand) },
               { "category_id", Utilities.DataFormating.GetNullParameter(this.Category) },
               { "model_year", Utilities.DataFormating.GetNullParameter(this.ModelYear) },
               { "list_price", Utilities.DataFormating.GetNullParameter(this.Price) },
            }
            ;
      }

   }

}
#pragma warning restore
