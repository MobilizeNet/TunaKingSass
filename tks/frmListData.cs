using System;
using System.Collections.Generic;
using System.Data;
using Mobilize.WebMap.Common.Attributes;

namespace TKS
{

   [Observable]
   public partial class frmListData
      : Mobilize.Web.Form
   {

      [Intercepted]
      public int SelectedIndex { get; set; }


      public frmListData()
      {
         InitializeComponent();
      }

      public void LoadData(string valueMember, string displayMember, DataTable values)
      {
         this.lbxData.DataSource = null;
         if ( this.lbxData.Items.Count > 0 )
         {
            this.lbxData.Items.Clear();
         }
         this.lbxData.ValueMember = valueMember;
         this.lbxData.DisplayMember = displayMember;
         lbxData.DataSource = values;
      }

      private void btnClose_Click(object sender, EventArgs e)
      {
         this.DialogResult = Mobilize.Web.DialogResult.Cancel;
         this.Close();
      }

      private void btnSelect_Click(object sender, EventArgs e)
      {
         this.SelectedIndex = this.lbxData.SelectedIndex;
         this.DialogResult = Mobilize.Web.DialogResult.OK;
         this.Hide();
      }

   }

}