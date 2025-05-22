namespace MyContacts
{
    public partial class Form1 : Form
    {
        IContactsRepository repository;
        public Form1()
        {
            InitializeComponent();
            repository = new ContactsRepository();
            dgMyContacts();
        }

        private void dgMyContacts()
        {
            dgContacts.AutoGenerateColumns = false;
            dgContacts.DataSource = repository.selectAll();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            AddOREditForm frm = new AddOREditForm();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                dgMyContacts();
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (dgContacts.CurrentRow != null)
            {
                int ContactID = Convert.ToInt32(dgContacts.CurrentRow.Cells[0].Value);
                AddOREditForm frm = new AddOREditForm();
                frm.ContactID = ContactID;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dgMyContacts();
                }
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (dgContacts.CurrentRow != null)
            {
                if (MessageBox.Show($"Do you want to delete this contact ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (repository.deleteContact(Convert.ToInt32(dgContacts.CurrentRow.Cells[0].Value)) == true)
                    {
                        MessageBox.Show("program was done successfully!");
                        dgMyContacts();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a contact!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            dgMyContacts();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgContacts.DataSource = repository.searchName(textBox1.Text);
        }
    }
}
