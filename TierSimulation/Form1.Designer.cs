namespace TierSimulation
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_Tiere = new System.Windows.Forms.ListBox();
            this.btnNestBauen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tiere erzeugen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Löwe jagd";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_Tiere
            // 
            this.lb_Tiere.FormattingEnabled = true;
            this.lb_Tiere.ItemHeight = 15;
            this.lb_Tiere.Location = new System.Drawing.Point(12, 58);
            this.lb_Tiere.Name = "lb_Tiere";
            this.lb_Tiere.Size = new System.Drawing.Size(181, 94);
            this.lb_Tiere.TabIndex = 2;
            // 
            // btnNestBauen
            // 
            this.btnNestBauen.Location = new System.Drawing.Point(12, 187);
            this.btnNestBauen.Name = "btnNestBauen";
            this.btnNestBauen.Size = new System.Drawing.Size(181, 23);
            this.btnNestBauen.TabIndex = 3;
            this.btnNestBauen.Text = "Nest bauen";
            this.btnNestBauen.UseVisualStyleBackColor = true;
            this.btnNestBauen.Click += new System.EventHandler(this.btnNestBauen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNestBauen);
            this.Controls.Add(this.lb_Tiere);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox lb_Tiere;
        private Button btnNestBauen;
    }
}