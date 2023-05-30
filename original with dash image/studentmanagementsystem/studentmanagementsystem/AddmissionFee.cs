using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentmanagementsystem
{
    public partial class AddmissionFee : Form
    {
        public AddmissionFee()
        {
            InitializeComponent();
        }
        
        DashboardNew Back = new DashboardNew();

        int RecNo;
        String year, amount, status, description;
        DateTime date;

        private void btnAdFeeSave_Click(object sender, EventArgs e)
        {
            sms smsclz = new sms();
            this.txtAdFeeRecNo.Text = Convert.ToString(smsclz.AdFeeGetNextNo());

            RecNo = Convert.ToInt32(this.txtAdFeeRecNo.Text.Trim());
            year = this.txtAdFeeYear.Text.Trim();
            amount = this.txtAdFeeAmount.Text.Trim();
            date = this.dtpAdFeeSDate.Value.Date;
            status = this.cmbAdFeeStatus.SelectedItem.ToString();
            description = this.txtAdFeeDes.Text.Trim();



            smsclz.AdFeeAddData(RecNo, year, amount, date, description, status);

            MessageBox.Show("Successfully Added Admission Details", "Message");

            Clear();
        }

        private void AdFeeDetails_Load(object sender, EventArgs e)
        {
            sms smsclz = new sms();
            this.txtAdFeeRecNo.Text = Convert.ToString(smsclz.AdFeeGetNextNo());
        }

        public void Clear()
        {
            this.txtAdFeeYear.Text = "";
            this.txtAdFeeAmount.Text = "";
            this.dtpAdFeeSDate.Text = "";
            this.cmbAdFeeStatus.Text = "";
            this.txtAdFeeDes.Text = "";

            sms smsclz = new sms();
            this.txtAdFeeRecNo.Text = Convert.ToString(smsclz.AdFeeGetNextNo());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Back.Show();
        }

       

        private void btnAdFeeClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAdFeeExit_Click(object sender, EventArgs e)
        {

        }

        private void AddmissionFee_Load(object sender, EventArgs e)
        {
            sms smsclz = new sms();
            this.txtAdFeeRecNo.Text = Convert.ToString(smsclz.AdFeeGetNextNo());
        }

        
        

        

        

        
    }
}
