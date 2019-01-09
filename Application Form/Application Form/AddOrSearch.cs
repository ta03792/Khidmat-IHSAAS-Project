using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Form
{
    public partial class AddOrSearch : Form
    {
        public AddOrSearch()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplicationForm add = new ApplicationForm();
            add.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssetsForm search = new AssetsForm();
            search.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForm search = new SearchForm();
            search.Show();
        }
    }
}
