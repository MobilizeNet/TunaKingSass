using System;
using TKS.ElectronicBillForms;
using Mobilize.WebMap.Common.Attributes;

namespace TKS
{

   [Observable]
   public partial class UOCollapsableControl
      : Mobilize.Web.UserControl
   {

      /// <summary>
      /// Initializes a new instance of the <see cref="UOCollapsableControl"/> class.
      /// </summary>
      public UOCollapsableControl()
      {
         InitializeComponent();
      }

      [Intercepted]
      /// <summary>
      /// Gets or sets a value indicating whether this instance is collapsed.
      /// </summary>
      /// <value>
      ///   <c>true</c> if this instance is collapsed; otherwise, <c>false</c>.
      /// </value>
      internal bool IsCollapsed { get; set; } = false;

      /// <summary>
      /// Sets the panel visibility.
      /// </summary>
      public void SetPanelVisibility()
      {
         this.pnlCollapsable.Visible = this.IsCollapsed;
         this.btnCollapseExpand.Text = this.IsCollapsed ? "▲" : "▼";
      }

      private void BtnCollapseExpand_Click(object sender, EventArgs e)
      {
         this.SetPanelVisibility();
         this.IsCollapsed = !this.IsCollapsed;
      }

      private void btnCreateUser_Click(object sender, EventArgs e)
      {
         UiCommons.OpenWindow<frmCustomer>(true);
      }

      private void btnCreateProduct_Click(object sender, EventArgs e)
      {
         UiCommons.OpenWindow<frmProduct>();
      }

      private void btnCreateUser_Click_1(object sender, EventArgs e)
      {
         UiCommons.OpenWindow<frmUser>();
      }

      private void btnList_Click(object sender, EventArgs e)
      {
         UiCommons.OpenWindow<frmList>();
      }

      private void btnCreateOrder_Click(object sender, EventArgs e)
      {
         UiCommons.OpenWindow<frmOrders>();
      }

      private void btnCreatInvoice_Click(object sender, EventArgs e)
      {
         UiCommons.OpenWindow<frmRoles>();
      }

      private void buttonMaintenance_Click(object sender, EventArgs e)
      {
         UiCommons.OpenWindow<FrmBillManagment>();
      }

   }

}