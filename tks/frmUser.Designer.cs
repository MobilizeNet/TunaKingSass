using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TKS
{

   partial class frmUser
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
         this.lblId = new Mobilize.Web.Label();
         this.lblPassword = new Mobilize.Web.Label();
         this.lblEmail = new Mobilize.Web.Label();
         this.txtId = new Mobilize.Web.TextBox();
         this.txtEmail = new Mobilize.Web.TextBox();
         this.txtPassword = new Mobilize.Web.TextBox();
         this.ucOkCancel = new TKS.ucOkCancel();
         this.chkId = new Mobilize.Web.CheckBox();
         this.chkPassword = new Mobilize.Web.CheckBox();
         this.chkEmail = new Mobilize.Web.CheckBox();
         this.SuspendLayout();
         // 
         // lblId
         // 
         this.lblId.AutoSize = true;
         this.lblId.Location = new System.Drawing.Point(25, 37);
         this.lblId.Name = "lblId";
         this.lblId.Size = new System.Drawing.Size(18, 13);
         this.lblId.TabIndex = 2;
         this.lblId.Text = "ID";
         // 
         // lblPassword
         // 
         this.lblPassword.AutoSize = true;
         this.lblPassword.Location = new System.Drawing.Point(25, 77);
         this.lblPassword.Name = "lblPassword";
         this.lblPassword.Size = new System.Drawing.Size(53, 13);
         this.lblPassword.TabIndex = 3;
         this.lblPassword.Text = "Password";
         // 
         // lblEmail
         // 
         this.lblEmail.AutoSize = true;
         this.lblEmail.Location = new System.Drawing.Point(25, 123);
         this.lblEmail.Name = "lblEmail";
         this.lblEmail.Size = new System.Drawing.Size(35, 13);
         this.lblEmail.TabIndex = 4;
         this.lblEmail.Text = "E-mail";
         // 
         // txtId
         // 
         this.txtId.Location = new System.Drawing.Point(119, 35);
         this.txtId.Name = "txtId";
         this.txtId.Size = new System.Drawing.Size(173, 20);
         this.txtId.TabIndex = 5;
         this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
         // 
         // txtEmail
         // 
         this.txtEmail.Location = new System.Drawing.Point(119, 121);
         this.txtEmail.Name = "txtEmail";
         this.txtEmail.Size = new System.Drawing.Size(173, 20);
         this.txtEmail.TabIndex = 6;
         this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
         // 
         // txtPassword
         // 
         this.txtPassword.Location = new System.Drawing.Point(119, 75);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.PasswordChar = '*';
         this.txtPassword.Size = new System.Drawing.Size(173, 20);
         this.txtPassword.TabIndex = 7;
         this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
         // 
         // ucOkCancel
         // 
         this.ucOkCancel.BackColor = System.Drawing.Color.White;
         this.ucOkCancel.CancelButtonText = "Cancel";
         this.ucOkCancel.Location = new System.Drawing.Point(8, 166);
         this.ucOkCancel.Name = "ucOkCancel";
         this.ucOkCancel.OkButtonText = "Ok";
         this.ucOkCancel.Size = new System.Drawing.Size(291, 52);
         this.ucOkCancel.TabIndex = 1;
         this.ucOkCancel.OkClick += new System.EventHandler(this.ucOkCancel2_OkClick);
         // 
         // chkId
         // 
         this.chkId.AutoSize = true;
         this.chkId.BackColor = System.Drawing.Color.White;
         this.chkId.Enabled = false;
         this.chkId.Location = new System.Drawing.Point(309, 37);
         this.chkId.Name = "chkId";
         this.chkId.Size = new System.Drawing.Size(15, 14);
         this.chkId.TabIndex = 8;
         this.chkId.UseVisualStyleBackColor = false;
         // 
         // chkPassword
         // 
         this.chkPassword.AutoSize = true;
         this.chkPassword.BackColor = System.Drawing.Color.White;
         this.chkPassword.Enabled = false;
         this.chkPassword.Location = new System.Drawing.Point(309, 78);
         this.chkPassword.Name = "chkPassword";
         this.chkPassword.Size = new System.Drawing.Size(15, 14);
         this.chkPassword.TabIndex = 9;
         this.chkPassword.UseVisualStyleBackColor = false;
         // 
         // chkEmail
         // 
         this.chkEmail.AutoSize = true;
         this.chkEmail.BackColor = System.Drawing.Color.White;
         this.chkEmail.Enabled = false;
         this.chkEmail.Location = new System.Drawing.Point(309, 124);
         this.chkEmail.Name = "chkEmail";
         this.chkEmail.Size = new System.Drawing.Size(15, 14);
         this.chkEmail.TabIndex = 10;
         this.chkEmail.UseVisualStyleBackColor = false;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(340, 232);
         this.Controls.Add(this.chkEmail);
         this.Controls.Add(this.chkPassword);
         this.Controls.Add(this.chkId);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.txtEmail);
         this.Controls.Add(this.txtId);
         this.Controls.Add(this.lblEmail);
         this.Controls.Add(this.lblPassword);
         this.Controls.Add(this.lblId);
         this.Controls.Add(this.ucOkCancel);
         this.Name = "frmUser";
         this.Text = "User";
         this.Load += new System.EventHandler(this.frmUser_Load);
         this.ResumeLayout(false);
         this.PerformLayout();
      }
#endregion

      [Intercepted]
      private ucOkCancel ucOkCancel { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblId { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblPassword { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblEmail { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox txtId { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox txtEmail { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox txtPassword { get; set; }

      [Intercepted]
      private Mobilize.Web.CheckBox chkId { get; set; }

      [Intercepted]
      private Mobilize.Web.CheckBox chkPassword { get; set; }

      [Intercepted]
      private Mobilize.Web.CheckBox chkEmail { get; set; }

   }

}