using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TKS
{

   partial class frmMain
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
         this.menuStrip1 = new Mobilize.Web.ToolStrip();
         this.fileToolStripMenuItem = new Mobilize.Web.ToolStripMenuItem();
         this.usersToolStripMenuItem = new Mobilize.Web.ToolStripMenuItem();
         this.createCustomerToolStripMenuItem = new Mobilize.Web.ToolStripMenuItem();
         this.viewCustomersToolStripMenuItem = new Mobilize.Web.ToolStripMenuItem();
         this.ordersToolStripMenuItem = new Mobilize.Web.ToolStripMenuItem();
         this.createOrderToolStripMenuItem = new Mobilize.Web.ToolStripMenuItem();
         this.personalizationToolStripMenuItem = new Mobilize.Web.ToolStripMenuItem();
         this.rolesToolStripMenuItem = new Mobilize.Web.ToolStripMenuItem();
         this.assignRoleToolStripMenuItem = new Mobilize.Web.ToolStripMenuItem();
         this.uoCollapsableControl1 = new TKS.UOCollapsableControl();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // menuStrip1
         // 
         this.menuStrip1.Properties().BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
         this.menuStrip1.Items.AddRange(new Mobilize.Web.ToolStripItem[] { this.fileToolStripMenuItem, this.usersToolStripMenuItem, this.ordersToolStripMenuItem, this.personalizationToolStripMenuItem, this.rolesToolStripMenuItem });
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(1244, 24);
         this.menuStrip1.TabIndex = 1;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
         this.fileToolStripMenuItem.Text = "File";
         // 
         // usersToolStripMenuItem
         // 
         this.usersToolStripMenuItem.DropDownItems.AddRange(new Mobilize.Web.ToolStripItem[] { this.createCustomerToolStripMenuItem, this.viewCustomersToolStripMenuItem });
         this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
         this.usersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
         this.usersToolStripMenuItem.Text = "Customers";
         // 
         // createCustomerToolStripMenuItem
         // 
         this.createCustomerToolStripMenuItem.Name = "createCustomerToolStripMenuItem";
         this.createCustomerToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
         this.createCustomerToolStripMenuItem.Text = "Create Customer";
         this.createCustomerToolStripMenuItem.Click += new System.EventHandler(this.createCustomerToolStripMenuItem_Click);
         // 
         // viewCustomersToolStripMenuItem
         // 
         this.viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
         this.viewCustomersToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
         this.viewCustomersToolStripMenuItem.Text = "View Customers";
         this.viewCustomersToolStripMenuItem.Click += new System.EventHandler(this.ViewCustomersToolStripMenuItem_Click);
         // 
         // ordersToolStripMenuItem
         // 
         this.ordersToolStripMenuItem.DropDownItems.AddRange(new Mobilize.Web.ToolStripItem[] { this.createOrderToolStripMenuItem });
         this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
         this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
         this.ordersToolStripMenuItem.Text = "Orders";
         // 
         // createOrderToolStripMenuItem
         // 
         this.createOrderToolStripMenuItem.Name = "createOrderToolStripMenuItem";
         this.createOrderToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
         this.createOrderToolStripMenuItem.Text = "Create Order";
         this.createOrderToolStripMenuItem.Click += new System.EventHandler(this.createOrderToolStripMenuItem_Click);
         // 
         // personalizationToolStripMenuItem
         // 
         this.personalizationToolStripMenuItem.Enabled = false;
         this.personalizationToolStripMenuItem.Name = "personalizationToolStripMenuItem";
         this.personalizationToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
         this.personalizationToolStripMenuItem.Text = "Personalization";
         // 
         // rolesToolStripMenuItem
         // 
         this.rolesToolStripMenuItem.DropDownItems.AddRange(new Mobilize.Web.ToolStripItem[] { this.assignRoleToolStripMenuItem });
         this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
         this.rolesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
         this.rolesToolStripMenuItem.Text = "Roles";
         // 
         // assignRoleToolStripMenuItem
         // 
         this.assignRoleToolStripMenuItem.Name = "assignRoleToolStripMenuItem";
         this.assignRoleToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
         this.assignRoleToolStripMenuItem.Text = "Assign Role";
         this.assignRoleToolStripMenuItem.Click += new System.EventHandler(this.assignRoleToolStripMenuItem_Click);
         // 
         // uoCollapsableControl1
         // 
         this.uoCollapsableControl1.BackColor = System.Drawing.Color.Transparent;
         this.uoCollapsableControl1.Location = new System.Drawing.Point(0, 25);
         this.uoCollapsableControl1.Properties().Margin = new Mobilize.Web.Padding(4, 3, 4, 3);
         this.uoCollapsableControl1.Name = "uoCollapsableControl1";
         this.uoCollapsableControl1.Size = new System.Drawing.Size(226, 793);
         this.uoCollapsableControl1.TabIndex = 2;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = Mobilize.Web.SystemColors.ButtonHighlight;
         this.ClientSize = new System.Drawing.Size(1244, 821);
         this.Controls.Add(this.uoCollapsableControl1);
         this.Controls.Add(this.menuStrip1);
         this.Properties().MainMenuStrip = this.menuStrip1;
         this.MaximizeBox = false;
         this.MaximumSize = new System.Drawing.Size(1260, 860);
         this.MinimumSize = new System.Drawing.Size(1260, 860);
         this.Name = "frmMain";
         this.Text = "Tuna King Seafood";
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();
      }
#endregion

      [Intercepted]
      private Mobilize.Web.ToolStrip menuStrip1 { get; set; }

      [Intercepted]
      private Mobilize.Web.ToolStripMenuItem fileToolStripMenuItem { get; set; }

      [Intercepted]
      private Mobilize.Web.ToolStripMenuItem usersToolStripMenuItem { get; set; }

      [Intercepted]
      private Mobilize.Web.ToolStripMenuItem ordersToolStripMenuItem { get; set; }

      [Intercepted]
      private UOCollapsableControl uoCollapsableControl1 { get; set; }

      [Intercepted]
      private Mobilize.Web.ToolStripMenuItem personalizationToolStripMenuItem { get; set; }

      [Intercepted]
      private Mobilize.Web.ToolStripMenuItem createCustomerToolStripMenuItem { get; set; }

      [Intercepted]
      private Mobilize.Web.ToolStripMenuItem viewCustomersToolStripMenuItem { get; set; }

      [Intercepted]
      private Mobilize.Web.ToolStripMenuItem rolesToolStripMenuItem { get; set; }

      [Intercepted]
      private Mobilize.Web.ToolStripMenuItem assignRoleToolStripMenuItem { get; set; }

      [Intercepted]
      private Mobilize.Web.ToolStripMenuItem createOrderToolStripMenuItem { get; set; }

   }

}