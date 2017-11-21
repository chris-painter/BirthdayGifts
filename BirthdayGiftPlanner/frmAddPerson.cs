using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChrisPainter_BirthdayGiftPlanner
{
    public partial class frmAddPerson : Form
    {
        Person newPerson = new Person();
        public frmAddPerson()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            newPerson.Name = txtName.Text;
            newPerson.Birthday = DateTime.Parse(txtBirthday.Text);
            newPerson.Relationship = txtRelationship.Text;
            newPerson.Budget = Double.Parse(txtBudget.Text);

            this.Tag = newPerson;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
