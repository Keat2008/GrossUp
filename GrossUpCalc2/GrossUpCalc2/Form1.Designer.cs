namespace GrossUpCalc2
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FedPer = new System.Windows.Forms.TextBox();
            this.FICASSPer = new System.Windows.Forms.TextBox();
            this.FICAMcarePer = new System.Windows.Forms.TextBox();
            this.StateTaxPer = new System.Windows.Forms.TextBox();
            this.LocalTaxPer = new System.Windows.Forms.TextBox();
            this.k401PrePer = new System.Windows.Forms.TextBox();
            this.NetAMT = new System.Windows.Forms.TextBox();
            this.k401PreAmt = new System.Windows.Forms.TextBox();
            this.LocalTaxAmt = new System.Windows.Forms.TextBox();
            this.StateTaxAmt = new System.Windows.Forms.TextBox();
            this.FICAMcareAmt = new System.Windows.Forms.TextBox();
            this.FICASSAmt = new System.Windows.Forms.TextBox();
            this.FedTaxAmt = new System.Windows.Forms.TextBox();
            this.Gross = new System.Windows.Forms.Label();
            this.GrossAmt = new System.Windows.Forms.TextBox();
            this.Clr = new System.Windows.Forms.Button();
            this.Calc = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gross Up Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Net Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Federal Tax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "401k (Pre Tax)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Local Tax";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "State Tax";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "FICA Medicare Tax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "FICA Soc Sec Tax";
            // 
            // FedPer
            // 
            this.FedPer.Location = new System.Drawing.Point(126, 102);
            this.FedPer.Name = "FedPer";
            this.FedPer.Size = new System.Drawing.Size(100, 20);
            this.FedPer.TabIndex = 1;
            // 
            // FICASSPer
            // 
            this.FICASSPer.Location = new System.Drawing.Point(126, 134);
            this.FICASSPer.Name = "FICASSPer";
            this.FICASSPer.Size = new System.Drawing.Size(100, 20);
            this.FICASSPer.TabIndex = 2;
            // 
            // FICAMcarePer
            // 
            this.FICAMcarePer.Location = new System.Drawing.Point(126, 160);
            this.FICAMcarePer.Name = "FICAMcarePer";
            this.FICAMcarePer.Size = new System.Drawing.Size(100, 20);
            this.FICAMcarePer.TabIndex = 3;
            // 
            // StateTaxPer
            // 
            this.StateTaxPer.Location = new System.Drawing.Point(126, 186);
            this.StateTaxPer.Name = "StateTaxPer";
            this.StateTaxPer.Size = new System.Drawing.Size(100, 20);
            this.StateTaxPer.TabIndex = 4;
            // 
            // LocalTaxPer
            // 
            this.LocalTaxPer.Location = new System.Drawing.Point(126, 210);
            this.LocalTaxPer.Name = "LocalTaxPer";
            this.LocalTaxPer.Size = new System.Drawing.Size(100, 20);
            this.LocalTaxPer.TabIndex = 5;
            // 
            // k401PrePer
            // 
            this.k401PrePer.Location = new System.Drawing.Point(126, 236);
            this.k401PrePer.Name = "k401PrePer";
            this.k401PrePer.Size = new System.Drawing.Size(100, 20);
            this.k401PrePer.TabIndex = 6;
            // 
            // NetAMT
            // 
            this.NetAMT.Location = new System.Drawing.Point(248, 55);
            this.NetAMT.Name = "NetAMT";
            this.NetAMT.Size = new System.Drawing.Size(100, 20);
            this.NetAMT.TabIndex = 0;
            this.NetAMT.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // k401PreAmt
            // 
            this.k401PreAmt.Location = new System.Drawing.Point(248, 236);
            this.k401PreAmt.Name = "k401PreAmt";
            this.k401PreAmt.ReadOnly = true;
            this.k401PreAmt.Size = new System.Drawing.Size(100, 20);
            this.k401PreAmt.TabIndex = 22;
            // 
            // LocalTaxAmt
            // 
            this.LocalTaxAmt.Location = new System.Drawing.Point(248, 210);
            this.LocalTaxAmt.Name = "LocalTaxAmt";
            this.LocalTaxAmt.ReadOnly = true;
            this.LocalTaxAmt.Size = new System.Drawing.Size(100, 20);
            this.LocalTaxAmt.TabIndex = 21;
            // 
            // StateTaxAmt
            // 
            this.StateTaxAmt.Location = new System.Drawing.Point(248, 186);
            this.StateTaxAmt.Name = "StateTaxAmt";
            this.StateTaxAmt.ReadOnly = true;
            this.StateTaxAmt.Size = new System.Drawing.Size(100, 20);
            this.StateTaxAmt.TabIndex = 20;
            // 
            // FICAMcareAmt
            // 
            this.FICAMcareAmt.Location = new System.Drawing.Point(248, 160);
            this.FICAMcareAmt.Name = "FICAMcareAmt";
            this.FICAMcareAmt.ReadOnly = true;
            this.FICAMcareAmt.Size = new System.Drawing.Size(100, 20);
            this.FICAMcareAmt.TabIndex = 19;
            // 
            // FICASSAmt
            // 
            this.FICASSAmt.Location = new System.Drawing.Point(248, 134);
            this.FICASSAmt.Name = "FICASSAmt";
            this.FICASSAmt.ReadOnly = true;
            this.FICASSAmt.Size = new System.Drawing.Size(100, 20);
            this.FICASSAmt.TabIndex = 18;
            // 
            // FedTaxAmt
            // 
            this.FedTaxAmt.Location = new System.Drawing.Point(248, 102);
            this.FedTaxAmt.Name = "FedTaxAmt";
            this.FedTaxAmt.ReadOnly = true;
            this.FedTaxAmt.Size = new System.Drawing.Size(100, 20);
            this.FedTaxAmt.TabIndex = 17;
            // 
            // Gross
            // 
            this.Gross.AutoSize = true;
            this.Gross.Location = new System.Drawing.Point(153, 281);
            this.Gross.Name = "Gross";
            this.Gross.Size = new System.Drawing.Size(73, 13);
            this.Gross.TabIndex = 24;
            this.Gross.Text = "Gross Amount";
            // 
            // GrossAmt
            // 
            this.GrossAmt.Location = new System.Drawing.Point(248, 281);
            this.GrossAmt.Name = "GrossAmt";
            this.GrossAmt.Size = new System.Drawing.Size(100, 20);
            this.GrossAmt.TabIndex = 25;
            // 
            // Clr
            // 
            this.Clr.Location = new System.Drawing.Point(35, 349);
            this.Clr.Name = "Clr";
            this.Clr.Size = new System.Drawing.Size(75, 23);
            this.Clr.TabIndex = 7;
            this.Clr.Text = "Clear";
            this.Clr.UseVisualStyleBackColor = true;
            this.Clr.Click += new System.EventHandler(this.Clr_Click);
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(166, 349);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(75, 23);
            this.Calc.TabIndex = 8;
            this.Calc.Text = "Calculate";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(292, 348);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 9;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 405);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.Clr);
            this.Controls.Add(this.GrossAmt);
            this.Controls.Add(this.Gross);
            this.Controls.Add(this.k401PreAmt);
            this.Controls.Add(this.LocalTaxAmt);
            this.Controls.Add(this.StateTaxAmt);
            this.Controls.Add(this.FICAMcareAmt);
            this.Controls.Add(this.FICASSAmt);
            this.Controls.Add(this.FedTaxAmt);
            this.Controls.Add(this.NetAMT);
            this.Controls.Add(this.k401PrePer);
            this.Controls.Add(this.LocalTaxPer);
            this.Controls.Add(this.StateTaxPer);
            this.Controls.Add(this.FICAMcarePer);
            this.Controls.Add(this.FICASSPer);
            this.Controls.Add(this.FedPer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Goss Up Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FedPer;
        private System.Windows.Forms.TextBox FICASSPer;
        private System.Windows.Forms.TextBox FICAMcarePer;
        private System.Windows.Forms.TextBox StateTaxPer;
        private System.Windows.Forms.TextBox LocalTaxPer;
        private System.Windows.Forms.TextBox k401PrePer;
        private System.Windows.Forms.TextBox NetAMT;
        private System.Windows.Forms.TextBox k401PreAmt;
        private System.Windows.Forms.TextBox LocalTaxAmt;
        private System.Windows.Forms.TextBox StateTaxAmt;
        private System.Windows.Forms.TextBox FICAMcareAmt;
        private System.Windows.Forms.TextBox FICASSAmt;
        private System.Windows.Forms.TextBox FedTaxAmt;
        private System.Windows.Forms.Label Gross;
        private System.Windows.Forms.TextBox GrossAmt;
        private System.Windows.Forms.Button Clr;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Button Close;
    }
}

