﻿namespace Passwortabfrage
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
            this.txbAusgabe = new System.Windows.Forms.TextBox();
            this.txbPasswort = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbAusgabe
            // 
            this.txbAusgabe.Enabled = false;
            this.txbAusgabe.Location = new System.Drawing.Point(12, 12);
            this.txbAusgabe.Multiline = true;
            this.txbAusgabe.Name = "txbAusgabe";
            this.txbAusgabe.Size = new System.Drawing.Size(224, 188);
            this.txbAusgabe.TabIndex = 0;
            // 
            // txbPasswort
            // 
            this.txbPasswort.Location = new System.Drawing.Point(12, 206);
            this.txbPasswort.Name = "txbPasswort";
            this.txbPasswort.PasswordChar = '*';
            this.txbPasswort.Size = new System.Drawing.Size(224, 23);
            this.txbPasswort.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(80, 235);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 270);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txbPasswort);
            this.Controls.Add(this.txbAusgabe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbAusgabe;
        private TextBox txbPasswort;
        private Button btnOK;
    }
}