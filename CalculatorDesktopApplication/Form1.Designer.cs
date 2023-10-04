namespace CalculatorDesktopApplication
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
            textBox1 = new TextBox();
            Num1 = new Button();
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Binary = new Label();
            Hexadecimal = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(534, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Num1
            // 
            Num1.AccessibleDescription = "Num1";
            Num1.AccessibleName = "Num1";
            Num1.Location = new Point(129, 122);
            Num1.Name = "Num1";
            Num1.Size = new Size(75, 23);
            Num1.TabIndex = 1;
            Num1.Text = "1";
            Num1.UseVisualStyleBackColor = true;
            Num1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AccessibleDescription = "Num2";
            button2.AccessibleName = "Num2";
            button2.Location = new Point(268, 122);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AccessibleDescription = "Num3";
            button3.AccessibleName = "Num3";
            button3.Location = new Point(422, 122);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.AccessibleDescription = "Num4";
            button4.AccessibleName = "Num4";
            button4.Location = new Point(129, 189);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.AccessibleDescription = "Num5";
            button5.AccessibleName = "Num5";
            button5.Location = new Point(268, 189);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.AccessibleDescription = "Num6";
            button6.AccessibleName = "Num6";
            button6.Location = new Point(422, 189);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.AccessibleDescription = "Num7";
            button7.AccessibleName = "Num7";
            button7.Location = new Point(129, 264);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.AccessibleDescription = "Num8";
            button8.AccessibleName = "Num8";
            button8.Location = new Point(268, 264);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.AccessibleDescription = "Num9";
            button9.AccessibleName = "Num9";
            button9.Location = new Point(422, 264);
            button9.Name = "button9";
            button9.Size = new Size(75, 23);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.AccessibleDescription = "Num0";
            button10.AccessibleName = "Num0";
            button10.Location = new Point(129, 336);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.AccessibleDescription = "Dot";
            button11.AccessibleName = "Dot";
            button11.Location = new Point(268, 336);
            button11.Name = "button11";
            button11.Size = new Size(75, 23);
            button11.TabIndex = 11;
            button11.Text = ".";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.AccessibleDescription = "equal";
            button12.AccessibleName = "equal";
            button12.Location = new Point(422, 336);
            button12.Name = "button12";
            button12.Size = new Size(75, 23);
            button12.TabIndex = 12;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.AccessibleDescription = "Plus";
            button13.AccessibleName = "Plus";
            button13.Location = new Point(573, 122);
            button13.Name = "button13";
            button13.Size = new Size(75, 23);
            button13.TabIndex = 13;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.AccessibleDescription = "Subtract";
            button14.AccessibleName = "Subtract";
            button14.Location = new Point(573, 189);
            button14.Name = "button14";
            button14.Size = new Size(75, 23);
            button14.TabIndex = 14;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.AccessibleDescription = "Multiply";
            button15.AccessibleName = "Multiply";
            button15.Location = new Point(573, 264);
            button15.Name = "button15";
            button15.Size = new Size(75, 23);
            button15.TabIndex = 15;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.AccessibleDescription = "Divide";
            button16.AccessibleName = "Divide";
            button16.Location = new Point(573, 336);
            button16.Name = "button16";
            button16.Size = new Size(75, 23);
            button16.TabIndex = 16;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(229, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(434, 23);
            textBox2.TabIndex = 17;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(229, 77);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(434, 23);
            textBox3.TabIndex = 18;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Binary
            // 
            Binary.AccessibleDescription = "Binary";
            Binary.AccessibleName = "Binary";
            Binary.AutoSize = true;
            Binary.Location = new Point(129, 47);
            Binary.Name = "Binary";
            Binary.Size = new Size(56, 17);
            Binary.TabIndex = 19;
            Binary.Text = "Binary：";
            Binary.Click += label1_Click;
            // 
            // Hexadecimal
            // 
            Hexadecimal.AccessibleDescription = "Hexadecimal";
            Hexadecimal.AccessibleName = "Hexadecimal";
            Hexadecimal.AutoSize = true;
            Hexadecimal.Location = new Point(129, 83);
            Hexadecimal.Name = "Hexadecimal";
            Hexadecimal.Size = new Size(94, 17);
            Hexadecimal.TabIndex = 20;
            Hexadecimal.Text = "Hexadecimal：";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Hexadecimal);
            Controls.Add(Binary);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
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
            Controls.Add(Num1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Num1;
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
        private TextBox textBox2;
        private TextBox textBox3;
        private Label Binary;
        private Label Hexadecimal;
    }
}