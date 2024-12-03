namespace hw
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
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            checkBox1 = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(128, 121);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(164, 12);
            button2.Name = "button2";
            button2.Size = new Size(128, 121);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(319, 12);
            button3.Name = "button3";
            button3.Size = new Size(128, 121);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(12, 155);
            button4.Name = "button4";
            button4.Size = new Size(128, 121);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button5
            // 
            button5.Enabled = false;
            button5.Location = new Point(164, 155);
            button5.Name = "button5";
            button5.Size = new Size(128, 121);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button1_Click;
            // 
            // button6
            // 
            button6.Enabled = false;
            button6.Location = new Point(319, 155);
            button6.Name = "button6";
            button6.Size = new Size(128, 121);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button1_Click;
            // 
            // button7
            // 
            button7.Enabled = false;
            button7.Location = new Point(12, 301);
            button7.Name = "button7";
            button7.Size = new Size(128, 121);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button1_Click;
            // 
            // button8
            // 
            button8.Enabled = false;
            button8.Location = new Point(164, 301);
            button8.Name = "button8";
            button8.Size = new Size(128, 121);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button1_Click;
            // 
            // button9
            // 
            button9.Enabled = false;
            button9.Location = new Point(319, 301);
            button9.Name = "button9";
            button9.Size = new Size(128, 121);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button1_Click;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ActiveCaption;
            button10.Location = new Point(619, 29);
            button10.Name = "button10";
            button10.Size = new Size(169, 50);
            button10.TabIndex = 9;
            button10.Text = "Начать игру";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(619, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(169, 118);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(13, 65);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Сложно";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(13, 29);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(57, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Легко";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(619, 95);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(171, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Компьютер ходит первым";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(checkBox1);
            Controls.Add(groupBox1);
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
            Name = "Form1";
            Text = "Form1";
            Click += button1_Click;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private GroupBox groupBox1;
        private CheckBox checkBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}