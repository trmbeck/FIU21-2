namespace WinFormsÜbungPolymorphie
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
            this.btnBasis = new System.Windows.Forms.Button();
            this.btnTestInt = new System.Windows.Forms.Button();
            this.btnTestString = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBasis
            // 
            this.btnBasis.Location = new System.Drawing.Point(24, 113);
            this.btnBasis.Name = "btnBasis";
            this.btnBasis.Size = new System.Drawing.Size(144, 23);
            this.btnBasis.TabIndex = 0;
            this.btnBasis.Text = "Basis Test()";
            this.btnBasis.UseVisualStyleBackColor = true;
            this.btnBasis.Click += new System.EventHandler(this.btnBasis_Click);
            // 
            // btnTestInt
            // 
            this.btnTestInt.Location = new System.Drawing.Point(258, 113);
            this.btnTestInt.Name = "btnTestInt";
            this.btnTestInt.Size = new System.Drawing.Size(158, 23);
            this.btnTestInt.TabIndex = 1;
            this.btnTestInt.Text = "Test(int)";
            this.btnTestInt.UseVisualStyleBackColor = true;
            this.btnTestInt.Click += new System.EventHandler(this.btnTestInt_Click);
            // 
            // btnTestString
            // 
            this.btnTestString.Location = new System.Drawing.Point(481, 113);
            this.btnTestString.Name = "btnTestString";
            this.btnTestString.Size = new System.Drawing.Size(143, 23);
            this.btnTestString.TabIndex = 2;
            this.btnTestString.Text = "Test(string)";
            this.btnTestString.UseVisualStyleBackColor = true;
            this.btnTestString.Click += new System.EventHandler(this.btnTestString_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 57);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 163);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestString);
            this.Controls.Add(this.btnTestInt);
            this.Controls.Add(this.btnBasis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnBasis;
        private Button btnTestInt;
        private Button btnTestString;
        private Label label1;
    }
}