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
    public partial class Toppings_Form : Form
    {
        public Toppings_Form()
        {
            InitializeComponent();
        }

        private void toppingsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.toppingsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_pizzaDataSet);

        }

        private void Toppings_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_pizzaDataSet.Toppings' table. You can move, or remove it, as needed.
            this.toppingsTableAdapter.Fill(this.dB_pizzaDataSet.Toppings);

        }
    }
}
