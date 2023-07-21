using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TKS
{

   partial class UOCollapsableControl
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
#region Component Designer generated code
      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.pnlHeader = new Mobilize.Web.Panel();
         this.lblHeader = new Mobilize.Web.Label();
         this.btnCollapseExpand = new Mobilize.Web.Button();
         this.pnlCollapsable = new Mobilize.Web.Panel();
         this.buttonMaintenance = new Mobilize.Web.Button();
         this.btnList = new Mobilize.Web.Button();
         this.btnCreateUser = new Mobilize.Web.Button();
         this.btnRoles = new Mobilize.Web.Button();
         this.btnCreateProduct = new Mobilize.Web.Button();
         this.btnCreateOrder = new Mobilize.Web.Button();
         this.btnCreateCustomer = new Mobilize.Web.Button();
         this.pnlHeader.SuspendLayout();
         this.pnlCollapsable.SuspendLayout();
         this.SuspendLayout();
         // 
         // pnlHeader
         // 
         this.pnlHeader.BackColor = System.Drawing.Color.Lavender;
         this.pnlHeader.Properties().BorderStyle = Mobilize.Web.BorderStyle.FixedSingle;
         this.pnlHeader.Controls.Add(this.lblHeader);
         this.pnlHeader.Controls.Add(this.btnCollapseExpand);
         this.pnlHeader.Location = new System.Drawing.Point(4, 4);
         this.pnlHeader.Properties().Margin = new Mobilize.Web.Padding(4);
         this.pnlHeader.Name = "pnlHeader";
         this.pnlHeader.Size = new System.Drawing.Size(293, 36);
         this.pnlHeader.TabIndex = 0;
         // 
         // lblHeader
         // 
         this.lblHeader.AutoSize = true;
         this.lblHeader.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 11.25F, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, ((byte)(0)));
         this.lblHeader.Location = new System.Drawing.Point(9, 6);
         this.lblHeader.Properties().Margin = new Mobilize.Web.Padding(4, 0, 4, 0);
         this.lblHeader.Name = "lblHeader";
         this.lblHeader.Size = new System.Drawing.Size(121, 24);
         this.lblHeader.TabIndex = 1;
         this.lblHeader.Text = "Top Higlights";
         // 
         // btnCollapseExpand
         // 
         this.btnCollapseExpand.Location = new System.Drawing.Point(255, 4);
         this.btnCollapseExpand.Properties().Margin = new Mobilize.Web.Padding(4);
         this.btnCollapseExpand.Name = "btnCollapseExpand";
         this.btnCollapseExpand.Size = new System.Drawing.Size(32, 28);
         this.btnCollapseExpand.TabIndex = 0;
         this.btnCollapseExpand.Text = "▲";
         this.btnCollapseExpand.UseVisualStyleBackColor = true;
         this.btnCollapseExpand.Click += new System.EventHandler(this.BtnCollapseExpand_Click);
         // 
         // pnlCollapsable
         // 
         this.pnlCollapsable.BackColor = System.Drawing.Color.GhostWhite;
         this.pnlCollapsable.Properties().BorderStyle = Mobilize.Web.BorderStyle.FixedSingle;
         this.pnlCollapsable.Controls.Add(this.buttonMaintenance);
         this.pnlCollapsable.Controls.Add(this.btnList);
         this.pnlCollapsable.Controls.Add(this.btnCreateUser);
         this.pnlCollapsable.Controls.Add(this.btnRoles);
         this.pnlCollapsable.Controls.Add(this.btnCreateProduct);
         this.pnlCollapsable.Controls.Add(this.btnCreateOrder);
         this.pnlCollapsable.Controls.Add(this.btnCreateCustomer);
         this.pnlCollapsable.Location = new System.Drawing.Point(4, 39);
         this.pnlCollapsable.Properties().Margin = new Mobilize.Web.Padding(4);
         this.pnlCollapsable.Name = "pnlCollapsable";
         this.pnlCollapsable.Size = new System.Drawing.Size(293, 932);
         this.pnlCollapsable.TabIndex = 1;
         // 
         // buttonMaintenance
         // 
         this.buttonMaintenance.BackColor = System.Drawing.Color.Lavender;
         this.buttonMaintenance.Location = new System.Drawing.Point(-1, 172);
         this.buttonMaintenance.Properties().Margin = new Mobilize.Web.Padding(4);
         this.buttonMaintenance.Name = "buttonMaintenance";
         this.buttonMaintenance.Size = new System.Drawing.Size(293, 28);
         this.buttonMaintenance.TabIndex = 6;
         this.buttonMaintenance.Text = "Process payment" + "";
         this.buttonMaintenance.UseVisualStyleBackColor = false;
         this.buttonMaintenance.Click += new System.EventHandler(this.buttonMaintenance_Click);
         // 
         // btnList
         // 
         this.btnList.BackColor = System.Drawing.Color.Lavender;
         this.btnList.Location = new System.Drawing.Point(-1, 89);
         this.btnList.Properties().Margin = new Mobilize.Web.Padding(4);
         this.btnList.Name = "btnList";
         this.btnList.Size = new System.Drawing.Size(293, 28);
         this.btnList.TabIndex = 5;
         this.btnList.Text = "Show Lists";
         this.btnList.UseVisualStyleBackColor = false;
         this.btnList.Click += new System.EventHandler(this.btnList_Click);
         // 
         // btnCreateUser
         // 
         this.btnCreateUser.BackColor = System.Drawing.Color.Lavender;
         this.btnCreateUser.Location = new System.Drawing.Point(-1, 60);
         this.btnCreateUser.Properties().Margin = new Mobilize.Web.Padding(4);
         this.btnCreateUser.Name = "btnCreateUser";
         this.btnCreateUser.Size = new System.Drawing.Size(293, 28);
         this.btnCreateUser.TabIndex = 4;
         this.btnCreateUser.Text = "Create User";
         this.btnCreateUser.UseVisualStyleBackColor = false;
         this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click_1);
         // 
         // btnRoles
         // 
         this.btnRoles.BackColor = System.Drawing.Color.Lavender;
         this.btnRoles.Location = new System.Drawing.Point(-1, 145);
         this.btnRoles.Properties().Margin = new Mobilize.Web.Padding(4);
         this.btnRoles.Name = "btnRoles";
         this.btnRoles.Size = new System.Drawing.Size(293, 28);
         this.btnRoles.TabIndex = 3;
         this.btnRoles.Text = "Assing Roles";
         this.btnRoles.UseVisualStyleBackColor = false;
         this.btnRoles.Click += new System.EventHandler(this.btnCreatInvoice_Click);
         // 
         // btnCreateProduct
         // 
         this.btnCreateProduct.BackColor = System.Drawing.Color.Lavender;
         this.btnCreateProduct.Location = new System.Drawing.Point(-1, 32);
         this.btnCreateProduct.Properties().Margin = new Mobilize.Web.Padding(4);
         this.btnCreateProduct.Name = "btnCreateProduct";
         this.btnCreateProduct.Size = new System.Drawing.Size(293, 28);
         this.btnCreateProduct.TabIndex = 2;
         this.btnCreateProduct.Text = "Create Product";
         this.btnCreateProduct.UseVisualStyleBackColor = false;
         this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
         // 
         // btnCreateOrder
         // 
         this.btnCreateOrder.BackColor = System.Drawing.Color.Lavender;
         this.btnCreateOrder.Location = new System.Drawing.Point(-1, 117);
         this.btnCreateOrder.Properties().Margin = new Mobilize.Web.Padding(4);
         this.btnCreateOrder.Name = "btnCreateOrder";
         this.btnCreateOrder.Size = new System.Drawing.Size(293, 28);
         this.btnCreateOrder.TabIndex = 1;
         this.btnCreateOrder.Text = "Create Order";
         this.btnCreateOrder.UseVisualStyleBackColor = false;
         this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
         // 
         // btnCreateCustomer
         // 
         this.btnCreateCustomer.BackColor = System.Drawing.Color.Lavender;
         this.btnCreateCustomer.Location = new System.Drawing.Point(-1, 4);
         this.btnCreateCustomer.Properties().Margin = new Mobilize.Web.Padding(4);
         this.btnCreateCustomer.Name = "btnCreateCustomer";
         this.btnCreateCustomer.Size = new System.Drawing.Size(293, 28);
         this.btnCreateCustomer.TabIndex = 0;
         this.btnCreateCustomer.Text = "Create Customer";
         this.btnCreateCustomer.UseVisualStyleBackColor = false;
         this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateUser_Click);
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Transparent;
         this.Controls.Add(this.pnlCollapsable);
         this.Controls.Add(this.pnlHeader);
         this.Properties().Margin = new Mobilize.Web.Padding(4);
         this.Name = "UOCollapsableControl";
         this.Size = new System.Drawing.Size(301, 976);
         this.pnlHeader.ResumeLayout(false);
         this.pnlHeader.PerformLayout();
         this.pnlCollapsable.ResumeLayout(false);
         this.ResumeLayout(false);
      }
#endregion

      [Intercepted]
      private Mobilize.Web.Panel pnlHeader { get; set; }

      [Intercepted]
      private Mobilize.Web.Panel pnlCollapsable { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnCollapseExpand { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblHeader { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnCreateCustomer { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnRoles { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnCreateProduct { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnCreateOrder { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnCreateUser { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnList { get; set; }

      [Intercepted]
      private Mobilize.Web.Button buttonMaintenance { get; set; }

   }

}