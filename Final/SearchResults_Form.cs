using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RCP_CSC253_2018
{
    public partial class SearchResults_Form : Form
    {
        public SearchResults_Form()
        {
            InitializeComponent();
            everythingDataGridView.Hide();
            everythingDataGridView.Location = new Point(12, 28);
            everythingDataGridView.Size = new Size(811, 204);
            dGridResults.Hide();
            dGridResults.Location = new Point(12, 28);
            dGridResults.Size = new Size(811, 204);
        }

        private void SearchResults_Form_Load(object sender, EventArgs e)
        {
            everythingDataGridView.Show();
            dGridResults.Hide();
            if (Customers_Form.formToLoad == 0)
            {
                if (Customers_Form.searchPrice == null && Customers_Form.searchSize == null)
                {
                    this.everythingTableAdapter.FillBySearch(this.dB_pizzaDataSet.Everything, Customers_Form.searchName, Customers_Form.searchPhone, null, null, Customers_Form.searchToppings);
                }
                else if (Customers_Form.searchPrice == null)
                {
                    int temp = int.Parse(Customers_Form.searchSize);
                    this.everythingTableAdapter.FillBySearch(this.dB_pizzaDataSet.Everything, Customers_Form.searchName, Customers_Form.searchPhone, null, temp, Customers_Form.searchToppings);
                }
                else if (Customers_Form.searchSize == null)
                {
                    decimal temp = decimal.Parse(Customers_Form.searchPrice);
                    this.everythingTableAdapter.FillBySearch(this.dB_pizzaDataSet.Everything, Customers_Form.searchName, Customers_Form.searchPhone, temp, null, Customers_Form.searchToppings);
                }
                else
                {
                    decimal tempDec = decimal.Parse(Customers_Form.searchPrice);
                    int tempInt = int.Parse(Customers_Form.searchSize);
                    this.everythingTableAdapter.FillBySearch(this.dB_pizzaDataSet.Everything, Customers_Form.searchName, Customers_Form.searchPhone, tempDec, tempInt, Customers_Form.searchToppings);
                }
            }
            else if (Customers_Form.formToLoad == 1)
            {
                everythingDataGridView.Hide();
                dGridResults.Show();
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\2018_Summer\CSC-253\Project\RCP_CSC253_2018\RCP_CSC253_2018\DB_pizza.mdf;Integrated Security=True;Connect Timeout=30";
                string sql = "SELECT * FROM AreaCode";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "AreaCode");
                connection.Close();
                dGridResults.DataSource = ds;
                dGridResults.DataMember = "AreaCode";
            } else if (Customers_Form.formToLoad == 2)
            {
                everythingDataGridView.Hide();
                dGridResults.Show();
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\2018_Summer\CSC-253\Project\RCP_CSC253_2018\RCP_CSC253_2018\DB_pizza.mdf;Integrated Security=True;Connect Timeout=30";
                string sql = "SELECT * FROM MainStreetCustomers";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "MainStreetCustomers");
                connection.Close();
                dGridResults.DataSource = ds;
                dGridResults.DataMember = "MainStreetCustomers";
            } else if (Customers_Form.formToLoad == 3)
            {
                everythingDataGridView.Hide();
                dGridResults.Show();
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\2018_Summer\CSC-253\Project\RCP_CSC253_2018\RCP_CSC253_2018\DB_pizza.mdf;Integrated Security=True;Connect Timeout=30";
                string sql = "SELECT * FROM ExpensivePizza";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                dataadapter.Fill(ds, "ExpensivePizza");
                connection.Close();
                dGridResults.DataSource = ds;
                dGridResults.DataMember = "ExpensivePizza";
            }
        }
    }
}
