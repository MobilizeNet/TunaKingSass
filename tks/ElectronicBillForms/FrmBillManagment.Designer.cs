using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TKS.ElectronicBillForms
{

   partial class FrmBillManagment
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
         this.panel1 = new Mobilize.Web.Panel();
         this.btnCancel = new Mobilize.Web.Button();
         this.btnNext = new Mobilize.Web.Button();
         this.btnBack = new Mobilize.Web.Button();
         this.pnlContent = new Mobilize.Web.Panel();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.btnCancel);
         this.panel1.Controls.Add(this.btnNext);
         this.panel1.Controls.Add(this.btnBack);
         this.panel1.Dock = Mobilize.Web.DockStyle.Bottom;
         this.panel1.Location = new System.Drawing.Point(0, 556);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(1006, 65);
         this.panel1.TabIndex = 0;
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(555, 12);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(182, 41);
         this.btnCancel.TabIndex = 2;
         this.btnCancel.Text = "Process payment";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnNext
         // 
         this.btnNext.Location = new System.Drawing.Point(406, 12);
         this.btnNext.Name = "btnNext";
         this.btnNext.Size = new System.Drawing.Size(108, 41);
         this.btnNext.TabIndex = 1;
         this.btnNext.Text = "Next >";
         this.btnNext.UseVisualStyleBackColor = true;
         this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
         // 
         // btnBack
         // 
         this.btnBack.Location = new System.Drawing.Point(275, 12);
         this.btnBack.Name = "btnBack";
         this.btnBack.Size = new System.Drawing.Size(91, 41);
         this.btnBack.TabIndex = 0;
         this.btnBack.Text = "< Back";
         this.btnBack.UseVisualStyleBackColor = true;
         this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
         // 
         // pnlContent
         // 
         this.pnlContent.Dock = Mobilize.Web.DockStyle.Fill;
         this.pnlContent.Location = new System.Drawing.Point(0, 0);
         this.pnlContent.Name = "pnlContent";
         this.pnlContent.Size = new System.Drawing.Size(1006, 556);
         this.pnlContent.TabIndex = 2;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1006, 621);
         this.Controls.Add(this.pnlContent);
         this.Controls.Add(this.panel1);
         this.Name = "FrmBillManagment";
         this.Text = "FrmBillManagment";
         this.Load += new System.EventHandler(this.FrmBillManagment_Load);
         this.panel1.ResumeLayout(false);
         this.ResumeLayout(false);
      }
#endregion

      [Intercepted]
      private Mobilize.Web.Panel panel1 { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnCancel { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnNext { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnBack { get; set; }

      [Intercepted]
      private Mobilize.Web.Panel pnlContent { get; set; }

   }

}