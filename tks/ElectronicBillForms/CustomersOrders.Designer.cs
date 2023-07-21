using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace TKS.ElectronicBillForms
{

   partial class CustomersOrders
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
         this.label1 = new Mobilize.Web.Label();
         this.textBox2 = new Mobilize.Web.TextBox();
         this.label3 = new Mobilize.Web.Label();
         this.button1 = new Mobilize.Web.Button();
         this.comboBox1 = new Mobilize.Web.ComboBox();
         this.label4 = new Mobilize.Web.Label();
         this.textBox1 = new Mobilize.Web.TextBox();
         this.label5 = new Mobilize.Web.Label();
         this.comboBox2 = new Mobilize.Web.ComboBox();
         this.textBox4 = new Mobilize.Web.TextBox();
         this.label6 = new Mobilize.Web.Label();
         this.label7 = new Mobilize.Web.Label();
         this.textBox5 = new Mobilize.Web.TextBox();
         this.label8 = new Mobilize.Web.Label();
         this.label9 = new Mobilize.Web.Label();
         this.comboBox3 = new Mobilize.Web.ComboBox();
         this.button2 = new Mobilize.Web.Button();
         this.label2 = new Mobilize.Web.Label();
         this.groupBox1 = new Mobilize.Web.GroupBox();
         this.radioButton4 = new Mobilize.Web.RadioButton();
         this.radioButton3 = new Mobilize.Web.RadioButton();
         this.radioButton2 = new Mobilize.Web.RadioButton();
         this.radioButton1 = new Mobilize.Web.RadioButton();
         this.textBox3 = new Mobilize.Web.TextBox();
         this.label10 = new Mobilize.Web.Label();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(303, 30);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(91, 17);
         this.label1.TabIndex = 3;
         this.label1.Text = "Electronic bill";
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(12, 315);
         this.textBox2.Multiline = true;
         this.textBox2.Name = "textBox2";
         this.textBox2.ReadOnly = true;
         this.textBox2.Size = new System.Drawing.Size(352, 117);
         this.textBox2.TabIndex = 6;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(12, 96);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(52, 17);
         this.label3.TabIndex = 7;
         this.label3.Text = "Offices";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(139, 438);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 9;
         this.button1.Text = "Remove";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // comboBox1
         // 
         this.comboBox1.Properties().FormattingEnabled = true;
         this.comboBox1.Location = new System.Drawing.Point(139, 89);
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(140, 24);
         this.comboBox1.TabIndex = 12;
         this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(392, 96);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(117, 17);
         this.label4.TabIndex = 15;
         this.label4.Text = "Economic Activity";
         // 
         // textBox1
         // 
         this.textBox1.AcceptsTab = true;
         this.textBox1.Location = new System.Drawing.Point(561, 93);
         this.textBox1.Name = "textBox1";
         this.textBox1.ReadOnly = true;
         this.textBox1.Size = new System.Drawing.Size(100, 22);
         this.textBox1.TabIndex = 16;
         this.textBox1.Text = "Producing";
         this.textBox1.Visible = false;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(12, 142);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(98, 17);
         this.label5.TabIndex = 17;
         this.label5.Text = "SerialNumber:";
         // 
         // comboBox2
         // 
         this.comboBox2.Properties().FormattingEnabled = true;
         this.comboBox2.Location = new System.Drawing.Point(139, 135);
         this.comboBox2.Name = "comboBox2";
         this.comboBox2.Size = new System.Drawing.Size(140, 24);
         this.comboBox2.TabIndex = 18;
         this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
         // 
         // textBox4
         // 
         this.textBox4.AcceptsTab = true;
         this.textBox4.Location = new System.Drawing.Point(561, 135);
         this.textBox4.Name = "textBox4";
         this.textBox4.ReadOnly = true;
         this.textBox4.Size = new System.Drawing.Size(100, 22);
         this.textBox4.TabIndex = 20;
         this.textBox4.Text = "525151";
         this.textBox4.Visible = false;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(392, 135);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(137, 17);
         this.label6.TabIndex = 19;
         this.label6.Text = "Consecutive number";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(12, 187);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(111, 17);
         this.label7.TabIndex = 21;
         this.label7.Text = "Comercial Name";
         // 
         // textBox5
         // 
         this.textBox5.Location = new System.Drawing.Point(139, 187);
         this.textBox5.Name = "textBox5";
         this.textBox5.Size = new System.Drawing.Size(140, 22);
         this.textBox5.TabIndex = 22;
         this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(285, 187);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(46, 17);
         this.label8.TabIndex = 23;
         this.label8.Text = "label8";
         this.label8.Visible = false;
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(12, 230);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(111, 17);
         this.label9.TabIndex = 24;
         this.label9.Text = "Select Customer";
         // 
         // comboBox3
         // 
         this.comboBox3.Properties().FormattingEnabled = true;
         this.comboBox3.Location = new System.Drawing.Point(139, 227);
         this.comboBox3.Name = "comboBox3";
         this.comboBox3.Size = new System.Drawing.Size(140, 24);
         this.comboBox3.TabIndex = 25;
         this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(664, 350);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(84, 52);
         this.button2.TabIndex = 26;
         this.button2.Text = "Get price";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(147, 282);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(67, 17);
         this.label2.TabIndex = 27;
         this.label2.Text = "ORDERS";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.radioButton4);
         this.groupBox1.Controls.Add(this.radioButton3);
         this.groupBox1.Controls.Add(this.radioButton2);
         this.groupBox1.Controls.Add(this.radioButton1);
         this.groupBox1.Location = new System.Drawing.Point(395, 230);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(402, 86);
         this.groupBox1.TabIndex = 29;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Type of payment";
         // 
         // radioButton4
         // 
         this.radioButton4.AutoSize = true;
         this.radioButton4.Location = new System.Drawing.Point(269, 37);
         this.radioButton4.Name = "radioButton4";
         this.radioButton4.Size = new System.Drawing.Size(103, 21);
         this.radioButton4.TabIndex = 3;
         this.radioButton4.TabStop = true;
         this.radioButton4.Text = "Check bank";
         this.radioButton4.UseVisualStyleBackColor = true;
         this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
         // 
         // radioButton3
         // 
         this.radioButton3.AutoSize = true;
         this.radioButton3.Location = new System.Drawing.Point(186, 37);
         this.radioButton3.Name = "radioButton3";
         this.radioButton3.Size = new System.Drawing.Size(77, 21);
         this.radioButton3.TabIndex = 2;
         this.radioButton3.TabStop = true;
         this.radioButton3.Text = "Deposit";
         this.radioButton3.UseVisualStyleBackColor = true;
         this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
         // 
         // radioButton2
         // 
         this.radioButton2.AutoSize = true;
         this.radioButton2.Location = new System.Drawing.Point(82, 37);
         this.radioButton2.Name = "radioButton2";
         this.radioButton2.Size = new System.Drawing.Size(98, 21);
         this.radioButton2.TabIndex = 1;
         this.radioButton2.TabStop = true;
         this.radioButton2.Text = "Credit card";
         this.radioButton2.UseVisualStyleBackColor = true;
         this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
         // 
         // radioButton1
         // 
         this.radioButton1.AutoSize = true;
         this.radioButton1.Location = new System.Drawing.Point(15, 37);
         this.radioButton1.Name = "radioButton1";
         this.radioButton1.Size = new System.Drawing.Size(61, 21);
         this.radioButton1.TabIndex = 0;
         this.radioButton1.TabStop = true;
         this.radioButton1.Text = "Cash";
         this.radioButton1.UseVisualStyleBackColor = true;
         this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
         // 
         // textBox3
         // 
         this.textBox3.Location = new System.Drawing.Point(544, 377);
         this.textBox3.Name = "textBox3";
         this.textBox3.Size = new System.Drawing.Size(100, 22);
         this.textBox3.TabIndex = 31;
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(461, 382);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(48, 17);
         this.label10.TabIndex = 32;
         this.label10.Text = "PRICE";
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.ClientSize = new System.Drawing.Size(809, 503);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.textBox3);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.comboBox3);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.textBox5);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.textBox4);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.comboBox2);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.comboBox1);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.None;
         this.Name = "CustomersOrders";
         this.Text = "CustomersOrders";
         this.Load += new System.EventHandler(this.CustomersOrders_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();
      }
#endregion

      [Intercepted]
      private Mobilize.Web.Label label1 { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox textBox2 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label3 { get; set; }

      [Intercepted]
      private Mobilize.Web.Button button1 { get; set; }

      [Intercepted]
      private Mobilize.Web.ComboBox comboBox1 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label4 { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox textBox1 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label5 { get; set; }

      [Intercepted]
      private Mobilize.Web.ComboBox comboBox2 { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox textBox4 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label6 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label7 { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox textBox5 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label8 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label9 { get; set; }

      [Intercepted]
      private Mobilize.Web.ComboBox comboBox3 { get; set; }

      [Intercepted]
      private Mobilize.Web.Button button2 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label2 { get; set; }

      [Intercepted]
      private Mobilize.Web.GroupBox groupBox1 { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox textBox3 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label label10 { get; set; }

      [Intercepted]
      private Mobilize.Web.RadioButton radioButton4 { get; set; }

      [Intercepted]
      private Mobilize.Web.RadioButton radioButton3 { get; set; }

      [Intercepted]
      private Mobilize.Web.RadioButton radioButton2 { get; set; }

      [Intercepted]
      private Mobilize.Web.RadioButton radioButton1 { get; set; }

   }

}