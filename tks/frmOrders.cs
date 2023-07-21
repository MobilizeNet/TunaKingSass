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

   [Observable]
   public partial class frmOrders
      : frmWhiteForm
   {

      [Intercepted]
      public DataTable Staff { get; set; }

      [Intercepted]
      public DataTable Stores { get; set; }

      [Intercepted]
      public DataTable Customers { get; set; }

      [Intercepted]
      public DataTable Products { get; set; }


      public frmOrders()
      {
         InitializeComponent();
         this.LoadDataSources();
         this.LoadDataControls(this.Staff, this.Stores, this.Products, this.Customers);
      }

      [Intercepted]
      public DataHandler DataHandler { get; set; } = new DataHandler();

      [Intercepted]
      public decimal UnitPrice { get; private set; }

      public void LoadDataSources()
      {
         this.Staff = DataHandler.GetDataSource("staff_id", "concat(first_name,' ', last_name) as fullName", "sales.staffs", true);
         this.Stores = DataHandler.GetDataSource("store_id", "store_name", "sales.stores");
         this.Customers = DataHandler.GetDataSource("customer_id", "concat(first_name,' ', last_name) as fullName", "sales.customers", true);
         this.Products = DataHandler.GetDataSource("product_id", "product_name", "production.products");
      }

      private void LoadDataControls(DataTable staff, DataTable stores, DataTable products, DataTable customers)
      {
         UiCommons.LoadComboSource("staff_id", "fullName", this.cboStaff, staff);
         UiCommons.LoadComboSource("store_id", "store_name", this.cboStore, stores);
         UiCommons.LoadListSource("product_id", "product_name", this.lbxProducts, products);
         UiCommons.LoadListSource("customer_id", "fullName", this.lbxCustomers, customers);
      }

      private void btnPlaceOrder_Click(object sender, EventArgs e)
      {
         this.pnlOrder.Enabled = true;
         this.ucOkCancel1.Enabled = true;
         this.btnPlaceOrder.Enabled = false;
         this.cboStaff.SelectedIndex = 0;
         this.cboStore.SelectedIndex = 0;
         this.lbxCustomers.SelectedIndex = 0;
         this.lbxProducts.SelectedIndex = 0;
      }

      private void ucOkCancel1_OkClick(object sender, EventArgs e)
      {
         if ( this.GetValidOrders(out var order, out var orderItem) )
         {
            this.DataHandler.CreateNewRegisterInTable("sales.orders", order);
            orderItem.OrderId = Convert.ToInt32(this.DataHandler.GetTableIdent("sales.orders"));
            orderItem.Id = Convert.ToInt32(this.DataHandler.GetTableCount("sales.order_items")) + 1;
            this.DataHandler.CreateNewRegisterInTable("sales.order_items", orderItem);
            Mobilize.Web.MessageBox.Show("Order saved successfully");
            this.txtOrder.Text = orderItem.OrderId.ToString();
            this.ucOkCancel1.btnOk.Enabled = false;
            this.pnlOrder.Enabled = false;
            return ;
         }
      }

      private bool GetValidOrders(out Order order, out OrderItem orderItem)
      {
         order = new Order()
            {
               CustomerId = (int)(this.lbxCustomers.SelectedItem as DataRowView)[this.lbxCustomers.ValueMember], OrderStatus = 4, OrderDate = this.dtpOrder.Value.Date, RequiredDate = this.dtpArrival.Value.Date, ShippedDate = this.dtpShipping.Value.Date, StoreId = UiCommons.GetComboValueFromText<int>(this.cboStore), StaffId = UiCommons.GetComboValueFromText<int>(this.cboStaff),
            };
         orderItem = new OrderItem()
            {
               ProductId = (int)(this.lbxProducts.SelectedItem as DataRowView)[this.lbxProducts.ValueMember], Quantity = Convert.ToInt32(this.numQuantity.Value), ListPrice = this.numPrice.Value, Discount = this.numDiscount.Value,
            };
         return true;
      }

      private void ucOkCancel1_Load(object sender, EventArgs e)
      {
         this.ucOkCancel1.Enabled = false;
      }

      private void frmOrders_Load(object sender, EventArgs e)
      {
         this.dtpArrival.Value = DateTime.Now.AddDays(5);
         this.dtpShipping.Value = DateTime.Now.AddDays(1);
      }

      private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
      {
         var productId = (this.lbxProducts.SelectedItem as DataRowView)[this.lbxProducts.ValueMember];
         UnitPrice = this.DataHandler.GetScalarValue<decimal>("list_price", "production.products", "product_id", productId.ToString());
         this.GetFinalPrice();
      }

      private void GetFinalPrice()
      {
         var subTotal = this.UnitPrice * this.numQuantity.Value;
         var total = subTotal - (subTotal * this.numDiscount.Value / 100);
         this.numPrice.Value = total;
      }

      private void NumericUpDownValueChanged(object sender, EventArgs e)
      {
         this.GetFinalPrice();
      }

   }

}