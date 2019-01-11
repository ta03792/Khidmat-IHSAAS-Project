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
    public partial class DocumentsForm : Form
    {
        public DocumentsForm()
        {
            InitializeComponent();
        }
        public DocumentsForm(string AppNos)
        {
            InitializeComponent();
            AppNoTextBox.Text = AppNos;
            AppNoTextBox.ReadOnly = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePathLabel.Text = openFileDialog.FileName; // to store path
                otherLabel.Visible = true;
                filePathLabel.Visible = true;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();
            if (AppNoTextBox.Text == "")
            {
                MessageBox.Show("Please enter an Application Number.");
            }
            else
            {
                bool existence = db.CheckIfExists("SELECT * FROM dbo.Application WHERE ApplicationNumber =" + AppNoTextBox.Text);
                if (!existence)
                {
                    MessageBox.Show("There is no such application in database. \n Please enter the correct Application Number");
                }
                else
                {
                    string FileToCopy = filePathLabel.Text;
                    string NewCopy = @"C:\Users\Mehreen Shafi\Desktop\Testing Docs\" + AppNoTextBox.Text + ".pdf";


                    if (System.IO.File.Exists(NewCopy) == true)
                    {
                        MessageBox.Show("A file of the same name already exists. \n Are you sure you have the correct ID?");
                    }
                    else
                    {
                        System.IO.File.Copy(FileToCopy, NewCopy);
                        MessageBox.Show("File Saved!");
                    }
                }
            }

        }

        private void DocumentsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
