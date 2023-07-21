using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TKS
{

   partial class frmList
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
         this.grdCustomers = new Mobilize.Web.DataGridView();
         this.tpgOrders = new Mobilize.Web.TabControl();
         this.tbpProducts = new Mobilize.Web.TabPage();
         this.grdProducts = new Mobilize.Web.DataGridView();
         this.tbpCustomers = new Mobilize.Web.TabPage();
         this.tbpUsers = new Mobilize.Web.TabPage();
         this.grdUsers = new Mobilize.Web.DataGridView();
         this.tabPage1 = new Mobilize.Web.TabPage();
         this.grdOrders = new Mobilize.Web.DataGridView();
         this.backgroundWorker1 = new Mobilize.Web.BackgroundWorker();
         this.tpgOrders.SuspendLayout();
         this.tbpProducts.SuspendLayout();
         this.tbpCustomers.SuspendLayout();
         this.tbpUsers.SuspendLayout();
         this.tabPage1.SuspendLayout();
         this.SuspendLayout();
         // 
         // grdCustomers
         // 
         this.grdCustomers.AllowUserToAddRows = false;
         this.grdCustomers.AllowUserToDeleteRows = false;
         this.grdCustomers.Properties().AllowUserToResizeColumns = false;
         this.grdCustomers.Properties().AllowUserToResizeRows = false;
         this.grdCustomers.ColumnHeadersHeightSizeMode = Mobilize.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.grdCustomers.Location = new System.Drawing.Point(6, 6);
         this.grdCustomers.Name = "grdCustomers";
         this.grdCustomers.ReadOnly = true;
         this.grdCustomers.RowTemplate.Height = 25;
         this.grdCustomers.Size = new System.Drawing.Size(825, 644);
         this.grdCustomers.TabIndex = 0;
         // 
         // tpgOrders
         // 
         this.tpgOrders.Controls.Add(this.tbpProducts);
         this.tpgOrders.Controls.Add(this.tbpCustomers);
         this.tpgOrders.Controls.Add(this.tbpUsers);
         this.tpgOrders.Controls.Add(this.tabPage1);
         this.tpgOrders.Location = new System.Drawing.Point(10, 12);
         this.tpgOrders.Name = "tpgOrders";
         this.tpgOrders.SelectedIndex = 0;
         this.tpgOrders.Size = new System.Drawing.Size(845, 682);
         this.tpgOrders.TabIndex = 1;
         this.tpgOrders.SelectedIndexChanged += new System.EventHandler(this.tabDatList_SelectedIndexChanged);
         // 
         // tbpProducts
         // 
         this.tbpProducts.Controls.Add(this.grdProducts);
         this.tbpProducts.Properties().Location = new System.Drawing.Point(4, 22);
         this.tbpProducts.Name = "tbpProducts";
         this.tbpProducts.Padding = new Mobilize.Web.Padding(3);
         this.tbpProducts.Size = new System.Drawing.Size(837, 656);
         this.tbpProducts.Properties().TabIndex = 1;
         this.tbpProducts.Text = "Products";
         this.tbpProducts.UseVisualStyleBackColor = true;
         // 
         // grdProducts
         // 
         this.grdProducts.AllowUserToAddRows = false;
         this.grdProducts.AllowUserToDeleteRows = false;
         this.grdProducts.Properties().AllowUserToResizeColumns = false;
         this.grdProducts.Properties().AllowUserToResizeRows = false;
         this.grdProducts.ColumnHeadersHeightSizeMode = Mobilize.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.grdProducts.Location = new System.Drawing.Point(6, 6);
         this.grdProducts.Name = "grdProducts";
         this.grdProducts.ReadOnly = true;
         this.grdProducts.RowTemplate.Height = 25;
         this.grdProducts.Size = new System.Drawing.Size(825, 644);
         this.grdProducts.TabIndex = 1;
         // 
         // tbpCustomers
         // 
         this.tbpCustomers.Controls.Add(this.grdCustomers);
         this.tbpCustomers.Properties().Location = new System.Drawing.Point(4, 22);
         this.tbpCustomers.Name = "tbpCustomers";
         this.tbpCustomers.Padding = new Mobilize.Web.Padding(3);
         this.tbpCustomers.Size = new System.Drawing.Size(837, 656);
         this.tbpCustomers.Properties().TabIndex = 0;
         this.tbpCustomers.Text = "Customers";
         this.tbpCustomers.UseVisualStyleBackColor = true;
         // 
         // tbpUsers
         // 
         this.tbpUsers.Controls.Add(this.grdUsers);
         this.tbpUsers.Properties().Location = new System.Drawing.Point(4, 22);
         this.tbpUsers.Name = "tbpUsers";
         this.tbpUsers.Padding = new Mobilize.Web.Padding(3);
         this.tbpUsers.Size = new System.Drawing.Size(837, 656);
         this.tbpUsers.Properties().TabIndex = 2;
         this.tbpUsers.Text = "Users";
         this.tbpUsers.UseVisualStyleBackColor = true;
         // 
         // grdUsers
         // 
         this.grdUsers.AllowUserToAddRows = false;
         this.grdUsers.AllowUserToDeleteRows = false;
         this.grdUsers.Properties().AllowUserToResizeColumns = false;
         this.grdUsers.Properties().AllowUserToResizeRows = false;
         this.grdUsers.ColumnHeadersHeightSizeMode = Mobilize.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.grdUsers.Location = new System.Drawing.Point(6, 6);
         this.grdUsers.Name = "grdUsers";
         this.grdUsers.ReadOnly = true;
         this.grdUsers.RowTemplate.Height = 25;
         this.grdUsers.Size = new System.Drawing.Size(825, 644);
         this.grdUsers.TabIndex = 1;
         // 
         // tabPage1
         // 
         this.tabPage1.Controls.Add(this.grdOrders);
         this.tabPage1.Properties().Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new Mobilize.Web.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(837, 656);
         this.tabPage1.Properties().TabIndex = 3;
         this.tabPage1.Text = "Orders";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // grdOrders
         // 
         this.grdOrders.AllowUserToAddRows = false;
         this.grdOrders.AllowUserToDeleteRows = false;
         this.grdOrders.Properties().AllowUserToResizeColumns = false;
         this.grdOrders.Properties().AllowUserToResizeRows = false;
         this.grdOrders.ColumnHeadersHeightSizeMode = Mobilize.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.grdOrders.Location = new System.Drawing.Point(6, 6);
         this.grdOrders.Name = "grdOrders";
         this.grdOrders.ReadOnly = true;
         this.grdOrders.RowTemplate.Height = 25;
         this.grdOrders.Size = new System.Drawing.Size(825, 644);
         this.grdOrders.TabIndex = 2;
         this.grdOrders.Properties().CellContentClick += new Mobilize.Web.DataGridViewCellEventHandler(this.grdOrders_CellContentClick);
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(866, 706);
         this.Controls.Add(this.tpgOrders);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmList";
         this.Text = "CustomerList";
         this.Load += new System.EventHandler(this.CustomerList_Load);
         this.tpgOrders.ResumeLayout(false);
         this.tbpProducts.ResumeLayout(false);
         this.tbpCustomers.ResumeLayout(false);
         this.tbpUsers.ResumeLayout(false);
         this.tabPage1.ResumeLayout(false);
         this.ResumeLayout(false);
         this.backgroundWorker1.SetReference(this);
         this.tbpProducts.FormName = "TKS.frmList";
         this.tbpProducts.DefName = "tbpProducts";
         this.tbpCustomers.FormName = "TKS.frmList";
         this.tbpCustomers.DefName = "tbpCustomers";
         this.tbpUsers.FormName = "TKS.frmList";
         this.tbpUsers.DefName = "tbpUsers";
         this.tabPage1.FormName = "TKS.frmList";
         this.tabPage1.DefName = "tabPage1";
      }
#endregion

      [Intercepted]
      private Mobilize.Web.DataGridView grdCustomers { get; set; }

      [Intercepted]
      private Mobilize.Web.TabPage tbpCustomers { get; set; }

      [Intercepted]
      private Mobilize.Web.TabPage tbpProducts { get; set; }

      [Intercepted]
      private Mobilize.Web.BackgroundWorker backgroundWorker1 { get; set; }

      [Intercepted]
      private Mobilize.Web.DataGridView grdProducts { get; set; }

      [Intercepted]
      private Mobilize.Web.TabPage tbpUsers { get; set; }

      [Intercepted]
      private Mobilize.Web.DataGridView grdUsers { get; set; }

      [Intercepted]
      public Mobilize.Web.TabControl tpgOrders { get; set; }

      [Intercepted]
      private Mobilize.Web.TabPage tabPage1 { get; set; }

      [Intercepted]
      private Mobilize.Web.DataGridView grdOrders { get; set; }

   }

}