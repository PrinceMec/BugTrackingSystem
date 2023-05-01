using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class Person : Form
    {

        string connectionString = "Data Source=LAPTOP-H7UTGEOV\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Initial Catalog = BugTrackingSystem;";

        public Person()
        {
            InitializeComponent();
        }

        public void DisableTheFields()
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            txtJobTitle.Enabled = false;
            txtSalary.Enabled = false;
            txtExperience.Enabled = false;
            txtHiredDate.Enabled = false;
            txtAddress.Enabled = false;
            txtEmail.Enabled = false;
            txtDOB.Enabled = false;
            txtEmployeeId.Enabled = false;
        }

        public void EnableTheFields()
        {
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            txtJobTitle.Enabled = true;
            txtSalary.Enabled = true;
            txtExperience.Enabled = true;
            txtHiredDate.Enabled = true;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
            txtDOB.Enabled = true;

        }

        public void EmptyFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtJobTitle.Text = "";
            txtSalary.Text = "";
            txtExperience.Text = "";
            txtHiredDate.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtDOB.Text = "";

        }

        public bool CheckFields()
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtJobTitle.Text != "" && txtSalary.Text != "" &&
                txtExperience.Text != "" && txtHiredDate.Text != "" && txtAddress.Text != "" && txtEmail.Text != "" && txtDOB.Text != "")
            {
                return true;
            }

            return false;
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select * from People", sqlCon);
                DataTable datatable = new DataTable();
                sqlDa.Fill(datatable);
                dgvShowEmployees.DataSource = datatable;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (CheckFields())
            {
                SqlConnection con = new SqlConnection(connectionString);
                string InsertQuery = "Insert into People(Firstname, Lastname, Jobtitle, Salary, YearsOfExperience, HiredDate, Address, Email, DateOfBirth)" +
                    "values('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtJobTitle.Text + "','" + txtSalary.Text + "','" +
                            txtExperience.Text + "','" + txtHiredDate.Text + "','" + txtAddress.Text + "','" + txtEmail.Text + "','" + txtDOB.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(InsertQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Employee Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                EmptyFields();
            }
            else
            {
                MessageBox.Show("Please fill the require information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        public void ShowCreator(string creatorId)
        {


            DisableTheFields();

            int salary = 0, experience = 0;
            string firstName = "", lastname = "", jobTitle = "", email = "", address = "";
            DateTime hiredDate = DateTime.Now, dob = DateTime.Now;

            int id = Convert.ToInt32(creatorId);
            SqlConnection conn = new SqlConnection(connectionString);
            //string InsertQuery = "select * from People where Id = '" + creatorId+ "'";
            //string cmdstring = string.Format("select *from People where id={0}", id);
            string cmdstring = string.Format("select Firstname, Lastname, JobTitle, Salary, YearsOfExperience, " +
                "HiredDate, Address, Email, DateOfBirth from People where id={0}", id);
            SqlCommand cmdDatabase = new SqlCommand(cmdstring, conn);
            SqlDataReader myReader;
            try
            {
                conn.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    firstName = myReader.GetString(0);
                    lastname = myReader.GetString(1);
                    jobTitle = myReader.GetString(2);
                    salary = myReader.GetInt32(3);
                    experience = myReader.GetInt32(4);
                    hiredDate = (DateTime)myReader.GetDateTime(5);
                    address = myReader.GetString(6);
                    email = myReader.GetString(7);
                    dob = (DateTime)myReader.GetDateTime(8);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtFirstName.Text = firstName;
            txtLastName.Text = lastname;
            txtJobTitle.Text = jobTitle;
            txtSalary.Text = salary.ToString();
            txtExperience.Text = experience.ToString();
            txtHiredDate.Text = hiredDate.ToString();
            txtAddress.Text = address;
            txtEmail.Text = email;
            txtDOB.Text = dob.ToString();
            txtEmployeeId.Text = creatorId;



        }

        private void txtEdit_Click(object sender, EventArgs e)
        {
            EnableTheFields();
        }

        private void dgvShowEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
