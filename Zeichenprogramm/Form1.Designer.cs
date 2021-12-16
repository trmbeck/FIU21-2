namespace Zeichenprogramm
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
            this.txbRadius = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteCircle = new System.Windows.Forms.Button();
            this.btnCreateCircle = new System.Windows.Forms.Button();
            this.txbY = new System.Windows.Forms.TextBox();
            this.txbX = new System.Windows.Forms.TextBox();
            this.panelAusgabe = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbRadius
            // 
            this.txbRadius.Location = new System.Drawing.Point(6, 51);
            this.txbRadius.Name = "txbRadius";
            this.txbRadius.PlaceholderText = "Radius";
            this.txbRadius.Size = new System.Drawing.Size(188, 23);
            this.txbRadius.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteCircle);
            this.groupBox1.Controls.Add(this.btnCreateCircle);
            this.groupBox1.Controls.Add(this.txbY);
            this.groupBox1.Controls.Add(this.txbX);
            this.groupBox1.Controls.Add(this.txbRadius);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kreis";
            // 
            // btnDeleteCircle
            // 
            this.btnDeleteCircle.Location = new System.Drawing.Point(6, 109);
            this.btnDeleteCircle.Name = "btnDeleteCircle";
            this.btnDeleteCircle.Size = new System.Drawing.Size(188, 23);
            this.btnDeleteCircle.TabIndex = 5;
            this.btnDeleteCircle.Text = "löschen";
            this.btnDeleteCircle.UseVisualStyleBackColor = true;
            // 
            // btnCreateCircle
            // 
            this.btnCreateCircle.Location = new System.Drawing.Point(6, 80);
            this.btnCreateCircle.Name = "btnCreateCircle";
            this.btnCreateCircle.Size = new System.Drawing.Size(188, 23);
            this.btnCreateCircle.TabIndex = 4;
            this.btnCreateCircle.Text = "erstellen";
            this.btnCreateCircle.UseVisualStyleBackColor = true;
            this.btnCreateCircle.Click += new System.EventHandler(this.btnCreateCircle_Click);
            // 
            // txbY
            // 
            this.txbY.Location = new System.Drawing.Point(111, 22);
            this.txbY.Name = "txbY";
            this.txbY.PlaceholderText = "Y";
            this.txbY.Size = new System.Drawing.Size(83, 23);
            this.txbY.TabIndex = 2;
            // 
            // txbX
            // 
            this.txbX.Location = new System.Drawing.Point(6, 22);
            this.txbX.Name = "txbX";
            this.txbX.PlaceholderText = "X";
            this.txbX.Size = new System.Drawing.Size(81, 23);
            this.txbX.TabIndex = 1;
            // 
            // panelAusgabe
            // 
            this.panelAusgabe.Location = new System.Drawing.Point(218, 15);
            this.panelAusgabe.Name = "panelAusgabe";
            this.panelAusgabe.Size = new System.Drawing.Size(570, 423);
            this.panelAusgabe.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAusgabe);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Zeichenprogramm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txbRadius;
        private GroupBox groupBox1;
        private Button btnDeleteCircle;
        private Button btnCreateCircle;
        private TextBox txbY;
        private TextBox txbX;
        private Panel panelAusgabe;
    }
}