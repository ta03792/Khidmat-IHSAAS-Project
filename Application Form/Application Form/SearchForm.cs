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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            {
                Results.DataSource = null;
                Results.Rows.Clear();

                string i = "";
                string q = "SELECT DISTINCT ApplicationNumber, FirstName, LastName, CNIC, CellNo FROM dbo.Application DA WHERE ";

                if (Monthly.Checked == true)
                {
                    i = "Monthly";
                }
                if (OneTime.Checked == true) 
                {
                    i = "One Time";
                }
            

                if (ApplicationNumber.Text != "")
                {
                    q += " DA.ApplicationNumber = " + Convert.ToInt64(ApplicationNumber.Text) + " AND ";
                }
                if (CNIC.Text!="")
                {
                    q += " DA.CNIC = '" + CNIC.Text + "' AND ";
                }
                if (FirstName.Text != "")
                {
                    q += " DA.FirstName = '" + FirstName.Text + "' AND ";
                }
                if (LastName.Text != "")
                {
                    q += " DA.LastName = '" + LastName.Text + "' AND ";
                }
                if (Monthly.Checked == true)
                {
                    q += " DA.Payment like '" + i + "' AND ";
                }
                if (OneTime.Checked == true)
                {
                    q += " DA.Payment like '" + i + "' AND ";
                }
                if (CellNumber.Text != "")
                {
                    q += " DA.CellNo = '" + CellNumber.Text + "' AND ";
                }

                string education = "DA.ApplicationNumber in (SELECT Application_ApplicationNumber FROM Stream_has_Application DS WHERE DS.Stream_idStream = " + 1 +") AND ";
                string ration = "DA.ApplicationNumber in (SELECT Application_ApplicationNumber FROM Stream_has_Application DS WHERE DS.Stream_idStream = " + 2 + ") AND ";
                string medical = "DA.ApplicationNumber in (SELECT Application_ApplicationNumber FROM Stream_has_Application DS WHERE DS.Stream_idStream = " + 3 + ") AND ";

                if (Education.Checked == true)
                {
                    q += education;
                    //MessageBox.Show(q);
                }
                if (Ration.Checked == true)
                {
                    q += ration;
                    //MessageBox.Show(q);
                }
                if (Medical.Checked == true)
                {
                    q += medical;
                    //MessageBox.Show(q);
                }

                string finalstring = "";
                for(int j = 0;j < q.Length - 5;j++)
                {
                    finalstring += q[j];
                }

                DbConnection d = new DbConnection();
                DataTable dt = d.Select(finalstring);
                
                for (int k = 0; k < dt.Rows.Count; k++)
                {
                    string s = dt.Rows[k][0].ToString() + dt.Rows[k][1].ToString();
                    Results.DataSource = dt;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool val = true;


            ApplicationForm profile = new ApplicationForm(val, Results.SelectedRows[0].Cells[0].Value.ToString());
            profile.Show();
            
        }

        private void Results_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ration_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Monthly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {

            bool val = false;

            ApplicationForm profile = new ApplicationForm(val, Results.SelectedRows[0].Cells[0].Value.ToString());
            profile.Show();

        }
    }
}
