using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TKS
{

   partial class frmOrders
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
         this.lbxProducts = new Mobilize.Web.ListBox();
         this.lblOrderDate = new Mobilize.Web.Label();
         this.dtpOrder = new Mobilize.Web.DateTimePicker();
         this.lblOrderN = new Mobilize.Web.Label();
         this.txtOrder = new Mobilize.Web.TextBox();
         this.dtpShipping = new Mobilize.Web.DateTimePicker();
         this.lbsShipDate = new Mobilize.Web.Label();
         this.lbxCustomers = new Mobilize.Web.ListBox();
         this.grbProduct = new Mobilize.Web.GroupBox();
         this.gbxUsers = new Mobilize.Web.GroupBox();
         this.dtpArrival = new Mobilize.Web.DateTimePicker();
         this.lb = new Mobilize.Web.Label();
         this.lblStaff = new Mobilize.Web.Label();
         this.cboStaff = new Mobilize.Web.ComboBox();
         this.cboStore = new Mobilize.Web.ComboBox();
         this.lblStore = new Mobilize.Web.Label();
         this.pnlOrder = new Mobilize.Web.Panel();
         this.numPrice = new Mobilize.Web.NumericUpDown();
         this.numDiscount = new Mobilize.Web.NumericUpDown();
         this.lblDiscount = new Mobilize.Web.Label();
         this.lblPrice = new Mobilize.Web.Label();
         this.numQuantity = new Mobilize.Web.NumericUpDown();
         this.lblQuantity = new Mobilize.Web.Label();
         this.btnPlaceOrder = new Mobilize.Web.Button();
         this.ucOkCancel1 = new TKS.ucOkCancel();
         this.grbProduct.SuspendLayout();
         this.gbxUsers.SuspendLayout();
         this.pnlOrder.SuspendLayout();
         this.SuspendLayout();
         // 
         // ucOkCancel1
         // 
         this.ucOkCancel1.Location = new System.Drawing.Point(48, 576);
         this.ucOkCancel1.OkClick += new System.EventHandler(this.ucOkCancel1_OkClick);
         this.ucOkCancel1.Load += new System.EventHandler(this.ucOkCancel1_Load);
         // 
         // lbxProducts
         // 
         this.lbxProducts.Properties().FormattingEnabled = true;
         this.lbxProducts.Location = new System.Drawing.Point(6, 22);
         this.lbxProducts.Name = "lbxProducts";
         this.lbxProducts.Size = new System.Drawing.Size(311, 173);
         this.lbxProducts.TabIndex = 1;
         this.lbxProducts.SelectedIndexChanged += new System.EventHandler(this.lbxProducts_SelectedIndexChanged);
         // 
         // lblOrderDate
         // 
         this.lblOrderDate.AutoSize = true;
         this.lblOrderDate.Location = new System.Drawing.Point(39, 74);
         this.lblOrderDate.Name = "lblOrderDate";
         this.lblOrderDate.Size = new System.Drawing.Size(59, 13);
         this.lblOrderDate.TabIndex = 2;
         this.lblOrderDate.Text = "Order Date";
         // 
         // dtpOrder
         // 
         this.dtpOrder.Enabled = false;
         this.dtpOrder.Format = Mobilize.Web.DateTimePickerFormat.Short;
         this.dtpOrder.Location = new System.Drawing.Point(104, 69);
         this.dtpOrder.Name = "dtpOrder";
         this.dtpOrder.Size = new System.Drawing.Size(87, 20);
         this.dtpOrder.TabIndex = 3;
         // 
         // lblOrderN
         // 
         this.lblOrderN.AutoSize = true;
         this.lblOrderN.Location = new System.Drawing.Point(16, 14);
         this.lblOrderN.Name = "lblOrderN";
         this.lblOrderN.Size = new System.Drawing.Size(73, 13);
         this.lblOrderN.TabIndex = 4;
         this.lblOrderN.Text = "Order Number";
         // 
         // txtOrder
         // 
         this.txtOrder.Enabled = false;
         this.txtOrder.Location = new System.Drawing.Point(95, 11);
         this.txtOrder.Name = "txtOrder";
         this.txtOrder.Size = new System.Drawing.Size(46, 20);
         this.txtOrder.TabIndex = 5;
         // 
         // dtpShipping
         // 
         this.dtpShipping.Format = Mobilize.Web.DateTimePickerFormat.Short;
         this.dtpShipping.Location = new System.Drawing.Point(365, 68);
         this.dtpShipping.Name = "dtpShipping";
         this.dtpShipping.Size = new System.Drawing.Size(87, 20);
         this.dtpShipping.TabIndex = 7;
         // 
         // lbsShipDate
         // 
         this.lbsShipDate.AutoSize = true;
         this.lbsShipDate.Location = new System.Drawing.Point(285, 74);
         this.lbsShipDate.Name = "lbsShipDate";
         this.lbsShipDate.Size = new System.Drawing.Size(74, 13);
         this.lbsShipDate.TabIndex = 6;
         this.lbsShipDate.Text = "Shipping Date";
         // 
         // lbxCustomers
         // 
         this.lbxCustomers.Properties().FormattingEnabled = true;
         this.lbxCustomers.Location = new System.Drawing.Point(5, 19);
         this.lbxCustomers.Name = "lbxCustomers";
         this.lbxCustomers.Size = new System.Drawing.Size(312, 173);
         this.lbxCustomers.TabIndex = 8;
         // 
         // grbProduct
         // 
         this.grbProduct.Controls.Add(this.lbxProducts);
         this.grbProduct.Location = new System.Drawing.Point(42, 301);
         this.grbProduct.Name = "grbProduct";
         this.grbProduct.Size = new System.Drawing.Size(323, 202);
         this.grbProduct.TabIndex = 9;
         this.grbProduct.TabStop = false;
         this.grbProduct.Text = "Select a Product";
         // 
         // gbxUsers
         // 
         this.gbxUsers.Controls.Add(this.lbxCustomers);
         this.gbxUsers.Location = new System.Drawing.Point(431, 306);
         this.gbxUsers.Name = "gbxUsers";
         this.gbxUsers.Size = new System.Drawing.Size(323, 197);
         this.gbxUsers.TabIndex = 10;
         this.gbxUsers.TabStop = false;
         this.gbxUsers.Text = "Select an User";
         // 
         // dtpArrival
         // 
         this.dtpArrival.Format = Mobilize.Web.DateTimePickerFormat.Short;
         this.dtpArrival.Location = new System.Drawing.Point(636, 69);
         this.dtpArrival.Name = "dtpArrival";
         this.dtpArrival.Size = new System.Drawing.Size(87, 20);
         this.dtpArrival.TabIndex = 12;
         // 
         // lb
         // 
         this.lb.AutoSize = true;
         this.lb.Location = new System.Drawing.Point(568, 74);
         this.lb.Name = "lb";
         this.lb.Size = new System.Drawing.Size(62, 13);
         this.lb.TabIndex = 11;
         this.lb.Text = "Arrival Date";
         // 
         // lblStaff
         // 
         this.lblStaff.AutoSize = true;
         this.lblStaff.Location = new System.Drawing.Point(39, 143);
         this.lblStaff.Name = "lblStaff";
         this.lblStaff.Size = new System.Drawing.Size(72, 13);
         this.lblStaff.TabIndex = 13;
         this.lblStaff.Text = "Processed By";
         // 
         // cboStaff
         // 
         this.cboStaff.DropDownStyle = Mobilize.Web.ComboBoxStyle.DropDownList;
         this.cboStaff.Properties().FormattingEnabled = true;
         this.cboStaff.Location = new System.Drawing.Point(131, 140);
         this.cboStaff.Name = "cboStaff";
         this.cboStaff.Size = new System.Drawing.Size(183, 21);
         this.cboStaff.TabIndex = 14;
         // 
         // cboStore
         // 
         this.cboStore.DropDownStyle = Mobilize.Web.ComboBoxStyle.DropDownList;
         this.cboStore.Properties().FormattingEnabled = true;
         this.cboStore.Location = new System.Drawing.Point(489, 140);
         this.cboStore.Name = "cboStore";
         this.cboStore.Size = new System.Drawing.Size(183, 21);
         this.cboStore.TabIndex = 16;
         // 
         // lblStore
         // 
         this.lblStore.AutoSize = true;
         this.lblStore.Location = new System.Drawing.Point(433, 143);
         this.lblStore.Name = "lblStore";
         this.lblStore.Size = new System.Drawing.Size(32, 13);
         this.lblStore.TabIndex = 15;
         this.lblStore.Text = "Store";
         // 
         // pnlOrder
         // 
         this.pnlOrder.Controls.Add(this.numPrice);
         this.pnlOrder.Controls.Add(this.numDiscount);
         this.pnlOrder.Controls.Add(this.lblDiscount);
         this.pnlOrder.Controls.Add(this.lblPrice);
         this.pnlOrder.Controls.Add(this.numQuantity);
         this.pnlOrder.Controls.Add(this.lblQuantity);
         this.pnlOrder.Controls.Add(this.lblOrderN);
         this.pnlOrder.Controls.Add(this.lblOrderDate);
         this.pnlOrder.Controls.Add(this.cboStore);
         this.pnlOrder.Controls.Add(this.dtpOrder);
         this.pnlOrder.Controls.Add(this.lblStore);
         this.pnlOrder.Controls.Add(this.txtOrder);
         this.pnlOrder.Controls.Add(this.cboStaff);
         this.pnlOrder.Controls.Add(this.lbsShipDate);
         this.pnlOrder.Controls.Add(this.lblStaff);
         this.pnlOrder.Controls.Add(this.dtpShipping);
         this.pnlOrder.Controls.Add(this.dtpArrival);
         this.pnlOrder.Controls.Add(this.grbProduct);
         this.pnlOrder.Controls.Add(this.lb);
         this.pnlOrder.Controls.Add(this.gbxUsers);
         this.pnlOrder.Enabled = false;
         this.pnlOrder.Location = new System.Drawing.Point(12, 12);
         this.pnlOrder.Name = "pnlOrder";
         this.pnlOrder.Size = new System.Drawing.Size(781, 546);
         this.pnlOrder.TabIndex = 17;
         // 
         // numPrice
         // 
         this.numPrice.DecimalPlaces = 2;
         this.numPrice.Enabled = false;
         this.numPrice.Location = new System.Drawing.Point(351, 227);
         this.numPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
         this.numPrice.Name = "numPrice";
         this.numPrice.Size = new System.Drawing.Size(73, 20);
         this.numPrice.TabIndex = 23;
         this.numPrice.Properties().TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // numDiscount
         // 
         this.numDiscount.Location = new System.Drawing.Point(638, 227);
         this.numDiscount.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
         this.numDiscount.Name = "numDiscount";
         this.numDiscount.Size = new System.Drawing.Size(73, 20);
         this.numDiscount.TabIndex = 22;
         this.numDiscount.Properties().TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.numDiscount.ValueChanged += new System.EventHandler(this.NumericUpDownValueChanged);
         // 
         // lblDiscount
         // 
         this.lblDiscount.AutoSize = true;
         this.lblDiscount.Location = new System.Drawing.Point(559, 229);
         this.lblDiscount.Name = "lblDiscount";
         this.lblDiscount.Size = new System.Drawing.Size(49, 13);
         this.lblDiscount.TabIndex = 21;
         this.lblDiscount.Text = "Discount";
         // 
         // lblPrice
         // 
         this.lblPrice.AutoSize = true;
         this.lblPrice.Location = new System.Drawing.Point(276, 229);
         this.lblPrice.Name = "lblPrice";
         this.lblPrice.Size = new System.Drawing.Size(31, 13);
         this.lblPrice.TabIndex = 19;
         this.lblPrice.Text = "Price";
         // 
         // numQuantity
         // 
         this.numQuantity.DecimalPlaces = 2;
         this.numQuantity.Location = new System.Drawing.Point(122, 227);
         this.numQuantity.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
         this.numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
         this.numQuantity.Name = "numQuantity";
         this.numQuantity.Size = new System.Drawing.Size(73, 20);
         this.numQuantity.TabIndex = 18;
         this.numQuantity.Properties().TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
         this.numQuantity.ValueChanged += new System.EventHandler(this.NumericUpDownValueChanged);
         // 
         // lblQuantity
         // 
         this.lblQuantity.AutoSize = true;
         this.lblQuantity.Location = new System.Drawing.Point(33, 229);
         this.lblQuantity.Name = "lblQuantity";
         this.lblQuantity.Size = new System.Drawing.Size(46, 13);
         this.lblQuantity.TabIndex = 17;
         this.lblQuantity.Text = "Quantity";
         // 
         // btnPlaceOrder
         // 
         this.btnPlaceOrder.Location = new System.Drawing.Point(347, 592);
         this.btnPlaceOrder.Name = "btnPlaceOrder";
         this.btnPlaceOrder.Size = new System.Drawing.Size(103, 23);
         this.btnPlaceOrder.TabIndex = 18;
         this.btnPlaceOrder.Text = "Place New Order";
         this.btnPlaceOrder.UseVisualStyleBackColor = true;
         this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
         // 
         // ucOkCancel2
         // 
         this.ucOkCancel1.BackColor = System.Drawing.Color.White;
         this.ucOkCancel1.CancelButtonText = "Cancel";
         this.ucOkCancel1.Location = new System.Drawing.Point(502, 576);
         this.ucOkCancel1.Name = "ucOkCancel2";
         this.ucOkCancel1.OkButtonText = "Ok";
         this.ucOkCancel1.Size = new System.Drawing.Size(291, 52);
         this.ucOkCancel1.TabIndex = 19;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(816, 652);
         this.Controls.Add(this.ucOkCancel1);
         this.Controls.Add(this.btnPlaceOrder);
         this.Controls.Add(this.pnlOrder);
         this.Name = "frmOrders";
         this.Text = "Orders";
         this.Load += new System.EventHandler(this.frmOrders_Load);
         this.Controls.SetChildIndex(this.pnlOrder, 0);
         this.Controls.SetChildIndex(this.btnPlaceOrder, 0);
         this.Controls.SetChildIndex(this.ucOkCancel1, 0);
         this.grbProduct.ResumeLayout(false);
         this.gbxUsers.ResumeLayout(false);
         this.pnlOrder.ResumeLayout(false);
         this.pnlOrder.PerformLayout();
         this.ResumeLayout(false);
      }
