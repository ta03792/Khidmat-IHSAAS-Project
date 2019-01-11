namespace Application_Form
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Search = new System.Windows.Forms.Button();
            this.SearchWindow = new System.Windows.Forms.GroupBox();
            this.Stream = new System.Windows.Forms.GroupBox();
            this.Medical = new System.Windows.Forms.CheckBox();
            this.Ration = new System.Windows.Forms.CheckBox();
            this.Education = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CellNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ApplicationNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CNIC = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.PaymentOption = new System.Windows.Forms.GroupBox();
            this.OneTime = new System.Windows.Forms.RadioButton();
            this.Monthly = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Results = new System.Windows.Forms.DataGridView();
            this.ViewButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SearchWindow.SuspendLayout();
            this.Stream.SuspendLayout();
            this.PaymentOption.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Results)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(796, 363);
            this.Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(112, 35);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchWindow
            // 
            this.SearchWindow.Controls.Add(this.Stream);
            this.SearchWindow.Controls.Add(this.label5);
            this.SearchWindow.Controls.Add(this.CellNumber);
            this.SearchWindow.Controls.Add(this.label4);
            this.SearchWindow.Controls.Add(this.ApplicationNumber);
            this.SearchWindow.Controls.Add(this.label3);
            this.SearchWindow.Controls.Add(this.label2);
            this.SearchWindow.Controls.Add(this.CNIC);
            this.SearchWindow.Controls.Add(this.LastName);
            this.SearchWindow.Controls.Add(this.label1);
            this.SearchWindow.Controls.Add(this.FirstName);
            this.SearchWindow.Controls.Add(this.PaymentOption);
            this.SearchWindow.Controls.Add(this.Search);
            this.SearchWindow.Location = new System.Drawing.Point(18, 18);
            this.SearchWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchWindow.Name = "SearchWindow";
            this.SearchWindow.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchWindow.Size = new System.Drawing.Size(920, 408);
            this.SearchWindow.TabIndex = 1;
            this.SearchWindow.TabStop = false;
            this.SearchWindow.Text = "Search Window";
            // 
            // Stream
            // 
            this.Stream.Controls.Add(this.Medical);
            this.Stream.Controls.Add(this.Ration);
            this.Stream.Controls.Add(this.Education);
            this.Stream.Location = new System.Drawing.Point(591, 185);
            this.Stream.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Stream.Name = "Stream";
            this.Stream.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Stream.Size = new System.Drawing.Size(286, 155);
            this.Stream.TabIndex = 25;
            this.Stream.TabStop = false;
            this.Stream.Text = "Stream of Aid";
            // 
            // Medical
            // 
            this.Medical.AutoSize = true;
            this.Medical.Location = new System.Drawing.Point(54, 108);
            this.Medical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Medical.Name = "Medical";
            this.Medical.Size = new System.Drawing.Size(89, 24);
            this.Medical.TabIndex = 2;
            this.Medical.Text = "Medical";
            this.Medical.UseVisualStyleBackColor = true;
            // 
            // Ration
            // 
            this.Ration.AutoSize = true;
            this.Ration.Location = new System.Drawing.Point(54, 72);
            this.Ration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ration.Name = "Ration";
            this.Ration.Size = new System.Drawing.Size(82, 24);
            this.Ration.TabIndex = 1;
            this.Ration.Text = "Ration";
            this.Ration.UseVisualStyleBackColor = true;
            // 
            // Education
            // 
            this.Education.AutoSize = true;
            this.Education.Location = new System.Drawing.Point(54, 37);
            this.Education.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Education.Name = "Education";
            this.Education.Size = new System.Drawing.Size(107, 24);
            this.Education.TabIndex = 0;
            this.Education.Text = "Education";
            this.Education.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cell Number:";
            // 
            // CellNumber
            // 
            this.CellNumber.Location = new System.Drawing.Point(162, 180);
            this.CellNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CellNumber.Name = "CellNumber";
            this.CellNumber.Size = new System.Drawing.Size(234, 26);
            this.CellNumber.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Application Number:";
            // 
            // ApplicationNumber
            // 
            this.ApplicationNumber.Location = new System.Drawing.Point(162, 60);
            this.ApplicationNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ApplicationNumber.Name = "ApplicationNumber";
            this.ApplicationNumber.Size = new System.Drawing.Size(234, 26);
            this.ApplicationNumber.TabIndex = 8;
            this.ApplicationNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 228);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "CNIC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name:";
            // 
            // CNIC
            // 
            this.CNIC.Location = new System.Drawing.Point(162, 223);
            this.CNIC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CNIC.Name = "CNIC";
            this.CNIC.Size = new System.Drawing.Size(234, 26);
            this.CNIC.TabIndex = 5;
            this.CNIC.TextChanged += new System.EventHandler(this.CNIC_TextChanged);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(162, 140);
            this.LastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(234, 26);
            this.LastName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(162, 100);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(234, 26);
            this.FirstName.TabIndex = 2;
            // 
            // PaymentOption
            // 
            this.PaymentOption.Controls.Add(this.OneTime);
            this.PaymentOption.Controls.Add(this.Monthly);
            this.PaymentOption.Location = new System.Drawing.Point(591, 23);
            this.PaymentOption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PaymentOption.Name = "PaymentOption";
            this.PaymentOption.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PaymentOption.Size = new System.Drawing.Size(286, 148);
            this.PaymentOption.TabIndex = 1;
            this.PaymentOption.TabStop = false;
            this.PaymentOption.Text = "PaymentOption";
            // 
            // OneTime
            // 
            this.OneTime.AutoSize = true;
            this.OneTime.Location = new System.Drawing.Point(54, 95);
            this.OneTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OneTime.Name = "OneTime";
            this.OneTime.Size = new System.Drawing.Size(102, 24);
            this.OneTime.TabIndex = 1;
            this.OneTime.TabStop = true;
            this.OneTime.Text = "One Time";
            this.OneTime.UseVisualStyleBackColor = true;
            // 
            // Monthly
            // 
            this.Monthly.AutoSize = true;
            this.Monthly.Location = new System.Drawing.Point(54, 45);
            this.Monthly.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Monthly.Name = "Monthly";
            this.Monthly.Size = new System.Drawing.Size(89, 24);
            this.Monthly.TabIndex = 0;
            this.Monthly.TabStop = true;
            this.Monthly.Text = "Monthly";
            this.Monthly.UseVisualStyleBackColor = true;
            this.Monthly.CheckedChanged += new System.EventHandler(this.Monthly_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Results);
            this.groupBox1.Location = new System.Drawing.Point(18, 435);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(920, 434);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // Results
            // 
            this.Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Results.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Results.DefaultCellStyle = dataGridViewCellStyle1;
            this.Results.Location = new System.Drawing.Point(14, 25);
            this.Results.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Results.MultiSelect = false;
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Results.Size = new System.Drawing.Size(896, 409);
            this.Results.TabIndex = 0;
            this.Results.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Results_CellContentClick);
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(825, 892);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(112, 35);
            this.ViewButton.TabIndex = 3;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(682, 892);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(112, 35);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.Edit_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(962, 932);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchWindow);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchForm";
            this.Text = "Search";
            this.SearchWindow.ResumeLayout(false);
            this.SearchWindow.PerformLayout();
            this.Stream.ResumeLayout(false);
            this.Stream.PerformLayout();
            this.PaymentOption.ResumeLayout(false);
            this.PaymentOption.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Results)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.GroupBox SearchWindow;
        private System.Windows.Forms.GroupBox PaymentOption;
        private System.Windows.Forms.RadioButton OneTime;
        private System.Windows.Forms.RadioButton Monthly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CNIC;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ApplicationNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.DataGridView Results;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CellNumber;
        private System.Windows.Forms.GroupBox Stream;
        private System.Windows.Forms.CheckBox Medical;
        private System.Windows.Forms.CheckBox Ration;
        private System.Windows.Forms.CheckBox Education;
        private System.Windows.Forms.Button EditButton;
    }
}