namespace GUI
{
    partial class Bug
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
            txtCreatorID = new TextBox();
            txtBugID = new TextBox();
            label2 = new Label();
            txtBugName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCreationDate = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            txtLastUpdate = new DateTimePicker();
            label8 = new Label();
            txtDesc = new TextBox();
            label9 = new Label();
            rbYes = new RadioButton();
            rbNo = new RadioButton();
            dgvMessages = new DataGridView();
            richTextBox1 = new RichTextBox();
            label10 = new Label();
            label11 = new Label();
            btnBugDetails = new Button();
            btnClear = new Button();
            btnNewBug = new Button();
            btnEdit = new Button();
            btnShowData = new Button();
            btnCreatorName = new Button();
            btnUpdate = new Button();
            txtSeverityID = new TextBox();
            txtPriorityID = new TextBox();
            btnCancel = new Button();
            btnShowLogs = new Button();
            btnGetMessages = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMessages).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 30);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 0;
            label1.Text = "Creator ID:";
            // 
            // txtCreatorID
            // 
            txtCreatorID.Location = new Point(154, 30);
            txtCreatorID.Name = "txtCreatorID";
            txtCreatorID.Size = new Size(305, 27);
            txtCreatorID.TabIndex = 1;
            // 
            // txtBugID
            // 
            txtBugID.Location = new Point(154, 76);
            txtBugID.Name = "txtBugID";
            txtBugID.Size = new Size(305, 27);
            txtBugID.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 72);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 2;
            label2.Text = "Bug ID:";
            // 
            // txtBugName
            // 
            txtBugName.Location = new Point(154, 122);
            txtBugName.Name = "txtBugName";
            txtBugName.Size = new Size(305, 27);
            txtBugName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 121);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 4;
            label3.Text = "Bug Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 167);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 6;
            label4.Text = "Priority ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 215);
            label5.Name = "label5";
            label5.Size = new Size(110, 28);
            label5.TabIndex = 8;
            label5.Text = "Severity ID:";
            // 
            // txtCreationDate
            // 
            txtCreationDate.Location = new Point(156, 263);
            txtCreationDate.Name = "txtCreationDate";
            txtCreationDate.Size = new Size(303, 27);
            txtCreationDate.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 263);
            label6.Name = "label6";
            label6.Size = new Size(136, 28);
            label6.TabIndex = 11;
            label6.Text = "Creation Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(14, 306);
            label7.Name = "label7";
            label7.Size = new Size(120, 28);
            label7.TabIndex = 13;
            label7.Text = "Last Update:";
            // 
            // txtLastUpdate
            // 
            txtLastUpdate.Location = new Point(156, 306);
            txtLastUpdate.Name = "txtLastUpdate";
            txtLastUpdate.Size = new Size(303, 27);
            txtLastUpdate.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(14, 391);
            label8.Name = "label8";
            label8.Size = new Size(116, 28);
            label8.TabIndex = 14;
            label8.Text = "Description:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(156, 395);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(305, 277);
            txtDesc.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(14, 354);
            label9.Name = "label9";
            label9.Size = new Size(76, 28);
            label9.TabIndex = 16;
            label9.Text = "Solved:";
            // 
            // rbYes
            // 
            rbYes.AutoSize = true;
            rbYes.Location = new Point(155, 351);
            rbYes.Name = "rbYes";
            rbYes.Size = new Size(51, 24);
            rbYes.TabIndex = 17;
            rbYes.TabStop = true;
            rbYes.Text = "Yes";
            rbYes.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            rbNo.AutoSize = true;
            rbNo.Location = new Point(212, 351);
            rbNo.Name = "rbNo";
            rbNo.Size = new Size(50, 24);
            rbNo.TabIndex = 18;
            rbNo.TabStop = true;
            rbNo.Text = "No";
            rbNo.UseVisualStyleBackColor = true;
            // 
            // dgvMessages
            // 
            dgvMessages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMessages.Location = new Point(476, 76);
            dgvMessages.Name = "dgvMessages";
            dgvMessages.RowHeadersWidth = 51;
            dgvMessages.RowTemplate.Height = 29;
            dgvMessages.Size = new Size(445, 283);
            dgvMessages.TabIndex = 19;
            dgvMessages.CellContentClick += dgvMessages_CellContentClick;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(476, 410);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(445, 262);
            richTextBox1.TabIndex = 20;
            richTextBox1.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(476, 29);
            label10.Name = "label10";
            label10.Size = new Size(96, 28);
            label10.TabIndex = 21;
            label10.Text = "Messages";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(476, 379);
            label11.Name = "label11";
            label11.Size = new Size(53, 28);
            label11.TabIndex = 22;
            label11.Text = "Logs";
            // 
            // btnBugDetails
            // 
            btnBugDetails.Location = new Point(145, 697);
            btnBugDetails.Name = "btnBugDetails";
            btnBugDetails.Size = new Size(131, 40);
            btnBugDetails.TabIndex = 23;
            btnBugDetails.Text = "Bug Details";
            btnBugDetails.UseVisualStyleBackColor = true;
            btnBugDetails.Click += btnBugDetails_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(693, 697);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(131, 40);
            btnClear.TabIndex = 24;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnNewBug
            // 
            btnNewBug.Location = new Point(419, 697);
            btnNewBug.Name = "btnNewBug";
            btnNewBug.Size = new Size(131, 40);
            btnNewBug.TabIndex = 26;
            btnNewBug.Text = "New Bug";
            btnNewBug.UseVisualStyleBackColor = true;
            btnNewBug.Click += btnNewBug_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(282, 697);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(131, 40);
            btnEdit.TabIndex = 27;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnShowData
            // 
            btnShowData.Location = new Point(627, 29);
            btnShowData.Name = "btnShowData";
            btnShowData.Size = new Size(144, 29);
            btnShowData.TabIndex = 28;
            btnShowData.Text = "Show Messages";
            btnShowData.UseVisualStyleBackColor = true;
            btnShowData.Click += btnShowData_Click;
            // 
            // btnCreatorName
            // 
            btnCreatorName.Location = new Point(556, 697);
            btnCreatorName.Name = "btnCreatorName";
            btnCreatorName.Size = new Size(131, 40);
            btnCreatorName.TabIndex = 29;
            btnCreatorName.Text = "Creator Name";
            btnCreatorName.UseVisualStyleBackColor = true;
            btnCreatorName.Click += btnCreatorName_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(8, 697);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 40);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtSeverityID
            // 
            txtSeverityID.Location = new Point(156, 216);
            txtSeverityID.Name = "txtSeverityID";
            txtSeverityID.Size = new Size(305, 27);
            txtSeverityID.TabIndex = 31;
            // 
            // txtPriorityID
            // 
            txtPriorityID.Location = new Point(156, 168);
            txtPriorityID.Name = "txtPriorityID";
            txtPriorityID.Size = new Size(305, 27);
            txtPriorityID.TabIndex = 32;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(830, 697);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 40);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnShowLogs
            // 
            btnShowLogs.Location = new Point(777, 375);
            btnShowLogs.Name = "btnShowLogs";
            btnShowLogs.Size = new Size(144, 29);
            btnShowLogs.TabIndex = 34;
            btnShowLogs.Text = "Show Logs";
            btnShowLogs.UseVisualStyleBackColor = true;
            // 
            // btnGetMessages
            // 
            btnGetMessages.Location = new Point(777, 28);
            btnGetMessages.Name = "btnGetMessages";
            btnGetMessages.Size = new Size(144, 29);
            btnGetMessages.TabIndex = 35;
            btnGetMessages.Text = "Get Messages";
            btnGetMessages.UseVisualStyleBackColor = true;
            btnGetMessages.Click += btnGetMessages_Click;
            // 
            // Bug
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 749);
            Controls.Add(btnGetMessages);
            Controls.Add(btnShowLogs);
            Controls.Add(btnCancel);
            Controls.Add(txtPriorityID);
            Controls.Add(txtSeverityID);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreatorName);
            Controls.Add(btnShowData);
            Controls.Add(btnEdit);
            Controls.Add(btnNewBug);
            Controls.Add(btnClear);
            Controls.Add(btnBugDetails);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(richTextBox1);
            Controls.Add(dgvMessages);
            Controls.Add(rbNo);
            Controls.Add(rbYes);
            Controls.Add(label9);
            Controls.Add(txtDesc);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtLastUpdate);
            Controls.Add(label6);
            Controls.Add(txtCreationDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtBugName);
            Controls.Add(label3);
            Controls.Add(txtBugID);
            Controls.Add(label2);
            Controls.Add(txtCreatorID);
            Controls.Add(label1);
            Name = "Bug";
            Text = "Bug";
            ((System.ComponentModel.ISupportInitialize)dgvMessages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCreatorID;
        private TextBox txtBugID;
        private Label label2;
        private TextBox txtBugName;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker txtCreationDate;
        private Label label6;
        private Label label7;
        private DateTimePicker txtLastUpdate;
        private Label label8;
        private TextBox txtDesc;
        private Label label9;
        private RadioButton rbYes;
        private RadioButton rbNo;
        private DataGridView dgvMessages;
        private RichTextBox richTextBox1;
        private Label label10;
        private Label label11;
        private Button btnBugDetails;
        private Button btnClear;
        private Button btnNewBug;
        private Button button5;
        private Button btnEdit;
        private Button btnShowData;
        private Button btnCreatorName;
        private Button btnUpdate;
        private TextBox txtSeverityID;
        private TextBox txtPriorityID;
        private Button btnCancel;
        private Button btnShowLogs;
        private Button btnGetMessages;
    }
}