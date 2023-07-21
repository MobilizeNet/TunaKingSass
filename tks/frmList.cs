using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilize.WebMap.Common.Attributes;

namespace TKS
{

   [Observable]
   public partial class frmList
      : Mobilize.Web.Form
   {

      public frmList()
      {
         InitializeComponent();
      }

      [Intercepted]
      public DataTable Customers { get; set; }

      [Intercepted]
      public DataTable Products { get; set; }

      [Intercepted]
      public DataTable Users { get; set; }

      [Intercepted]
      public DataTable Orders { get; set; }

      private void CustomerList_Load(object sender, EventArgs e)
      {
         var dataHandler = new TKS_DB.DataHandler();
         this.Customers = dataHandler.GetDataTableSource(@"customer_id as 'Id',
                  first_name as 'First Name',
                  last_name as 'Last Name',
                  phone as 'Phone',
                  email as 'E-mail',
                  street as 'Street',
                  city as 'City',
                  state as 'State',
                  zip_code as 'Zip Code'", "sales.customers");
         this.Products = dataHandler.GetDataTableSource(@"product_id as 'Id',
                  product_name as 'Name',
                  model_year as 'Model Year',
                  list_price as 'Price'", "production.products");
         this.Users = dataHandler.GetDataTableSource(@"user_id as 'Id',
                user_roles as 'Role',
                user_email as 'E-mail'", "roles.users");
         this.Orders = dataHandler.GetDataTableSource(@"order_id as 'Id',
                customer_id as 'Customer ID',
                order_status as 'Order Status',
                order_date as 'Order Date',
                required_date as 'Required Date',
                shipped_date as 'Shipping Date',
                store_id as 'Store Id',
                staff_id as 'Staff Id'", "sales.orders");
         this.SetupInitialView();
      }

      private void SetupGrid(DataTable dataTable, Mobilize.Web.DataGridView grid, bool hideId = true, bool adjustColumn = false, bool ClickOrder = false)
      {
         grid.DataSource = dataTable.DefaultView;
         if ( ClickOrder )
         {
            grid.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid.Columns[4].DefaultCellStyle.Format = "MM/dd/yyyy";
            grid.Columns[5].DefaultCellStyle.Format = "MM/dd/yyyy";
         }
         if ( hideId )
         {
            grid.Columns[0].Visible = false;
         }
         if ( adjustColumn )
         {
            grid.Columns[1].Width = 250;
         }
      }

      private void tabDatList_SelectedIndexChanged(object sender, EventArgs e)
      {
         switch ( ((Mobilize.Web.TabControl)sender).SelectedIndex )
         {
            case 0:
               this.SetupInitialView();
               break;
            case 1:
               this.Text = "Customers";
               this.SetupGrid(this.Customers, this.grdCustomers);
               break;
            case 2:
               this.Text = "Users";
               this.SetupGrid(this.Users, this.grdUsers, hideId: false);
               break;
            case 3:
               this.Text = "Orders";
               this.SetupGrid(this.Orders, this.grdOrders, hideId: false, ClickOrder: true);
               break;
         }
      }

      private void SetupInitialView()
      {
         this.Text = "Products";
         this.SetupGrid(this.Products, this.grdProducts, adjustColumn: true);
      }

      private void grdOrders_CellContentClick(object sender, Mobilize.Web.DataGridViewCellEventArgs e)
      {
      }

   }

}