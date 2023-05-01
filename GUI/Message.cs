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
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=LAPTOP-H7UTGEOV\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Initial Catalog = BugTrackingSystem;";


        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void GetMessages(string idx)
        {
            int id = 0, BugId = 0, creationId = 0;
            string title = "", text = "";
            DateTime creationDate = DateTime.Now;

            id = Convert.ToInt32(idx);
            SqlConnection conn = new SqlConnection(connectionString);
            
            string cmdstring = string.Format("select BugId, Title, Text, CreationDate, CreatorId " +
                " from Messages where id={0}", id);
            SqlCommand cmdDatabase = new SqlCommand(cmdstring, conn);
            SqlDataReader myReader;
            try
            {
                conn.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    BugId = myReader.GetInt32(0);
                    title = myReader.GetString(1);
                    text = myReader.GetString(2);
                    creationDate = (DateTime)myReader.GetDateTime(3);
                    creationId = myReader.GetInt32(4);
                    


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtBugIdInMessage.Text = BugId.ToString();
            txtTitleInMessage.Text = title;
            txtTextInMessage.Text = text;
            txtCreatorDateInMessage.Text = creationDate.ToString();
            txtCreatorIDInMessage.Text = creationId.ToString();
        }
    }
}
