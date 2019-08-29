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
    public partial class CategoryForm : Form
    {
        List<Category> kateqoriyalar;
        int selectedIndex = -1;


        public CategoryForm(List<Category> cat)
        {
            InitializeComponent();
            kateqoriyalar = cat;
        }

        private void BtnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (selectedIndex == -1)
            {

                Category c = new Category();
                c.Name = txtCategoryName.Text;
                kateqoriyalar.Add(c);
                GenerateCategories();

            } else
            {
                kateqoriyalar[selectedIndex].Name = txtCategoryName.Text;
               

                GenerateCategories();

            }

        }

        private void GenerateCategories()
        {
            ResetForm();
            lbxCategories.Items.Clear();
            foreach (Category category in kateqoriyalar)
            {
                lbxCategories.Items.Add(category.Name);
            }
        }

        private void ResetForm()
        {
            btnDelete.Enabled = false;
            selectedIndex = -1;
            btnSaveUpdate.Text = "Save";
            txtCategoryName.Text = "";
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            GenerateCategories();

        }


        private void LbxCategories_DoubleClick(object sender, EventArgs e)
        {
            selectedIndex = lbxCategories.SelectedIndex;

            if (selectedIndex >= 0)
            {
                btnSaveUpdate.Text = "Edit";
                txtCategoryName.Text = kateqoriyalar[selectedIndex].Name;
                btnDelete.Enabled = true;
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            //kateqoriyalar.Remove(kateqoriyalar[selectedIndex]);
            kateqoriyalar.RemoveAt(selectedIndex);
            GenerateCategories();
        }
    }
}
