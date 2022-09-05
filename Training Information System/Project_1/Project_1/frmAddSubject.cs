using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class frmAddSubject : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CQKIKAQ;Initial Catalog=TrainingInformationSystemDB;Integrated Security=True");
       
        public frmAddSubject()
        {
            InitializeComponent();
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert INTO subjects (id,name) VALUES(@i,@n)";
            cmd.Parameters.AddWithValue("@i", txtID.Text);
            cmd.Parameters.AddWithValue("@n", txtName.Text);
            if(cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Inserted Successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            txtID.Clear();
            txtName.Clear();
        }
    }
}
