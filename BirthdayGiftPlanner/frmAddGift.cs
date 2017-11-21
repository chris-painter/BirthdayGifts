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
    public partial class frmAddGift : Form
    {
        Person Person = new Person();

        public frmAddGift(Gift gift)
        {
            InitializeComponent();
        }

        public frmAddGift(Person person)
        {
            InitializeComponent();
            Person = person;

            txtBudget.Text = Person.Budget.ToString("c");
            if (Person.Gifts != null)
            { }
                double total = 0;
                for (int i = 0; i < Person.Gifts.Count; i++)
                {
                    total = total + Person.Gifts[i].TotalPrice;
                }

                txtTotal.Text = total.ToString("c");
                double remaining = Person.Budget - total;
                txtRemaining.Text = remaining.ToString("c");
            }
        //Eh

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Gift nGift = new Gift();
            nGift.Name = txtName.Text;
            nGift.Price = Double.Parse(txtPrice.Text);
            nGift.Quantity = Convert.ToInt32(nud.Value);

            double total = 0;
            for(int i = 0; i < Person.Gifts.Count; i++)
            {
                total = total + nGift.TotalPrice;
            }
            if(total > Person.Budget)
            {
                MessageBox.Show("You have exceeded your budget!");
            }
            else
            {
                this.Tag = nGift;
                DialogResult = DialogResult.OK;
                this.Close();
            }

            //Person.Gifts.Add(nGift);
            
           
        }
    }
    }

