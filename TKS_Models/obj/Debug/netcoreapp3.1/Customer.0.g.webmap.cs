#pragma warning disable
#line 1 "Customer.cs"
#line hidden
using System;
using System.Collections.Generic;
using Mobilize.WebMap.Common.Attributes;

namespace TKS_Models
{
    public partial class Customer
    {
#line hidden
        protected override System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            foreach (var item in base._Mobilize_GetChanges())
            {
                yield return item;
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Id) > 0)
            {
                yield return "Id";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_LastName) > 0)
            {
                yield return "LastName";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Phone) > 0)
            {
                yield return "Phone";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Street) > 0)
            {
                yield return "Street";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_City) > 0)
            {
                yield return "City";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_State) > 0)
            {
                yield return "State";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_ZipCode) > 0)
            {
                yield return "ZipCode";
            }

            yield break;
        }

        protected override bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "Id":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Id) > 0;
                case "LastName":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_LastName) > 0;
                case "Phone":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Phone) > 0;
                case "Street":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Street) > 0;
                case "City":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_City) > 0;
                case "State":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_State) > 0;
                case "ZipCode":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_ZipCode) > 0;
            }

            return base._Mobilize_HasChanges(propertyName);
        }

        protected override Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            base._Mobilize_GetReferenceMap(refs);
            return refs;
        }

        protected override void _Mobilize_CleanChanges()
        {
            if (!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew || ((Mobilize.WebMap.Common.Core.IObservable)this).RefCount > 0)
            {
                this._Mobilize_DirtyFlag_0 = 0;
                this._Mobilize_ControlFlag = 0;
            }

            base._Mobilize_CleanChanges();
        }

        protected override System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> _Mobilize_GetReferences()
        {
            foreach (var baseRef in base._Mobilize_GetReferences())
            {
                yield return baseRef;
            }

            yield break;
        }

        private uint _Mobilize_DirtyFlag_0;
        const uint _Mobilize_Dirty_Id = (uint)1 << 0;
        const uint _Mobilize_Dirty_LastName = (uint)1 << 1;
        const uint _Mobilize_Dirty_Phone = (uint)1 << 2;
        const uint _Mobilize_Dirty_Street = (uint)1 << 3;
        const uint _Mobilize_Dirty_City = (uint)1 << 4;
        const uint _Mobilize_Dirty_State = (uint)1 << 5;
        const uint _Mobilize_Dirty_ZipCode = (uint)1 << 6;
#line 11
    }
}