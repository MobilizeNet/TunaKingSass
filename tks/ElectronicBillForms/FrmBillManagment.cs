using System;
using System.Linq;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TKS.ElectronicBillForms
{

   [Observable]
   public partial class FrmBillManagment
      : Mobilize.Web.Form
   {

      [Intercepted]
      int top { get; set; } = -1;

      [Intercepted]
      int count { get; set; }

      [Intercepted]
      public CustomersOrders customOrders { get; set; } = new CustomersOrders();

      [Intercepted]
      Mobilize.Web.Form[] frm { get; set; }


      public FrmBillManagment()
      {
         InitializeComponent();
         Mobilize.Web.Form[] frmNew = { customOrders };
         frm = frmNew;
         count = frm.Count();
      }

      private void LoadNewForm()
      {
         frm[top].Properties().TopLevel = false;
         frm[top].AutoScroll = true;
         frm[top].Dock = Mobilize.Web.DockStyle.Fill;
         this.pnlContent.Controls.Clear();
         this.pnlContent.Controls.Add(frm[top]);
         frm[top].Show();
      }

      private void Next()
      {
         top++;
         if ( top >= count )
         {
            return ;
         }
         else
         {
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            LoadNewForm();
            if ( top + 1 == count )
            {
               btnNext.Enabled = false;
            }
         }
         if ( top <= 0 )
         {
            btnBack.Enabled = false;
         }
      }

      private void Back()
      {
         top--;
         if ( top <= -1 )
         {
            return ;
         }
         else
         {
            btnBack.Enabled = true;
            btnNext.Enabled = true;
            LoadNewForm();
            if ( top - 1 <= -1 )
            {
               btnBack.Enabled = false;
            }
         }
         if ( top >= count )
         {
            btnNext.Enabled = false;
         }
      }

      private void FrmBillManagment_Load(object sender, EventArgs e)
      {
         Next();
      }

      private void btnNext_Click(object sender, EventArgs e)
      {
         Next();
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         frm[top].Close();
         this.Close();
      }

      private void btnBack_Click_1(object sender, EventArgs e)
      {
         Back();
      }

   }

}