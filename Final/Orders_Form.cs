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
    public partial class Orders_Form : Form
    {
        public Orders_Form()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.ordersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dB_pizzaDataSet);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void Orders_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_pizzaDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.dB_pizzaDataSet.Orders);

        }
    }
}
