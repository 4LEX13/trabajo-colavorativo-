namespace calculadoraDePromedios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLab1 = new System.Windows.Forms.TextBox();
            this.txtParc1 = new System.Windows.Forms.TextBox();
            this.txtResul1 = new System.Windows.Forms.TextBox();
            this.txtLab2 = new System.Windows.Forms.TextBox();
            this.txtParc2 = new System.Windows.Forms.TextBox();
            this.txtResul2 = new System.Windows.Forms.TextBox();
            this.txtLab3 = new System.Windows.Forms.TextBox();
            this.txtParc3 = new System.Windows.Forms.TextBox();
            this.txtResul3 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(357, 315);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(60, 26);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "lab1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parcial 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "resultado 1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "lab 2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtLab1
            // 
            this.txtLab1.Location = new System.Drawing.Point(155, 56);
            this.txtLab1.Name = "txtLab1";
            this.txtLab1.Size = new System.Drawing.Size(100, 23);
            this.txtLab1.TabIndex = 6;
            // 
            // txtParc1
            // 
            this.txtParc1.Location = new System.Drawing.Point(155, 120);
            this.txtParc1.Name = "txtParc1";
            this.txtParc1.Size = new System.Drawing.Size(100, 23);
            this.txtParc1.TabIndex = 7;
            this.txtParc1.TextChanged += new System.EventHandler(this.txtLab2_TextChanged);
            // 
            // txtResul1
            // 
            this.txtResul1.Location = new System.Drawing.Point(155, 196);
            this.txtResul1.Name = "txtResul1";
            this.txtResul1.Size = new System.Drawing.Size(100, 23);
            this.txtResul1.TabIndex = 8;
            // 
            // txtLab2
            // 
            this.txtLab2.Location = new System.Drawing.Point(367, 53);
            this.txtLab2.Name = "txtLab2";
            this.txtLab2.Size = new System.Drawing.Size(100, 23);
            this.txtLab2.TabIndex = 9;
            // 
            // txtParc2
            // 
            this.txtParc2.Location = new System.Drawing.Point(367, 120);
            this.txtParc2.Name = "txtParc2";
            this.txtParc2.Size = new System.Drawing.Size(100, 23);
            this.txtParc2.TabIndex = 10;
            // 
            // txtResul2
            // 
            this.txtResul2.Location = new System.Drawing.Point(367, 196);
            this.txtResul2.Name = "txtResul2";
            this.txtResul2.Size = new System.Drawing.Size(100, 23);
            this.txtResul2.TabIndex = 11;
            // 
            // txtLab3
            // 
            this.txtLab3.Location = new System.Drawing.Point(584, 58);
            this.txtLab3.Name = "txtLab3";
            this.txtLab3.Size = new System.Drawing.Size(100, 23);
            this.txtLab3.TabIndex = 12;
            // 
            // txtParc3
            // 
            this.txtParc3.Location = new System.Drawing.Point(584, 117);
            this.txtParc3.Name = "txtParc3";
            this.txtParc3.Size = new System.Drawing.Size(100, 23);
            this.txtParc3.TabIndex = 13;
            // 
            // txtResul3
            // 
            this.txtResul3.Location = new System.Drawing.Point(584, 196);
            this.txtResul3.Name = "txtResul3";
            this.txtResul3.Size = new System.Drawing.Size(100, 23);
            this.txtResul3.TabIndex = 14;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(310, 132);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(51, 15);
            this.label.TabIndex = 15;
            this.label.Text = "Parcial 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "resultado 2";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "lab 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "parcial 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(509, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "resultado 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Resultado Final";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(367, 250);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 23);
            this.txtFinal.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 533);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtResul3);
            this.Controls.Add(this.txtParc3);
            this.Controls.Add(this.txtLab3);
            this.Controls.Add(this.txtResul2);
            this.Controls.Add(this.txtParc2);
            this.Controls.Add(this.txtLab2);
            this.Controls.Add(this.txtResul1);
            this.Controls.Add(this.txtParc1);
            this.Controls.Add(this.txtLab1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "calculador de promedio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLab1;
        private System.Windows.Forms.TextBox txtParc1;
        private System.Windows.Forms.TextBox txtResul1;
        private System.Windows.Forms.TextBox txtLab2;
        private System.Windows.Forms.TextBox txtParc2;
        private System.Windows.Forms.TextBox txtResul2;
        private System.Windows.Forms.TextBox txtLab3;
        private System.Windows.Forms.TextBox txtParc3;
        private System.Windows.Forms.TextBox txtResul3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFinal;
    }
}

