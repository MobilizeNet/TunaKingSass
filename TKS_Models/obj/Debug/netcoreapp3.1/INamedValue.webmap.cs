#pragma warning disable
#line 1 "INamedValue.cs"
#pragma warning disable
#line 1 "INamedValue.cs"
using Mobilize.WebMap.Common.Attributes;

namespace TKS_Models
{

   [Observable]
   public partial class NamedValue
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string Id_k__BackingField;
#line 11


      [Intercepted]
      public string Id 
#line 11
                       { 
#line 11
                         get                            
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Id_k__BackingField;} 
#line 11

#line 11
                              set                                 
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Id;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Id_k__BackingField=(string)value;} 
#line 11
                                   }

#line 12

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string Name_k__BackingField;
#line 14


      [Intercepted]
      public string Name 
#line 14
                         { 
#line 14
                           get                              
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Name_k__BackingField;} 
#line 14

#line 14
                                set                                   
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Name;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Name_k__BackingField=(string)value;} 
#line 14
                                     }

#line 15

   }

}
#pragma warning restore
