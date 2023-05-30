using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace studentmanagementsystem
{
    public partial class CoursePreQualificationDetails : Form
    {
        public CoursePreQualificationDetails()
        {
            InitializeComponent();
        }

        DashboardNew Back = new DashboardNew();
        conlink sqlcon = new conlink();

        int PreQualiNo;
        String PreQualiName, PreQualiNote;
        
        
       
        private void CoursePreQualificationDetails_Load(object sender, EventArgs e)
        {
            sms smsclz = new sms();
            this.txtPreQNo.Text = Convert.ToString(smsclz.preQualiGetNextNo());

            this.btnPreQSave.Visible = false;
            this.btnPreQSearch.Visible = false;
            this.cmbPreQSearch.Visible = false;
            this.btnPreQBack.Enabled = false;

        }

        private void btnPreQAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(cmbPreQName.SelectedIndex == -1) && !(txtPreQNote.Text == ""))
                {
                    PreQualiNo = Convert.ToInt32(this.txtPreQNo.Text.Trim());
                    PreQualiName = this.cmbPreQName.SelectedItem.ToString();
                    PreQualiNote = this.txtPreQNote.Text.Trim();

                    sms smsclz = new sms();

                    this.txtPreQNo.Text = Convert.ToString(smsclz.preQualiGetNextNo());

                    smsclz.preQualiAddData(PreQualiNo, PreQualiName, PreQualiNote);

                    MessageBox.Show("Successfully Added Pre Qualification Detail", "Message");

                    Clear();

                }
                else
                {
                    MessageBox.Show("A record with these values has null value." + "\n" +  "Check Name, description and try again", "Error");

                }
            }
            catch
            {
                MessageBox.Show("A record with these values already exists. Please check name and description and try again", "Error");
            }

        }
        public void Clear()
        {

            this.txtPreQNote.Text = "";
            this.cmbPreQName.SelectedIndex = -1;

            sms smsclz = new sms();
            this.txtPreQNo.Text = Convert.ToString(smsclz.preQualiGetNextNo());
        }

        private void btnPreQBack_Click(object sender, EventArgs e)
        {
            this.btnPreQSave.Visible = false;
            this.btnPreQSearch.Visible = false;
            this.cmbPreQSearch.Visible = false;
            this.txtPreQNo.Visible = true;
            this.btnPreQAdd.Visible = true;
            
            
            sms smsclz = new sms();
            this.txtPreQNo.Text = Convert.ToString(smsclz.preQualiGetNextNo());
            
            Clear();
        }

        private void btnPreQClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnPreQEdit_Click(object sender, EventArgs e)
        {
            this.btnPreQSearch.Visible = true;
            this.btnPreQSave.Visible = true;
            this.cmbPreQSearch.Visible = true;
            this.btnPreQAdd.Visible = false;
            this.cmbPreQName.Enabled = false;
            this.btnPreQBack.Enabled = true;

            FillPreQNo();
        }

        void FillPreQNo()
        {
            try
            {
                this.cmbPreQSearch.Items.Clear();
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                string msql = "select * from prequalificationdetails";
                SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
                SqlCeDataReader dr;
                conn.Open();
                dr = cmd1.ExecuteReader();

                while (dr.Read())
                {
                    string Pno = dr.GetString(0);
                    cmbPreQSearch.Items.Add(Pno);

                }

                conn.Close();
                conn.Dispose();
            }
            catch
            {

            }

        }

        private void btnPreQSearch_Click(object sender, EventArgs e)
        {
            string PreQno = this.cmbPreQSearch.SelectedItem.ToString();
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = " select * from prequalificationdetails where(record_no = '" + PreQno + "')";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                
                this.cmbPreQName.SelectedItem = dr[1].ToString();
                this.txtPreQNote.Text = dr[2].ToString();

            }
            conn.Close();
            conn.Dispose();
        }

        private void btnPreQSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(cmbPreQName.SelectedIndex == -1) && !(txtPreQNote.Text == ""))
                {
                    int pQuliNo = Convert.ToInt32(cmbPreQSearch.SelectedIndex.ToString());
                    string pQuliName = cmbPreQName.SelectedIndex.ToString();
                    string pQuliNote = txtPreQNote.Text.Trim();

                    sms smsclz = new sms();
                    smsclz.updatePreQualiData(pQuliNo, pQuliName, pQuliNote);


                    MessageBox.Show("Updated Successfully", "Message");
                    Clear();
                }
                //else
                //{
                //    MessageBox.Show("A record with these values have null value." + "\n" + "Please check name, description and try again", "Error");

                //}

            }
            catch
            {
                MessageBox.Show("A record with these values already exists or have null value." + "\n" + "Please check name, description and try again", "Error");

            }

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Back.Show();
        }
        
    }
}
