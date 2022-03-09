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
            this.txtInput = new System.Windows.Forms.RichTextBox();
            this.textBoxDiagonalkekanan = new System.Windows.Forms.TextBox();
            this.textBoxDiagonalKekiri = new System.Windows.Forms.TextBox();
            this.textBoxSummaries = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonProccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(226, 44);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(281, 176);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "";
            // 
            // textBoxDiagonalkekanan
            // 
            this.textBoxDiagonalkekanan.Location = new System.Drawing.Point(226, 226);
            this.textBoxDiagonalkekanan.Name = "textBoxDiagonalkekanan";
            this.textBoxDiagonalkekanan.Size = new System.Drawing.Size(281, 20);
            this.textBoxDiagonalkekanan.TabIndex = 1;
            // 
            // textBoxDiagonalKekiri
            // 
            this.textBoxDiagonalKekiri.Location = new System.Drawing.Point(226, 257);
            this.textBoxDiagonalKekiri.Name = "textBoxDiagonalKekiri";
            this.textBoxDiagonalKekiri.Size = new System.Drawing.Size(281, 20);
            this.textBoxDiagonalKekiri.TabIndex = 2;
            // 
            // textBoxSummaries
            // 
            this.textBoxSummaries.Location = new System.Drawing.Point(226, 283);
            this.textBoxSummaries.Name = "textBoxSummaries";
            this.textBoxSummaries.Size = new System.Drawing.Size(281, 20);
            this.textBoxSummaries.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasil Diagonal Kekanan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasil Diagonal Kekiri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Jumlah Kedua Hasil Diagonal";
            // 
            // buttonProccess
            // 
            this.buttonProccess.Location = new System.Drawing.Point(226, 322);
            this.buttonProccess.Name = "buttonProccess";
            this.buttonProccess.Size = new System.Drawing.Size(148, 39);
            this.buttonProccess.TabIndex = 8;
            this.buttonProccess.Text = "Proccess";
            this.buttonProccess.UseVisualStyleBackColor = true;
            this.buttonProccess.Click += new System.EventHandler(this.buttonProccess_Click);
            // 
            // FormSoal2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonProccess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSummaries);
            this.Controls.Add(this.textBoxDiagonalKekiri);
            this.Controls.Add(this.textBoxDiagonalkekanan);
            this.Controls.Add(this.txtInput);
            this.Name = "FormSoal2";
            this.Text = "FormSoal2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtInput;
        private System.Windows.Forms.TextBox textBoxDiagonalkekanan;
        private System.Windows.Forms.TextBox textBoxDiagonalKekiri;
        private System.Windows.Forms.TextBox textBoxSummaries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonProccess;
    }
}