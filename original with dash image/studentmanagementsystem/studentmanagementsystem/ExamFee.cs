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
    public partial class ExamFee : Form
    {
        public ExamFee()
        {
            InitializeComponent();
        }
        DashboardNew Back = new DashboardNew();

        int RecNo;
        String year, fee, status, description;
        DateTime date;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Back.Show();
        }

        private void btnExFeeSave_Click(object sender, EventArgs e)
        {
            sms smsclz = new sms();
            this.txtExFeeRecNo.Text = Convert.ToString(smsclz.ExamFeeGetNextNo());

            RecNo = Convert.ToInt32(this.txtExFeeRecNo.Text.Trim());
            year = this.txtExFeeYear.Text.Trim();
            fee = this.txtExFeeExFee.Text.Trim();
            date = this.dtpExFeeSDate.Value.Date;
            status = this.cmbExFeeStatus.SelectedItem.ToString();
            description = this.txtExFeedes.Text.Trim();



            smsclz.examfeeAddData(RecNo, year, fee, date, description, status);

            MessageBox.Show("Successfully Added Exam Details", "Message");

            Clear();
        }
       

        public void Clear()
        {
            this.txtExFeeYear.Text = "";
            this.txtExFeeExFee.Text = "";
            this.dtpExFeeSDate.Text = "";
            this.cmbExFeeStatus.Text = "";
            this.txtExFeedes.Text = "";


            sms smsclz = new sms();
            this.txtExFeeRecNo.Text = Convert.ToString(smsclz.ExamFeeGetNextNo());
        }

        private void btnExFeeClear_Click(object sender, EventArgs e)
        {

            Clear();
        }

        private void btnExFeeExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Back.Show();
        }

        private void ExamFee_Load(object sender, EventArgs e)
        {
            sms smsclz = new sms();
            this.txtExFeeRecNo.Text = Convert.ToString(smsclz.ExamFeeGetNextNo());
        }
    }
}
