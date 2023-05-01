using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class NewBug : Form
    {
        public NewBug()
        {
            InitializeComponent();
        }

        public void EmptyFields()
        {
            txtBugName.Text = "";
            txtDesc.Text = "";
            txtCreatorID.Text = "";
            txtPriorityID.Text = "";
            txtSeverityID.Text = "";
            txtPriorityID.Text = "";
            txtCreationDate.Text = "";
            txtLastUpdateDate.Text = "";
            rbYes.Checked = false;
            rbNo.Checked = false;

        }

        public bool CheckFields()
        {
            bool radioButtonIsChecked = false;

            if (rbYes.Checked == true || rbNo.Checked == true)
            {
                radioButtonIsChecked = true;
            }

            if(txtBugName.Text != ""  && txtCreatorID.Text != "" && txtPriorityID.Text != "" && txtSeverityID.Text != ""
                && txtPriorityID.Text != "" && txtCreationDate.Text != "" && txtLastUpdateDate.Text != "" && radioButtonIsChecked)
            {
                return true;
            }
            return false;
        }

        string connectionString = "Data Source=LAPTOP-H7UTGEOV\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Initial Catalog = BugTrackingSystem;";


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string rbResults = "";

            if(rbYes.Checked)
            {
                rbResults = "true";

            }  
            else if(rbNo.Checked)
            {
                rbResults = "false";
            }
            

            if(CheckFields())
            {
                
                SqlConnection con = new SqlConnection(connectionString);
                string InsertQuery = "Insert into Bugs(Name, Description, CreatorID, PriorityID, SeverityID, CreationDate, LastUpdateDate, Solved)" +
                    "values('" + txtBugName.Text + "','" + txtDesc.Text + "','" + txtCreatorID.Text + "','" + txtPriorityID.Text + "','" + txtSeverityID.Text + "','" +
                            txtCreationDate.Text + "','" + txtLastUpdateDate.Text + "','" + rbResults + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(InsertQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Bug Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmptyFields();
            } else
            {
                MessageBox.Show("Please fill all the require information!", "Warnings", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
