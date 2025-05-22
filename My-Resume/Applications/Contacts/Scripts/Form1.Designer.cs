namespace MyContacts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgContacts = new DataGridView();
            ContactID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Family = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            Refreshbtn = new ToolStripButton();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            addANewContactToolStripMenuItem = new ToolStripMenuItem();
            Addbtn = new ToolStripMenuItem();
            Editbtn = new ToolStripMenuItem();
            Deletebtn = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgContacts).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(13, 25);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(756, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Tag = "";
            groupBox1.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(585, 32);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 29);
            label1.Name = "label1";
            label1.Size = new Size(151, 24);
            label1.TabIndex = 0;
            label1.Text = "Search(Name) :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgContacts);
            groupBox2.Location = new Point(13, 121);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(756, 419);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Contacts";
            // 
            // dgContacts
            // 
            dgContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgContacts.BackgroundColor = SystemColors.Control;
            dgContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgContacts.Columns.AddRange(new DataGridViewColumn[] { ContactID, name, Family, Age, Email });
            dgContacts.Location = new Point(7, 22);
            dgContacts.Name = "dgContacts";
            dgContacts.RowHeadersWidth = 51;
            dgContacts.Size = new Size(742, 390);
            dgContacts.TabIndex = 0;
            // 
            // ContactID
            // 
            ContactID.DataPropertyName = "ContactID";
            ContactID.HeaderText = "ContactID";
            ContactID.MinimumWidth = 6;
            ContactID.Name = "ContactID";
            ContactID.Visible = false;
            // 
            // name
            // 
            name.DataPropertyName = "Name";
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            // 
            // Family
            // 
            Family.DataPropertyName = "Family";
            Family.HeaderText = "Family";
            Family.MinimumWidth = 6;
            Family.Name = "Family";
            // 
            // Age
            // 
            Age.DataPropertyName = "Age";
            Age.HeaderText = "Age";
            Age.MinimumWidth = 6;
            Age.Name = "Age";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { Refreshbtn, toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(782, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // Refreshbtn
            // 
            Refreshbtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Refreshbtn.Image = (Image)resources.GetObject("Refreshbtn.Image");
            Refreshbtn.ImageTransparentColor = Color.Magenta;
            Refreshbtn.Name = "Refreshbtn";
            Refreshbtn.Size = new Size(29, 24);
            Refreshbtn.Text = "toolStripButton1";
            Refreshbtn.Click += Refreshbtn_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { addANewContactToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(89, 24);
            toolStripDropDownButton1.Text = "Option";
            // 
            // addANewContactToolStripMenuItem
            // 
            addANewContactToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Addbtn, Editbtn, Deletebtn });
            addANewContactToolStripMenuItem.Image = (Image)resources.GetObject("addANewContactToolStripMenuItem.Image");
            addANewContactToolStripMenuItem.Name = "addANewContactToolStripMenuItem";
            addANewContactToolStripMenuItem.Size = new Size(193, 26);
            addANewContactToolStripMenuItem.Text = "Contact Option";
            // 
            // Addbtn
            // 
            Addbtn.Image = (Image)resources.GetObject("Addbtn.Image");
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(136, 26);
            Addbtn.Text = "Add";
            Addbtn.Click += Addbtn_Click;
            // 
            // Editbtn
            // 
            Editbtn.Image = (Image)resources.GetObject("Editbtn.Image");
            Editbtn.Name = "Editbtn";
            Editbtn.Size = new Size(136, 26);
            Editbtn.Text = "Edit";
            Editbtn.Click += Editbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.Image = (Image)resources.GetObject("Deletebtn.Image");
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(136, 26);
            Deletebtn.Text = "Delete";
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Contacts";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgContacts).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ToolStrip toolStrip1;
        private ToolStripButton Refreshbtn;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem addANewContactToolStripMenuItem;
        private ToolStripMenuItem Addbtn;
        private ToolStripMenuItem Editbtn;
        private ToolStripMenuItem Deletebtn;
        private DataGridView dgContacts;
        private DataGridViewTextBoxColumn ContactID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Family;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Email;
        private TextBox textBox1;
        private Label label1;
    }
}
