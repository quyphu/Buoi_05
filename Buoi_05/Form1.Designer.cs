namespace Buoi_05
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
            this.components = new System.ComponentModel.Container();
            this.txtYourName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.YourName = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYourName
            // 
            this.txtYourName.Location = new System.Drawing.Point(373, 132);
            this.txtYourName.Name = "txtYourName";
            this.txtYourName.Size = new System.Drawing.Size(200, 20);
            this.txtYourName.TabIndex = 3;
            this.txtYourName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtYourName.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(373, 188);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(200, 20);
            this.txtYear.TabIndex = 4;
            this.txtYear.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // YourName
            // 
            this.YourName.AutoSize = true;
            this.YourName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YourName.Location = new System.Drawing.Point(281, 137);
            this.YourName.Name = "YourName";
            this.YourName.Size = new System.Drawing.Size(65, 15);
            this.YourName.TabIndex = 6;
            this.YourName.Text = "You Name :";
            this.YourName.Click += new System.EventHandler(this.label1_Click);
            this.YourName.Leave += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Year.Location = new System.Drawing.Point(281, 191);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(73, 15);
            this.Year.TabIndex = 7;
            this.Year.Text = "Year of Birth :";
            this.Year.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Year.Leave += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(281, 269);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "&Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(401, 269);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(517, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 361);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.YourName);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtYourName);
            this.Name = "Form1";
            this.Text = "My Name Project";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYourName;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label YourName;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

