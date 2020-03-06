namespace SmartEducation
{
    partial class AccountForm
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
            this.lblAbit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAbit
            // 
            this.lblAbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAbit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblAbit.Location = new System.Drawing.Point(39, 36);
            this.lblAbit.Name = "lblAbit";
            this.lblAbit.Size = new System.Drawing.Size(349, 61);
            this.lblAbit.TabIndex = 0;
            this.lblAbit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 399);
            this.Controls.Add(this.lblAbit);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAbit;
    }
}