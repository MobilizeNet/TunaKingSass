using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TKS_DB;
using TKS_Models;
using Mobilize.WebMap.Common.Attributes;

namespace TKS
{

   [Observable]
   public partial class frmProduct
      : Mobilize.Web.Form
   {

      public frmProduct()
      {
         InitializeComponent();
      }

      [Intercepted]
      public DataTable Categories { get; set; }

      [Intercepted]
      private DataTable Brands { get; set; }

      [Intercepted]
      private frmListData DataForm { get; set; }

      [Intercepted]
      private DataHandler DataHandler { get; } = new DataHandler();

      [Intercepted]
      private bool ShouldClose { get; set; }

      private void btnSave_Click(object sender, EventArgs e)
      {
         this.ShouldClose = true;
         if ( this.GetValidProduct(out var product) )
         {
            this.DataHandler.CreateNewRegisterInTable("production.products", product);
            Mobilize.Web.MessageBox.Show("Product saved successfully");
            this.Close();
            return ;
         }
         this.ShouldClose = false;
         Mobilize.Web.MessageBox.Show("Please verify all fields are filled");
      }

      private bool GetValidProduct(out Product product)
      {
         if ( IsValidProduct() )
         {
            product = new Product()
               {
                  Name = UiCommons.EmptyToNull(this.txtName.Text), Brand = UiCommons.GetComboValueFromText<int>(this.cboBrand), Category = UiCommons.GetComboValueFromText<int>(this.cboCategory), ModelYear = Convert.ToInt16(this.cboModel.Text), Price = this.numPrice.Value,
               };
            return true;
         }
         product = null;
         return false;
      }

      private bool IsValidProduct()
      {
         return !string.IsNullOrEmpty(this.txtName.Text) && this.cboBrand.SelectedItem != null && this.cboCategory.SelectedItem != null && this.cboModel.SelectedItem != null && this.numPrice.Value != 0M;
      }

      private void button2_Click(object sender, EventArgs e)
      {
         // This code should not be moving to FE.
         this.Close();
      }

      private void frmProduct_FormClosing(object sender, Mobilize.Web.FormClosingEventArgs e)
      {
         // This code should not be moving to FE.
         if ( !this.ShouldClose )
         {
            if ( Mobilize.Web.MessageBox.Show("Are you sure you want to leave without saving?", "Attention Required", Mobilize.Web.MessageBoxButtons.YesNo) == Mobilize.Web.DialogResult.No )
            {
               e.Cancel = true;
            }
         }
      }

      private void frmProduct_Load(object sender, EventArgs e)
      {
         this.LoadBrands();
         this.LoadCategories();
         this.LoadYears();
      }

      private void LoadYears()
      {
         var years = Enumerable.Range(1930, 100).Cast<object>().ToArray();
         this.cboModel.Items.AddRange(years);
         this.cboModel.SelectedItem = DateTime.Now.Year;
      }

      private void lnkBrand_LinkClicked(object sender, Mobilize.Web.LinkLabelLinkClickedEventArgs e)
      {
         this.DataForm = new frmListData();
         this.DataForm.LoadData("brand_id", "brand_name", this.Brands);
         if ( this.DataForm.ShowDialog() == Mobilize.Web.DialogResult.OK )
         {
            this.cboBrand.SelectedIndex = this.DataForm.SelectedIndex;
         }
      }

      private void lnkCategory_LinkClicked(object sender, Mobilize.Web.LinkLabelLinkClickedEventArgs e)
      {
         this.DataForm = new frmListData();
         this.DataForm.LoadData("category_id", "category_name", this.Categories);
         if ( this.DataForm.ShowDialog() == Mobilize.Web.DialogResult.OK )
         {
            this.cboCategory.SelectedIndex = this.DataForm.SelectedIndex;
         }
      }

      private void LoadBrands()
      {
         this.Brands = this.DataHandler.GetDataSource("brand_id", "brand_name", "production.brands");
         this.LoadList("brand_id", "brand_name", this.Brands, this.cboBrand);
      }

      private void LoadCategories()
      {
         this.Categories = this.DataHandler.GetDataSource("category_id", "category_name", "production.categories");
         LoadList("category_id", "category_name", this.Categories, this.cboCategory);
      }

      private void LoadList(string valueMember, string displayMember, DataTable values, Mobilize.Web.ComboBox listCtl)
      {
         listCtl.ValueMember = valueMember;
         listCtl.DisplayMember = displayMember;
         listCtl.DataSource = values;
      }

      private void btnVerify_Click(object sender, EventArgs e)
      {
         if ( !this.IsValidProduct() )
         {
            SetAlert(this.txtName, lblNameAlert);
            SetAlert(this.cboBrand, lblBrandAlert);
            SetAlert(this.cboCategory, lblCategoryAlert);
            SetAlert(this.cboModel, lblModelAlert);
            if ( this.numPrice.Value == 0 )
            {
               this.lblPriceAlert.Visible = true;
            }
            else
            {
               this.lblPriceAlert.Visible = false;
            }
         }
         else
         {
            lblNameAlert.Visible = false;
            lblBrandAlert.Visible = false;
            lblCategoryAlert.Visible = false;
            lblModelAlert.Visible = false;
         }
      }

      private void SetAlert(Mobilize.Web.Control control, Mobilize.Web.Control alertControl)
      {
         if ( string.IsNullOrEmpty(control.Text) )
         {
            alertControl.Visible = true;
         }
         else
         {
            alertControl.Visible = false;
         }
      }

      private void txtName_TextChanged(object sender, EventArgs e)
      {
         var ctrl = sender as Mobilize.Web.Control;
         if ( ctrl != null && !String.IsNullOrEmpty(ctrl.Text) )
         {
            this.lnkBrand.Enabled = true;
            this.lnkCategory.Enabled = true;
         }
         else
         {
            this.lnkBrand.Enabled = false;
            this.lnkCategory.Enabled = false;
         }
      }

   }

}