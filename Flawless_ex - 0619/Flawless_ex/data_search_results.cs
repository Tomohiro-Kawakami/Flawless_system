using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flawless_ex
{
    public partial class Data_search_results : Form
    {
        CustomerHistory customerHistory;
        public Data_search_results(CustomerHistory customer)
        {
            InitializeComponent();

            customerHistory = customer;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
            customerHistory.Show();
        }
    }
}
