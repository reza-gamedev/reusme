using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContacts
{
    public partial class AddOREditForm : Form
    {
        public int ContactID;
        IContactsRepository repository;
        public AddOREditForm()
        {
            InitializeComponent();
            repository = new ContactsRepository();
            this.Load += AddOREditForm_Load;
        }


        private void AddOREditForm_Load(object? sender, EventArgs e)
        {
            if (ContactID == 0)
            {
                this.Text = "Add Contact";
            }
            else
            {
                this.Text = "Edit Contact";
                DataTable dt = repository.selectRow(ContactID);
                txtName.Text = dt.Rows[0][1].ToString();
                txtFamily.Text = dt.Rows[0][2].ToString();
                txtEmail.Text = dt.Rows[0][4].ToString();
                numAge.Value = Convert.ToInt32(dt.Rows[0][3]);
            }
        }
        bool ValidateInputs()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please Enter 'Name'", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtFamily.Text == "")
            {
                MessageBox.Show("Please Enter 'Family'", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (numAge.Value == 0)
            {
                MessageBox.Show("Please Enter 'Age'", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please Enter 'Email'", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (ValidateInputs() == true)
            {
                bool issuccess;
                if (ContactID == 0)
                {
                    issuccess = repository.insertContact(txtName.Text, txtFamily.Text, (int)numAge.Value, txtEmail.Text);
                }
                else
                {
                    issuccess = repository.editContact(ContactID, txtName.Text, txtFamily.Text, (int)numAge.Value, txtEmail.Text);
                }
                if (issuccess == true)
                {
                    MessageBox.Show("Program was successfull!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Program was not successfull!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
