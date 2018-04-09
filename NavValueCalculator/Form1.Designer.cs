namespace NavValueCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Spendofday = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_buyPrice = new System.Windows.Forms.TextBox();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.txt_actualsalevalue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_minimumSellingvalue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Buy Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Spend of day";
            // 
            // txt_Spendofday
            // 
            this.txt_Spendofday.Location = new System.Drawing.Point(178, 68);
            this.txt_Spendofday.Name = "txt_Spendofday";
            this.txt_Spendofday.Size = new System.Drawing.Size(129, 20);
            this.txt_Spendofday.TabIndex = 4;
            this.txt_Spendofday.Text = "1";
            this.txt_Spendofday.TextChanged += new System.EventHandler(this.txt_Spendofday_TextChanged);
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(178, 106);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(129, 20);
            this.txt_qty.TabIndex = 5;
            this.txt_qty.Text = "1";
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            // 
            // txt_buyPrice
            // 
            this.txt_buyPrice.Location = new System.Drawing.Point(178, 144);
            this.txt_buyPrice.Name = "txt_buyPrice";
            this.txt_buyPrice.Size = new System.Drawing.Size(129, 20);
            this.txt_buyPrice.TabIndex = 6;
            this.txt_buyPrice.Text = "1";
            this.txt_buyPrice.TextChanged += new System.EventHandler(this.txt_buyPrice_TextChanged);
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(178, 185);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(129, 20);
            this.txt_value.TabIndex = 7;
            this.txt_value.Text = "1";
            this.txt_value.TextChanged += new System.EventHandler(this.txt_value_TextChanged);
            // 
            // txt_actualsalevalue
            // 
            this.txt_actualsalevalue.Location = new System.Drawing.Point(178, 245);
            this.txt_actualsalevalue.Name = "txt_actualsalevalue";
            this.txt_actualsalevalue.Size = new System.Drawing.Size(129, 20);
            this.txt_actualsalevalue.TabIndex = 10;
            this.txt_actualsalevalue.Text = "1";
            this.txt_actualsalevalue.TextChanged += new System.EventHandler(this.txt_actualsalevalue_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Actual Purchase value";
            // 
            // txt_minimumSellingvalue
            // 
            this.txt_minimumSellingvalue.Location = new System.Drawing.Point(178, 287);
            this.txt_minimumSellingvalue.Name = "txt_minimumSellingvalue";
            this.txt_minimumSellingvalue.Size = new System.Drawing.Size(129, 20);
            this.txt_minimumSellingvalue.TabIndex = 12;
            this.txt_minimumSellingvalue.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Minimum Selling value";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 46);
            this.button1.TabIndex = 13;
            this.button1.Text = "ReCalculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_minimumSellingvalue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_actualsalevalue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.txt_buyPrice);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_Spendofday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Spendofday;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_buyPrice;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.TextBox txt_actualsalevalue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_minimumSellingvalue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

