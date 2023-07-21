#pragma warning disable
#line 1 "Bill.cs"
#pragma warning disable
#line 1 "Bill.cs"
using System.Collections.Generic;
using Mobilize.WebMap.Common.Attributes;

namespace TKS_Models
{

   [Observable]
   public partial class Bill
   {

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string Office_k__BackingField;
#line 12


      [Intercepted]
      public string Office 
#line 12
                           { 
#line 12
                             get                                
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.Office_k__BackingField;} 
#line 12

#line 12
                                  set                                     
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_Office;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.Office_k__BackingField=(string)value;} 
#line 12
                                       }

#line 13

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private System.Collections.Generic.Dictionary<string, string> DocumentType_k__BackingField;
#line 15


      [Intercepted]
      public Dictionary<string, string> DocumentType 
#line 15
                                                     { 
#line 15
                                                       get                                                          
#line hidden
{if((_Mobilize_LoadedFlag_0&_Mobilize_Loaded_DocumentType)<=0){this.DocumentType_k__BackingField=Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.GetNonObservable<System.Collections.Generic.Dictionary<string, string>>(this,_Mobilize_References,0);_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_DocumentType;}return this.DocumentType_k__BackingField;} 
#line 15

#line 15
                                                            set                                                               
#line hidden
{if(Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.SetNonObservable<Dictionary<string, string> >(this,_Mobilize_References,0,this.DocumentType_k__BackingField,(System.Collections.Generic.Dictionary<string, string>)value)){_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_DocumentType;}_Mobilize_LoadedFlag_0|=_Mobilize_Loaded_DocumentType;_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.DocumentType_k__BackingField=(System.Collections.Generic.Dictionary<string, string>)value;} 
#line 15
                                                                 }

#line 16

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string EconomicActivity_k__BackingField;
#line 18


      [Intercepted]
      public string EconomicActivity 
#line 18
                                     { 
#line 18
                                       get                                          
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.EconomicActivity_k__BackingField;} 
#line 18

#line 18
                                            set                                               
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_EconomicActivity;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.EconomicActivity_k__BackingField=(string)value;} 
#line 18
                                                 }

#line 19

#line hidden

[System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)]
private string SerialNumber_k__BackingField;
#line 21


      [Intercepted]
      public string SerialNumber 
#line 21
                                 { 
#line 21
                                   get                                      
#line hidden
{Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);return this.SerialNumber_k__BackingField;} 
#line 21

#line 21
                                        set                                           
#line hidden
{_Mobilize_DirtyFlag_0|=_Mobilize_Dirty_SerialNumber;Mobilize.WebMap.Common.Core.Context.CoreContext.Services.Instrumentation.Track(this);_Mobilize_ControlFlag|=_Mobilize_HasChanged_Flag;this.SerialNumber_k__BackingField=(string)value;} 
#line 21
                                             }

#line 22

   }

}
#pragma warning restore
