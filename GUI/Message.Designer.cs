namespace GUI
{
    partial class Message
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtBugIdInMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitleInMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreatorIDInMessage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTextInMessage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCreatorDateInMessage = new System.Windows.Forms.DateTimePicker();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(146, 32);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(356, 27);
            this.txtID.TabIndex = 1;
            // 
            // txtBugIdInMessage
            // 
            this.txtBugIdInMessage.Location = new System.Drawing.Point(146, 94);
            this.txtBugIdInMessage.Name = "txtBugIdInMessage";
            this.txtBugIdInMessage.Size = new System.Drawing.Size(356, 27);
            this.txtBugIdInMessage.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bug ID:";
            // 
            // txtTitleInMessage
            // 
            this.txtTitleInMessage.Location = new System.Drawing.Point(146, 152);
            this.txtTitleInMessage.Name = "txtTitleInMessage";
            this.txtTitleInMessage.Size = new System.Drawing.Size(356, 27);
            this.txtTitleInMessage.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Title:";
            // 
            // txtCreatorIDInMessage
            // 
            this.txtCreatorIDInMessage.Location = new System.Drawing.Point(146, 213);
            this.txtCreatorIDInMessage.Name = "txtCreatorIDInMessage";
            this.txtCreatorIDInMessage.Size = new System.Drawing.Size(356, 27);
            this.txtCreatorIDInMessage.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Creator ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Creator Date:";
            // 
            // txtTextInMessage
            // 
            this.txtTextInMessage.Location = new System.Drawing.Point(146, 339);
            this.txtTextInMessage.Multiline = true;
            this.txtTextInMessage.Name = "txtTextInMessage";
            this.txtTextInMessage.Size = new System.Drawing.Size(356, 92);
            this.txtTextInMessage.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Text:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(32, 492);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 41);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(342, 492);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 41);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtCreatorDateInMessage
            // 
            this.txtCreatorDateInMessage.Location = new System.Drawing.Point(146, 279);
            this.txtCreatorDateInMessage.Name = "txtCreatorDateInMessage";
            this.txtCreatorDateInMessage.Size = new System.Drawing.Size(356, 27);
            this.txtCreatorDateInMessage.TabIndex = 14;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(187, 492);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(149, 41);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 545);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtCreatorDateInMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTextInMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCreatorIDInMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitleInMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBugIdInMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "Message";
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtID;
        private TextBox txtBugIdInMessage;
        private Label label2;
        private TextBox txtTitleInMessage;
        private Label label3;
        private TextBox txtCreatorIDInMessage;
        private Label label4;
        private Label label5;
        private TextBox txtTextInMessage;
        private Label label6;
        private Button btnSave;
        private Button btnCancel;
        private DateTimePicker txtCreatorDateInMessage;
        private Button btnEdit;
    }
}