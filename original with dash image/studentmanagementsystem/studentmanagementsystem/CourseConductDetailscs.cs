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
    public partial class CourseConductDetailscs : Form
    {
        public CourseConductDetailscs()
        {
            InitializeComponent();
        }

        DashboardNew Back = new DashboardNew();
        conlink sqlcon = new conlink();
        
        int ConductNo;
        String conductName, conductTime, conductStatus;

        

        private void btnConductAdd_Click(object sender, EventArgs e)
        {
        
            ConductNo = Convert.ToInt32(this.txtConductNo.Text.Trim());
            conductName = this.txtConductName.Text.Trim();
            conductTime = this.txtConductTime.Text.Trim();
            conductStatus = this.cmbConductStatus.SelectedItem.ToString();
            
            sms smsclz = new sms();
            
            this.txtConductNo.Text = Convert.ToString(smsclz.conductGetNextNo());
            
            smsclz.conducAddData(ConductNo, conductName, conductTime, conductStatus);

            MessageBox.Show("Successfully Added Course Conduct Days & Time", "Message");

            Clear();
        }

        private void CourseConductDetailscs_Load(object sender, EventArgs e)
        {
            sms smsclz = new sms();
            this.txtConductNo.Text = Convert.ToString(smsclz.conductGetNextNo());

            this.btnConductSave.Visible = false;
            this.btnConductSearch.Visible = false;
            this.cmbConductSearch.Visible = false;
            
        }

        public void Clear()
        {
           
            this.txtConductName.Text = "";
            this.txtConductTime.Text = "";
            this.cmbConductStatus.SelectedIndex = -1;

            sms smsclz = new sms();
            this.txtConductNo.Text = Convert.ToString(smsclz.conductGetNextNo());
        }

        private void btnCConductBack_Click(object sender, EventArgs e)
        {
            this.btnConductSave.Visible = false;
            this.btnConductAdd.Visible = true;
            this.btnConductSearch.Visible = false;
            this.cmbConductSearch.Visible = false;
            this.txtConductNo.Visible = true;
            this.txtConductName.Enabled = true;
            this.txtConductTime.Enabled = true;

            Clear();
        }

        private void btnConductClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnConductEdit_Click(object sender, EventArgs e)
        {
            this.btnConductSearch.Visible = true;
            this.btnConductSave.Visible = true;
            this.cmbConductSearch.Visible = true;
            this.btnConductAdd.Visible = false;

            FillConductNo();
        }


        void FillConductNo()
        {
            this.cmbConductSearch.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from courseconductdetails";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string conductNo = dr.GetString(0);
                cmbConductSearch.Items.Add(conductNo);
            }

            conn.Close();
            conn.Dispose();

        }

        private void btnConductSearch_Click(object sender, EventArgs e)
        {
            string conNo = this.cmbConductSearch.SelectedItem.ToString();
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = " select * from courseconductdetails where(record_no = '" + conNo + "')";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
       
                this.txtConductName.Text = dr[1].ToString();
                this.txtConductTime.Text = dr[2].ToString();
                this.cmbConductStatus.SelectedItem = dr[3].ToString();
                
            }
            conn.Close();
            conn.Dispose();

            this.txtConductName.Enabled = false;
            this.txtConductTime.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Back.Show();
        }

        private void btnConductSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Cconduct = cmbConductSearch.SelectedItem.ToString();
                string conductStatus = cmbConductStatus.SelectedItem.ToString();
                
                sms smsclz = new sms();
                smsclz.updatecourseconductData(conductStatus, Cconduct);


                MessageBox.Show("Updated Successfully", "Message");

            }
            catch
            {
                MessageBox.Show("Not Updated", "Warning/Error");
            }
        }

        
    }
}
