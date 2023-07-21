using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilize.WebMap.Common.Attributes;

namespace TKS
{

   [Observable]
   public partial class frmMain
      : Mobilize.Web.Form
   {

      public frmMain()
      {
         InitializeComponent();
      }

      private void ViewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
      {
         var form = UiCommons.OpenWindow<frmList>();
         form.tpgOrders.SelectedIndex = 1;
      }

      private void createCustomerToolStripMenuItem_Click(object sender, EventArgs e)
      {
         UiCommons.OpenWindow<frmCustomer>(true);
      }

      private void assignRoleToolStripMenuItem_Click(object sender, EventArgs e)
      {
         UiCommons.OpenWindow<frmRoles>();
      }

      private void createOrderToolStripMenuItem_Click(object sender, EventArgs e)
      {
         UiCommons.OpenWindow<frmOrders>();
      }

   }

}