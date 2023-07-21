using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_DB;
using TKS_Models;
using Mobilize.WebMap.Common.Attributes;

namespace TKS
{

   public delegate void OnSaveEventHandler();

   [Observable]
   public partial class frmUser
      : Mobilize.Web.Form
   {

      public frmUser()
      {
         InitializeComponent();
         this.OnSave += this.Save;
         this.DataHandler = new DataHandler();
      }

      private void Save()
      {
         // Attached to declared event handler invoked the DB, should not be moved.
         if ( !string.IsNullOrWhiteSpace(this.txtId.Text) && this.chkId.Checked && this.chkPassword.Checked && this.chkEmail.Checked )
         {
            var user = new User()
            {
               Name = this.txtId.Text, Password = this.txtPassword.Text, Email = this.txtEmail.Text,
            };
            this.DataHandler.CreateNewRegisterInTable("roles.users", user);
            Mobilize.Web.MessageBox.Show("User saved successfully");
            this.Close();
         }
      }

      [Intercepted]
      private OnSaveEventHandler OnSave { get; set; }

      [Intercepted]
      public DataHandler DataHandler { get; set; }

      private void frmUser_Load(object sender, EventArgs e)
      {
         // Load event should not be moved.
         this.ucOkCancel.OkButtonText = "Save";
      }

      private void ucOkCancel2_OkClick(object sender, EventArgs e)
      {
         // Invoke declared event handler with DB call attached to the DB, should not be moved.
         this.Save();
      }

      private void txtId_TextChanged(object sender, EventArgs e)
      {
         // DB call in candidate event to be moved to the FE. Should not be moved.
         this.chkId.CheckState = ValidationCommon.IsValidUserName(((Mobilize.Web.Control)sender).Text) ? Mobilize.Web.CheckState.Checked : Mobilize.Web.CheckState.Unchecked;
      }

      private void txtPassword_TextChanged(object sender, EventArgs e)
      {
         // This should be moved to the FE.
         this.chkPassword.Checked = new ValidationCommon().IsValidPassword(((Mobilize.Web.Control)sender).Text);
      }

      private void txtEmail_TextChanged(object sender, EventArgs e)
      {
         // DB call in candidate event to be moved to the FE. Should not be moved.
         this.chkEmail.Checked = ValidationCommon.IsValidEmailDomian(((Mobilize.Web.Control)sender).Text);
      }

   }

}