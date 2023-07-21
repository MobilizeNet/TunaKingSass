using System;
using System.Collections.Generic;
using System.Data;
using TKS_Models;
using Mobilize.WebMap.Common.Attributes;

namespace TKS
{

   [Observable]
   public class UiCommons
   {

      public static T OpenWindow<T>(params object[] values)
         where T : Mobilize.Web.Form
      {
         var frm = Activator.CreateInstance(typeof(T), values) as T;
         frm.Show();
         return frm as T;
      }

      public static string EmptyToNull(string value)
      {
         return string.IsNullOrEmpty(value) ? null : value;
      }

      public static void LoadComboSource(string valueMember, string displayMember, Mobilize.Web.ComboBox cbo, DataTable values)
      {
         cbo.ValueMember = valueMember;
         cbo.DisplayMember = displayMember;
         cbo.DataSource = values;
      }

      public static void LoadListSource(string valueMember, string displayMember, Mobilize.Web.ListBox ltx, DataTable values)
      {
         ltx.ValueMember = valueMember;
         ltx.DisplayMember = displayMember;
         ltx.DataSource = values;
      }

      public static T GetComboValueFromText<T>(Mobilize.Web.ComboBox cmb)
      {
         var text = cmb.Text;
         foreach ( DataRowView item in cmb.Items )
         {
            if ( (string)(item[cmb.DisplayMember]) == text )
            {
               return (T)(item[cmb.ValueMember]);
            }
         }
         return default(T);
      }

   }

}