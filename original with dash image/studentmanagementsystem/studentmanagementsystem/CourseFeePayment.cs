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
    public partial class CourseFeePayment : Form
    {
        public CourseFeePayment()
        {
            InitializeComponent();
            FillRegNo();
        }

        DashboardNew Back = new DashboardNew();
        sms smsclz = new sms();
        conlink sqlcon = new conlink();

        string reg_no, fname, year, trade, ccode, cname, fee, duration, amount, ad_status, in1_fee, in1_status, in2_fee, in2_status, in3_fee, in3_status, bal, status, sdatestr, edatestr;
        DateTime regDate,sdate,edate,ad_date,in1_date,in2_date,in3_date;

        bool isUpdate = false;

        private void btnCFeeSave_Click(object sender, EventArgs e)
        {
            in1_status = this.cmbCFeeI1Status.SelectedItem != null ? this.cmbCFeeI1Status.SelectedItem.ToString() : "Incomplete";
            in2_status = this.cmbCFeeI2Status.SelectedItem != null ? this.cmbCFeeI2Status.SelectedItem.ToString() : "Incomplete";
            in3_status = this.cmbCFeeLStatus.SelectedItem != null ? this.cmbCFeeLStatus.SelectedItem.ToString() : "Incomplete";
            bal = this.txtCFeeBal.Text.Trim();
            status = this.cmbCFeeStatus.SelectedItem != null ? this.cmbCFeeStatus.SelectedItem.ToString() : "Incomplete";

            if (isUpdate)
            {
                smsclz.CFeeUpdateData(reg_no, in1_status,in2_status,in3_status,bal,status);

                MessageBox.Show("Successfully updated Course Fee Payment Details", "Message");
            }
            else
            {
                amount = this.txtCFeeAdFee.Text.Trim();
                ad_date = this.dtpCFeeAdDate.Value.Date;
                ad_status = this.cmbCFeeAdStatus.SelectedItem.ToString();
                in1_fee = this.txtCFeeI1Fee.Text.Trim();
                in1_date = this.dtpCFeeI1Date.Value.Date;
                in2_fee = this.txtCFeeI2Fee.Text.Trim();
                in2_date = this.dtpCFeeI2Date.Value.Date;
                in3_fee = this.txtCFeeLFee.Text.Trim();
                in3_date = this.dtpCFeeLDate.Value.Date;

                smsclz.CFeeAddData(reg_no, regDate, fname, year, trade, ccode, cname, fee, duration, sdate, edate, amount, ad_date, ad_status, in1_fee, in1_date, in1_status, in2_fee, in2_date, in2_status, in3_fee, in3_date, in3_status, bal, status);

                MessageBox.Show("Successfully Added Course Fee Payment Details", "Message");
            }
        }

        private void btnCFeeExit_Click(object sender, EventArgs e)
        {

        }

        private void btnCFeeClear_Click(object sender, EventArgs e)
        { }
          

        private void btnCFeeCal_Click(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = "SELECT TOP 1 * from AdmissionFeeDetails ORDER BY Record_No DESC";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                this.txtCFeeAdFee.Text = dr[2].ToString();
            }

            //if (!string.IsNullOrEmpty(txtCFeeCFee.Text))
            //  {
            // decimal Amount = cal(Convert.ToDecimal(txtCFeeCFee.Text));
            // txtCFeeCFee.Text = Amount.ToString("N2"); 


            // }
            // decimal amount = 0;



            //  decimal Bala =Convert.ToDecimal(txtCFeeCFee.Text) - amount;
            // txtCFeeBal.Text = Bala.ToString();//
            //

            decimal amount = Math.Round(Convert.ToDecimal(txtCFeeCFee.Text) / 3);
            txtCFeeI1Fee.Text = amount.ToString();
            txtCFeeI2Fee.Text = amount.ToString();
            txtCFeeLFee.Text = amount.ToString();

            int Ad = Convert.ToInt32(txtCFeeAdFee.Text);
            int Fee = Convert.ToInt32(txtCFeeCFee.Text);
            int bal = Ad + Fee;
            txtCFeeBal.Text = bal.ToString();



            // decimal a = Convert.ToDecimal(txtCFeeAdFee.Text);
            // decimal b = Convert.ToDecimal(txtCFeeCFee.Text);

            // decimal bal = a + b;
            // txtCFeeBal.Text = bal.ToString();

        }



        private void txtCFeeCFee_TextChanged(object sender, EventArgs e)
        {

        }

        void FillRegNo()
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from studentRegistration";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string RegNo = dr.GetString(10);
                cmbCFeeReg.Items.Add(RegNo);

            }

            conn.Close();
            conn.Dispose();

        }

        void FAdFee()
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from AdmissionFeeDetails";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string Year = dr.GetString(1);
                cmbCFeeReg.Items.Add(Year);

            }

            conn.Close();
            conn.Dispose();

        }

        private void btnCFeeSearch_Click(object sender, EventArgs e)
        {
            string RegNo = this.cmbCFeeReg.SelectedItem.ToString();
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = " select * from studentregistration where(registrationNo = '" + RegNo + "')";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();

            reg_no = RegNo;
            while (dr.Read())
            {
                regDate = dr.GetDateTime(28);
                this.txtCFeeRegDate.Text = regDate.ToString();

                year = dr[1].ToString();
                this.txtCFeeYear.Text = year;

                fname = dr[11].ToString();
                this.txtCFeeSName.Text = fname;

                ccode = dr[6].ToString();
                this.txtCFeeCCode.Text = ccode;

                duration = dr[4].ToString();
                this.txtCFeeDuration.Text = duration;

                fee = dr[3].ToString();
                this.txtCFeeCFee.Text = fee;

                cname = dr[5].ToString();
                this.txtCFeeCName.Text = cname;

                sdatestr = dr[8].ToString();
                this.txtCFeeSDate.Text = sdatestr;

                edatestr = dr[9].ToString();
                this.txtCFeeEDate.Text = edatestr;

                trade =dr[2].ToString();
                this.txtCFeeTrade.Text = trade;
            }

            FillInstallmentData(RegNo);
        }

        private void FillInstallmentData(string regNo)
        {
            string RegNo = this.cmbCFeeReg.SelectedItem.ToString();
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = " select * from CourseFeePaymentDetails where(registrationNo = '" + RegNo + "')";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();

            isUpdate = false;
            btnCFeeCal.Enabled = true;

            while (dr.Read())
            {
                this.txtCFeeAdFee.Text = dr[11].ToString();
                this.dtpCFeeAdDate.Value = dr.GetDateTime(12);
                this.cmbCFeeAdStatus.SelectedItem = dr[13].ToString();
                this.txtCFeeI1Fee.Text = dr[14].ToString();
                this.dtpCFeeI1Date.Value = dr.GetDateTime(15);
                this.txtCFeeI2Fee.Text = dr[17].ToString();
                this.dtpCFeeI2Date.Value = dr.GetDateTime(18);
                this.txtCFeeLFee.Text = dr[20].ToString();
                this.dtpCFeeLDate.Value = dr.GetDateTime(21);
                this.cmbCFeeI1Status.SelectedItem = dr[16].ToString();
                this.cmbCFeeI2Status.SelectedItem = dr[19].ToString();
                this.cmbCFeeLStatus.SelectedItem = dr[22].ToString();
                this.txtCFeeBal.Text = dr[23].ToString();
                this.cmbCFeeStatus.SelectedItem = dr[24].ToString();

                isUpdate = true;
                btnCFeeCal.Enabled = false;
            }
        }

        private Decimal cal(decimal Tp)
        {
            decimal amount = 0;

            amount = Math.Round(Tp / 3, 2);
            return amount;


        }

        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        private void btnCFeeClear_Click_1(object sender, EventArgs e)
        {
              this.cmbCFeeReg.Text = "";
            this.txtCFeeRegDate.Text = "";
            this.txtCFeeSName.Text = "";
            this.txtCFeeCCode.Text = "";
            this.txtCFeeDuration.Text = "";
            this.txtCFeeCFee.Text = "";
            this.txtCFeeCName.Text = "";
            this.txtCFeeSDate.Text = "";
            this.txtCFeeEDate.Text = "";
            this.txtCFeeAdFee.Text = "";
            this.cmbCFeeAdStatus.Items.Clear();
            this.dtpCFeeAdDate.Text = "";
            this.txtCFeeI1Fee.Text = "";
            this.cmbCFeeI1Status.Items.Clear();
            this.dtpCFeeI1Date.Text = "";
            this.txtCFeeI2Fee.Text = "";
            this.cmbCFeeI2Status.Items.Clear();
            this.txtCFeeLFee.Text = "";
            this.cmbCFeeLStatus.Items.Clear();
            this.dtpCFeeLDate.Text = "";
            this.txtCFeeBal.Text = "";
            this.cmbCFeeStatus.Items.Clear();
            this.cmbCFeeReg.Text = "";
               this.txtCFeeTrade.Text =""; 
        
        }

        private void btnCFeeExit_Click_1(object sender, EventArgs e)
        {
             this.Hide();
            Back.Show();
        }

        private void cmbCFeeAdStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            var value = ((ComboBox)sender).SelectedItem.ToString();
            if (value == "Complete" && !string.IsNullOrEmpty(this.txtCFeeBal.Text) && !string.IsNullOrEmpty(this.txtCFeeAdFee.Text))
            {
                var balace = Decimal.Parse(this.txtCFeeBal.Text);
                var fee = Decimal.Parse(this.txtCFeeAdFee.Text);

                this.txtCFeeBal.Text = Math.Round(Math.Max(0, balace - fee)).ToString();
            }
        }

        private void cmbCFeeI2Status_SelectedValueChanged(object sender, EventArgs e)
        {
            var value = ((ComboBox)sender).SelectedItem.ToString();
            if (value == "Complete" && !string.IsNullOrEmpty(this.txtCFeeBal.Text) && !string.IsNullOrEmpty(this.txtCFeeI2Fee.Text))
            {
                var balace = Decimal.Parse(this.txtCFeeBal.Text);
                var fee = Decimal.Parse(this.txtCFeeI2Fee.Text);

                this.txtCFeeBal.Text = Math.Round(Math.Max(0, balace - fee)).ToString();
            }
        }

        private void cmbCFeeI1Status_SelectedValueChanged(object sender, EventArgs e)
        {
            var value = ((ComboBox)sender).SelectedItem.ToString();
            if (value == "Complete" && !string.IsNullOrEmpty(this.txtCFeeBal.Text) && !string.IsNullOrEmpty(this.txtCFeeI1Fee.Text))
            {
                var balace = Decimal.Parse(this.txtCFeeBal.Text);
                var fee = Decimal.Parse(this.txtCFeeI1Fee.Text);

                this.txtCFeeBal.Text = Math.Round(Math.Max(0, balace - fee)).ToString();
            }
        }

        private void cmbCFeeLStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            var value = ((ComboBox)sender).SelectedItem.ToString();
            if (value == "Complete" && !string.IsNullOrEmpty(this.txtCFeeBal.Text) && !string.IsNullOrEmpty(this.txtCFeeLFee.Text))
            {
                var balace = Decimal.Parse(this.txtCFeeBal.Text);
                var fee = Decimal.Parse(this.txtCFeeLFee.Text);

                var lBalance = Math.Round(Math.Max(0, balace - fee));

                this.txtCFeeBal.Text = lBalance.ToString();

                if (lBalance == 0)
                {
                    this.cmbCFeeStatus.SelectedItem = "Complete";
                }
            }
        }
    }
}
