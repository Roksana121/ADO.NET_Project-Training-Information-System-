using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class frmtrainerInsert : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CQKIKAQ;Initial Catalog=TrainingInformationSystemDB;" +
        "Integrated Security=True");
       

        public frmtrainerInsert()
        {
            InitializeComponent();
        }

        
        private void LoadCombo()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT id,name FROM subjects", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            cmbSubject.DataSource = ds.Tables[0];
            cmbSubject.DisplayMember = "name";
            cmbSubject.ValueMember = "id";
            con.Close();
        }
        private void AllClear()
        {
            txtId.Text = "";
            txtName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtpictureFile.Clear();
            cmbSubject.SelectedIndex = -1;



        }
       
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(txtpictureFile.Text);
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Bmp);
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO trainers(trainerId,trainerName,trainerContact,trainerEmail,picture,subjectId )VALUES(@i,@n,@c,@e,@p,@s)";
            cmd.Parameters.AddWithValue("@i", txtId.Text);
            cmd.Parameters.AddWithValue("@n", txtName.Text);
            cmd.Parameters.AddWithValue("@c", txtContact.Text);
            cmd.Parameters.AddWithValue("@e", txtEmail.Text);
            cmd.Parameters.Add(new SqlParameter("@p", SqlDbType.VarBinary) { Value = ms.ToArray() });

            cmd.Parameters.AddWithValue("@s", cmbSubject.SelectedValue);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Data insert successfully!!!");

            }
            con.Close();
            AllClear();
        }

        private void frmtrainerInsert_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                this.picBox.Image = img;
                txtpictureFile.Text = openFileDialog1.FileName;

            }
        }
    }
}
