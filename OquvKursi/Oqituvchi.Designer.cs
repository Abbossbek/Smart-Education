namespace OquvKursi
{
    partial class Oqituvchi
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
            this.rbAyol = new System.Windows.Forms.RadioButton();
            this.rbErkak = new System.Windows.Forms.RadioButton();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFan = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rbAyol
            // 
            this.rbAyol.AutoSize = true;
            this.rbAyol.Location = new System.Drawing.Point(199, 177);
            this.rbAyol.Name = "rbAyol";
            this.rbAyol.Size = new System.Drawing.Size(56, 21);
            this.rbAyol.TabIndex = 10;
            this.rbAyol.TabStop = true;
            this.rbAyol.Text = "Ayol";
            this.rbAyol.UseVisualStyleBackColor = true;
            // 
            // rbErkak
            // 
            this.rbErkak.AutoSize = true;
            this.rbErkak.Location = new System.Drawing.Point(108, 177);
            this.rbErkak.Name = "rbErkak";
            this.rbErkak.Size = new System.Drawing.Size(65, 21);
            this.rbErkak.TabIndex = 9;
            this.rbErkak.TabStop = true;
            this.rbErkak.Text = "Erkak";
            this.rbErkak.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(108, 125);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(147, 22);
            this.txtAge.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Jinsi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Yoshi";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(251, 274);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 17;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 76);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 22);
            this.txtName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ismi";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(108, 28);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(245, 22);
            this.txtLastName.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Familiyasi";
            // 
            // cmbFan
            // 
            this.cmbFan.FormattingEnabled = true;
            this.cmbFan.Location = new System.Drawing.Point(108, 224);
            this.cmbFan.Name = "cmbFan";
            this.cmbFan.Size = new System.Drawing.Size(147, 24);
            this.cmbFan.TabIndex = 23;
            // 
            // Oqituvchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 327);
            this.Controls.Add(this.cmbFan);
            this.Controls.Add(this.rbErkak);
            this.Controls.Add(this.rbAyol);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Name = "Oqituvchi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yangi O\'qituvchi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAyol;
        private System.Windows.Forms.RadioButton rbErkak;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFan;

    }
}