namespace WindowsFormsApp1
{
    partial class FormSoal2
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
            this.textBoxDiagonalkekanan = new System.Windows.Forms.TextBox();
            this.textBoxDiagonalKekiri = new System.Windows.Forms.TextBox();
            this.textBoxSummaries = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonProccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDiagonalkekanan
            // 
            this.textBoxDiagonalkekanan.Location = new System.Drawing.Point(383, 48);
            this.textBoxDiagonalkekanan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxDiagonalkekanan.Name = "textBoxDiagonalkekanan";
            this.textBoxDiagonalkekanan.Size = new System.Drawing.Size(558, 31);
            this.textBoxDiagonalkekanan.TabIndex = 1;
            // 
            // textBoxDiagonalKekiri
            // 
            this.textBoxDiagonalKekiri.Location = new System.Drawing.Point(383, 107);
            this.textBoxDiagonalKekiri.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxDiagonalKekiri.Name = "textBoxDiagonalKekiri";
            this.textBoxDiagonalKekiri.Size = new System.Drawing.Size(558, 31);
            this.textBoxDiagonalKekiri.TabIndex = 2;
            // 
            // textBoxSummaries
            // 
            this.textBoxSummaries.Location = new System.Drawing.Point(383, 157);
            this.textBoxSummaries.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxSummaries.Name = "textBoxSummaries";
            this.textBoxSummaries.Size = new System.Drawing.Size(558, 31);
            this.textBoxSummaries.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasil Diagonal Kekanan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasil Diagonal Kekiri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jumlah Kedua Hasil Diagonal";
            // 
            // buttonProccess
            // 
            this.buttonProccess.Location = new System.Drawing.Point(383, 232);
            this.buttonProccess.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonProccess.Name = "buttonProccess";
            this.buttonProccess.Size = new System.Drawing.Size(296, 75);
            this.buttonProccess.TabIndex = 8;
            this.buttonProccess.Text = "Proccess";
            this.buttonProccess.UseVisualStyleBackColor = true;
            this.buttonProccess.Click += new System.EventHandler(this.buttonProccess_Click);
            // 
            // FormSoal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 392);
            this.Controls.Add(this.buttonProccess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSummaries);
            this.Controls.Add(this.textBoxDiagonalKekiri);
            this.Controls.Add(this.textBoxDiagonalkekanan);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormSoal2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSoal2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDiagonalkekanan;
        private System.Windows.Forms.TextBox textBoxDiagonalKekiri;
        private System.Windows.Forms.TextBox textBoxSummaries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonProccess;
    }
}