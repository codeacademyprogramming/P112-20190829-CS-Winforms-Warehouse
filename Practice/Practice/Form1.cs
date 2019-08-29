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
    public partial class Form1 : Form
    {
        List<Category> categories;
        List<Company> companies;

        // CRUD
        // Create
        // Read
        // Update
        // Delete
        public Form1()
        {
            InitializeComponent();
            categories = new List<Category>();
            companies = new List<Company>();
        }

        private void CategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm(categories);
            categoryForm.FormClosed += new FormClosedEventHandler(FillCategories);
            categoryForm.ShowDialog();
        }

       

        private void FillCategories(object sender, EventArgs e)
        {
            cmbCategories.Items.Clear();
            foreach (Category item in categories)
            {
                cmbCategories.Items.Add(item.Name);
            }
        }

        private void CompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyForm companyForm = new CompanyForm(companies);
            companyForm.FormClosed += new FormClosedEventHandler(FillCompanies);
            companyForm.ShowDialog();

        }

        private void FillCompanies(object sender, EventArgs e)
        {
            cmbCompanies.Items.Clear();
            foreach (Company item in companies)
            {
                cmbCompanies.Items.Add(item.Name);
            }
        }
    }
}
