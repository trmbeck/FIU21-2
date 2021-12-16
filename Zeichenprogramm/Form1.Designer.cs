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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteRectangle = new System.Windows.Forms.Button();
            this.txbRectangleX = new System.Windows.Forms.TextBox();
            this.txbRectangleY = new System.Windows.Forms.TextBox();
            this.btnCreateRectangle = new System.Windows.Forms.Button();
            this.txbRectangleA = new System.Windows.Forms.TextBox();
            this.txbRectangleB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
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
            this.panelAusgabe.Location = new System.Drawing.Point(242, 12);
            this.panelAusgabe.Name = "panelAusgabe";
            this.panelAusgabe.Size = new System.Drawing.Size(570, 423);
            this.panelAusgabe.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(224, 181);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(216, 153);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kreis";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(216, 153);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rechteck";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteRectangle);
            this.groupBox2.Controls.Add(this.txbRectangleX);
            this.groupBox2.Controls.Add(this.txbRectangleY);
            this.groupBox2.Controls.Add(this.btnCreateRectangle);
            this.groupBox2.Controls.Add(this.txbRectangleA);
            this.groupBox2.Controls.Add(this.txbRectangleB);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 141);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rechteck";
            // 
            // btnDeleteRectangle
            // 
            this.btnDeleteRectangle.Location = new System.Drawing.Point(6, 109);
            this.btnDeleteRectangle.Name = "btnDeleteRectangle";
            this.btnDeleteRectangle.Size = new System.Drawing.Size(192, 23);
            this.btnDeleteRectangle.TabIndex = 5;
            this.btnDeleteRectangle.Text = "Löschen";
            this.btnDeleteRectangle.UseVisualStyleBackColor = true;
            // 
            // txbRectangleX
            // 
            this.txbRectangleX.Location = new System.Drawing.Point(6, 22);
            this.txbRectangleX.Name = "txbRectangleX";
            this.txbRectangleX.PlaceholderText = "X";
            this.txbRectangleX.Size = new System.Drawing.Size(86, 23);
            this.txbRectangleX.TabIndex = 0;
            // 
            // txbRectangleY
            // 
            this.txbRectangleY.Location = new System.Drawing.Point(109, 22);
            this.txbRectangleY.Name = "txbRectangleY";
            this.txbRectangleY.PlaceholderText = "Y";
            this.txbRectangleY.Size = new System.Drawing.Size(89, 23);
            this.txbRectangleY.TabIndex = 1;
            // 
            // btnCreateRectangle
            // 
            this.btnCreateRectangle.Location = new System.Drawing.Point(6, 80);
            this.btnCreateRectangle.Name = "btnCreateRectangle";
            this.btnCreateRectangle.Size = new System.Drawing.Size(192, 23);
            this.btnCreateRectangle.TabIndex = 4;
            this.btnCreateRectangle.Text = "Erstellen";
            this.btnCreateRectangle.UseVisualStyleBackColor = true;
            this.btnCreateRectangle.Click += new System.EventHandler(this.btnCreateRectangle_Click);
            // 
            // txbRectangleA
            // 
            this.txbRectangleA.Location = new System.Drawing.Point(6, 51);
            this.txbRectangleA.Name = "txbRectangleA";
            this.txbRectangleA.PlaceholderText = "a";
            this.txbRectangleA.Size = new System.Drawing.Size(86, 23);
            this.txbRectangleA.TabIndex = 2;
            // 
            // txbRectangleB
            // 
            this.txbRectangleB.Location = new System.Drawing.Point(109, 51);
            this.txbRectangleB.Name = "txbRectangleB";
            this.txbRectangleB.PlaceholderText = "b";
            this.txbRectangleB.Size = new System.Drawing.Size(89, 23);
            this.txbRectangleB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 454);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelAusgabe);
            this.Name = "Form1";
            this.Text = "Zeichenprogramm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private Button btnDeleteRectangle;
        private TextBox txbRectangleX;
        private TextBox txbRectangleY;
        private Button btnCreateRectangle;
        private TextBox txbRectangleA;
        private TextBox txbRectangleB;
    }
}