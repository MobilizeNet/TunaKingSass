using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using TKS_DB;
using TKS_Models;
using Mobilize.WebMap.Common.Attributes;

namespace TKS
{

   [Observable]
   public partial class frmCustomer
      : Mobilize.Web.Form
   {

      [Intercepted]
      private DataHandler DataHandler { get; } = new DataHandler();


      /// <summary>
      /// Initializes a new instance of the <see cref="frmCustomer" /> class.
      /// </summary>
      /// <param name="isNew">if set to <c>true</c> [is new].</param>
      public frmCustomer(bool isNew)
      {
         InitializeComponent();
         this.IsNew = isNew;
      }

      [Intercepted]
      /// <summary>
      /// Gets or sets a value indicating whether this instance is new.
      /// </summary>
      /// <value>
      ///   <c>true</c> if this instance is new; otherwise, <c>false</c>.
      /// </value>
      internal bool IsNew { get; set; }

      [Intercepted]
      /// <summary>
      /// Gets or sets a value indicating whether this instance is read only.
      /// </summary>
      /// <value>
      ///   <c>true</c> if this instance is read only; otherwise, <c>false</c>.
      /// </value>
      internal bool IsReadOnly { get; set; }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         // This code should not be moving to FE.
         var result = Mobilize.Web.MessageBox.Show("Are you sure you want to cancel?", "Please confirm", Mobilize.Web.MessageBoxButtons.YesNo);
         if ( result == Mobilize.Web.DialogResult.Yes )
         {
            this.Close();
         }
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         // This code should not be moving to FE.
         if ( !this.VerifyControls() )
         {
            Mobilize.Web.MessageBox.Show("Please verify the fields.");
            return ;
         }
         if ( this.IsNew )
         {
            this.DataHandler.CreateNewRegisterInTable("sales.customers", new Customer()
               {
                  Name = this.txtFirstName.Text, LastName = this.txtLastName.Text, Phone = UiCommons.EmptyToNull(this.mskPhone.Text), Email = this.txtEmail.Text, Street = UiCommons.EmptyToNull(this.txtStreet.Text), City = UiCommons.EmptyToNull(this.txtCity.Text), State = UiCommons.EmptyToNull(UiCommons.GetComboValueFromText<string>(this.cboState)), ZipCode = UiCommons.EmptyToNull(this.txtZip.Text),
               });
            this.Close();
         }
      }

      private bool VerifyControls()
      {
         return this.VerifyBackColor(this.txtFirstName) && this.VerifyText(this.txtFirstName) && this.VerifyBackColor(this.txtLastName) && this.VerifyText(this.txtLastName) && this.VerifyBackColor(this.txtEmail) && this.VerifyText(this.txtEmail) && this.VerifyText(this.mskPhone) && this.VerifyText(this.txtStreet) && this.VerifyText(txtZip) && this.VerifyText(this.txtCity) && this.cboState.SelectedIndex != -1;
      }

      private bool VerifyBackColor(Mobilize.Web.Control control)
      {
         return control.BackColor != Color.Red;
      }

      private bool VerifyText(Mobilize.Web.Control control)
      {
         return control.Text != string.Empty;
      }

      private void frmCustomer_Load(object sender, EventArgs e)
      {
         // This code should not be moving to FE.
         this.LoadStates();
      }

      private void LoadStates()
      {
         // This code should be moving to FE.
         var states = this.DataHandler.GetDataSource("state_id", "state_name", "sales.states");
         UiCommons.LoadComboSource("state_id", "state_name", this.cboState, states);
      }

      private void txtEmail_Leave(object sender, EventArgs e)
      {
         var control = sender as Mobilize.Web.Control;
         if ( control.BackColor == Color.Red )
         {
            control.BackColor = Color.White;
         }
      }

      private void txtEmail_Validating(object sender, CancelEventArgs e)
      {
         // This code should be moving to FE.
         var control = sender as Mobilize.Web.Control;
         if ( !Regex.IsMatch(control.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase) )
         {
            e.Cancel = true;
            control.BackColor = Color.Red;
         }
      }

      private void txtFirstName_Validated(object sender, EventArgs e)
      {
         // This code should be moving to FE.
         var control = sender as Mobilize.Web.Control;
         if ( control.BackColor == Color.Red )
         {
            control.BackColor = Color.White;
         }
         switch ( control.Name )
         {
            case "txtFirstName":
               this.lblFirstName.ForeColor = Color.Black;
               break;
            case "txtLastName":
               lblLastName.ForeColor = Color.Black;
               break;
         }
      }

      private void txtFirstName_Validating(object sender, CancelEventArgs e)
      {
         // This code should be moving to FE.
         var control = sender as Mobilize.Web.Control;
         if ( ValidationCommon.IsValidNameCase(control) )
         {
            e.Cancel = true;
            control.BackColor = Color.Red;
         }
         switch ( control.Name )
         {
            case "txtFirstName":
               this.lblFirstName.ForeColor = Color.Red;
               break;
            case "txtLastName":
               lblLastName.ForeColor = Color.Red;
               break;
         }
      }

      private void txtLastName_Leave(object sender, EventArgs e)
      {
         var control = sender as Mobilize.Web.Control;
         if ( control.BackColor == Color.Red )
         {
            control.BackColor = Color.White;
         }
      }

      private void txtCity_KeyPress(object sender, Mobilize.Web.KeyPressEventArgs e)
      {
         e.KeyChar = char.ToUpper(e.KeyChar);
      }

      private void txtZip_KeyPress(object sender, Mobilize.Web.KeyPressEventArgs e)
      {
         var match = Regex.Match(e.KeyChar.ToString(), @"^[0-9-]*$");
         if ( !match.Success )
         {
            e.Handled = true;
         }
      }

   }

}