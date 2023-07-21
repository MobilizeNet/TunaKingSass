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
   public partial class ucOkCancel
      : Mobilize.Web.UserControl
   {

      [Intercepted]
      public string OkButtonText
      {
         get => this.btnOk.Text;
         set => this.btnOk.Text = value;
      }

      [Intercepted]
      public string CancelButtonText
      {
         get => this.btnCancel.Text;
         set => this.btnCancel.Text = value;
      }


      public ucOkCancel()
      {
         InitializeComponent();
      }
      public event EventHandler OkClick;
      public event EventHandler CancelClick;

      private void btnOk_Click(object sender, EventArgs e)
      {
         this.OkClick?.Invoke(sender, e);
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         this.ParentForm.Close();
      }

   }

}