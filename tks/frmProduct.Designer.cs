using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TKS
{

   partial class frmProduct
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
         this.btnSave = new Mobilize.Web.Button();
         this.button2 = new Mobilize.Web.Button();
         this.lnkCategory = new Mobilize.Web.LinkLabel();
         this.lblName = new Mobilize.Web.Label();
         this.lnkBrand = new Mobilize.Web.LinkLabel();
         this.lblModel = new Mobilize.Web.Label();
         this.lblPrice = new Mobilize.Web.Label();
         this.txtName = new Mobilize.Web.TextBox();
         this.numPrice = new Mobilize.Web.NumericUpDown();
         this.cboModel = new Mobilize.Web.ComboBox();
         this.cboBrand = new Mobilize.Web.ComboBox();
         this.cboCategory = new Mobilize.Web.ComboBox();
         this.btnVerify = new Mobilize.Web.Button();
         this.lblNameAlert = new Mobilize.Web.Label();
         this.lblBrandAlert = new Mobilize.Web.Label();
         this.lblCategoryAlert = new Mobilize.Web.Label();
         this.lblModelAlert = new Mobilize.Web.Label();
         this.lblPriceAlert = new Mobilize.Web.Label();
         this.SuspendLayout();
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(33, 341);
         this.btnSave.Properties().Margin = new Mobilize.Web.Padding(4, 4, 4, 4);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(100, 28);
         this.btnSave.TabIndex = 0;
         this.btnSave.Text = "Save";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(336, 341);
         this.button2.Properties().Margin = new Mobilize.Web.Padding(4, 4, 4, 4);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(100, 28);
         this.button2.TabIndex = 1;
         this.button2.Text = "Cancel";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // lnkCategory
         // 
         this.lnkCategory.AutoSize = true;
         this.lnkCategory.Enabled = false;
         this.lnkCategory.Location = new System.Drawing.Point(52, 146);
         this.lnkCategory.Properties().Margin = new Mobilize.Web.Padding(4, 0, 4, 0);
         this.lnkCategory.Name = "lnkCategory";
         this.lnkCategory.Size = new System.Drawing.Size(65, 17);
         this.lnkCategory.TabIndex = 2;
         this.lnkCategory.TabStop = true;
         this.lnkCategory.Text = "Category";
         this.lnkCategory.LinkClicked += new Mobilize.Web.LinkLabelLinkClickedEventHandler(this.lnkCategory_LinkClicked);
         // 
         // lblName
         // 
         this.lblName.AutoSize = true;
         this.lblName.Location = new System.Drawing.Point(52, 39);
         this.lblName.Properties().Margin = new Mobilize.Web.Padding(4, 0, 4, 0);
         this.lblName.Name = "lblName";
         this.lblName.Size = new System.Drawing.Size(45, 17);
         this.lblName.TabIndex = 3;
         this.lblName.Text = "Name";
         // 
         // lnkBrand
         // 
         this.lnkBrand.AutoSize = true;
         this.lnkBrand.Enabled = false;
         this.lnkBrand.Location = new System.Drawing.Point(52, 92);
         this.lnkBrand.Properties().Margin = new Mobilize.Web.Padding(4, 0, 4, 0);
         this.lnkBrand.Name = "lnkBrand";
         this.lnkBrand.Size = new System.Drawing.Size(46, 17);
         this.lnkBrand.TabIndex = 4;
         this.lnkBrand.TabStop = true;
         this.lnkBrand.Text = "Brand";
         this.lnkBrand.LinkClicked += new Mobilize.Web.LinkLabelLinkClickedEventHandler(this.lnkBrand_LinkClicked);
         // 
         // lblModel
         // 
         this.lblModel.AutoSize = true;
         this.lblModel.Location = new System.Drawing.Point(52, 204);
         this.lblModel.Properties().Margin = new Mobilize.Web.Padding(4, 0, 4, 0);
         this.lblModel.Name = "lblModel";
         this.lblModel.Size = new System.Drawing.Size(80, 17);
         this.lblModel.TabIndex = 5;
         this.lblModel.Text = "Model Year";
         // 
         // lblPrice
         // 
         this.lblPrice.AutoSize = true;
         this.lblPrice.Location = new System.Drawing.Point(57, 260);
         this.lblPrice.Properties().Margin = new Mobilize.Web.Padding(4, 0, 4, 0);
         this.lblPrice.Name = "lblPrice";
         this.lblPrice.Size = new System.Drawing.Size(40, 17);
         this.lblPrice.TabIndex = 6;
         this.lblPrice.Text = "Price";
         // 
         // txtName
         // 
         this.txtName.Location = new System.Drawing.Point(187, 36);
         this.txtName.Properties().Margin = new Mobilize.Web.Padding(4, 4, 4, 4);
         this.txtName.Name = "txtName";
         this.txtName.Size = new System.Drawing.Size(213, 22);
         this.txtName.TabIndex = 7;
         this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
         // 
         // numPrice
         // 
         this.numPrice.DecimalPlaces = 2;
         this.numPrice.Location = new System.Drawing.Point(187, 257);
         this.numPrice.Properties().Margin = new Mobilize.Web.Padding(4, 4, 4, 4);
         this.numPrice.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
         this.numPrice.Name = "numPrice";
         this.numPrice.Size = new System.Drawing.Size(215, 22);
         this.numPrice.TabIndex = 8;
         this.numPrice.Properties().TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // cboModel
         // 
         this.cboModel.Properties().FormattingEnabled = true;
         this.cboModel.Location = new System.Drawing.Point(187, 201);
         this.cboModel.Properties().Margin = new Mobilize.Web.Padding(4, 4, 4, 4);
         this.cboModel.Name = "cboModel";
         this.cboModel.Size = new System.Drawing.Size(213, 24);
         this.cboModel.TabIndex = 9;
         // 
         // cboBrand
         // 
         this.cboBrand.DropDownStyle = Mobilize.Web.ComboBoxStyle.DropDownList;
         this.cboBrand.Enabled = false;
         this.cboBrand.Properties().FormattingEnabled = true;
         this.cboBrand.Location = new System.Drawing.Point(187, 92);
         this.cboBrand.Properties().Margin = new Mobilize.Web.Padding(4, 4, 4, 4);
         this.cboBrand.Name = "cboBrand";
         this.cboBrand.Size = new System.Drawing.Size(213, 24);
         this.cboBrand.TabIndex = 10;
         // 
         // cboCategory
         // 
         this.cboCategory.DropDownStyle = Mobilize.Web.ComboBoxStyle.DropDownList;
         this.cboCategory.Enabled = false;
         this.cboCategory.Properties().FormattingEnabled = true;
         this.cboCategory.Location = new System.Drawing.Point(187, 143);
         this.cboCategory.Properties().Margin = new Mobilize.Web.Padding(4, 4, 4, 4);
         this.cboCategory.Name = "cboCategory";
         this.cboCategory.Size = new System.Drawing.Size(213, 24);
         this.cboCategory.TabIndex = 11;
         // 
         // btnVerify
         // 
         this.btnVerify.Location = new System.Drawing.Point(183, 341);
         this.btnVerify.Properties().Margin = new Mobilize.Web.Padding(4, 4, 4, 4);
         this.btnVerify.Name = "btnVerify";
         this.btnVerify.Size = new System.Drawing.Size(111, 28);
         this.btnVerify.TabIndex = 12;
         this.btnVerify.Text = "Verify Product";
         this.btnVerify.UseVisualStyleBackColor = true;
         this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
         // 
         // btnNameAlert
         // 
         this.lblNameAlert.BackColor = System.Drawing.Color.Red;
         this.lblNameAlert.Enabled = false;
         this.lblNameAlert.Location = new System.Drawing.Point(409, 39);
         this.lblNameAlert.Properties().Margin = new Mobilize.Web.Padding(4, 4, 4, 4);
         this.lblNameAlert.Name = "btnNameAlert";
         this.lblNameAlert.Size = new System.Drawing.Size(20, 18);
         this.lblNameAlert.TabIndex = 13;
         this.lblNameAlert.Visible = false;
         // 
         // btnBrandAlert
         // 
         this.lblBrandAlert.BackColor = System.Drawing.Color.Red;
         this.lblBrandAlert.Enabled = false;
         this.lblBrandAlert.Location = new System.Drawing.Point(409, 95);
         this.lblBrandAlert.Properties().Margin = new Mobilize.Web.Padding(4, 4, 4, 4);
         this.lblBrandAlert.Name = "btnBrandAlert";
         this.lblBrandAlert.Size = new System.Drawing.Size(20, 18);
         this.lblBrandAlert.TabIndex = 14;
         this.lblBrandAlert.Visible = false;
         // 
         // btnCategoryAlert
         // 
         this.lblCategoryAlert.BackColor = System.Drawing.Color.Red;
         this.lblCategoryAlert.Enabled = false;
         this.lblCategoryAlert.Location = new System.Drawing.Point(409, 144);
         this.lblCategoryAlert.Properties().Margin = new Mobilize.Web.Padding(4, 4, 4, 4);
         this.lblCategoryAlert.Name = "btnCategoryAlert";
         this.lblCategoryAlert.Size = new System.Drawing.Size(20, 18);
         this.lblCategoryAlert.TabIndex = 15;
         this.lblCategoryAlert.Visible = false;
         // 
         // btnModelAlert
         // 
         this.lblModelAlert.BackColor = System.Drawing.Color.Red;
         this.lblModelAlert.Enabled = false;
         this.lblModelAlert.Location = new System.Drawing.Point(409, 204);
         this.lblModelAlert.Properties().Margin = new Mobilize.Web.Padding(4, 4, 4, 4);
         this.lblModelAlert.Name = "btnModelAlert";
         this.lblModelAlert.Size = new System.Drawing.Size(20, 18);
         this.lblModelAlert.TabIndex = 16;
         this.lblModelAlert.Visible = false;
         // 
         // btnPriceAlert
         // 
         this.lblPriceAlert.BackColor = System.Drawing.Color.Red;
         this.lblPriceAlert.Enabled = false;
         this.lblPriceAlert.Location = new System.Drawing.Point(409, 258);
         this.lblPriceAlert.Properties().Margin = new Mobilize.Web.Padding(4, 4, 4, 4);
         this.lblPriceAlert.Name = "btnPriceAlert";
         this.lblPriceAlert.Size = new System.Drawing.Size(20, 18);
         this.lblPriceAlert.TabIndex = 17;
         this.lblPriceAlert.Visible = false;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(452, 404);
         this.Controls.Add(this.lblPriceAlert);
         this.Controls.Add(this.lblModelAlert);
         this.Controls.Add(this.lblCategoryAlert);
         this.Controls.Add(this.lblBrandAlert);
         this.Controls.Add(this.lblNameAlert);
         this.Controls.Add(this.btnVerify);
         this.Controls.Add(this.cboCategory);
         this.Controls.Add(this.cboBrand);
         this.Controls.Add(this.cboModel);
         this.Controls.Add(this.numPrice);
         this.Controls.Add(this.txtName);
         this.Controls.Add(this.lblPrice);
         this.Controls.Add(this.lblModel);
         this.Controls.Add(this.lnkBrand);
         this.Controls.Add(this.lblName);
         this.Controls.Add(this.lnkCategory);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.btnSave);
         this.Properties().Margin = new Mobilize.Web.Padding(4, 4, 4, 4);
         this.Name = "frmProduct";
         this.Text = "Product";
         this.FormClosing += new Mobilize.Web.FormClosingEventHandler(this.frmProduct_FormClosing);
         this.Load += new System.EventHandler(this.frmProduct_Load);
         this.ResumeLayout(false);
         this.PerformLayout();
      }
#endregion

      [Intercepted]
      private Mobilize.Web.Button btnSave { get; set; }

      [Intercepted]
      private Mobilize.Web.Button button2 { get; set; }

      [Intercepted]
      private Mobilize.Web.LinkLabel lnkCategory { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblName { get; set; }

      [Intercepted]
      private Mobilize.Web.LinkLabel lnkBrand { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblModel { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblPrice { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox txtName { get; set; }

      [Intercepted]
      private Mobilize.Web.NumericUpDown numPrice { get; set; }

      [Intercepted]
      private Mobilize.Web.ComboBox cboModel { get; set; }

      [Intercepted]
      private Mobilize.Web.ComboBox cboBrand { get; set; }

      [Intercepted]
      private Mobilize.Web.ComboBox cboCategory { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnVerify { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblNameAlert { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblBrandAlert { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblCategoryAlert { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblModelAlert { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblPriceAlert { get; set; }

   }

}