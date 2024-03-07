namespace Calculator_1
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
            txtDisplay = new TextBox();
            btnEqual = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn10 = new Button();
            btnPlus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnMinus = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(5, 12);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(360, 53);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextChanged += txtDisplay_TextChanged;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(5, 561);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(360, 59);
            btnEqual.TabIndex = 1;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(60, 310);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 60);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button2_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(153, 310);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 60);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(241, 310);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 60);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(60, 218);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 60);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click_1;
            // 
            // btn5
            // 
            btn5.Location = new Point(153, 218);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 60);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click_1;
            // 
            // btn6
            // 
            btn6.Location = new Point(241, 218);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 60);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click_1;
            // 
            // btn7
            // 
            btn7.Location = new Point(60, 124);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 60);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button8_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(153, 124);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 60);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(241, 124);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 60);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn10
            // 
            btn10.Location = new Point(153, 400);
            btn10.Name = "btn10";
            btn10.Size = new Size(60, 60);
            btn10.TabIndex = 11;
            btn10.Text = "0";
            btn10.UseVisualStyleBackColor = true;
            btn10.Click += btn10_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(60, 483);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(60, 60);
            btnPlus.TabIndex = 12;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(60, 400);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(60, 60);
            btnMultiply.TabIndex = 13;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += button13_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(241, 400);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(60, 60);
            btnDivide.TabIndex = 14;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(241, 483);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(60, 60);
            btnMinus.TabIndex = 15;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(153, 483);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(60, 60);
            btnClear.TabIndex = 16;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(369, 632);
            Controls.Add(btnClear);
            Controls.Add(btnMinus);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnPlus);
            Controls.Add(btn10);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnEqual);
            Controls.Add(txtDisplay);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnEqual;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn10;
        private Button btnPlus;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnMinus;
        private Button btnClear;
    }
}
