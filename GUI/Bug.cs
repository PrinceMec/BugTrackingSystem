using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace GUI
{
    public partial class Bug : Form
    {
        string connectionString = "Data Source=LAPTOP-H7UTGEOV\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Initial Catalog = BugTrackingSystem;";


        public Bug()
        {
            InitializeComponent();
        }

        public void EmptyFields()
        {
            txtBugID.Text = "";
            txtBugName.Text = "";
            txtDesc.Text = "";
            txtCreatorID.Text = "";
            txtCreationDate.Text = "";
            txtPriorityID.Text = "";
            txtSeverityID.Text = "";
            txtLastUpdate.Text = "";

            rbYes.Checked = false;
            rbNo.Checked = false;
        }

        public bool CheckFields()
        {
            bool checkRb = false;

            if (rbYes.Checked == true)
            {
                checkRb = true;

            }
            else if (rbNo.Checked == false)
            {
                checkRb = false;
            }

            if (txtBugID.Text != "" && txtBugName.Text != "" && txtCreatorID.Text != "" && txtCreationDate.Text != "" &&
                txtPriorityID.Text != "" && txtSeverityID.Text != "" && txtLastUpdate.Text != "" && checkRb)
            {
                return true;
            }

            return false;
        }

        public void DisableTheFields()
        {
            txtBugID.Enabled = false;
            txtBugName.Enabled = false;
            txtDesc.Enabled = false;
            txtCreatorID.Enabled = false;
            txtCreationDate.Enabled = false;
            txtPriorityID.Enabled = false;
            txtSeverityID.Enabled = false;
            txtLastUpdate.Enabled = false;

            rbYes.Enabled = false;
            rbNo.Enabled = false;
        }

        public void EnableTheFields()
        {
            txtBugID.Enabled = true;
            txtBugName.Enabled = true;
            txtDesc.Enabled = true;
            txtCreatorID.Enabled = true;
            txtCreationDate.Enabled = true;
            txtPriorityID.Enabled = true;
            txtSeverityID.Enabled = true;
            txtLastUpdate.Enabled = true;

            rbYes.Enabled = true;
            rbNo.Enabled = true;
        }


        public void ShowBugs(string idx)
        {
            DisableTheFields();
            string bugName = "", desc = "", solved = "";
            int creatorID = 0, priorityID = 0, severityID = 0;
            DateTime creationDate = DateTime.Now, lastUpdateDate = DateTime.Now;


            if (idx != "")
            {
                int id = Convert.ToInt32(idx);
                SqlConnection conn = new SqlConnection(connectionString);
                string cmdstring = string.Format("select Name, Description, CreatorID, PriorityID, SeverityID, " +
                    "CreationDate, LastUpdateDate, Solved from Bugs where id={0}", id);
                SqlCommand cmdDatabase = new SqlCommand(cmdstring, conn);
                SqlDataReader myReader;
                try
                {
                    conn.Open();
                    myReader = cmdDatabase.ExecuteReader();

                    while (myReader.Read())
                    {
                        bugName = myReader.GetString(0);
                        desc = myReader.GetString(1);
                        creatorID = myReader.GetInt32(2);
                        priorityID = myReader.GetInt32(3);
                        severityID = myReader.GetInt32(4);
                        creationDate = (DateTime)myReader.GetDateTime(5);
                        lastUpdateDate = (DateTime)myReader.GetDateTime(6);
                        solved = myReader.GetString(7);


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtBugID.Text = id.ToString();
                txtBugName.Text = bugName.ToString();
                txtDesc.Text = desc.ToString();
                txtCreatorID.Text = creatorID.ToString();
                txtCreationDate.Text = creationDate.ToString();
                txtPriorityID.Text = priorityID.ToString();
                txtSeverityID.Text = severityID.ToString();
                txtLastUpdate.Text = lastUpdateDate.ToString();

                if (solved == "false")
                {
                    rbNo.Checked = true;

                }
                else if (solved == "true")
                {
                    rbYes.Checked = false;
                }
            }
            else
            {
                EnableTheFields();
                MessageBox.Show("Enter the Bug ID to see details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                EnableTheFields();
                txtBugID.Enabled = false;
                txtCreatorID.Enabled = false;
                txtCreationDate.Enabled = false;
                txtLastUpdate.Enabled = false;


            }
            else
            {
                MessageBox.Show("Not Enough Fields to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Messages", sqlCon);
                DataTable datatable = new DataTable();
                sqlDa.Fill(datatable);
                dgvMessages.DataSource = datatable;
            }
        }

        private void btnNewBug_Click(object sender, EventArgs e)
        {
            NewBug openNewBugForm = new NewBug();

            openNewBugForm.Show();
        }

        private void btnNewMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnCreatorName_Click(object sender, EventArgs e)
        {
            Person personForm = new Person();

            if (txtCreatorID.Text != "")
            {
                personForm.ShowCreator(txtCreatorID.Text);
                personForm.Show();
            }
            else
            {
                MessageBox.Show("Enter Creator ID to see details!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnBugDetails_Click(object sender, EventArgs e)
        {
            DisableTheFields();
            string bugName = "", desc = "", solved = "";
            int creatorID = 0, priorityID = 0, severityID = 0;
            DateTime creationDate = DateTime.Now, lastUpdateDate = DateTime.Now;


            if (txtBugID.Text != "")
            {
                int id = Convert.ToInt32(txtBugID.Text);
                SqlConnection conn = new SqlConnection(connectionString);
                string cmdstring = string.Format("select Name, Description, CreatorID, PriorityID, SeverityID, " +
                    "CreationDate, LastUpdateDate, Solved from Bugs where id={0}", id);
                SqlCommand cmdDatabase = new SqlCommand(cmdstring, conn);
                SqlDataReader myReader;
                try
                {
                    conn.Open();
                    myReader = cmdDatabase.ExecuteReader();

                    while (myReader.Read())
                    {
                        bugName = myReader.GetString(0);
                        desc = myReader.GetString(1);
                        creatorID = myReader.GetInt32(2);
                        priorityID = myReader.GetInt32(3);
                        severityID = myReader.GetInt32(4);
                        creationDate = (DateTime)myReader.GetDateTime(5);
                        lastUpdateDate = (DateTime)myReader.GetDateTime(6);
                        solved = myReader.GetString(7);


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtBugID.Text = id.ToString();
                txtBugName.Text = bugName.ToString();
                txtDesc.Text = desc.ToString();
                txtCreatorID.Text = creatorID.ToString();
                txtCreationDate.Text = creationDate.ToString();
                txtPriorityID.Text = priorityID.ToString();
                txtSeverityID.Text = severityID.ToString();
                txtLastUpdate.Text = lastUpdateDate.ToString();

                if (solved == "false")
                {
                    rbNo.Checked = true;

                }
                else if (solved == "true")
                {
                    rbYes.Checked = false;
                }
            }
            else
            {
                EnableTheFields();
                MessageBox.Show("Enter the Bug ID to see details!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (CheckFields())
            {
                string rbButtonResults = "";

                if (rbYes.Checked == true)
                {
                    rbButtonResults = "true";
                }
                else
                {
                    rbButtonResults = "false";
                }

                SqlConnection con = new SqlConnection(connectionString);
                string InsertQuery = "Insert into Bugs(Name, Description, CreatorID, PriorityID, SeverityID, CreationDate, LastUpdateDate, Solved)" +
                    "values('" + txtBugName.Text + "','" + txtDesc.Text + "','" + txtCreatorID.Text + "','" + txtPriorityID.Text + "','" +
                            txtSeverityID.Text + "','" + txtCreationDate.Text + "','" + txtLastUpdate.Text + "','" + rbButtonResults + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(InsertQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Bug Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EnableTheFields();
                EmptyFields();

            }
            else
            {
                MessageBox.Show("Please enter the require information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {


            DialogResult result = (DialogResult)MessageBoxButtons.YesNo;


            DialogResult dialogResult = MessageBox.Show("Are you sure want to cancel all the information?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                EnableTheFields();
                EmptyFields();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = (DialogResult)MessageBoxButtons.YesNo;


            DialogResult dialogResult = MessageBox.Show("Are you sure want to cancel all the information?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                EmptyFields();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnGetMessages_Click(object sender, EventArgs e)
        {
            string idx = "";

            foreach (DataGridViewRow row in dgvMessages.SelectedRows)
            {
                idx = row.Cells[0].Value.ToString();


            }



            Message message = new Message();
            message.GetMessages(idx);

        }

        private void dgvMessages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