#endregion

      [Intercepted]
      private Mobilize.Web.ListBox lbxProducts { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblOrderDate { get; set; }

      [Intercepted]
      private Mobilize.Web.DateTimePicker dtpOrder { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblOrderN { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox txtOrder { get; set; }

      [Intercepted]
      private Mobilize.Web.DateTimePicker dtpShipping { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lbsShipDate { get; set; }

      [Intercepted]
      private Mobilize.Web.ListBox lbxCustomers { get; set; }

      [Intercepted]
      private Mobilize.Web.GroupBox grbProduct { get; set; }

      [Intercepted]
      private Mobilize.Web.GroupBox gbxUsers { get; set; }

      [Intercepted]
      private Mobilize.Web.DateTimePicker dtpArrival { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lb { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblStaff { get; set; }

      [Intercepted]
      private Mobilize.Web.ComboBox cboStaff { get; set; }

      [Intercepted]
      private Mobilize.Web.ComboBox cboStore { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblStore { get; set; }

      [Intercepted]
      private Mobilize.Web.Panel pnlOrder { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnPlaceOrder { get; set; }

      [Intercepted]
      private Mobilize.Web.NumericUpDown numQuantity { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblQuantity { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblPrice { get; set; }

      [Intercepted]
      private Mobilize.Web.Label lblDiscount { get; set; }

      [Intercepted]
      private Mobilize.Web.NumericUpDown numDiscount { get; set; }

      [Intercepted]
      private Mobilize.Web.NumericUpDown numPrice { get; set; }

      [Intercepted]
      private ucOkCancel ucOkCancel1 { get; set; }

   }

}