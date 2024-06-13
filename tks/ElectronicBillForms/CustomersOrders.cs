using System;
using System.Collections;
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

namespace TKS.ElectronicBillForms
{

   [Observable]
   public partial class CustomersOrders
      : Mobilize.Web.Form
   {

      [Intercepted]
      public DataTable Customers { get; set; }

      [Intercepted]
      public DataTable Products { get; set; }

      [Intercepted]
      public DataTable Orders { get; set; }

      [Intercepted]
      public DataTable OrderItem { get; set; }

      [Intercepted]
      public DataTable product { get; set; }

      [Intercepted]
      public DataHandler DataHandler { get; set; } = new DataHandler();

      [Intercepted]
      private List<string> officesArray { get; set; } = new List<string>
      {
         "Production Store",
         "Supply Store",
         "Buy Store",
         "Sell Store"
      }
      ;

      [Intercepted]
      private List<string> economicActivity { get; set; } = new List<string>
      {
         "Producing",
         "Suplying",
         "Buying",
         "Selling"
      }
      ;

      [Intercepted]
      private List<int> srlNumbr { get; set; } = new List<int>
      {
         525151,
         242624,
         4558445,
         158142,
         25564812
      }
      ;

      [Intercepted]
      private List<int> consec { get; set; } = new List<int>
      {
         23445,
         6656,
         7678,
         345,
         67
      }
      ;

      [Intercepted]
      private ArrayList billList { get; set; } = new ArrayList();

      [Intercepted]
      private List<string> orderList { get; set; } = new List<string>
      {
      };

      [Intercepted]
      private Dictionary<string, double> paymentDiscounts { get; set; } = new Dictionary<string, double>
      {
         { "card", 0.03 },
         { "checkBank", 0.15 },
         { "cash", 0.30 },
         { "deposit", 0.8 }
      }
      ;

      [Intercepted]
      private string paymentSel { get; set; } = "";


      public CustomersOrders()
      {
         InitializeComponent();
      }

      private void CustomersOrders_Load(object sender, EventArgs e)
      {
         this.Customers = DataHandler.GetDataSource("customer_id", "concat(first_name,' ', last_name) as fullName", "sales.customers", true);
         UiCommons.LoadComboSource("customer_id", "fullName", this.comboBox3, this.Customers);
         this.comboBox1.DataSource = officesArray;
         this.comboBox2.DataSource = srlNumbr;
         this.textBox1.Text = this.economicActivity[0].ToString();
         this.textBox4.Text = this.srlNumbr[0].ToString();
      }

      private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
      {
         var combobx = sender as Mobilize.Web.ComboBox;
         var indx = combobx.SelectedIndex;
         string obj = this.officesArray[indx];
         this.textBox1.Text = this.economicActivity[indx];
         this.textBox1.Visible = true;
         var j = billList.Count;
         billList.Add(obj);
      }

      private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
      {
         var combobx = sender as Mobilize.Web.ComboBox;
         var indx = combobx.SelectedIndex;
         var obj = this.srlNumbr[indx];
         this.textBox4.Text = this.consec[indx].ToString();
         this.textBox4.Visible = true;
         billList.Add(obj);
      }

      private void textBox5_TextChanged(object sender, EventArgs e)
      {
         var txtBx = sender as Mobilize.Web.TextBox;
         if ( txtBx.Text.Length > 30 )
         {
            this.label8.Text = "Name is too long";
            this.label8.Visible = true;
         }
         else
         {
            this.label8.Visible = false;
         }
      }

      private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
      {
         var combobx = sender as Mobilize.Web.ComboBox;
         var indx = combobx.SelectedValue;
         this.Orders = DataHandler.GetDataTableSourceCondition(@"order_id as 'Id',
                customer_id as 'Customer ID',
                order_status as 'Order Status'", "sales.orders", "customer_id = " + String.Format("'{0}'", indx));
         this.orderList.Clear();
         string value = "";
         foreach ( DataRow item in this.Orders.Rows )
         {
            var id = item.ItemArray[0];
            var orderId = "  Order id: " + id;
            value += orderId;
            var order = new Order();
            order.Id = Convert.ToInt32(id);
            this.orderList.Add(id.ToString());
         }
         textBox2.Text = value;
      }

      private void button1_Click(object sender, EventArgs e)
      {
         if ( this.orderList.Count > 0 )
         {
            this.orderList.RemoveAt(this.orderList.Count - 1);
            string value = "";
            var count = this.orderList.Count;
            for ( int i = 0; i < count; i++ )
            {
               var id = this.orderList[i];
               value += "  Order id: " + id;
            }
            textBox2.Text = value;
         }
      }

      private void button2_Click(object sender, EventArgs e)
      {
         double price = 0;
         foreach ( var item in this.orderList )
         {
            this.Orders = DataHandler.GetDataTableSourceCondition(@" list_price as 'price'", "sales.order_items", "order_id = " + String.Format("'{0}'", item.ToString()));
            var prflag = this.Orders.Rows;
            foreach ( DataRow orderItem in prflag )
            {
               price += Double.Parse(orderItem.ItemArray[0].ToString());
            }
         }
         try
         {
            this.paymentDiscounts.TryGetValue(paymentSel, out double doub);
            price = price - price * doub;
         }
         catch( Exception )
         {
         }
         this.textBox3.Text = price.ToString();
      }

      private void radioButton2_CheckedChanged(object sender, EventArgs e)
      {
         this.paymentSel = "card";
      }

      private void radioButton4_CheckedChanged(object sender, EventArgs e)
      {
         this.paymentSel = "checkBank";
      }

      private void radioButton1_CheckedChanged(object sender, EventArgs e)
      {
         this.paymentSel = "cash";
      }

      private void radioButton3_CheckedChanged(object sender, EventArgs e)
      {
         this.paymentSel = "deposit";
      }

   }

}