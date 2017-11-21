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
    public partial class frmMain : Form
    {
        List<Person> peopleList = new List<Person>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgvPerson.DataSource = typeof(List<Person>);
            dgvPerson.DataSource = peopleList;
            //dgvPerson.Columns["Gifts"].Visible = false;
            
        }

        private void btnDataFill_Click(object sender, EventArgs e)
        {
            List<Gift> p1Gifts = new List<Gift>();
            List<Gift> p2Gifts = new List<Gift>();

            Gift g1 = new Gift();
            g1.Name = "Toolbox";
            g1.Price = 99.99;
            g1.Quantity = 1;
            p1Gifts.Add(g1);

            Gift g2 = new Gift();
            g2.Name = "Pocket Knife";
            g2.Price = 18.00;
            g2.Quantity = 5;
            p1Gifts.Add(g2);

            p2Gifts.Add(g2);

            Gift g3 = new Gift();
            g3.Name = "Football";
            g3.Price = 20.99;
            g3.Quantity = 1;
            p1Gifts.Add(g3);
                
            Person p1 = new Person();
            p1.Name = "Chris";
            p1.Relationship = "Son";
            p1.Birthday = DateTime.Parse("12/24/1996");
            p1.Budget = 1000;
            p1.Gifts = p1Gifts;
            peopleList.Add(p1);

            Person p2 = new Person();
            p2.Name = "Tom";
            p2.Relationship = "Father";
            p2.Birthday = DateTime.Parse("04/12/1965");
            p2.Budget = 20000;
            p2.Gifts = p2Gifts;
            peopleList.Add(p2);

            LoadData();
        }

        private void dgvPerson_SelectionChanged(object sender, EventArgs e)
        {          
            if(dgvPerson.SelectedRows.Count > 0)
            {
                Person p = (Person)dgvPerson.SelectedRows[0].DataBoundItem;
                txtName.Text = p.Name;
                txtRelationship.Text = p.Relationship;
                txtBirthday.Text = p.Birthday.ToString("M/dd/yyyy");
                txtBudget.Text = p.Budget.ToString();

                TimeSpan a = p.Birthday - DateTime.Now;
                txtDaystoBirthday.Text = a.ToString();

                dgvGift.DataSource = typeof(List<Gift>);
                dgvGift.DataSource = p.Gifts;

                double total = 0;
                if (p.Gifts != null)
                {
                    for (int i = 0; i < p.Gifts.Count; i++)
                    {
                        total = total + p.Gifts[i].TotalPrice;
                    }

                    txtTotal.Text = total.ToString("c");
                    double remaining = p.Budget - total;
                    txtRemaining.Text = remaining.ToString("c");
                }
            }
            
        }

        private void btnAddTop_Click(object sender, EventArgs e)
        {
            frmAddPerson add = new frmAddPerson();
            add.ShowDialog();

            if(add.DialogResult == DialogResult.OK)
            {
                Person newPerson = new Person();
                newPerson = (Person)add.Tag;
                peopleList.Add(newPerson);
                LoadData();
            }
        }

        private void dgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void btnAddBottom_Click(object sender, EventArgs e)
        {
            Person personToAddTo = new Person();
            personToAddTo = (Person)dgvPerson.SelectedRows[0].DataBoundItem;
            frmAddGift addG = new frmAddGift((Person)dgvPerson.SelectedRows[0].DataBoundItem);
            addG.ShowDialog();

            if(addG.DialogResult == DialogResult.OK)
            {
                Gift newGift = new Gift();
                newGift = (Gift)addG.Tag;
                personToAddTo.Gifts.Add(newGift);
                LoadData();

                dgvGift.DataSource = typeof(List<Gift>);
                dgvGift.DataSource = personToAddTo.Gifts;
            }
        }

        //Not completely implemented
        private void btnEditBottom_Click(object sender, EventArgs e)
        {
            Person pToEdit = new Person();
            pToEdit = (Person)dgvPerson.SelectedRows[0].DataBoundItem;
            frmAddGift edit = new frmAddGift((Gift)dgvGift.SelectedRows[0].DataBoundItem);
            edit.ShowDialog();

            if (edit.DialogResult == DialogResult.OK)
            {
                Gift newGift = new Gift();
                newGift = (Gift)edit.Tag;
                pToEdit.Gifts.Add(newGift);
                LoadData();

                dgvGift.DataSource = typeof(List<Gift>);
                dgvGift.DataSource = pToEdit.Gifts;
            }
        }

        //Not completely implemented
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Person updatePerson = new Person();
            updatePerson = (Person)dgvPerson.SelectedRows[0].DataBoundItem;

            updatePerson.Name = txtName.Text;
            updatePerson.Birthday = DateTime.Parse(txtBirthday.Text);
            updatePerson.Relationship = txtRelationship.Text;
            updatePerson.Budget = Int32.Parse(txtBudget.Text);

        }

        private void btnRemoveTop_Click(object sender, EventArgs e)
        {
            Person personToRemove = new Person();
            personToRemove = (Person)dgvPerson.SelectedRows[0].DataBoundItem;
            peopleList.Remove(personToRemove);
            LoadData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person = (Person)dgvPerson.SelectedRows[0].DataBoundItem;

            Gift giftToRemove = new Gift();
            giftToRemove = (Gift)dgvGift.SelectedRows[0].DataBoundItem;
            person.Gifts.Remove(giftToRemove);

            dgvGift.DataSource = typeof(List<Gift>);
            dgvGift.DataSource = person.Gifts;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            StringBuilder toPrint = new StringBuilder();
            for(int t = 0; t < peopleList.Count; t++)
            {
                string add = peopleList[t].Display();
                toPrint.AppendLine(add);
            }
            Person person = new Person();
            person = (Person)dgvPerson.SelectedRows[0].DataBoundItem;
            
            frmPrint print = new frmPrint(toPrint);
            print.ShowDialog();
        }
    }
}
