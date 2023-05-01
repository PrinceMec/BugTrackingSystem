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
    public partial class Selection : Form
    {

        string connectionString = "Data Source=LAPTOP-H7UTGEOV\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Initial Catalog = BugTrackingSystem;";
        

        public Selection()
        {
            InitializeComponent();
        }

        private void btnShowBugs_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select * from Bugs", sqlCon);
                DataTable datatable = new DataTable();
                sqlDa.Fill(datatable);
                dgvListOfBugs.DataSource = datatable;
            }
        }

        private void dgvListOfBugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string idx = "";

            foreach (DataGridViewRow row in dgvListOfBugs.SelectedRows)
            {
                idx = row.Cells[0].Value.ToString();


            }

            Bug bug = new Bug();
            bug.ShowBugs(idx);
            bug.Show();
        }
    }
}
