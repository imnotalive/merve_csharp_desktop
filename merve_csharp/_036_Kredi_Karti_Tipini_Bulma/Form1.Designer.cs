namespace merve_csharp._036_Kredi_Karti_Tipini_Bulma
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
            this.txt_card_no = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kontrol = new System.Windows.Forms.Button();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_card_no
            // 
            this.txt_card_no.Location = new System.Drawing.Point(134, 48);
            this.txt_card_no.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_card_no.Name = "txt_card_no";
            this.txt_card_no.Size = new System.Drawing.Size(308, 26);
            this.txt_card_no.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kredi Kart No";
            // 
            // btn_kontrol
            // 
            this.btn_kontrol.Location = new System.Drawing.Point(453, 46);
            this.btn_kontrol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_kontrol.Name = "btn_kontrol";
            this.btn_kontrol.Size = new System.Drawing.Size(112, 35);
            this.btn_kontrol.TabIndex = 2;
            this.btn_kontrol.Text = "Kontol Et";
            this.btn_kontrol.UseVisualStyleBackColor = true;
            this.btn_kontrol.Click += new System.EventHandler(this.btn_kontrol_Click);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(129, 98);
            this.lbl_sonuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(67, 20);
            this.lbl_sonuc.TabIndex = 3;
            this.lbl_sonuc.Text = "Sonuç : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(16, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(382, 32);
            this.label12.TabIndex = 5;
            this.label12.Text = "C# Kredi Kartı Tipini Bulma";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 349);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.btn_kontrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_card_no);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_card_no;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kontrol;
        private System.Windows.Forms.Label lbl_sonuc;
        private System.Windows.Forms.Label label12;
    }
}