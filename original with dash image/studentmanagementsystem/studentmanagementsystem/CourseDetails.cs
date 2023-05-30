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
    public partial class CourseDetails : Form
    {
        public CourseDetails()
        {
            InitializeComponent();
            FillTrade();
            FillCourseConduct();    
        }

        DashboardNew Back = new DashboardNew();
        sms smsclz = new sms();
        conlink sqlcon = new conlink();

        int RecordNo, maxInstruct, maxStudent;
        string Trade, cFName, cShortN, cType, cYear, cBatch, cDuration, cCode, cFee, cStatus, cConductDay, cConductTime;
        string PQualiName, PQualiNote;
        DateTime cStartDate, cEndDate;
        int m = 0;
        
        void FillTrade()
        {
            try
            {
                cmbCourseTrade.Items.Clear();

                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                string msql = "select * from tradedetails";
                SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
                SqlCeDataReader dr;
                conn.Open();
                dr = cmd1.ExecuteReader();

                while (dr.Read())
                {
                    string tName = dr.GetString(1);
                    cmbCourseTrade.Items.Add(tName);
                }

                conn.Close();
                conn.Dispose();
            }
            catch
            {

            }
        }

        void FillCourseConduct()
        {
            try
            {
                cmbCourseDay.Items.Clear();

                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                string msql = "select * from courseconductdetails";
                SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
                SqlCeDataReader dr;
                conn.Open();
                dr = cmd1.ExecuteReader();

                while (dr.Read())
                {
                    string ConductName = dr.GetString(1);
                    cmbCourseDay.Items.Add(ConductName);
                }

                conn.Close();
                conn.Dispose();
            }
            catch
            {

            }
        }

        private void cmbCpreQualiN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.cmbCpreQualiDes.Items.Clear();

                string PQualiName = this.cmbCpreQualiN.SelectedItem.ToString();
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = " select * from prequalificationdetails where(preQualificationName =  '" + PQualiName + "')";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();

                while (dr.Read())
                {
                    string QualiDescri = dr.GetString(2);
                    cmbCpreQualiDes.Items.Add(QualiDescri);
                }
                conn.Close();
                conn.Dispose();
            }
            catch
            {

            }

        }
        

        private void cmbCourseDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                this.cmbCourseTime.Items.Clear();
                string conductDate = this.cmbCourseDay.SelectedItem.ToString();
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = " select * from courseconductdetails where(conduct_days = '" + conductDate + "')";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    string CourseTime = dr.GetString(2);
                    cmbCourseTime.Items.Add(CourseTime);
                }

                conn.Close();
                conn.Dispose();
            }
            catch
            {
                
            }
        }

        public void btnCourseCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(txtCShortName.Text == "") && !(txtCourseYear.Text == "") && !(txtCourseBatchN.Text == "") && !(cmbCourseTrade.SelectedIndex == -1) && !(cmbCourseType.SelectedIndex == -1) && !(txtCourseCode.Text == ""))
                {
                    RecordNo = Convert.ToInt32(this.txtFCourseDRN.Text.Trim());
                    Trade = this.cmbCourseTrade.SelectedItem.ToString();
                    cFName = this.txtCourseName.Text.Trim();
                    cShortN = this.txtCShortName.Text.Trim();
                    cType = this.cmbCourseType.SelectedItem.ToString();
                    cYear = this.txtCourseYear.Text.Trim();
                    cBatch = this.txtCourseBatchN.Text.Trim();
                    cDuration = this.txtCourseDurat.Text.Trim();
                    cStartDate = Convert.ToDateTime(this.dtpCourseStart.Text.Trim());
                    cEndDate = Convert.ToDateTime(this.dtpCourseEnd.Text.Trim());
                    cCode = this.txtCourseCode.Text.Trim();
                    cFee = this.txtCourseFee.Text.Trim();
                    cStatus = this.cmbCourseStatus.SelectedItem.ToString();
                    cConductDay = this.cmbCourseDay.SelectedItem.ToString();
                    cConductTime = this.cmbCourseTime.SelectedItem.ToString();
                    PQualiName = this.cmbCpreQualiN.SelectedItem.ToString();
                    PQualiNote = this.cmbCpreQualiDes.SelectedItem.ToString();
                    maxInstruct = Convert.ToInt32(this.txtCInstMax.Text.Trim());
                    maxStudent = Convert.ToInt32(this.txtCStuMax.Text.Trim());

                    sms smsclz = new sms();

                    this.txtFCourseDRN.Text = Convert.ToString(smsclz.courseGetNextNo());


                    smsclz.courseAddData(RecordNo, Trade, cFName, cShortN, cType, cYear, cBatch, cDuration, cStartDate, cEndDate, cCode, cFee, cStatus, cConductDay, cConductTime, PQualiName, PQualiNote, maxInstruct, maxStudent);

                    MessageBox.Show("Successfully Created Course", "Message");

                    this.txtCourseDurat.Text = "0";
                    Clear();
                }
                else
                {
                    MessageBox.Show("All details should be fill" + "\n" + "Make sure course code is generated", "Message");
                }
            }
            catch
            {
                MessageBox.Show("Not Created,Try Again", "Message");
            }
        }

        private void CourseDetails_Load(object sender, EventArgs e)
        {
            sms smsclz = new sms();
            this.txtFCourseDRN.Text = Convert.ToString(smsclz.courseGetNextNo());
            this.cmbCodeSearch.Visible = false;
            this.lblCodeSearch.Visible = false;
            this.btnCodeSearch.Visible = false;
            this.txtCourseCode.Enabled = false;
            this.btnCourseSave.Visible = false;
            this.btnCourseBack.Enabled = false;
            this.dtpCourseEnd.Enabled = false;

            this.lblcoursecodemessage.Visible = false;

        }

        private void btnCCodeGenerator_Click(object sender, EventArgs e)
        {
            try
            {
                var prefix = cmbCourseType.SelectedItem.ToString().Substring(0, 1);
                txtCourseCode.Text = txtCourseYear.Text + "-" + txtCourseBatchN.Text + "-" + txtCShortName.Text + "-" + prefix + "-" + txtFCourseDRN.Text;
            }
            catch
            {
                MessageBox.Show("Please Fill All Fields", "Message");
            }
         }


        public void Clear()
        {
            this.txtCourseName.Text = "";
            this.txtCShortName.Text = "";
            this.txtCourseYear.Text = "";
            this.txtCourseBatchN.Text = "";
            //this.txtCourseDurat.Text = "";
            this.txtCourseCode.Text = "";
            this.txtCourseFee.Text = "";
            this.txtCInstMax.Text = "";
            this.txtCStuMax.Text = "";
            this.cmbCourseTrade.SelectedIndex = -1;
            this.cmbCourseType.SelectedIndex = -1;
            this.cmbCourseStatus.SelectedIndex = -1;
            
            this.cmbCourseDay.SelectedIndex = -1;
            this.cmbCourseTime.SelectedIndex = -1;
            this.cmbCpreQualiN.SelectedIndex = -1;
            this.cmbCpreQualiDes.SelectedIndex = -1;
            
            this.dtpCourseStart.Value = System.DateTime.Now;
            this.dtpCourseEnd.Value = System.DateTime.Now;

           
            sms smsclz = new sms();
            this.txtFCourseDRN.Text = Convert.ToString(smsclz.courseGetNextNo());
        }

        private void btnCourseClear_Click(object sender, EventArgs e)
        {
            this.txtCourseDurat.Text = "";
            Clear();
        }

        private void btnCourseBack_Click(object sender, EventArgs e)
        {
            
            this.cmbCodeSearch.Visible = false;
            this.btnCodeSearch.Visible = false;
            this.btnCourseSave.Visible = false;
            this.btnCCodeGenerator.Visible = true;
            this.txtCourseCode.Visible = true;
            this.btnCourseCreate.Visible = true;

            this.txtFCourseDRN.Enabled = true;
            this.txtCourseName.Enabled = true;
            this.txtCourseYear.Enabled = true;
            this.txtCShortName.Enabled = true;
            this.txtCourseBatchN.Enabled = true;
            this.cmbCourseTrade.Enabled = true;
            this.cmbCourseType.Enabled = true;
            this.btnCourseBack.Enabled = false;
            this.btnCourseClear.Enabled = true;

            this.dtpCourseStart.Value = System.DateTime.Now;
            this.dtpCourseEnd.Value = System.DateTime.Now;

            //int cDuration = Convert.ToInt32(this.txtCourseDurat.Text.Trim());
            this.txtCourseDurat.Text = "0";


            Clear();
            
        }

        private void btnCourseEdit_Click(object sender, EventArgs e)
        {
            FillCourseCode();

            this.btnCourseSave.Visible = true;
            
            this.lblCodeSearch.Visible = true;
            this.btnCodeSearch.Visible = true;
            this.cmbCodeSearch.Visible = true;
            this.btnCCodeGenerator.Visible = false;
            this.txtFCourseDRN.Enabled = false;
            this.txtCourseName.Enabled = false;
            this.txtCourseYear.Enabled = false;
            this.txtCShortName.Enabled = false;
            this.txtCourseBatchN.Enabled = false;
            this.cmbCourseTrade.Enabled = false;
            this.cmbCourseType.Enabled = false;
            this.txtCourseCode.Visible = false;
            this.btnCourseBack.Enabled = true;
            this.btnCourseClear.Enabled = false;
           
            this.btnCourseCreate.Visible = false;

        }

        void FillCourseCode()
        {
            cmbCodeSearch.Items.Clear();
            
            this.cmbCodeSearch.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from coursedetails";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string CCode = dr.GetString(10);
                cmbCodeSearch.Items.Add(CCode);
            }

            conn.Close();
            conn.Dispose();

        }

        private void btnCodeSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string Code = this.cmbCodeSearch.SelectedItem.ToString();
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = " select * from coursedetails where(course_code = '" + Code + "')";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    this.txtFCourseDRN.Text = dr[0].ToString();
                    this.cmbCourseTrade.SelectedItem = dr[1].ToString();
                    this.txtCourseName.Text = dr[2].ToString();
                    this.txtCShortName.Text = dr[3].ToString();
                    this.cmbCourseType.SelectedItem = dr[4].ToString();
                    this.txtCourseYear.Text = dr[5].ToString();
                    this.txtCourseBatchN.Text = dr[6].ToString();
                    this.txtCourseDurat.Text = dr[7].ToString();
                    this.dtpCourseStart.Value = Convert.ToDateTime(dr[8].ToString());
                    this.dtpCourseEnd.Value = Convert.ToDateTime(dr[9].ToString());
                    this.txtCourseFee.Text = dr[11].ToString();
                    this.cmbCourseStatus.SelectedItem = dr[12].ToString();
                    this.cmbCourseDay.SelectedItem = dr[13].ToString();
                    this.cmbCourseTime.SelectedItem = dr[14].ToString();
                    this.cmbCpreQualiN.SelectedItem = dr[15].ToString();
                    this.cmbCpreQualiDes.SelectedItem = dr[16].ToString();
                    this.txtCInstMax.Text = dr[17].ToString();
                    this.txtCStuMax.Text = dr[18].ToString();

                }
                conn.Close();
                conn.Dispose();
            }
            catch
            {
                MessageBox.Show("Try Again", "Message");
            }
        }

        private void btnCourseSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                string c_code = cmbCodeSearch.SelectedItem.ToString();
                string Duration = txtCourseDurat.Text.Trim();
                DateTime StartDate = Convert.ToDateTime(dtpCourseStart.Text.Trim());
                DateTime EndDate = Convert.ToDateTime(dtpCourseEnd.Text.Trim());
                string Fee = txtCourseFee.Text.Trim();
                string status = cmbCourseStatus.SelectedItem.ToString();
                string ConductDay = this.cmbCourseDay.SelectedItem.ToString();
                string ConductTime = this.cmbCourseTime.SelectedItem.ToString();
                string pQualiName = this.cmbCpreQualiN.SelectedItem.ToString();
                string pQualiNote = this.cmbCpreQualiDes.SelectedItem.ToString();
                int MaxInstruct = Convert.ToInt32(this.txtCInstMax.Text.Trim());
                int MaxStudent = Convert.ToInt32(this.txtCStuMax.Text.Trim());

                if (!(txtCourseDurat.Text == "") && !(StartDate == System.DateTime.Now) && !(EndDate == System.DateTime.Now) && !(cmbCourseDay.SelectedIndex == -1) && !(cmbCourseStatus.SelectedIndex == -1) && !(cmbCourseTime.SelectedIndex == -1) && !(cmbCpreQualiN.SelectedIndex == -1) && !(cmbCpreQualiDes.SelectedIndex == -1) && !(txtCourseFee.Text == "") && !(txtCInstMax.Text == "") && !(txtCStuMax.Text == ""))
                {
                    smsclz.updateCourseData(c_code, Duration, StartDate, EndDate, Fee, status, ConductDay, ConductTime, pQualiName, pQualiNote, MaxInstruct, MaxStudent);


                    MessageBox.Show("Updated Successfully", "Message");
                    this.btnCourseClear.Enabled = true;
                    this.btnCourseCreate.Visible = true;
                    this.btnCourseSave.Visible = false;

                    Clear();
                }

            }
            catch
            {
                MessageBox.Show("Not Updated", "Warning/Error");
                this.btnCourseClear.Enabled = true;
                this.btnCourseCreate.Enabled = false;
                this.btnCourseSave.Visible = true;
                this.btnCourseCreate.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Back.Show();
        }

        private void dtpCourseStart_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime date = DateTime.Today;
                //int thisyear = date.Year;
                if (this.dtpCourseStart.Value > date)
                {
                    m = Convert.ToInt32(this.txtCourseDurat.Text.Trim());
                    this.dtpCourseEnd.Value = this.dtpCourseStart.Value.AddMonths(m).AddDays(0);
                }
                else
                {
                    MessageBox.Show("The date entered cannot be a previous date");
                }
            }
            catch
            {

            }
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {
            if (!(System.Text.RegularExpressions.Regex.IsMatch(txtCourseName.Text, "^[a-zA-Z ]+$")) && !(txtCourseName.Text == "")) 
            {
                MessageBox.Show("Enter only alphabetical characters");
            }
        }

        private void txtCShortName_TextChanged(object sender, EventArgs e)
        {
            if (!(System.Text.RegularExpressions.Regex.IsMatch(txtCShortName.Text, "^[A-Z]+$")) && !(txtCShortName.Text == ""))
            {
                MessageBox.Show("Enter only UPPERCASE alphabetical characters");
            }
        }

        private void txtCourseYear_TextChanged(object sender, EventArgs e)
        {
            
            DateTime date = DateTime.Today;
            int thisyear = date.Year;

            if (!(System.Text.RegularExpressions.Regex.IsMatch(txtCourseYear.Text, "^[0-9]+$")) && !(txtCourseYear.Text == "")) // code for 2021 < 2023 *
            {
                MessageBox.Show("Enter only numeric values and" + "\n" + "The year entered cannot be a previous year");

            }
            //int Y = Convert.ToInt32(this.txtCourseYear.Text.Trim());
            //if (Y == thisyear)
            //{
            //        MessageBox.Show("Enter only numeric values and" + "\n" + "The year entered cannot be a previous year");
            //}
        }

        private void txtCourseFee_TextChanged(object sender, EventArgs e)
        {
            if (!(System.Text.RegularExpressions.Regex.IsMatch(txtCourseFee.Text, "^[0-9]+$")) && !(txtCourseFee.Text == ""))
            {
                MessageBox.Show("Enter only numeric values");
            }
        }

        private void txtCourseBatchN_TextChanged(object sender, EventArgs e)
        {
            if (!(System.Text.RegularExpressions.Regex.IsMatch(txtCourseBatchN.Text, "^[0-9]+$")) && !(txtCourseBatchN.Text == ""))
            {
                MessageBox.Show("Enter only numeric values");
            }
        }

        private void txtCourseDurat_TextChanged(object sender, EventArgs e)
        {
            if (!(System.Text.RegularExpressions.Regex.IsMatch(txtCourseDurat.Text, "^[0-9]+$")) && !(txtCourseDurat.Text == ""))
            {
                MessageBox.Show("Enter only numeric values");
            }
        }

        private void txtCInstMax_TextChanged(object sender, EventArgs e)
        {
            if (!(System.Text.RegularExpressions.Regex.IsMatch(txtCInstMax.Text, "^[0-9]+$")) && !(txtCInstMax.Text == ""))
            {
                MessageBox.Show("Enter only numeric values");
            }
        }

        private void txtCStuMax_TextChanged(object sender, EventArgs e)
        {
            if (!(System.Text.RegularExpressions.Regex.IsMatch(txtCStuMax.Text, "^[0-9]+$")) && !(txtCStuMax.Text == ""))
            {
                MessageBox.Show("Enter only numeric values");
            }
        }

        private void btnCCodeGenerator_MouseHover(object sender, EventArgs e)
        {
            this.lblcoursecodemessage.Visible = true;
        }

        private void btnCCodeGenerator_MouseLeave(object sender, EventArgs e)
        {
            this.lblcoursecodemessage.Visible = false;
        }

        

        

        

    }
}
