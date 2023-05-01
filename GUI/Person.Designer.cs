namespace GUI
{
    partial class Person
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
            label1 = new Label();
            txtEmployeeId = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label10 = new Label();
            txtJobTitle = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtAddress = new TextBox();
            label7 = new Label();
            txtSalary = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtExperience = new TextBox();
            label11 = new Label();
            txtHiredDate = new DateTimePicker();
            btnSave = new Button();
            dgvShowEmployees = new DataGridView();
            label12 = new Label();
            btnShowData = new Button();
            txtDOB = new DateTimePicker();
            label13 = new Label();
            txtEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShowEmployees).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 0;
            label1.Text = "Employee ID";
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.Enabled = false;
            txtEmployeeId.Location = new Point(140, 79);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(286, 27);
            txtEmployeeId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(222, 37);
            label2.TabIndex = 2;
            label2.Text = "Employee Details";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(140, 112);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(286, 27);
            txtFirstName.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(12, 111);
            label10.Name = "label10";
            label10.Size = new Size(106, 28);
            label10.TabIndex = 17;
            label10.Text = "First Name";
            // 
            // txtJobTitle
            // 
            txtJobTitle.Location = new Point(140, 178);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(286, 27);
            txtJobTitle.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 177);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 21;
            label3.Text = "Job Title";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(140, 145);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(286, 27);
            txtLastName.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 144);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 19;
            label4.Text = "Last Name";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(140, 211);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(286, 27);
            txtEmail.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 210);
            label6.Name = "label6";
            label6.Size = new Size(59, 28);
            label6.TabIndex = 23;
            label6.Text = "Email";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(140, 381);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(286, 66);
            txtAddress.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 380);
            label7.Name = "label7";
            label7.Size = new Size(82, 28);
            label7.TabIndex = 29;
            label7.Text = "Address";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(140, 242);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(286, 27);
            txtSalary.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 241);
            label8.Name = "label8";
            label8.Size = new Size(65, 28);
            label8.TabIndex = 27;
            label8.Text = "Salary";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 273);
            label9.Name = "label9";
            label9.Size = new Size(105, 28);
            label9.TabIndex = 31;
            label9.Text = "Experience";
            // 
            // txtExperience
            // 
            txtExperience.Location = new Point(140, 277);
            txtExperience.Name = "txtExperience";
            txtExperience.Size = new Size(286, 27);
            txtExperience.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(12, 313);
            label11.Name = "label11";
            label11.Size = new Size(106, 28);
            label11.TabIndex = 33;
            label11.Text = "Hired Date";
            // 
            // txtHiredDate
            // 
            txtHiredDate.Location = new Point(142, 315);
            txtHiredDate.Name = "txtHiredDate";
            txtHiredDate.Size = new Size(284, 27);
            txtHiredDate.TabIndex = 34;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(25, 467);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(181, 50);
            btnSave.TabIndex = 35;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvShowEmployees
            // 
            dgvShowEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowEmployees.Location = new Point(458, 83);
            dgvShowEmployees.Name = "dgvShowEmployees";
            dgvShowEmployees.RowHeadersWidth = 51;
            dgvShowEmployees.RowTemplate.Height = 29;
            dgvShowEmployees.Size = new Size(912, 434);
            dgvShowEmployees.TabIndex = 36;
            dgvShowEmployees.CellContentClick += dgvShowEmployees_CellContentClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(458, 9);
            label12.Name = "label12";
            label12.Size = new Size(227, 37);
            label12.TabIndex = 37;
            label12.Text = "List Of Employees";
            // 
            // btnShowData
            // 
            btnShowData.Location = new Point(1239, 19);
            btnShowData.Name = "btnShowData";
            btnShowData.Size = new Size(131, 29);
            btnShowData.TabIndex = 38;
            btnShowData.Text = "Show Data";
            btnShowData.UseVisualStyleBackColor = true;
            btnShowData.Click += btnShowData_Click;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(142, 348);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(284, 27);
            txtDOB.TabIndex = 40;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(12, 346);
            label13.Name = "label13";
            label13.Size = new Size(56, 28);
            label13.TabIndex = 39;
            label13.Text = "DOB:";
            // 
            // txtEdit
            // 
            txtEdit.Location = new Point(245, 467);
            txtEdit.Name = "txtEdit";
            txtEdit.Size = new Size(181, 50);
            txtEdit.TabIndex = 41;
            txtEdit.Text = "Edit";
            txtEdit.UseVisualStyleBackColor = true;
            txtEdit.Click += txtEdit_Click;
            // 
            // Person
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 538);
            Controls.Add(txtEdit);
            Controls.Add(txtDOB);
            Controls.Add(label13);
            Controls.Add(btnShowData);
            Controls.Add(label12);
            Controls.Add(dgvShowEmployees);
            Controls.Add(btnSave);
            Controls.Add(txtHiredDate);
            Controls.Add(label11);
            Controls.Add(txtExperience);
            Controls.Add(label9);
            Controls.Add(txtAddress);
            Controls.Add(label7);
            Controls.Add(txtSalary);
            Controls.Add(label8);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(txtJobTitle);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label4);
            Controls.Add(txtFirstName);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(txtEmployeeId);
            Controls.Add(label1);
            Name = "Person";
            Text = "Person";
            ((System.ComponentModel.ISupportInitialize)dgvShowEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmployeeId;
        private Label label2;
        private TextBox txtFirstName;
        private Label label10;
        private TextBox txtJobTitle;
        private Label label3;
        private TextBox txtLastName;
        private Label label4;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtAddress;
        private Label label7;
        private TextBox txtSalary;
        private Label label8;
        private Label label9;
        private TextBox txtExperience;
        private Label label11;
        private DateTimePicker txtHiredDate;
        private Button btnSave;
        private DataGridView dgvShowEmployees;
        private Label label12;
        private Button btnShowData;
        private DateTimePicker txtDOB;
        private Label label13;
        private Button txtEdit;
    }
}