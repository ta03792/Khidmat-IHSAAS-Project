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
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }
        public ApplicationForm(bool val, string appNo)

        {
            // View Profile Form 
            if (val == true)
            {
                InitializeComponent();

                // Create a new datatable with the selected user
                DbConnection d = new DbConnection();
                DataTable theData = d.Select("SELECT * FROM Application WHERE ApplicationNumber = " + appNo);


                // Display values of the selected profile in the textboxes
                ApplicationNumber.Text = appNo;
                ApplicationNumber.ReadOnly = true;
                FirstName.Text = theData.Rows[0]["FirstName"].ToString();
                FirstName.ReadOnly = true;
                LastName.Text = theData.Rows[0]["LastName"].ToString();
                LastName.ReadOnly = true;
                CNIC.Text = theData.Rows[0]["CNIC"].ToString();
                CNIC.ReadOnly = true;
                FatherName.Text = theData.Rows[0]["FatherName"].ToString();
                FatherName.ReadOnly = true;

                DateInitiated.Value = DateTime.Parse(theData.Rows[0]["DateInitiated"].ToString());
                DateInitiated.Enabled = false;
                CellNumber.Text = theData.Rows[0]["CellNo"].ToString();
                CellNumber.ReadOnly = true;
                Address.Text = theData.Rows[0]["Address"].ToString();
                Address.ReadOnly = true; 

                if (theData.Rows[0]["Payment"].ToString() == "Monthly")
                {
                    Monthly.Checked = true;
                    Onetime.AutoCheck = false;
                }
                else if (theData.Rows[0]["Payment"].ToString() == "One Time")
                {
                    Onetime.Checked = true;
                    Monthly.AutoCheck = false;
                }
                

                AddButton.Visible = true;
                ViewDocButton.Visible = true;
                AddDocButton.Visible = false;

                //Making stream view-only
                DataTable theData1 = d.Select("SELECT * FROM Stream_has_Application WHERE Application_ApplicationNumber = " + appNo);

                if (theData1.Rows[0]["Stream_idStream"].ToString() == "1")
                {
                    Education.Checked = true;
                    Ration.AutoCheck = false;
                    Medical.AutoCheck = false;
                }
                if (theData1.Rows[0]["Stream_idStream"].ToString() == "2")
                {
                    Ration.Checked = true;
                    Education.AutoCheck = false;
                    Medical.AutoCheck = false;
                }
                if (theData1.Rows[0]["Stream_idStream"].ToString() == "3")
                {
                    Medical.Checked = true;
                    Education.AutoCheck = false;
                    Ration.AutoCheck = false;
                }

                DataTable theData2 = d.Select("SELECT * FROM ApplicantPrimaryInfo WHERE Application_ApplicationNumber = " + appNo);
                
                TotalIncome.Text = theData2.Rows[0]["TotalIncome"].ToString();
                TotalIncome.ReadOnly = true;
                MonthlyRation.Text = theData2.Rows[0]["MonthlyRationCharges"].ToString();
                MonthlyRation.ReadOnly = true;
                EducationalExpenses.Text = theData2.Rows[0]["EducationalExpenses"].ToString();
                EducationalExpenses.ReadOnly = true;
                MedicalExpenses.Text = theData2.Rows[0]["MedicalExpenses"].ToString();
                MedicalExpenses.ReadOnly = true;
                OtherExpenses.Text = theData2.Rows[0]["OtherExpenses"].ToString();
                OtherExpenses.ReadOnly = true;
                ConveyanceExpenses.Text = theData2.Rows[0]["ConveyanceExpenses"].ToString();
                ConveyanceExpenses.ReadOnly = true;
                TotalExpense.Text = theData2.Rows[0]["TotalExpenses"].ToString();
                TotalExpense.ReadOnly = true;

                CalculateExpenses.Hide();
                
                //Making Assets view-only
                DataTable theData3 = d.Select("SELECT * FROM ApplicantAssets WHERE Application_ApplicationNumber = " + appNo);

                CurrentMoney.Text = theData3.Rows[0]["MoneyOwned"].ToString();
                CurrentMoney.ReadOnly = true;
                Gold.Text = theData3.Rows[0]["Gold"].ToString();
                Gold.ReadOnly = true;
                Silver.Text = theData3.Rows[0]["Silver"].ToString();
                Silver.ReadOnly = true;
                Wares.Text = theData3.Rows[0]["Wares"].ToString();
                Wares.ReadOnly = true;
                Installment.Text = theData3.Rows[0]["BCInstallmentsLeft"].ToString();
                Installment.ReadOnly = true;
                Animal.Text = theData3.Rows[0]["AnimalBreed"].ToString();
                Animal.ReadOnly = true;
                CPNotinUse.Text = theData3.Rows[0]["NoOfCells"].ToString();
                CPNotinUse.ReadOnly = true;
                VNotinUse.Text = theData3.Rows[0]["NoOfVehicles"].ToString();
                VNotinUse.ReadOnly = true;
                LoansGiven.Text = theData3.Rows[0]["LoansGivenToSomeone"].ToString();
                LoansGiven.ReadOnly = true;
                Other.Text = theData3.Rows[0]["Bonds"].ToString();  //Other currencies/Bonds
                Other.ReadOnly = true;
                PNotinUse.Text = theData3.Rows[0]["UnusedPlots"].ToString();
                PNotinUse.ReadOnly = true;
                LuxuryItems.Text = theData3.Rows[0]["LuxuryItems"].ToString();
                LuxuryItems.ReadOnly = true;


                //Making Dues view-only
                DataTable theData4 = d.Select("SELECT * FROM ApplicantDues WHERE Application_ApplicationNumber = " + appNo);

                DueRent.Text = theData4.Rows[0]["DueRent"].ToString();
                DueRent.ReadOnly = true;
                SecurityDeposit.Text = theData4.Rows[0]["SecurityDeposit"].ToString();
                SecurityDeposit.ReadOnly = true;
                BCInstallmentDue.Text = theData4.Rows[0]["BCInstallmentsDue"].ToString();
                BCInstallmentDue.ReadOnly = true;
                UtilityBills.Text = theData4.Rows[0]["PayableUtilityBills"].ToString();
                UtilityBills.ReadOnly = true;
                LoansDue.Text = theData4.Rows[0]["DueLoan"].ToString();
                LoansDue.ReadOnly = true;

                DataTable theData5 = d.Select("SELECT * FROM DeductableDues WHERE ApplicationNumber = " + appNo);

                TCountableAssets.Text = theData5.Rows[0]["TotalCountableAssets"].ToString();
                TCountableAssets.ReadOnly = true;
                TDeductableDues.Text = theData5.Rows[0]["TotalDeductableDues"].ToString();
                TDeductableDues.ReadOnly = true;
                NCountableAssets.Text = theData5.Rows[0]["NoOfVehicles"].ToString();
                NCountableAssets.ReadOnly = true;
                CAmountZakat.Text = theData5.Rows[0]["LoansGivenToSomeone"].ToString();
                CAmountZakat.ReadOnly = true;
                Debt.Text = theData3.Rows[0]["Debt"].ToString();
                Debt.ReadOnly = true;


                DataTable theData6 = d.Select("SELECT * FROM ApplicantFamilyInfo WHERE Application_ApplicationNumber = " + appNo);

                NoOfFamilyMembers.Text = theData5.Rows[0]["NoOfFamilyMembers"].ToString();
                NoOfFamilyMembers.ReadOnly = true;

                string boys = theData5.Rows[0]["NoOfBoysAndAges"].ToString();
                string noOfboys = "";
                string ages = "";
                foreach (char c in boys)
                {
                    if (c != ':')
                    {
                        noOfboys = noOfboys + c;
                    }
                    else
                    {
                        if(c != ':')
                        {
                            ages = ages + c;
                        }
                    }
                }
                NoOfBoys.Text = noOfboys;
                NoOfBoys.ReadOnly = true;
                BoyAges.Text = ages;
                BoyAges.ReadOnly = true;

                string girls = theData5.Rows[0]["NoOfGirlsAndAges"].ToString();
                string noOfgirls = "";
                string g_ages = "";
                foreach (char g in girls)
                {
                    if (g != ':')
                    {
                        noOfgirls = noOfgirls + g;
                    }
                    else
                    {
                        if (g != ':')
                        {
                            g_ages = g_ages + g;
                        }
                    }
                }
                NoOfGirls.Text = noOfgirls;
                NoOfGirls.ReadOnly = true;
                GirlAges.Text = g_ages;
                GirlAges.ReadOnly = true;

                SchoolGoing.Text = theData5.Rows[0]["NoOfSchoolgoingChildren"].ToString();
                SchoolGoing.ReadOnly = true;
                BUnderGuardianShip.Text = theData5.Rows[0]["BrotherUnderGuardianship"].ToString();
                BUnderGuardianShip.ReadOnly = true;
                GUnderGuardianship.Text = theData5.Rows[0]["SisterUnderGuardianship"].ToString();
                GUnderGuardianship.ReadOnly = true;
                EFamilyMembers.Text = theData5.Rows[0]["NoOfEmployedFamilyMembers"].ToString();
                EFamilyMembers.ReadOnly = true;
                SourceofIncome.Text = theData5.Rows[0]["SourceofIncome"].ToString();
                SourceofIncome.ReadOnly = true;
                AidReceived.Text = theData5.Rows[0]["AnyAidReceived"].ToString();
                AidReceived.ReadOnly = true;


            }

            //Update Profile Form
            else if (val == false)
            {
                InitializeComponent();

                // Create a new datatble with the selected user
                DbConnection db = new DbConnection();
                DataTable theData = db.Select("SELECT * FROM Application WHERE ApplicationNumber = " + appNo);


                // Display values of the selected profile in the textboxes
                ApplicationNumber.Text = appNo;
                FirstName.Text = theData.Rows[0]["FirstName"].ToString();
                LastName.Text = theData.Rows[0]["LastName"].ToString();
                CNIC.Text = theData.Rows[0]["CNIC"].ToString();
                FatherName.Text = theData.Rows[0]["FatherName"].ToString();

                DateInitiated.Value = DateTime.Parse(theData.Rows[0]["DateInitiated"].ToString());
                CellNumber.Text = theData.Rows[0]["CellNo"].ToString();
                Address.Text = theData.Rows[0]["Address"].ToString();

                if (theData.Rows[0]["Payment"].ToString() == "Monthly")
                {
                    Monthly.Checked = true;
                }
                else if (theData.Rows[0]["Payment"].ToString() == "One Time")
                {
                    Onetime.Checked = true;
                }

                AddButton.Hide();
                UpdateButton.Show();
                AddDocButton.Visible = true;

                //Updating stream
                DataTable theData1 = db.Select("SELECT * FROM Stream_has_Application WHERE ApplicationNumber = " + appNo);

                if (theData1.Rows[0]["Stream_idStream"].ToString() == "1")
                {
                    Education.Checked = true;
                }
                if (theData1.Rows[0]["Stream_idStream"].ToString() == "2")
                {
                    Ration.Checked = true;
                }
                if (theData1.Rows[0]["Stream_idStream"].ToString() == "3")
                {
                    Medical.Checked = true;
                }

            }

        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DbConnection d = new DbConnection();
            string i = "";
            string j = "";
            if(Monthly.Checked == true)
            {
                i = "Monthly";
            }
            if(Onetime.Checked == true)
            {
                i = "One Time";
            }
            if (Education.Checked == true)
            {
                j+= "1";
            }
            if (Ration.Checked == true)
            {
                j+= "2";
            }
            if (Medical.Checked == true)
            {
                j+= "3";
            }
           
            string boysages = NoOfBoys.Text + ":" + BoyAges.Text;
            string girlsages = NoOfGirls.Text + ":" + GirlAges.Text;
            
            d.Inserts("EXEC New_Applicant '" + ApplicationNumber.Text + "','" + CNIC.Text + "','" + FirstName.Text + "','" + LastName.Text + "','" + FatherName.Text + "','" + CellNumber.Text + "','" + DateInitiated.Value + "','" + Address.Text + "','" + i + "','" + Religion.Text + "','" + Sect.Text + "'");
            d.Inserts("EXEC New_Applicant_Primary '" + ApplicationNumber.Text + "','" + TotalIncome.Text + "','" + MonthlyRation.Text + "','" + EducationalExpenses.Text + "','" + MedicalExpenses.Text + "','" + ConveyanceExpenses.Text + "','" + OtherExpenses.Text + "','" + TotalExpense.Text + "'");
            d.Inserts("INSERT INTO dbo.ApplicantDues VALUES ('" + ApplicationNumber.Text + "','" + UtilityBills.Text + "','" + DueRent.Text + "','" + LoansDue.Text + "','" + BCInstallmentDue.Text + "','" + SecurityDeposit.Text + "')");
            d.Inserts("INSERT INTO dbo.ApplicantAssets VALUES ('" + ApplicationNumber.Text + "','" + CurrentMoney.Text + "','" + Gold.Text + "','" + Silver.Text + "','" + CPNotinUse.Text + "','" + VNotinUse.Text + "','" + Debt.Text + "','" + BCInstallmentDue.Text + "','" + Wares.Text + "','" + PNotinUse.Text + "','" + Other.Text + "','" + LuxuryItems.Text + "','" + Animal.Text + "','" + LoansGiven.Text + "')");
            d.Inserts("INSERT INTO dbo.ApplicantFamilyInfo VALUES ('" + ApplicationNumber.Text + "','" + NoOfFamilyMembers.Text + "','" + boysages + "','" + girlsages + "','" + SchoolGoing.Text + "','" + BUnderGuardianShip.Text + "','" + GUnderGuardianship.Text + "','" + EFamilyMembers.Text + "','" + SourceofIncome.Text + "','" + AidReceived.Text + "')");
            d.Inserts("INSERT INTO dbo.DeductableDues VALUES ('" + ApplicationNumber.Text + "','" + TCountableAssets.Text + "','" + TDeductableDues.Text + "','" + NCountableAssets.Text + "','" + CAmountZakat.Text + "'");


            if (Education.Checked == true)
            {
                d.Inserts("INSERT INTO dbo.Stream_has_Application VALUES ('"  + 1 + "','" + ApplicationNumber.Text + "')");
                //MessageBox.Show("INSERT INTO dbo.Stream_has_Application VALUES ('" + 1 + "','" + ApplicationNumber.Text + "')");
            }
            if (Ration.Checked == true)
            {
                d.Inserts("INSERT INTO dbo.Stream_has_Application  VALUES ('" + 2 + "','" + ApplicationNumber.Text + "')");
               // MessageBox.Show("INSERT INTO dbo.Stream_has_Application VALUES ('" + 1 + "','" + ApplicationNumber.Text + "')");
            }
            if (Medical.Checked == true)
            {
                d.Inserts("INSERT INTO dbo.Stream_has_Application  VALUES ('" + 3 + "','" + ApplicationNumber.Text + "')");
               // MessageBox.Show("INSERT INTO dbo.Stream_has_Application VALUES ('" + 1 + "','" + ApplicationNumber.Text + "')");
            }

            SearchForm search = new SearchForm();

            search.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void ApplicationNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void UtilityBills_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void CellNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocumentsForm formDoc = new DocumentsForm();
            formDoc.Show();

            // if user has a doc, then open it.

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void Monthly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ShowAssets_Click(object sender, EventArgs e)
        {
            AssetsForm assets = new AssetsForm();
            assets.Show();
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void CalculateExpenses_Click(object sender, EventArgs e)
        {
            long TotalExpenses = 0;
            TotalExpenses += Convert.ToInt64(MonthlyRation.Text) + Convert.ToInt64(EducationalExpenses.Text) + Convert.ToInt64(MedicalExpenses.Text) + Convert.ToInt64(ConveyanceExpenses.Text) + Convert.ToInt64(OtherExpenses.Text);
            string final = Convert.ToString(TotalExpenses);
            TotalExpense.Text = final;


        }

        private void Medical_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Education_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DbConnection d = new DbConnection();
            string i = "";
            if (Monthly.Checked == true)
            {
                i = "Monthly";
            }
            if (Onetime.Checked == true)
            {
                i = "One Time";
            }
            string boysages = NoOfBoys.Text + ":" + BoyAges.Text;
            string girlsages = NoOfBoys.Text + ":" + GirlAges.Text;

            d.Update("Update dbo.Application Set FirstName ='" + FirstName.Text + "', CNIC = '" + CNIC.Text + "', LastName = '" + LastName.Text + "',FatherName = '" + FatherName.Text + "', CellNo = '" + CellNumber.Text + "', DateInitiated = '" + DateInitiated.Value + "', Address = '" + Address.Text + "', Payment = '" + i + "' Where ApplicationNumber = '" + ApplicationNumber.Text + "'");
            d.Update("Update dbo.ApplicantPrimaryInfo Set TotalIncome = '" + TotalIncome.Text + "', MonthlyRationCharges = '" + MonthlyRation.Text + "', EducationalExpenses = '" + EducationalExpenses.Text + "', MedicalExpenses= '" + MedicalExpenses.Text + "',ConveyanceExpenses ='" + ConveyanceExpenses.Text + "',OtherExpenses = '" + OtherExpenses.Text + "' Where Application_ApplicationNumber = '" + ApplicationNumber.Text + "'");
            d.Update("Update dbo.ApplicantDues Set PayableUtilityBills ='" + UtilityBills.Text + "', DueRent = '" + DueRent.Text + "',DueLoan ='" + LoansDue.Text + "',BCInstallmentsDue ='" + BCInstallmentDue.Text + "',SecurityDeposit ='" + SecurityDeposit.Text + "' Where Application_ApplicationNumber = '" + ApplicationNumber.Text + "'");
            d.Update("Update dbo.ApplicantAssets Set MoneyOwned = '" + CurrentMoney.Text + "',Gold = '" + Gold.Text + "',Silver ='" + Silver.Text + "',NoOfCells = '" + CPNotinUse.Text + "',NoOfVehicles ='" + VNotinUse.Text + "',Debt = '" + Debt.Text + "',BCInstallmentsLeft ='" + BCInstallmentDue.Text + "',Wares = '" + Wares.Text + "',UnusedPlots ='" + PNotinUse.Text + "',Bonds ='" + Other.Text + "',LuxuryItems='" + LuxuryItems.Text + "',AnimalBreed ='" + Animal.Text + "' Where Application_ApplicationNumber = '" + ApplicationNumber.Text + "'");
            d.Update("Update dbo.ApplicantFamilyInfo Set NoOfFamilyMembers ='" + NoOfFamilyMembers.Text + "',NoOfBoysAndAges ='" + BoyAges.Text + "',NoOfSchoolgoingChildren ='" + SchoolGoing.Text + "',BrotherUnderGuardianship='" + BUnderGuardianShip.Text + "',SisterUnderGuardianship='" + GUnderGuardianship.Text + "',NoOfEmployedFamilyMembers='" + EFamilyMembers.Text + "',SourceOfIncome ='" + SourceofIncome.Text + "',AnyAidReceived ='" + AidReceived.Text + "' Where Application_ApplicationNumber = '" + ApplicationNumber.Text + "'");
            d.Update("Update dbo.DeductableDues Set TotalCountableAssets ='" + TCountableAssets.Text + "',TotalDeductableDues ='" + TDeductableDues.Text + "',NetCountableAssets ='" + NCountableAssets.Text + "',CurrentAmountZakat='" + CAmountZakat.Text + "' Where ApplicationNumber = '" + ApplicationNumber.Text + "'");
            
            SearchForm search = new SearchForm();
            search.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();
            bool existence = db.CheckIfExists("SELECT * FROM dbo.Application WHERE ApplicationNumber =" + ApplicationNumber.Text);
            if (!existence)
            {
                MessageBox.Show("There are no documents for this applicant \nOr there is no such applicant");
            }
            else
            {
                string filename = @"C:\Users\Mehreen Shafi\Desktop\Testing Docs\" + ApplicationNumber.Text + ".pdf";
                System.Diagnostics.Process.Start(filename);
            }

          
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }
    }
}
