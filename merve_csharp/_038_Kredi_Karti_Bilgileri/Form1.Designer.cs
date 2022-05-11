using System.Windows.Forms;

namespace merve_csharp._038_Kredi_Karti_Bilgileri
{
    partial class Form1:Form
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
            this.label12 = new System.Windows.Forms.Label();
            this.btn_kontrol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_card_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_kart_turu = new System.Windows.Forms.Label();
            this.lbl_bin_kodu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_hesap_no = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_kontrol_sayi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(45, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(519, 32);
            this.label12.TabIndex = 17;
            this.label12.Text = "C# Kredi Kartı Numarasındaki Bilgiler";
            // 
            // btn_kontrol
            // 
            this.btn_kontrol.Location = new System.Drawing.Point(501, 31);
            this.btn_kontrol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_kontrol.Name = "btn_kontrol";
            this.btn_kontrol.Size = new System.Drawing.Size(112, 35);
            this.btn_kontrol.TabIndex = 15;
            this.btn_kontrol.Text = "Kontol Et";
            this.btn_kontrol.UseVisualStyleBackColor = true;
         
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kredi Kart No";
            // 
            // txt_card_no
            // 
            this.txt_card_no.Location = new System.Drawing.Point(182, 32);
            this.txt_card_no.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_card_no.Name = "txt_card_no";
            this.txt_card_no.Size = new System.Drawing.Size(308, 26);
            this.txt_card_no.TabIndex = 13;
            this.txt_card_no.Text = "1234-5678-9876-5432";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kart Türü";
            // 
            // lbl_kart_turu
            // 
            this.lbl_kart_turu.AutoSize = true;
            this.lbl_kart_turu.Location = new System.Drawing.Point(206, 129);
            this.lbl_kart_turu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kart_turu.Name = "lbl_kart_turu";
            this.lbl_kart_turu.Size = new System.Drawing.Size(21, 20);
            this.lbl_kart_turu.TabIndex = 20;
            this.lbl_kart_turu.Text = "...";
            // 
            // lbl_bin_kodu
            // 
            this.lbl_bin_kodu.AutoSize = true;
            this.lbl_bin_kodu.Location = new System.Drawing.Point(206, 166);
            this.lbl_bin_kodu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bin_kodu.Name = "lbl_bin_kodu";
            this.lbl_bin_kodu.Size = new System.Drawing.Size(21, 20);
            this.lbl_bin_kodu.TabIndex = 22;
            this.lbl_bin_kodu.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "BIN Kodu";
            // 
            // lbl_hesap_no
            // 
            this.lbl_hesap_no.AutoSize = true;
            this.lbl_hesap_no.Location = new System.Drawing.Point(206, 203);
            this.lbl_hesap_no.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hesap_no.Name = "lbl_hesap_no";
            this.lbl_hesap_no.Size = new System.Drawing.Size(21, 20);
            this.lbl_hesap_no.TabIndex = 24;
            this.lbl_hesap_no.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Hesap Numarası";
            // 
            // lbl_kontrol_sayi
            // 
            this.lbl_kontrol_sayi.AutoSize = true;
            this.lbl_kontrol_sayi.Location = new System.Drawing.Point(206, 240);
            this.lbl_kontrol_sayi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_kontrol_sayi.Name = "lbl_kontrol_sayi";
            this.lbl_kontrol_sayi.Size = new System.Drawing.Size(21, 20);
            this.lbl_kontrol_sayi.TabIndex = 26;
            this.lbl_kontrol_sayi.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 240);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Kontrol Sayısı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 552);
            this.Controls.Add(this.lbl_kontrol_sayi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_hesap_no);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_bin_kodu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_kart_turu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_kontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_card_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_kart_turu;
        private System.Windows.Forms.Label lbl_bin_kodu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_hesap_no;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_kontrol_sayi;
        private System.Windows.Forms.Label label9;
    }
}