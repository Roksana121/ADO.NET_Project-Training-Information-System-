using CrystalDecisions.CrystalReports.Engine;
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
    public partial class frmSubjectWiseTrainerInformation : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CQKIKAQ;Initial Catalog=TrainingInformationSystemDB;Integrated Security=True");

        public frmSubjectWiseTrainerInformation()
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

        private void frmSubjectWiseTrainerInformation_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ReportDocument rptCrytal = new ReportDocument();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM trainers WHERE subjectId=" + cmbSubject.SelectedValue + "", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "trainer");
            rptCrytal.Load(@"C:\Users\HP\Downloads\1266242\Training Information System-2final\Project_1\rptTrainerInfo.rpt");
            rptCrytal.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rptCrytal;
        }

        
    }
}
