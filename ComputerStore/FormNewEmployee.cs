using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerStore
{
    public partial class FormNewEmployee : Form
    {
        public FormNewEmployee()
        {
            InitializeComponent();
        }

        private void FormNewEmployee_Load(object sender, EventArgs e)
        {

            List<Title> titles = DataAccess.ReadAllTitle();
            //bsTitle.DataSource = titles;
            // ucitaj titles iz baze
            // [dodaj binding source]

            cmbTitle.DataSource = titles;
            cmbTitle.DisplayMember = "TitleName";
            cmbTitle.ValueMember = "IdTitle";
            cmbTitle.SelectedItem = null;
            cmbTitle.Text = "Izaberi sa liste";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text != "" && txtFirstName.Text != ""
                 && cmbTitle.SelectedItem != null  )
            {
                // insert za employee-a
                DataAccess.CreateNewEmployee(txtLastName.Text, txtFirstName.Text
                    , (int)cmbTitle.SelectedValue, txtIdPerson.Text, txtCellPhone.Text, txtAddress.Text, txtCity.Text);

                // resetovanje polja za unos
                //txtLastName.Text = "";
                //txtFirstName.Clear();
                //cmbTitle.SelectedItem = null;

                this.Close();
            }
            else
            {
                MessageBox.Show("Morate uneti sve podatke.");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
