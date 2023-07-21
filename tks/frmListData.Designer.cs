using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TKS
{

   partial class frmListData
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
         this.lbxData = new Mobilize.Web.ListBox();
         this.btnSelect = new Mobilize.Web.Button();
         this.btnClose = new Mobilize.Web.Button();
         this.SuspendLayout();
         // 
         // lbxData
         // 
         this.lbxData.Properties().FormattingEnabled = true;
         this.lbxData.Location = new System.Drawing.Point(12, 12);
         this.lbxData.Name = "lbxData";
         this.lbxData.Size = new System.Drawing.Size(206, 251);
         this.lbxData.TabIndex = 0;
         // 
         // btnSelect
         // 
         this.btnSelect.Location = new System.Drawing.Point(22, 282);
         this.btnSelect.Name = "btnSelect";
         this.btnSelect.Size = new System.Drawing.Size(75, 23);
         this.btnSelect.TabIndex = 1;
         this.btnSelect.Text = "Select Value";
         this.btnSelect.UseVisualStyleBackColor = true;
         this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
         // 
         // btnClose
         // 
         this.btnClose.Location = new System.Drawing.Point(129, 282);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(75, 23);
         this.btnClose.TabIndex = 2;
         this.btnClose.Text = "Close";
         this.btnClose.UseVisualStyleBackColor = true;
         this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(230, 317);
         this.Controls.Add(this.btnClose);
         this.Controls.Add(this.btnSelect);
         this.Controls.Add(this.lbxData);
         this.Name = "frmListData";
         this.Text = "Pick Data";
         this.ResumeLayout(false);
      }
#endregion

      [Intercepted]
      private Mobilize.Web.ListBox lbxData { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnSelect { get; set; }

      [Intercepted]
      private Mobilize.Web.Button btnClose { get; set; }

   }

}