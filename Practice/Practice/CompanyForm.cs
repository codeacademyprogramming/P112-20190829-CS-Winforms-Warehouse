using Practice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class CompanyForm : Form
    {
        List<Company> comps;
        int selectedR = -1;
        public CompanyForm(List<Company> companies )
        {
            InitializeComponent();
            comps = companies;
        }

        private void DataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedR = dgvCompanies.SelectedRows[0].Index;
            Company c = comps[selectedR];

            txtName.Text = c.Name;
            txtPhone.Text = c.Phone;
            txtAddress.Text = c.Address;
        }

        private void BtnSaveUpdate_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company.Name = txtName.Text;
            company.Phone = txtPhone.Text;
            company.Address = txtAddress.Text;

            comps.Add(company);
            GenerateCompanies();
        }

        private void GenerateCompanies()
        {
            ResetForm();

            dgvCompanies.Rows.Clear();

            foreach (Company item in comps)
            {
                dgvCompanies.Rows.Add(item.Name.ToUpper(), item.Phone.ToUpper(), item.Address.ToUpper());
            }
        }

        private void ResetForm()
        {
            txtAddress.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }
    }
}
