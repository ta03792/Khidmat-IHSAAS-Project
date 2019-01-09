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
    public partial class AssetsForm : Form
    {
        public AssetsForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string q = "SELECT ApplicationNumber, FirstName, LastName, CNIC, CellNo FROM dbo.Application DA INNER JOIn dbo.ApplicantAssets DAS ON DA.ApplicationNumber = DAS.Application_ApplicationNumber WHERE";

                if (FromFluidCash.Text != "" && ToFluidCash.Text != "")
                {
                    q += " DAS.MoneyOwned BETWEEN " + Convert.ToInt64(FromFluidCash.Text) + " AND " + Convert.ToInt64(ToFluidCash.Text) + " AND ";
                }
                if (FromGold.Text != "" && ToGold.Text != "")
                {
                    q += " DAS.Gold BETWEEN " + Convert.ToInt64(FromGold.Text) + " AND " + Convert.ToInt64(ToGold .Text) + " AND ";
                }
                if (FromSilver.Text != "" && ToSilver.Text != "")
                {
                    q += " DAS.Silver BETWEEN " + Convert.ToInt64(FromSilver.Text) + " AND " + Convert.ToInt64(ToSilver.Text) + " AND ";
                }
                if (FromWares.Text != "" && ToWares.Text != "")
                {
                    q += " DAS.Wares BETWEEN " + Convert.ToInt64(FromWares.Text) + " AND " + Convert.ToInt64(ToWares.Text) + " AND ";
                }
                if (FromBC.Text != "" && ToBC.Text != "")
                {
                    q += " DAS.BCInstallmentsLeft BETWEEN " + Convert.ToInt64(FromBC.Text) + " AND " + Convert.ToInt64(ToBC.Text) + " AND ";
                }
                if (FromAnimals.Text != "" && ToAnimals.Text != "")
                {
                    q += " DAS.AnimalBreed BETWEEN " + Convert.ToInt64(FromAnimals.Text) + " AND " + Convert.ToInt64(ToAnimals.Text) + " AND ";
                }
                if (CPNotinUse.Text != "")
                {
                    q += " DAS.NoOfCells = " + Convert.ToInt64(CPNotinUse.Text) + " AND ";
                }
                if (VNotinUse.Text != "")
                {
                    q += " DAS.NoOfVehicles = " + Convert.ToInt64(VNotinUse.Text) + " AND ";
                }
                if (FromLoans.Text != "" && ToLoans.Text != "")
                {
                    q += " DAS.LoansGivenToSomeone BETWEEN " + Convert.ToInt64(FromLoans.Text) + " AND " + Convert.ToInt64(ToLoans.Text) + " AND ";
                }
                if (PNotinUse.Text != "")
                {
                    q += " DAS.UnusedPlots = " + Convert.ToInt64(PNotinUse.Text) + " AND ";
                }
                if (LuxuryItems.Text != "")
                {
                    q += " DAS.LuxuryItems = " + Convert.ToInt64(LuxuryItems.Text) + " AND ";
                }

                string finalstring = "";
                for (int j = 0; j < q.Length - 5; j++)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool val = true;


            ApplicationForm profile = new ApplicationForm(val, Results.SelectedRows[0].Cells[0].Value.ToString());
            profile.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool val = false;

            ApplicationForm profile = new ApplicationForm(val, Results.SelectedRows[0].Cells[0].Value.ToString());
            profile.Show();
        }
    }
}
