﻿namespace merve_csharp._009_NotiftyIcon_Kullanimi
{
    partial class AnaMenu
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.öneGetirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uygulamayıKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öneGetirToolStripMenuItem,
            this.uygulamayıKapatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 48);
            // 
            // öneGetirToolStripMenuItem
            // 
            this.öneGetirToolStripMenuItem.Name = "öneGetirToolStripMenuItem";
            this.öneGetirToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.öneGetirToolStripMenuItem.Text = "Öne Getir";
            this.öneGetirToolStripMenuItem.Click += new System.EventHandler(this.öneGetirToolStripMenuItem_Click);
            // 
            // uygulamayıKapatToolStripMenuItem
            // 
            this.uygulamayıKapatToolStripMenuItem.Name = "uygulamayıKapatToolStripMenuItem";
            this.uygulamayıKapatToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.uygulamayıKapatToolStripMenuItem.Text = "Uygulamayı Kapat";
            this.uygulamayıKapatToolStripMenuItem.Click += new System.EventHandler(this.uygulamayıKapatToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "C# NotifyIcon Kullanımı ve C# NotifyIcon Bildirimleri";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(28, 75);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(663, 17);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
           
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 150);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "notifyıcon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaMenu_FormClosing);
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.Resize += new System.EventHandler(this.AnaMenu_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öneGetirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uygulamayıKapatToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
