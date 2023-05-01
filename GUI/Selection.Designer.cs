namespace GUI
{
    partial class Selection
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBugID = new System.Windows.Forms.TextBox();
            this.txtCreatorID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBugName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dgvListOfBugs = new System.Windows.Forms.DataGridView();
            this.btnShowBugs = new System.Windows.Forms.Button();
            this.txtPriorityID = new System.Windows.Forms.TextBox();
            this.txtSeverityID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfBugs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bug Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bug ID";
            // 
            // txtBugID
            // 
            this.txtBugID.Location = new System.Drawing.Point(167, 79);
            this.txtBugID.Name = "txtBugID";
            this.txtBugID.Size = new System.Drawing.Size(246, 27);
            this.txtBugID.TabIndex = 2;
            // 
            // txtCreatorID
            // 
            this.txtCreatorID.Location = new System.Drawing.Point(730, 79);
            this.txtCreatorID.Name = "txtCreatorID";
            this.txtCreatorID.Size = new System.Drawing.Size(246, 27);
            this.txtCreatorID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(583, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Creator ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Priority ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Severity ID:";
            // 
            // txtBugName
            // 
            this.txtBugName.Location = new System.Drawing.Point(730, 115);
            this.txtBugName.Name = "txtBugName";
            this.txtBugName.Size = new System.Drawing.Size(246, 27);
            this.txtBugName.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(583, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bug Name:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(167, 186);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(246, 88);
            this.txtDesc.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(20, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(583, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "Solved";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(731, 225);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(51, 24);
            this.rbYes.TabIndex = 14;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(803, 225);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(50, 24);
            this.rbNo.TabIndex = 15;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(20, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 37);
            this.label9.TabIndex = 16;
            this.label9.Text = "List Of Bugs";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Location = new System.Drawing.Point(803, 355);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(173, 39);
            this.btnSelect.TabIndex = 18;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dgvListOfBugs
            // 
            this.dgvListOfBugs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOfBugs.Location = new System.Drawing.Point(20, 407);
            this.dgvListOfBugs.Name = "dgvListOfBugs";
            this.dgvListOfBugs.RowHeadersWidth = 51;
            this.dgvListOfBugs.RowTemplate.Height = 29;
            this.dgvListOfBugs.Size = new System.Drawing.Size(956, 234);
            this.dgvListOfBugs.TabIndex = 19;
            this.dgvListOfBugs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListOfBugs_CellContentClick);
            // 
            // btnShowBugs
            // 
            this.btnShowBugs.Location = new System.Drawing.Point(445, 355);
            this.btnShowBugs.Name = "btnShowBugs";
            this.btnShowBugs.Size = new System.Drawing.Size(173, 39);
            this.btnShowBugs.TabIndex = 20;
            this.btnShowBugs.Text = "Show Bugs";
            this.btnShowBugs.UseVisualStyleBackColor = true;
            this.btnShowBugs.Click += new System.EventHandler(this.btnShowBugs_Click);
            // 
            // txtPriorityID
            // 
            this.txtPriorityID.Location = new System.Drawing.Point(167, 112);
            this.txtPriorityID.Name = "txtPriorityID";
            this.txtPriorityID.Size = new System.Drawing.Size(246, 27);
            this.txtPriorityID.TabIndex = 21;
            // 
            // txtSeverityID
            // 
            this.txtSeverityID.Location = new System.Drawing.Point(167, 145);
            this.txtSeverityID.Name = "txtSeverityID";
            this.txtSeverityID.Size = new System.Drawing.Size(246, 27);
            this.txtSeverityID.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(583, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 28);
            this.label11.TabIndex = 25;
            this.label11.Text = "Last Edit Date:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(583, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 28);
            this.label12.TabIndex = 26;
            this.label12.Text = "Creation Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(732, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 27);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(732, 182);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(244, 27);
            this.dateTimePicker2.TabIndex = 28;
            // 
            // Selection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 657);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSeverityID);
            this.Controls.Add(this.txtPriorityID);
            this.Controls.Add(this.btnShowBugs);
            this.Controls.Add(this.dgvListOfBugs);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBugName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCreatorID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBugID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Selection";
            this.Text = "Selection";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfBugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBugID;
        private TextBox txtCreatorID;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBugName;
        private Label label6;
        private TextBox txtDesc;
        private Label label7;
        private Label label8;
        private ErrorProvider errorProvider1;
        private DataGridView dgvListOfBugs;
        private Button btnSelect;
        private Button button1;
        private Label label9;
        private RadioButton rbNo;
        private RadioButton rbYes;
        private Button btnShowBugs;
        private TextBox txtSeverityID;
        private TextBox txtPriorityID;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label12;
        private Label label11;
    }
}