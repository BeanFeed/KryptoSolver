namespace KryptoSolver
{
    partial class KryptoSolver
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
            this.Title = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.input6 = new System.Windows.Forms.TextBox();
            this.input5 = new System.Windows.Forms.TextBox();
            this.input4 = new System.Windows.Forms.TextBox();
            this.input3 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CalcButton = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.SelecterBar = new System.Windows.Forms.TrackBar();
            this.SolutionsCount = new System.Windows.Forms.Label();
            this.Selected = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelecterBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Lucida Sans Unicode", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Title.Location = new System.Drawing.Point(35, 32);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(414, 45);
            this.Title.TabIndex = 0;
            this.Title.Text = "Austin\'s Krypto Solver";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input1
            // 
            this.input1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.input1.Location = new System.Drawing.Point(0, 0);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(51, 40);
            this.input1.TabIndex = 1;
            this.input1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.input6);
            this.panel1.Controls.Add(this.input5);
            this.panel1.Controls.Add(this.input4);
            this.panel1.Controls.Add(this.input3);
            this.panel1.Controls.Add(this.input2);
            this.panel1.Controls.Add(this.input1);
            this.panel1.Location = new System.Drawing.Point(14, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 40);
            this.panel1.TabIndex = 2;
            // 
            // input6
            // 
            this.input6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.input6.Location = new System.Drawing.Point(405, 0);
            this.input6.Name = "input6";
            this.input6.Size = new System.Drawing.Size(51, 40);
            this.input6.TabIndex = 6;
            // 
            // input5
            // 
            this.input5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.input5.Location = new System.Drawing.Point(324, 0);
            this.input5.Name = "input5";
            this.input5.Size = new System.Drawing.Size(51, 40);
            this.input5.TabIndex = 5;
            // 
            // input4
            // 
            this.input4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.input4.Location = new System.Drawing.Point(243, 0);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(51, 40);
            this.input4.TabIndex = 4;
            // 
            // input3
            // 
            this.input3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.input3.Location = new System.Drawing.Point(162, 0);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(51, 40);
            this.input3.TabIndex = 3;
            // 
            // input2
            // 
            this.input2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.input2.Location = new System.Drawing.Point(81, 0);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(51, 40);
            this.input2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 80);
            this.label1.TabIndex = 7;
            this.label1.Text = "+\r\n-\r\n*\r\n/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(150, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 80);
            this.label2.TabIndex = 8;
            this.label2.Text = "+\r\n-\r\n*\r\n/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(231, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 80);
            this.label3.TabIndex = 9;
            this.label3.Text = "+\r\n-\r\n*\r\n/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(312, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 80);
            this.label4.TabIndex = 10;
            this.label4.Text = "+\r\n-\r\n*\r\n/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(393, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "=";
            // 
            // CalcButton
            // 
            this.CalcButton.BackColor = System.Drawing.Color.DarkGray;
            this.CalcButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalcButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.CalcButton.Location = new System.Drawing.Point(175, 207);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(117, 42);
            this.CalcButton.TabIndex = 12;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = false;
            this.CalcButton.Click += new System.EventHandler(this.Calc_Click);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.DarkGray;
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output.ForeColor = System.Drawing.Color.RoyalBlue;
            this.output.Location = new System.Drawing.Point(14, 323);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(456, 33);
            this.output.TabIndex = 13;
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SelecterBar
            // 
            this.SelecterBar.Location = new System.Drawing.Point(175, 255);
            this.SelecterBar.Maximum = 1;
            this.SelecterBar.Minimum = 1;
            this.SelecterBar.Name = "SelecterBar";
            this.SelecterBar.Size = new System.Drawing.Size(117, 45);
            this.SelecterBar.TabIndex = 14;
            this.SelecterBar.Value = 1;
            this.SelecterBar.Scroll += new System.EventHandler(this.SelecterBar_Scroll);
            // 
            // SolutionsCount
            // 
            this.SolutionsCount.AutoSize = true;
            this.SolutionsCount.Location = new System.Drawing.Point(298, 255);
            this.SolutionsCount.Name = "SolutionsCount";
            this.SolutionsCount.Size = new System.Drawing.Size(101, 25);
            this.SolutionsCount.TabIndex = 15;
            this.SolutionsCount.Text = "Count: 0";
            this.SolutionsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Selected
            // 
            this.Selected.BackColor = System.Drawing.Color.DarkGray;
            this.Selected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Selected.Location = new System.Drawing.Point(3, 255);
            this.Selected.Name = "Selected";
            this.Selected.ReadOnly = true;
            this.Selected.Size = new System.Drawing.Size(166, 33);
            this.Selected.TabIndex = 16;
            this.Selected.Text = "Selected: 1";
            this.Selected.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KryptoSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(482, 371);
            this.Controls.Add(this.Selected);
            this.Controls.Add(this.SolutionsCount);
            this.Controls.Add(this.SelecterBar);
            this.Controls.Add(this.output);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "KryptoSolver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Krypto Solver";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelecterBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private TextBox input1;
        private Panel panel1;
        private TextBox input6;
        private TextBox input5;
        private TextBox input4;
        private TextBox input3;
        private TextBox input2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button CalcButton;
        private TextBox output;
        private TrackBar SelecterBar;
        private Label SolutionsCount;
        private TextBox Selected;
    }
}