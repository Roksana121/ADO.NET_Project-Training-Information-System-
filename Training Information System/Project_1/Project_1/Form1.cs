using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtrainerInsert ti = new frmtrainerInsert();
            ti.MdiParent = this;
            ti.Show();
        }

        private void editeDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrainerEditDelete fud = new frmTrainerEditDelete();
            fud.MdiParent = this;
            fud.Show();

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrainerView tv = new frmTrainerView();
            tv.MdiParent = this;
            tv.Show();
        }

        private void trainerInformationViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport tir = new frmReport();
            tir.MdiParent = this;
            tir.Show();
        }

        private void subjectWiseTrainerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSubjectWiseTrainerInformation swt = new frmSubjectWiseTrainerInformation();
            swt.MdiParent = this;
            swt.Show();
        }

        private void trainerInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrainerView tv = new frmTrainerView();
            tv.MdiParent = this;
            tv.Show();
        }

        private void trainerInsertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmtrainerInsert ti = new frmtrainerInsert();
            ti.MdiParent = this;
            ti.Show();
        }

        private void trainerEditDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrainerEditDelete fed = new frmTrainerEditDelete();
            fed.MdiParent = this;
            fed.Show();
        }

        private void trainerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport tir = new frmReport();
            tir.MdiParent = this;
            tir.Show();
        }

        private void subjectWiseTrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjectWiseTrainerInformation swt = new frmSubjectWiseTrainerInformation();
            swt.MdiParent = this;
            swt.Show();
        }

        private void addNewSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSubject aS= new frmAddSubject();
            aS.MdiParent = this;
            aS.Show();
        }
    }
}
