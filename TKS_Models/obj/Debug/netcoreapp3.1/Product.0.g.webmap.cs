#pragma warning disable
#line 1 "Product.cs"
#line hidden
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilize.WebMap.Common.Attributes;

namespace TKS_Models
{
    public partial class Product : Mobilize.WebMap.Common.Core.IObservable, Mobilize.WebMap.Common.Core.IDelta
    {
#line hidden
        [System.NonSerialized]
        private Mobilize.WebMap.Common.Core.Identifier  _mobilizeId = Mobilize.WebMap.Common.Core.Context.CoreContext.Services.IdentifierService.GetIdentifier();
        Mobilize.WebMap.Common.Core.Identifier Mobilize.WebMap.Common.Core.IObservable.MobilizeId
        {
            get =>  _mobilizeId;
            set =>  _mobilizeId = value;
        }

        Mobilize.WebMap.Common.Core.ReferenceMap Mobilize.WebMap.Common.Core.IObservable.References
        {
            get => this._Mobilize_GetReferenceMap(new Mobilize.WebMap.Common.Core.ReferenceMap());
            set => throw new System.NotImplementedException();
        }

        protected uint _Mobilize_ControlFlag = 1;
        bool Mobilize.WebMap.Common.Core.ITrackable.IsNew
        {
            get => (this._Mobilize_ControlFlag & _Mobilize_IsNew_Flag) > 0;
            set => _Mobilize_ControlFlag = value ? this._Mobilize_ControlFlag = 1 << 0 : this._Mobilize_ControlFlag & 0 << 0;
        }

        Mobilize.WebMap.Common.Core.IDelta Mobilize.WebMap.Common.Core.ITrackable.Delta => this;
        void Mobilize.WebMap.Common.Core.ITrackable.CleanChanges() => _Mobilize_CleanChanges();
        protected virtual void _Mobilize_CleanChanges()
        {
            if (!((Mobilize.WebMap.Common.Core.ITrackable)this).IsNew || ((Mobilize.WebMap.Common.Core.IObservable)this).RefCount > 0)
            {
                this._Mobilize_DirtyFlag_0 = 0;
                this._Mobilize_ControlFlag = 0;
            }
        }

        protected virtual Mobilize.WebMap.Common.Core.ReferenceMap _Mobilize_GetReferenceMap(Mobilize.WebMap.Common.Core.ReferenceMap refs)
        {
            return refs;
        }

        private int _Mobilize_RefCount = 0;
        int Mobilize.WebMap.Common.Core.IObservable.DecrementRefCount()
        {
            return System.Threading.Interlocked.Decrement(ref _Mobilize_RefCount);
        }

        int Mobilize.WebMap.Common.Core.IObservable.IncrementRefCount()
        {
            return System.Threading.Interlocked.Increment(ref _Mobilize_RefCount);
        }

        int Mobilize.WebMap.Common.Core.IObservable.RefCount
        {
            get
            {
                return _Mobilize_RefCount;
            }
        }

        System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> Mobilize.WebMap.Common.Core.IObservable.GetReferences()
        {
            return this._Mobilize_GetReferences();
        }

        protected virtual System.Collections.Generic.IEnumerable<Mobilize.WebMap.Common.Core.IObservable> _Mobilize_GetReferences()
        {
            yield break;
        }

        const uint _Mobilize_IsNew_Flag = (uint)1 << 0;
        protected const uint _Mobilize_HasChanged_Flag = (uint)1 << 1;
        bool Mobilize.WebMap.Common.Core.ITrackable.HasChanged
        {
            get => (this._Mobilize_ControlFlag & _Mobilize_HasChanged_Flag) > 0;
        }

        const uint _Mobilize_IsRefresh_Flag = (uint)1 << 2;
        bool Mobilize.WebMap.Common.Core.ITrackable.IsRefresh
        {
            get => (this._Mobilize_ControlFlag & _Mobilize_IsRefresh_Flag) > 0;
            set => _Mobilize_ControlFlag = value ? this._Mobilize_ControlFlag = 1 << 2 : this._Mobilize_ControlFlag & 0 << 2;
        }

        const uint _Mobilize_IsMarked_Flag = (uint)1 << 3;
        bool Mobilize.WebMap.Common.Core.ITrackable.IsMarked
        {
            get => (this._Mobilize_ControlFlag & _Mobilize_IsMarked_Flag) > 0;
            set => _Mobilize_ControlFlag = value ? this._Mobilize_ControlFlag = 1 << 3 : this._Mobilize_ControlFlag & 0 << 3;
        }

        bool Mobilize.WebMap.Common.Core.IDelta.IsNew
        {
            get => (this._Mobilize_ControlFlag & _Mobilize_IsNew_Flag) > 0;
            set => _Mobilize_ControlFlag = value ? this._Mobilize_ControlFlag = 1 << 0 : this._Mobilize_ControlFlag & 0 << 0;
        }

        Mobilize.WebMap.Common.Core.IObservable Mobilize.WebMap.Common.Core.IDelta.Target
        {
            get => this;
            set => throw new System.NotImplementedException();
        }

        System.Collections.Generic.IEnumerable<string> Mobilize.WebMap.Common.Core.IDelta.Changes => this._Mobilize_GetChanges();
        bool Mobilize.WebMap.Common.Core.IDelta.HasChanges(string propertyName) => this._Mobilize_HasChanges(propertyName);
        protected virtual System.Collections.Generic.IEnumerable<string> _Mobilize_GetChanges()
        {
            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Id) > 0)
            {
                yield return "Id";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Name) > 0)
            {
                yield return "Name";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Brand) > 0)
            {
                yield return "Brand";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Category) > 0)
            {
                yield return "Category";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_ModelYear) > 0)
            {
                yield return "ModelYear";
            }

            if ((_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Price) > 0)
            {
                yield return "Price";
            }

            yield break;
        }

        protected virtual bool _Mobilize_HasChanges(string propertyName)
        {
            switch (propertyName)
            {
                case "Id":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Id) > 0;
                case "Name":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Name) > 0;
                case "Brand":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Brand) > 0;
                case "Category":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Category) > 0;
                case "ModelYear":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_ModelYear) > 0;
                case "Price":
                    return (_Mobilize_DirtyFlag_0 & _Mobilize_Dirty_Price) > 0;
            }

            return false;
        }

        private uint _Mobilize_DirtyFlag_0;
        const uint _Mobilize_Dirty_Id = (uint)1 << 0;
        const uint _Mobilize_Dirty_Name = (uint)1 << 1;
        const uint _Mobilize_Dirty_Brand = (uint)1 << 2;
        const uint _Mobilize_Dirty_Category = (uint)1 << 3;
        const uint _Mobilize_Dirty_ModelYear = (uint)1 << 4;
        const uint _Mobilize_Dirty_Price = (uint)1 << 5;
#line 14
    }
}