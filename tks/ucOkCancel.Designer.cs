using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TKS
{

   partial class ucOkCancel
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
         this.btnOk = new Mobilize.Web.Button();
         this.btnCancel = new Mobilize.Web.Button();
         this.SuspendLayout();
         // 
         // btnOk
         // 
         this.btnOk.Location = new System.Drawing.Point(25, 15);
         this.btnOk.Name = "btnOk";
         this.btnOk.Size = new System.Drawing.Size(75, 23);
         this.btnOk.TabIndex = 0;
         this.btnOk.Text = "Ok";
         this.btnOk.UseVisualStyleBackColor = true;
         this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Location = new System.Drawing.Point(182, 15);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 1;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnOk);
         this.Name = "ucOkCancel";
         this.Size = new System.Drawing.Size(291, 52);
         this.ResumeLayout(false);
      }
#endregion

      [Intercepted]
      private Mobilize.Web.Button btnCancel { get; set; }

      [Intercepted]
      public Mobilize.Web.Button btnOk { get; set; }

   }

}