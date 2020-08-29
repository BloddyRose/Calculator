namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.enterArea = new System.Windows.Forms.TextBox();
            this.adBt = new System.Windows.Forms.Button();
            this.subBt = new System.Windows.Forms.Button();
            this.mulBt = new System.Windows.Forms.Button();
            this.devBt = new System.Windows.Forms.Button();
            this.eqBt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dotBt = new System.Windows.Forms.Button();
            this.clearBt = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // enterArea
            // 
            this.enterArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enterArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterArea.Location = new System.Drawing.Point(10, 12);
            this.enterArea.Name = "enterArea";
            this.enterArea.Size = new System.Drawing.Size(317, 22);
            this.enterArea.TabIndex = 0;
            this.enterArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // adBt
            // 
            this.adBt.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.adBt.FlatAppearance.BorderSize = 2;
            this.adBt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Ivory;
            this.adBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.adBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.adBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adBt.Location = new System.Drawing.Point(252, 47);
            this.adBt.Name = "adBt";
            this.adBt.Size = new System.Drawing.Size(77, 42);
            this.adBt.TabIndex = 1;
            this.adBt.Text = "+";
            this.adBt.UseVisualStyleBackColor = true;
            this.adBt.Click += new System.EventHandler(this.adBt_Click);
            // 
            // subBt
            // 
            this.subBt.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.subBt.FlatAppearance.BorderSize = 2;
            this.subBt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Ivory;
            this.subBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.subBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.subBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subBt.Location = new System.Drawing.Point(252, 95);
            this.subBt.Name = "subBt";
            this.subBt.Size = new System.Drawing.Size(75, 42);
            this.subBt.TabIndex = 2;
            this.subBt.Text = "-";
            this.subBt.UseVisualStyleBackColor = true;
            this.subBt.Click += new System.EventHandler(this.subBt_Click);
            // 
            // mulBt
            // 
            this.mulBt.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.mulBt.FlatAppearance.BorderSize = 2;
            this.mulBt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Ivory;
            this.mulBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.mulBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.mulBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mulBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulBt.Location = new System.Drawing.Point(252, 191);
            this.mulBt.Name = "mulBt";
            this.mulBt.Size = new System.Drawing.Size(75, 42);
            this.mulBt.TabIndex = 3;
            this.mulBt.Text = "*";
            this.mulBt.UseVisualStyleBackColor = true;
            this.mulBt.Click += new System.EventHandler(this.mulBt_Click);
            // 
            // devBt
            // 
            this.devBt.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.devBt.FlatAppearance.BorderSize = 2;
            this.devBt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Ivory;
            this.devBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.devBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.devBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devBt.Location = new System.Drawing.Point(254, 143);
            this.devBt.Name = "devBt";
            this.devBt.Size = new System.Drawing.Size(75, 42);
            this.devBt.TabIndex = 4;
            this.devBt.Text = "/";
            this.devBt.UseVisualStyleBackColor = true;
            this.devBt.Click += new System.EventHandler(this.devBt_Click);
            // 
            // eqBt
            // 
            this.eqBt.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.eqBt.FlatAppearance.BorderSize = 2;
            this.eqBt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Ivory;
            this.eqBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.eqBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.eqBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eqBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eqBt.Location = new System.Drawing.Point(92, 240);
            this.eqBt.Name = "eqBt";
            this.eqBt.Size = new System.Drawing.Size(154, 42);
            this.eqBt.TabIndex = 5;
            this.eqBt.Text = "=";
            this.eqBt.UseVisualStyleBackColor = true;
            this.eqBt.Click += new System.EventHandler(this.eqBt_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Ivory;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Ivory;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(91, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Ivory;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(171, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Ivory;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(12, 143);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 42);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Ivory;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(92, 143);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 42);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Ivory;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(172, 143);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 42);
            this.button6.TabIndex = 11;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Ivory;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(12, 191);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 42);
            this.button7.TabIndex = 12;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Ivory;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(92, 191);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(74, 42);
            this.button8.TabIndex = 13;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button9.FlatAppearance.BorderSize = 2;
            this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Ivory;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(172, 191);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(74, 42);
            this.button9.TabIndex = 14;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button10.FlatAppearance.BorderSize = 2;
            this.button10.FlatAppearance.CheckedBackColor = System.Drawing.Color.Ivory;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(12, 240);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(74, 42);
            this.button10.TabIndex = 15;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // dotBt
            // 
            this.dotBt.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.dotBt.FlatAppearance.BorderSize = 2;
            this.dotBt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Ivory;
            this.dotBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.dotBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.dotBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dotBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotBt.Location = new System.Drawing.Point(172, 47);
            this.dotBt.Name = "dotBt";
            this.dotBt.Size = new System.Drawing.Size(74, 42);
            this.dotBt.TabIndex = 17;
            this.dotBt.Text = ".";
            this.dotBt.UseVisualStyleBackColor = true;
            this.dotBt.Click += new System.EventHandler(this.dotBt_Click);
            // 
            // clearBt
            // 
            this.clearBt.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.clearBt.FlatAppearance.BorderSize = 2;
            this.clearBt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Ivory;
            this.clearBt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.clearBt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.clearBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBt.Location = new System.Drawing.Point(12, 47);
            this.clearBt.Name = "clearBt";
            this.clearBt.Size = new System.Drawing.Size(153, 41);
            this.clearBt.TabIndex = 18;
            this.clearBt.Text = "C";
            this.clearBt.UseVisualStyleBackColor = true;
            this.clearBt.Click += new System.EventHandler(this.clearBt_Click);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.Azure;
            this.button11.FlatAppearance.BorderSize = 2;
            this.button11.FlatAppearance.CheckedBackColor = System.Drawing.Color.Ivory;
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(252, 240);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 41);
            this.button11.TabIndex = 19;
            this.button11.Text = "About";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 1);
            this.panel1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 293);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.clearBt);
            this.Controls.Add(this.dotBt);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eqBt);
            this.Controls.Add(this.devBt);
            this.Controls.Add(this.mulBt);
            this.Controls.Add(this.subBt);
            this.Controls.Add(this.adBt);
            this.Controls.Add(this.enterArea);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(355, 332);
            this.MinimumSize = new System.Drawing.Size(355, 332);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterArea;
        private System.Windows.Forms.Button adBt;
        private System.Windows.Forms.Button subBt;
        private System.Windows.Forms.Button mulBt;
        private System.Windows.Forms.Button devBt;
        private System.Windows.Forms.Button eqBt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button dotBt;
        private System.Windows.Forms.Button clearBt;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel1;
    }
}

