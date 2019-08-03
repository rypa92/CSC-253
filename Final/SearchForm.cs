using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCP_CSC253_2018
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text)){
                Customers_Form.searchName = null;
            }
            else
            {
                Customers_Form.searchName = "%" + txtName.Text + "%";
            }
            if (String.IsNullOrWhiteSpace(txtPhone.Text))
            {
                Customers_Form.searchPhone = null;
            }
            else
            {
                Customers_Form.searchPhone = "%" + txtPhone.Text + "%";
            }
            if (String.IsNullOrWhiteSpace(txtPrice.Text))
            {
                Customers_Form.searchPrice = null;
            }
            else
            {
                Customers_Form.searchPrice = txtPrice.Text;
            }
            if (String.IsNullOrWhiteSpace(txtSize.Text))
            {
                Customers_Form.searchSize = null;
            }
            else
            {
                Customers_Form.searchSize = txtSize.Text;
            }
            if (String.IsNullOrWhiteSpace(txtToppings.Text))
            {
                Customers_Form.searchToppings = null;
            }
            else
            {
                Customers_Form.searchToppings = "%" + txtToppings.Text + "%";
            }
            this.Close();
        }
    }
}
