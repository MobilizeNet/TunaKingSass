using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TKS
{

   partial class frmCustomer
   {

      /// <summary>
      /// Required designer variable.
      /// </summary>
      [Intercepted]
      private Mobilize.Web.Controls.Interfaces.IContainer components { get; set; } = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if ( disposing && (components != null) )
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      [Mobilize.WebMap.Common.Attributes.Designer]
#region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.btnCancel = new Mobilize.Web.Button();
         this.btnSave = new Mobilize.Web.Button();
         this.lblFirstName = new Mobilize.Web.Label();
         this.lblLastName = new Mobilize.Web.Label();
         this.lblPhone = new Mobilize.Web.Label();
         this.lblEmail = new Mobilize.Web.Label();
         this.lblStreet = new Mobilize.Web.Label();
         this.lblCity = new Mobilize.Web.Label();
         this.lblState = new Mobilize.Web.Label();
         this.lblZip = new Mobilize.Web.Label();
         this.mskPhone = new Mobilize.Web.MaskedTextBox();
         this.txtFirstName = new Mobilize.Web.TextBox();
         this.txtLastName = new Mobilize.Web.TextBox();
         this.txtEmail = new Mobilize.Web.TextBox();
         this.txtStreet = new Mobilize.Web.TextBox();
         this.txtCity = new Mobilize.Web.TextBox();
         this.txtZip = new Mobilize.Web.TextBox();
         this.cboState = new Mobilize.Web.ComboBox();
         this.SuspendLayout();
         // 
         // btnCancel
         // 
         this.btnCancel.CausesValidation = false;
         this.btnCancel.Location = new System.Drawing.Point(240, 465);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 0;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(80, 465);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(75, 23);
         this.btnSave.TabIndex = 1;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // lblFirstName
         // 
         this.lblFirstName.AutoSize = true;
         this.lblFirstName.Location = new System.Drawing.Point(24, 38);
         this.lblFirstName.Name = "lblFirstName";
         this.lblFirstName.Size = new System.Drawing.Size(60, 13);
         this.lblFirstName.TabIndex = 2;
         this.lblFirstName.Text = "First Name:";
         // 
         // lblLastName
         // 
         this.lblLastName.AutoSize = true;
         this.lblLastName.Location = new System.Drawing.Point(24, 84);
         this.lblLastName.Name = "lblLastName";
         this.lblLastName.Size = new System.Drawing.Size(61, 13);
         this.lblLastName.TabIndex = 3;
         this.lblLastName.Text = "Last Name:";
         // 
         // lblPhone
         // 
         this.lblPhone.AutoSize = true;
         this.lblPhone.Location = new System.Drawing.Point(24, 131);
         this.lblPhone.Name = "lblPhone";
         this.lblPhone.Size = new System.Drawing.Size(41, 13);
         this.lblPhone.TabIndex = 4;
         this.lblPhone.Text = "Phone:";
         // 
         // lblEmail
         // 
         this.lblEmail.AutoSize = true;
         this.lblEmail.Location = new System.Drawing.Point(24, 176);
         this.lblEmail.Name = "lblEmail";
         this.lblEmail.Size = new System.Drawing.Size(35, 13);
         this.lblEmail.TabIndex = 5;
         this.lblEmail.Text = "Email:";
         // 
         // lblStreet
         // 
         this.lblStreet.AutoSize = true;
         this.lblStreet.Location = new System.Drawing.Point(24, 224);
         this.lblStreet.Name = "lblStreet";
         this.lblStreet.Size = new System.Drawing.Size(38, 13);
         this.lblStreet.TabIndex = 6;
         this.lblStreet.Text = "Street:";
         // 
         // lblCity
         // 
         this.lblCity.AutoSize = true;
         this.lblCity.Location = new System.Drawing.Point(24, 303);
         this.lblCity.Name = "lblCity";
         this.lblCity.Size = new System.Drawing.Size(27, 13);
         this.lblCity.TabIndex = 7;
         this.lblCity.Text = "City:";
         // 
         // lblState
         // 
         this.lblState.AutoSize = true;
         this.lblState.Location = new System.Drawing.Point(24, 356);
         this.lblState.Name = "lblState";
         this.lblState.Size = new System.Drawing.Size(35, 13);
         this.lblState.TabIndex = 8;
         this.lblState.Text = "State:";
         // 
         // lblZip
         // 
         this.lblZip.AutoSize = true;
         this.lblZip.Location = new System.Drawing.Point(24, 413);
         this.lblZip.Name = "lblZip";
         this.lblZip.Size = new System.Drawing.Size(53, 13);
         this.lblZip.TabIndex = 9;
         this.lblZip.Text = "Zip Code:";
         // 
         // mskPhone
         // 
         this.mskPhone.Location = new System.Drawing.Point(118, 132);
         this.mskPhone.Mask = "(###)###-####";
         this.mskPhone.Name = "mskPhone";
         this.mskPhone.Size = new System.Drawing.Size(235, 20);
         this.mskPhone.TabIndex = 10;
         this.mskPhone.TextMaskFormat = Mobilize.Web.MaskFormat.ExcludePromptAndLiterals;
         // 
         // txtFirstName
         // 
         this.txtFirstName.Location = new System.Drawing.Point(118, 38);
         this.txtFirstName.Name = "txtFirstName";
         this.txtFirstName.Size = new System.Drawing.Size(235, 20);
         this.txtFirstName.TabIndex = 11;
         this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
         this.txtFirstName.Validated += new System.EventHandler(this.txtFirstName_Validated);
         // 
         // txtLastName
         // 
         this.txtLastName.Location = new System.Drawing.Point(118, 84);
         this.txtLastName.Name = "txtLastName";
         this.txtLastName.Size = new System.Drawing.Size(235, 20);
         this.txtLastName.TabIndex = 12;
         this.txtLastName.Leave += new System.EventHandler(this.txtFirstName_Validated);
         this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
         // 
         // txtEmail
         // 
         this.txtEmail.Location = new System.Drawing.Point(118, 177);
         this.txtEmail.Name = "txtEmail";
         this.txtEmail.Size = new System.Drawing.Size(235, 20);
         this.txtEmail.TabIndex = 13;
         this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
         this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
         // 
         // txtStreet
         // 
         this.txtStreet.Location = new System.Drawing.Point(118, 225);
         this.txtStreet.Multiline = true;
         this.txtStreet.Name = "txtStreet";
         this.txtStreet.Size = new System.Drawing.Size(235, 53);
         this.txtStreet.TabIndex = 14;
         // 
         // txtCity
         // 
         this.txtCity.Location = new System.Drawing.Point(118, 304);
         this.txtCity.Name = "txtCity";
         this.txtCity.Size = new System.Drawing.Size(235, 20);
         this.txtCity.TabIndex = 15;
         this.txtCity.KeyPress += new Mobilize.Web.KeyPressEventHandler(this.txtCity_KeyPress);
         // 
         // txtZip
         // 
         this.txtZip.Location = new System.Drawing.Point(118, 413);
         this.txtZip.MaxLength = 5;
         this.txtZip.Name = "txtZip";
         this.txtZip.Size = new System.Drawing.Size(235, 20);
         this.txtZip.TabIndex = 17;
         this.txtZip.KeyPress += new Mobilize.Web.KeyPressEventHandler(this.txtZip_KeyPress);
         // 
         // cboState
         // 
         this.cboState.DropDownStyle = Mobilize.Web.ComboBoxStyle.DropDownList;
         this.cboState.Properties().FormattingEnabled = true;
         this.cboState.Location = new System.Drawing.Point(118, 357);
         this.cboState.Name = "cboState";
         this.cboState.Size = new System.Drawing.Size(235, 21);
         this.cboState.TabIndex = 18;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(388, 498);
         this.Controls.Add(this.cboState);
         this.Controls.Add(this.txtZip);
         this.Controls.Add(this.txtCity);
         this.Controls.Add(this.txtStreet);
         this.Controls.Add(this.txtEmail);
         this.Controls.Add(this.txtLastName);
         this.Controls.Add(this.txtFirstName);
         this.Controls.Add(this.mskPhone);
         this.Controls.Add(this.lblZip);
         this.Controls.Add(this.lblState);
         this.Controls.Add(this.lblCity);
         this.Controls.Add(this.lblStreet);
         this.Controls.Add(this.lblEmail);
         this.Controls.Add(this.lblPhone);
         this.Controls.Add(this.lblLastName);
         this.Controls.Add(this.lblFirstName);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.btnCancel);
         this.Name = "frmCustomer";
         this.Text = "TKS - Customer";
         this.Load += new System.EventHandler(this.frmCustomer_Load);
         this.ResumeLayout(false);
         this.PerformLayout();
      }
#endregion

      [Intercepted]
      private Mobilize.Web.Button btnCancel { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnSave { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblFirstName { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblLastName { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblPhone { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblEmail { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblStreet { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblCity { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblState { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblZip { get; set; }

      [Intercepted]
      private Mobilize.Web.MaskedTextBox mskPhone { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox txtFirstName { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox txtLastName { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox txtEmail { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox txtStreet { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox txtCity { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox txtZip { get; set; }

      [Intercepted]
      private Mobilize.Web.ComboBox cboState { get; set; }

   }

}