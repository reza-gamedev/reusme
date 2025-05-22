namespace Calculator
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
            label1 = new Label();
            label2 = new Label();
            PlusButton = new Button();
            DevideButton = new Button();
            MultipleButton = new Button();
            MinusButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 24);
            label1.TabIndex = 0;
            label1.Text = "number 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 49);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 24);
            label2.TabIndex = 1;
            label2.Text = "number 2:";
            // 
            // PlusButton
            // 
            PlusButton.Location = new Point(12, 86);
            PlusButton.Name = "PlusButton";
            PlusButton.Size = new Size(76, 55);
            PlusButton.TabIndex = 4;
            PlusButton.Text = "+";
            PlusButton.UseVisualStyleBackColor = true;
            PlusButton.Click += PlusButton_Click;
            // 
            // DevideButton
            // 
            DevideButton.Location = new Point(259, 86);
            DevideButton.Name = "DevideButton";
            DevideButton.Size = new Size(76, 55);
            DevideButton.TabIndex = 5;
            DevideButton.Text = "/";
            DevideButton.UseVisualStyleBackColor = true;
            DevideButton.Click += DevideButton_Click;
            // 
            // MultipleButton
            // 
            MultipleButton.Location = new Point(177, 86);
            MultipleButton.Name = "MultipleButton";
            MultipleButton.Size = new Size(76, 55);
            MultipleButton.TabIndex = 6;
            MultipleButton.Text = "*";
            MultipleButton.UseVisualStyleBackColor = true;
            MultipleButton.Click += MultipleButton_Click;
            // 
            // MinusButton
            // 
            MinusButton.Location = new Point(95, 86);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(76, 55);
            MinusButton.TabIndex = 7;
            MinusButton.Text = "-";
            MinusButton.UseVisualStyleBackColor = true;
            MinusButton.Click += MinusButton_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(12, 147);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(323, 32);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Location = new Point(122, 9);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 32);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Location = new Point(122, 49);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(205, 32);
            textBox3.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 185);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(MinusButton);
            Controls.Add(MultipleButton);
            Controls.Add(DevideButton);
            Controls.Add(PlusButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button PlusButton;
        private Button DevideButton;
        private Button MultipleButton;
        private Button MinusButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
