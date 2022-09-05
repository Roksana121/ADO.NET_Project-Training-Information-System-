using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Project_1
{
    public partial class frmTrainerEditDelete : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CQKIKAQ;Initial Catalog=TrainingInformationSystemDB;Integrated Security=True");
       

        public frmTrainerEditDelete()
        {
            InitializeComponent();
        }

        private void LoadCombo()
        {
            //con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT id,name FROM subjects", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmbSubject.DataSource = ds.Tables[0];
            cmbSubject.DisplayMember = "name";
            cmbSubject.ValueMember = "id";

            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT trainerId FROM trainers", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            cmbId.ValueMember = "trainerId";
            cmbId.DisplayMember = "trainerId";
            cmbId.DataSource = dt2;
            //con.Close();
        }

        private void frmTrainerEditDelete_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }
       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtpictureFile.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE trainers SET trainerName=@n,trainerContact=@c,trainerEmail=@e,picture=@p,subjectId=@s WHERE trainerId=@i";
            cmd.Parameters.AddWithValue("@i", cmbSubject.SelectedValue);
            cmd.Parameters.AddWithValue("@n", txtName.Text);
            cmd.Parameters.AddWithValue("@c", txtContact.Text);
            cmd.Parameters.AddWithValue("@e", txtEmail.Text);
            cmd.Parameters.Add(new SqlParameter("@p", SqlDbType.VarBinary) { Value = ms.ToArray() });

            cmd.Parameters.AddWithValue("@s", cmbSubject.SelectedValue);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Update successfully!!!");

            }
            con.Close();
            LoadCombo();
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog2.FileName);
                this.picBox.Image = img;
                txtpictureFile.Text = openFileDialog2.FileName;

            }
        }

       

        private void cmbId_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT trainerId,trainerName,trainerContact,trainerEmail,picture,subjectId FROM trainers WHERE trainerId=@i";
            cmd.Parameters.AddWithValue("@i", cmbSubject.SelectedValue);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //lblID.cmbId = "";
                txtName.Text = dr.GetString(1);
                txtContact.Text = dr.GetString(2);
                txtEmail.Text = dr.GetString(3);
                cmbSubject.SelectedValue = dr.GetInt32(5);
                picBox.Image = Image.FromStream(dr.GetStream(4));

            }
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM trainers WHERE trainerId=@i", con);
            cmd.Parameters.AddWithValue("@i", cmbId.SelectedValue);
            con.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data Deleted successfully!!!");
            }
            con.Close();
            LoadCombo();

        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
