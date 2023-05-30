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
    public partial class TradeDetails : Form
    {
        public TradeDetails()
        {
            InitializeComponent();
        }

        DashboardNew Back = new DashboardNew();
        conlink sqlcon = new conlink();
        
        int tradeNo;
        String tradeName, tradeNote;

        private void btnTradeAdd_Click(object sender, EventArgs e)
        {
            tradeNo = Convert.ToInt32(this.txtTradeNo.Text.Trim());
            tradeName = this.txtTradeName.Text.Trim();
            tradeNote = this.txtTradeDescrip.Text.Trim();

            sms smsclz = new sms();

            this.txtTradeNo.Text = Convert.ToString(smsclz.tradetGetNextNo());

            smsclz.tradeAddData(tradeNo, tradeName, tradeNote);

            MessageBox.Show("Successfully Added Trade Details", "Message");

            Clear();
        }

        private void TradeDetails_Load(object sender, EventArgs e)
        {
            sms smsclz = new sms();
            this.txtTradeNo.Text = Convert.ToString(smsclz.tradetGetNextNo());
            this.cmbTradeSearch.Visible = false;
            this.btnTradeSave.Visible = false;
            this.btnTradeSearch.Visible = false;
        }

        public void Clear()
        {

            this.txtTradeName.Text = "";
            this.txtTradeDescrip.Text = "";
          

            sms smsclz = new sms();
            this.txtTradeNo.Text = Convert.ToString(smsclz.tradetGetNextNo());
        }

        private void btnTradeClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnTradeBack_Click(object sender, EventArgs e)
        {
            this.btnTradeAdd.Visible = true;
            this.btnTradeSave.Visible = false;
            this.btnTradeSearch.Visible = false;
            this.cmbTradeSearch.Visible = false;
            this.txtTradeName.Enabled = true;

            Clear();
        }

        private void btnTradeEdit_Click(object sender, EventArgs e)
        {
            this.cmbTradeSearch.Visible = true;
            this.btnTradeSave.Visible = true;
            this.btnTradeSearch.Visible = true;
            this.btnTradeAdd.Visible = false;

            FillTradeNo();
        }

        void FillTradeNo()
        {
            this.cmbTradeSearch.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from tradedetails";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string TNo = dr.GetString(0);
                cmbTradeSearch.Items.Add(TNo);

            }

            conn.Close();
            conn.Dispose();

        }

        private void btnTradeSearch_Click(object sender, EventArgs e)
        {
            string tNo = this.cmbTradeSearch.SelectedItem.ToString();
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = " select * from tradedetails where(record_no = '" + tNo + "')";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                this.txtTradeName.Text = dr[1].ToString();
                this.txtTradeDescrip.Text = dr[2].ToString();

            }

            this.txtTradeName.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Back.Show();
        }

        private void btnTradeSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Tradeno = cmbTradeSearch.SelectedItem.ToString();
                string tDescription = txtTradeDescrip.Text.Trim();

                sms smsclz = new sms();
                smsclz.updateTradeData(Tradeno, tDescription);


                MessageBox.Show("Updated Successfully", "Message");

            }
            catch
            {
                MessageBox.Show("Not Updated", "Warning/Error");
            }
        }

    }
}
