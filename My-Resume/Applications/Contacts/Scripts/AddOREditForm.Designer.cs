namespace MyContacts
{
    partial class AddOREditForm
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
            Information = new GroupBox();
            submitbtn = new Button();
            emaillbl = new Label();
            txtEmail = new TextBox();
            agelbl = new Label();
            familylbl = new Label();
            txtFamily = new TextBox();
            namelbl = new Label();
            numAge = new NumericUpDown();
            txtName = new TextBox();
            Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            SuspendLayout();
            // 
            // Information
            // 
            Information.Controls.Add(submitbtn);
            Information.Controls.Add(emaillbl);
            Information.Controls.Add(txtEmail);
            Information.Controls.Add(agelbl);
            Information.Controls.Add(familylbl);
            Information.Controls.Add(txtFamily);
            Information.Controls.Add(namelbl);
            Information.Controls.Add(numAge);
            Information.Controls.Add(txtName);
            Information.Location = new Point(12, 12);
            Information.Name = "Information";
            Information.Size = new Size(413, 170);
            Information.TabIndex = 0;
            Information.TabStop = false;
            Information.Text = "Information";
            // 
            // submitbtn
            // 
            submitbtn.Location = new Point(305, 135);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(94, 29);
            submitbtn.TabIndex = 9;
            submitbtn.Text = "Submit";
            submitbtn.UseVisualStyleBackColor = true;
            submitbtn.Click += submitbtn_Click;
            // 
            // emaillbl
            // 
            emaillbl.AutoSize = true;
            emaillbl.Location = new Point(6, 101);
            emaillbl.Name = "emaillbl";
            emaillbl.Size = new Size(56, 21);
            emaillbl.TabIndex = 8;
            emaillbl.Text = "email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(66, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(333, 28);
            txtEmail.TabIndex = 7;
            // 
            // agelbl
            // 
            agelbl.AutoSize = true;
            agelbl.Location = new Point(6, 64);
            agelbl.Name = "agelbl";
            agelbl.Size = new Size(43, 21);
            agelbl.TabIndex = 6;
            agelbl.Text = "age:";
            // 
            // familylbl
            // 
            familylbl.AutoSize = true;
            familylbl.Location = new Point(214, 34);
            familylbl.Name = "familylbl";
            familylbl.Size = new Size(60, 21);
            familylbl.TabIndex = 4;
            familylbl.Text = "family:";
            // 
            // txtFamily
            // 
            txtFamily.Location = new Point(274, 31);
            txtFamily.Name = "txtFamily";
            txtFamily.Size = new Size(125, 28);
            txtFamily.TabIndex = 3;
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Location = new Point(6, 34);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(57, 21);
            namelbl.TabIndex = 2;
            namelbl.Text = "name:";
            // 
            // numAge
            // 
            numAge.Location = new Point(66, 64);
            numAge.Name = "numAge";
            numAge.Size = new Size(125, 28);
            numAge.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(66, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 28);
            txtName.TabIndex = 0;
            // 
            // AddOREditForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 194);
            Controls.Add(Information);
            Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddOREditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add(Edit) Contact";
            Load += AddOREditForm_Load;
            Information.ResumeLayout(false);
            Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Information;
        private Label agelbl;
        private Label familylbl;
        private TextBox txtFamily;
        private Label namelbl;
        private NumericUpDown numAge;
        private TextBox txtName;
        private Label emaillbl;
        private TextBox txtEmail;
        private Button submitbtn;
    }
}