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
    public partial class ExamPayment : Form
    {
        public ExamPayment()
        {
            InitializeComponent();
            FillExPay();
        }

        DashboardNew Back = new DashboardNew();
        conlink sqlcon = new conlink();

        int billno;
        String regno, fname, regdate, year, trade, cname, sdate, edate, duration, cpay, adpay, ass_status, shy1_status, shy2_fee,   shy2_pstatus, shy2_status, shy3_fee,   shy3_pstatus, exam_status;
        DateTime shy2_date, shy3_date;

             private void btnExPaySave_Click(object sender, EventArgs e)
        {
            sms smsclz = new sms();
           // this.txtExPayBillNo.Text = Convert.ToString(smsclz.ExamPayGetNextNo());

            //billno = Convert.ToInt32(this.txtExPayBillNo.Text.Trim());
            regno = this.cmbExPayReg.SelectedItem.ToString();
            regdate = this.txtExPayRegDate.Text.Trim();
            fname = this.txtExPaySName.Text.Trim();
            year = this.txtExPayYear.Text.Trim();
            trade = this.txtExPayTrade.Text.Trim();
            cname = this.txtExPayCName.Text.Trim();
            duration = this.txtExPayDuration.Text.Trim();
            sdate = this.txtExPaySDate.Text.Trim();
            edate = this.txtExPayEDate.Text.Trim();
            ass_status = this.txtExPayAsStatus.Text.Trim();
            cpay = this.txtExPayCPay.Text.Trim();
            adpay = this.txtExPayAdStatus.Text.Trim();
            shy1_status = this.txtExPay1shyStatus.Text.Trim();
            shy2_fee = this.txtExPay2Fee.Text.Trim();
            shy2_date = this.dtpExPay2Date.Value;
            shy2_pstatus = this.cmbExPay2Status.SelectedItem.ToString();
            shy2_status = this.txtExPay2shyStatus.Text.Trim();
            shy3_fee = this.txtExPayLFee.Text.Trim();
            shy3_date = this.dtpExPayLDate.Value;
            shy3_pstatus = this.cmbExPayLStatus.SelectedItem != null ? this.cmbExPayLStatus.SelectedItem.ToString() : "";
            exam_status = this.cmbExPayEStatus.SelectedItem.ToString();
          
            

            //smsclz.ExFeeAddData(regno, fname, regdate, year, trade, cname, sdate, edate, duration, cpay, adpay, ass_status, shy1_status, shy2_fee, shy2_date, shy2_pstatus, shy2_status, shy3_fee,  shy3_date,  shy3_pstatus, exam_status);

            MessageBox.Show("Successfully Added Exam Fee Payment Details", "Message");

            //Clear();

        
        }

        void FillExPay()
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from studentRegistration";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string regno = dr.GetString(10);
                cmbExPayReg.Items.Add(regno);

            }

            conn.Close();
            conn.Dispose();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Back.Show();
        }

        private void btnExPaySearch_Click(object sender, EventArgs e)
        {
            string regno = this.cmbExPayReg.SelectedItem.ToString();
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = " select * from studentRegistration where(registrationNo = '" + regno + "')";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                this.txtExPaySName.Text = dr[11].ToString();
                this.txtExPayRegDate.Text = dr[28].ToString();
                this.txtExPayYear.Text = dr[1].ToString();
                this.txtExPayTrade.Text = dr[2].ToString();
                this.txtExPayCName.Text = dr[5].ToString();
                this.txtExPaySDate.Text = dr[8].ToString();
                this.txtExPayEDate.Text = dr[9].ToString();
                this.txtExPayDuration.Text = dr[4].ToString();
               
            }

            FillAssignmentStatus(regno);

            FillPaymentStatus(regno);

            FillExamDetails(regno);
        }

        private void Toggle2NdShy(bool enabled)
        { 
            cmbExPayLStatus.Enabled = enabled;
            dtpExPayLDate.Enabled = enabled;
            txtExPayLFee.Enabled = enabled;
            txtExPay2shyStatus.Enabled = enabled;
            cmbExPay2Status.Enabled = enabled;
            dtpExPay2Date.Enabled = enabled;
            txtExPay2Fee.Enabled = enabled;
        }

        private void FillExamDetails(string regNo)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = " select * from examdetails where(registrationNo = '" + regNo + "')";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                this.txtExPay1shyStatus.Text = dr[15].ToString();
            }

            if (this.txtExPay1shyStatus.Text == "Incomplete")
            {
                Toggle2NdShy(true);
                Fill2ndShy();
            }
           
        }

        private void Fill2ndShy()
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = "select top 1 * from ExamFeeDetails order by record_no desc";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            var fee = string.Empty;
            while (dr.Read())
            {
                fee = dr[2].ToString();
            }

            txtExPay2Fee.Text = fee;
        }


        private void FillAssignmentStatus(string regNo)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = " select * from assignmentandprojectallocationdetails where(registrationNo = '" + regNo + "')";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                this.txtExPayAsStatus.Text = dr[dr.GetOrdinal("status")].ToString();
            }
        }

        private void FillPaymentStatus(string regNo)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = " select * from CourseFeePaymentDetails where(registrationNo = '" + regNo + "')";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                this.txtExPayCPay.Text = dr[24].ToString();
                this.txtExPayAdStatus.Text = dr[13].ToString();
            }
        }

        private void btnExPayClear_Click(object sender, EventArgs e)
        {
            this.cmbExPayReg.Text = "";
            this.txtExPaySName.Text = "";
            this.txtExPayRegDate.Text = "";
            this.txtExPayYear.Text = "";
            this.txtExPayTrade.Text = "";
            this.txtExPayCName.Text = "";
            this.txtExPaySDate.Text = "";
            this.txtExPayEDate.Text = "";
            this.txtExPayAsStatus.Text = "";
            this.txtExPayDuration.Text = "";
            this.txtExPayCPay.Text = "";
            this.txtExPayAdStatus.Text = "";
            this.txtExPay1shyStatus.Text = "";
            this.txtExPay2Fee.Text = "";
            this.dtpExPay2Date.Text = "";
            this.cmbExPay2Status.SelectedIndex = -1;
            this.txtExPay2shyStatus.Text = "";
            this.txtExPayLFee.Text = "";
            this.dtpExPayLDate.Text = "";
            this.cmbExPayLStatus.SelectedIndex = -1;
            this.cmbExPayEStatus.SelectedIndex = -1;



        }

        private void btnExPayExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Back.Show();
        }

        private void ExamPayment_Load(object sender, EventArgs e)
        {
            sms smsclz = new sms();
            this.txtExPayBillNo.Text = Convert.ToString(smsclz.ExamPayGetNextNo());
        }
    }
}
      