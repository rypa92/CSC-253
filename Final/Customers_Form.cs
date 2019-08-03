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
    public partial class Customers_Form : Form
    {
        public static int formToLoad { get; set; }
        public static string searchName { get; set; }
        public static string searchPrice { get; set; }
        public static string searchPhone { get; set; }
        public static string searchToppings { get; set; }
        public static string searchSize { get; set; }

        public Customers_Form()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.customersTableAdapter.Update(this.dB_pizzaDataSet.Customers);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_pizzaDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dB_pizzaDataSet.Customers);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Orders_Form)
                {
                    open = true;
                }
                else 
                {
                    open = false;
                }
            }
            if (open)
            {
                MessageBox.Show("Orders is already open.");
            } else
            {
                Form orders = new Orders_Form();
                orders.Show();
            }
        }

        private void btnToppings_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Toppings_Form)
                {
                    open = true;
                }
                else
                {
                    open = false;
                }
            }
            if (open)
            {
                MessageBox.Show("Toppings is already open.");
            }
            else
            {
                Form toppings = new Toppings_Form();
                toppings.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            formToLoad = 0;
            Form search = new SearchForm();
            search.ShowDialog();
            Form results = new SearchResults_Form();
            results.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.dB_pizzaDataSet.Customers);
        }

        private void btn404_Click(object sender, EventArgs e)
        {
            formToLoad = 1;
            Form view = new SearchResults_Form();
            view.ShowDialog();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            formToLoad = 2;
            Form view = new SearchResults_Form();
            view.ShowDialog();
        }

        private void btnExpensive_Click(object sender, EventArgs e)
        {
            formToLoad = 3;
            Form view = new SearchResults_Form();
            view.ShowDialog();
        }
    }
}
