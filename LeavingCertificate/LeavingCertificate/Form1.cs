using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace LeavingCertificate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            CrystalReport1 cr = new CrystalReport1();
            TextObject Name = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Name"];
            TextObject ID = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["ID"];
            TextObject Branch = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Branch"];
            TextObject DOB = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["DOB"];
            TextObject Performance = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["Performance"];
            TextObject AdmissionYear = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["AdmissionYear"];
            TextObject DateOfIssue = (TextObject)cr.ReportDefinition.Sections["Section3"].ReportObjects["DateOfIssue"];

            Name.Text = txtName.Text;
            ID.Text = txtID.Text;
            Branch.Text = txtBranch.Text;
            DOB.Text = txtDOB.Text;
            Performance.Text = txtPerformance.Text;
            AdmissionYear.Text = txtAdmissionYear.Text;
            DateOfIssue.Text = txtTCDate.Text;

            fm2.crystalReportViewer1.ReportSource = cr;
            fm2.Show();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
