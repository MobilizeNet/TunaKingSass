using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TKS
{

   partial class frmRoles
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
         this.tvwUser = new Mobilize.Web.TreeView();
         this.btnRemove = new Mobilize.Web.Button();
         this.btnAdd = new Mobilize.Web.Button();
         this.lbxRoles = new Mobilize.Web.ListBox();
         this.txtSecurityLevel = new Mobilize.Web.TextBox();
         this.lblSecurityLevel = new Mobilize.Web.Label();
         this.ucOkCancel1 = new TKS.ucOkCancel();
         this.btnSecurityLevel = new Mobilize.Web.Button();
         this.SuspendLayout();
         // 
         // tvwUser
         // 
         this.tvwUser.Location = new System.Drawing.Point(12, 58);
         this.tvwUser.Name = "tvwUser";
         this.tvwUser.Size = new System.Drawing.Size(245, 333);
         this.tvwUser.TabIndex = 0;
         this.tvwUser.NodeMouseClick += new Mobilize.Web.TreeNodeMouseClickEventHandler(this.tvwUser_NodeMouseClick_1);
         // 
         // btnRemove
         // 
         this.btnRemove.Location = new System.Drawing.Point(280, 163);
         this.btnRemove.Name = "btnRemove";
         this.btnRemove.Size = new System.Drawing.Size(33, 29);
         this.btnRemove.TabIndex = 2;
         this.btnRemove.Text = "-->";
         this.btnRemove.UseVisualStyleBackColor = true;
         this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
         // 
         // btnAdd
         // 
         this.btnAdd.Location = new System.Drawing.Point(280, 210);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(33, 29);
         this.btnAdd.TabIndex = 3;
         this.btnAdd.Text = "<--";
         this.btnAdd.UseVisualStyleBackColor = true;
         this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
         // 
         // lbxRoles
         // 
         this.lbxRoles.Properties().FormattingEnabled = true;
         this.lbxRoles.Location = new System.Drawing.Point(341, 58);
         this.lbxRoles.Name = "lbxRoles";
         this.lbxRoles.Size = new System.Drawing.Size(243, 329);
         this.lbxRoles.TabIndex = 4;
         // 
         // txtSecurityLevel
         // 
         this.txtSecurityLevel.Enabled = false;
         this.txtSecurityLevel.Location = new System.Drawing.Point(95, 12);
         this.txtSecurityLevel.Name = "txtSecurityLevel";
         this.txtSecurityLevel.Size = new System.Drawing.Size(141, 20);
         this.txtSecurityLevel.TabIndex = 6;
         // 
         // lblSecurityLevel
         // 
         this.lblSecurityLevel.AutoSize = true;
         this.lblSecurityLevel.Location = new System.Drawing.Point(12, 15);
         this.lblSecurityLevel.Name = "lblSecurityLevel";
         this.lblSecurityLevel.Size = new System.Drawing.Size(77, 13);
         this.lblSecurityLevel.TabIndex = 7;
         this.lblSecurityLevel.Text = "Security Level:";
         // 
         // ucOkCancel1
         // 
         this.ucOkCancel1.BackColor = System.Drawing.Color.White;
         this.ucOkCancel1.CancelButtonText = "Cancel";
         this.ucOkCancel1.Location = new System.Drawing.Point(293, 396);
         this.ucOkCancel1.Name = "ucOkCancel1";
         this.ucOkCancel1.OkButtonText = "Ok";
         this.ucOkCancel1.Size = new System.Drawing.Size(291, 52);
         this.ucOkCancel1.TabIndex = 5;
         this.ucOkCancel1.OkClick += new System.EventHandler(this.ucOkCancel1_OkClick);
         // 
         // btnSecurityLevel
         // 
         this.btnSecurityLevel.Location = new System.Drawing.Point(116, 410);
         this.btnSecurityLevel.Name = "btnSecurityLevel";
         this.btnSecurityLevel.Size = new System.Drawing.Size(141, 23);
         this.btnSecurityLevel.TabIndex = 8;
         this.btnSecurityLevel.Text = "Load User Security Level";
         this.btnSecurityLevel.UseVisualStyleBackColor = true;
         this.btnSecurityLevel.Click += new System.EventHandler(this.btnSecurityLevel_Click);
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(596, 455);
         this.Controls.Add(this.btnSecurityLevel);
         this.Controls.Add(this.lblSecurityLevel);
         this.Controls.Add(this.txtSecurityLevel);
         this.Controls.Add(this.ucOkCancel1);
         this.Controls.Add(this.lbxRoles);
         this.Controls.Add(this.btnAdd);
         this.Controls.Add(this.btnRemove);
         this.Controls.Add(this.tvwUser);
         this.Name = "frmRoles";
         this.Text = "User Roles";
         this.Load += new System.EventHandler(this.frmRoles_Load);
         this.ResumeLayout(false);
         this.PerformLayout();
      }
#endregion

      [Intercepted]
      private Mobilize.Web.TreeView tvwUser { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnRemove { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnAdd { get; set; }

      [Intercepted]
      private Mobilize.Web.ListBox lbxRoles { get; set; }

      [Intercepted]
      private ucOkCancel ucOkCancel1 { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox txtSecurityLevel { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblSecurityLevel { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnSecurityLevel { get; set; }

   }

}