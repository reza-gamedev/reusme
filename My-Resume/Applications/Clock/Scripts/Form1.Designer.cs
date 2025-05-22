namespace Clock
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
            groupBox1 = new GroupBox();
            SecondLbl = new Label();
            MinuteLbl = new Label();
            label3 = new Label();
            label2 = new Label();
            HourLbl = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.WindowText;
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(SecondLbl);
            groupBox1.Controls.Add(MinuteLbl);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(HourLbl);
            groupBox1.Location = new Point(-1, -11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(218, 77);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // SecondLbl
            // 
            SecondLbl.AutoSize = true;
            SecondLbl.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SecondLbl.ForeColor = Color.Chartreuse;
            SecondLbl.Location = new Point(169, 23);
            SecondLbl.Name = "SecondLbl";
            SecondLbl.Size = new Size(42, 32);
            SecondLbl.TabIndex = 4;
            SecondLbl.Text = "52";
            SecondLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MinuteLbl
            // 
            MinuteLbl.AutoSize = true;
            MinuteLbl.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MinuteLbl.ForeColor = Color.Chartreuse;
            MinuteLbl.Location = new Point(91, 23);
            MinuteLbl.Name = "MinuteLbl";
            MinuteLbl.Size = new Size(42, 32);
            MinuteLbl.TabIndex = 3;
            MinuteLbl.Text = "47";
            MinuteLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Chartreuse;
            label3.Location = new Point(139, 23);
            label3.Name = "label3";
            label3.Size = new Size(24, 32);
            label3.TabIndex = 2;
            label3.Text = ":";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Chartreuse;
            label2.Location = new Point(61, 23);
            label2.Name = "label2";
            label2.Size = new Size(24, 32);
            label2.TabIndex = 1;
            label2.Text = ":";
            // 
            // HourLbl
            // 
            HourLbl.AutoSize = true;
            HourLbl.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HourLbl.ForeColor = Color.Chartreuse;
            HourLbl.Location = new Point(13, 23);
            HourLbl.Name = "HourLbl";
            HourLbl.Size = new Size(42, 32);
            HourLbl.TabIndex = 0;
            HourLbl.Text = "12";
            HourLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowText;
            ClientSize = new Size(216, 64);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "TimeClock";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label HourLbl;
        private Label SecondLbl;
        private Label MinuteLbl;
        private Label label3;
        private Label label2;
    }
}
