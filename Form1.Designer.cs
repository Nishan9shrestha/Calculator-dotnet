﻿namespace Calculator
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
            textBoxDisplay = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            label1 = new Label();
            button17 = new Button();
            SuspendLayout();
            // 
            // textBoxDisplay
            // 
            textBoxDisplay.Location = new Point(172, 52);
            textBoxDisplay.Multiline = true;
            textBoxDisplay.Name = "textBoxDisplay";
            textBoxDisplay.Size = new Size(396, 69);
            textBoxDisplay.TabIndex = 0;
            textBoxDisplay.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(176, 131);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 1;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(281, 181);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 2;
            button2.Text = "4";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(172, 181);
            button3.Name = "button3";
            button3.Size = new Size(75, 35);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(281, 131);
            button4.Name = "button4";
            button4.Size = new Size(75, 35);
            button4.TabIndex = 4;
            button4.Text = "1";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(281, 236);
            button5.Name = "button5";
            button5.Size = new Size(75, 35);
            button5.TabIndex = 5;
            button5.Text = "7";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(176, 236);
            button6.Name = "button6";
            button6.Size = new Size(75, 35);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(393, 181);
            button7.Name = "button7";
            button7.Size = new Size(75, 35);
            button7.TabIndex = 7;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(393, 131);
            button8.Name = "button8";
            button8.Size = new Size(75, 35);
            button8.TabIndex = 8;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(393, 236);
            button9.Name = "button9";
            button9.Size = new Size(75, 35);
            button9.TabIndex = 9;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ActiveCaption;
            button10.Location = new Point(493, 131);
            button10.Name = "button10";
            button10.Size = new Size(75, 35);
            button10.TabIndex = 10;
            button10.Text = "+";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.ActiveCaption;
            button11.Location = new Point(493, 187);
            button11.Name = "button11";
            button11.Size = new Size(75, 35);
            button11.TabIndex = 11;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = SystemColors.ActiveCaption;
            button12.Location = new Point(493, 242);
            button12.Name = "button12";
            button12.Size = new Size(75, 35);
            button12.TabIndex = 12;
            button12.Text = "/";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(176, 294);
            button13.Name = "button13";
            button13.Size = new Size(75, 29);
            button13.TabIndex = 13;
            button13.Text = "9";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.ActiveCaption;
            button14.Location = new Point(281, 294);
            button14.Name = "button14";
            button14.Size = new Size(75, 29);
            button14.TabIndex = 14;
            button14.Text = ".";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.BackColor = SystemColors.Control;
            button15.Location = new Point(362, 294);
            button15.Name = "button15";
            button15.Size = new Size(57, 29);
            button15.TabIndex = 15;
            button15.Text = "AC";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.BackColor = SystemColors.GradientActiveCaption;
            button16.Location = new Point(493, 291);
            button16.Name = "button16";
            button16.Size = new Size(75, 35);
            button16.TabIndex = 16;
            button16.Text = "=";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 9);
            label1.Name = "label1";
            label1.Size = new Size(112, 30);
            label1.TabIndex = 17;
            label1.Text = "Calculator";
            // 
            // button17
            // 
            button17.Location = new Point(425, 294);
            button17.Name = "button17";
            button17.Size = new Size(53, 29);
            button17.TabIndex = 18;
            button17.Text = "C";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button17);
            Controls.Add(label1);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxDisplay);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDisplay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Label label1;
        private Button button17;
    }
}
