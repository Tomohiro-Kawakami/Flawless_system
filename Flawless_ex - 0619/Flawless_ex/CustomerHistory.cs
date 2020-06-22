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
    public partial class CustomerHistory : Form
    {
        int staff_id;
        MainMenu mainMenu;
        public CustomerHistory(MainMenu main, int id)
        {
            InitializeComponent();
            staff_id = id;
            mainMenu = main;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            mainMenu.Show();
        }

        private void data_searchButton_Click(object sender, EventArgs e)//検索ボタン
        {
            Data_search_results data_Search = new Data_search_results(this);

            this.Hide();
            data_Search.Show();
        }
    }
}
