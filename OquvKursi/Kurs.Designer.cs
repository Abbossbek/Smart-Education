namespace OquvKursi
{
    partial class Kurs
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
            this.cmbFan = new System.Windows.Forms.ComboBox();
            this.txtSoat = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.rbJuft = new System.Windows.Forms.RadioButton();
            this.rbToq = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kun";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soat";
            // 
            // cmbFan
            // 
            this.cmbFan.FormattingEnabled = true;
            this.cmbFan.Location = new System.Drawing.Point(99, 33);
            this.cmbFan.Name = "cmbFan";
            this.cmbFan.Size = new System.Drawing.Size(121, 24);
            this.cmbFan.TabIndex = 3;
            // 
            // txtSoat
            // 
            this.txtSoat.Location = new System.Drawing.Point(99, 154);
            this.txtSoat.Name = "txtSoat";
            this.txtSoat.Size = new System.Drawing.Size(121, 22);
            this.txtSoat.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(78, 208);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // rbJuft
            // 
            this.rbJuft.AutoSize = true;
            this.rbJuft.Location = new System.Drawing.Point(99, 87);
            this.rbJuft.Name = "rbJuft";
            this.rbJuft.Size = new System.Drawing.Size(95, 21);
            this.rbJuft.TabIndex = 7;
            this.rbJuft.TabStop = true;
            this.rbJuft.Text = "Juft kunlar";
            this.rbJuft.UseVisualStyleBackColor = true;
            // 
            // rbToq
            // 
            this.rbToq.AutoSize = true;
            this.rbToq.Location = new System.Drawing.Point(99, 114);
            this.rbToq.Name = "rbToq";
            this.rbToq.Size = new System.Drawing.Size(97, 21);
            this.rbToq.TabIndex = 8;
            this.rbToq.TabStop = true;
            this.rbToq.Text = "Toq kunlar";
            this.rbToq.UseVisualStyleBackColor = true;
            // 
            // Kurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 258);
            this.Controls.Add(this.rbToq);
            this.Controls.Add(this.rbJuft);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSoat);
            this.Controls.Add(this.cmbFan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yangi kurs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFan;
        private System.Windows.Forms.TextBox txtSoat;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.RadioButton rbJuft;
        private System.Windows.Forms.RadioButton rbToq;
    }
}