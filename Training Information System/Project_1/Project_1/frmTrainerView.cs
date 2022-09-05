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
    public partial class frmTrainerView : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CQKIKAQ;Initial Catalog=TrainingInformationSystemDB;" +
         "Integrated Security=True");

        public frmTrainerView()
        {
            InitializeComponent();
        }

        private void frmTrainerView_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *FROM trainers", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            
        }
    }
}
