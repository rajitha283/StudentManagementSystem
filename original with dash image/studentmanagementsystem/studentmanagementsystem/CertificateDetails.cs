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
    public partial class CertificateDetails : Form
    {
        
        string cdrecno, cdregno, cdname, cdnicno, cdcourse, cdtrade, cdyear, cdsdate, cdedate, cdexmstate, cdexmdate, cdocetno, cdostatus, cddreason, cddcetino, cddstatus;
        DateTime cdoissdate, cddissdate;

        conlink sqlcon = new conlink();
        DashboardNew Back = new DashboardNew();

        public CertificateDetails()
        {
            InitializeComponent();
        }

        private void CertificateDetails_Load(object sender, EventArgs e)
        {
            sms smsclz = new sms();
            this.txtcdrecno.Text = Convert.ToString(smsclz.cetifictGetNextNo());
            this.btncdsdsearch.Enabled = false;
            this.txtcdddcetino.Enabled = false;

            this.txtsdregno.Enabled = false;
            this.txtcdsdname.Enabled = false;
            this.txtcdsdcourse.Enabled = false;
            this.txtcdsdtrade.Enabled = false;
            this.txtcdsdyear.Enabled = false;
            this.txtcdsdsdate.Enabled = false;
            this.txtcdsdedate.Enabled = false;
            this.txtcdsdestatus.Enabled = false;

            this.txtcdodcetino.Enabled = false;
            this.dtpcdodidate.Enabled = false;
            this.cmbcdodstatus.Enabled = false;

        }

        private void btncdadd_Click(object sender, EventArgs e)
        {
            try
            {
                cdrecno = txtcdrecno.Text.Trim();
                cdregno = txtsdregno.Text.Trim();
                cdname = txtcdsdname.Text.Trim();
                cdnicno = txtcdsdnicno.Text.Trim();
                cdcourse = txtcdsdcourse.Text.Trim();
                cdtrade = txtcdsdtrade.Text.Trim();
                cdyear = txtcdsdyear.Text.Trim();
                cdyear = txtcdsdyear.Text.Trim();
                cdsdate = txtcdsdsdate.Text.Trim();
                cdedate = txtcdsdedate.Text.Trim();
                cdexmstate = txtcdsdestatus.Text.Trim();
                cdocetno = txtcdodcetino.Text.Trim();
                cdoissdate = Convert.ToDateTime(this.dtpcdodidate.Value);
                cdostatus = cmbcdodstatus.Text.Trim();
                cddreason = txtcdddreason.Text.Trim();
                cddcetino = txtcdddcetino.Text.Trim();
                cddissdate = Convert.ToDateTime(this.dtmcdddidate.Value);
                cddstatus = cmbcdddstatus.Text.Trim();

                sms smsclz = new sms();
                smsclz.cetiaddData(cdrecno, cdregno, cdname, cdnicno, cdcourse, cdtrade, cdyear, cdsdate, cdedate, cdexmdate, cdocetno, cdoissdate, cdostatus, cddreason, cddcetino, cddissdate, cddstatus);
                MessageBox.Show("Successfully Add!", "Message");
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Unknown Error!", "Comman Error !");
           }
        }

        private void btncdsdsearch_Click(object sender, EventArgs e)
        {
            string srch = this.txtcdsdnicno.Text;
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = " select * from examdetails where(nicNo = '" + srch + "')";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {

                this.txtcdsdname.Text = dr[1].ToString();
                this.txtcdsdcourse.Text = dr[5].ToString();
                this.txtcdsdtrade.Text = dr[4].ToString();
                this.txtcdsdyear.Text = dr[3].ToString();
                this.txtcdsdsdate.Text = dr[6].ToString();
                this.txtcdsdedate.Text = dr[7].ToString();
                this.txtsdregno.Text = dr[0].ToString();
                this.txtcdsdestatus.Text = dr[10].ToString();

                
                /*this.txtcdsdestatus.Text = dr[8].ToString();
                this.txtcdexamdate.Text = dr[9].ToString();
                this.txtcdodcetino.Text = dr[10].ToString();
                this.dtpcdodidate.Value = Convert.ToDateTime(dr[11].ToString());
                this.cmbcdodstatus.Text = dr[12].ToString();
                this.txtcdddreason.Text = dr[13].ToString();
                this.txtcdddcetino.Text = dr[14].ToString();
                this.dtmcdddidate.Value = Convert.ToDateTime(dr[15].ToString());
                this.cmbcdddstatus.Text = dr[16].ToString();*/

            }
            conn.Close();
            conn.Dispose();

            this.txtcdsdnicno.Enabled = false;
            

            /*this.txtcdsdestatus.Enabled = false;
            this.txtcdexamdate.Enabled = false;
            this.txtcdodcetino.Enabled = false;
            this.dtpcdodidate.Enabled = false;
            this.cmbcdodstatus.Enabled = false;
            this.txtcdddreason.Enabled = false;
            this.txtcdddcetino.Enabled = false;
            this.dtmcdddidate.Enabled = false;
            this.cmbcdddstatus.Enabled = false;*/
        }

        private void btncdclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            this.txtsdregno.Text = "";
            this.txtcdsdname.Text = "";
            this.txtcdsdnicno.Text = "";
            this.txtcdsdcourse.Text = "";
            this.txtcdsdtrade.Text = "";
            this.txtcdsdyear.Text = "";
            this.txtcdsdsdate.Text = "";
            this.txtcdsdedate.Text = "";
            this.txtcdsdestatus.Text = "";
            this.txtcdodcetino.Text = "";
            this.dtpcdodidate.Value = DateTime.Now;
            this.cmbcdodstatus.SelectedIndex = -1;
            this.txtcdddreason.Text = "";
            this.txtcdddcetino.Text = "";
            this.dtmcdddidate.Value = DateTime.Now;
            this.cmbcdddstatus.SelectedIndex = -1;
        }

        private void btncdgen_Click(object sender, EventArgs e)
        {
            txtcdodcetino.Text = "ceti- " + txtsdregno.Text + txtcdrecno.Text;
        }

        private void btncdgtdup_Click(object sender, EventArgs e)
        {
            string srch = this.txtsdregno.Text;
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = " select * from certificatedetails where(registrationNo = '" + srch + "')";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                btncdgen.Enabled = false;
                btncdsave.Visible = true;
                txtcdostat.Visible = true;
                
                
                this.txtcdddcetino.Text = dr[9].ToString();
                this.txtcdrecno.Text = dr[16].ToString();
                this.txtcdodcetino.Text = dr[9].ToString();
                this.dtpcdodidate.Value = Convert.ToDateTime(dr[10].ToString());
                this.txtcdostat.Text = dr[11].ToString();
                this.txtcdddreason.Text = dr[12].ToString();
                this.dtmcdddidate.Value = Convert.ToDateTime(dr[14].ToString());
                this.txtdcdstat.Text = dr[15].ToString();
                
                
            }
            conn.Close();
            conn.Dispose();

            this.txtcdddcetino.Enabled = false;
            this.txtcdsdestatus.Enabled = false;
            this.txtcdodcetino.Enabled = false;
            this.dtpcdodidate.Enabled = false;
            this.cmbcdodstatus.Enabled = false;
            this.txtcdostat.Enabled = false;
        }

        private void btncdsave_Click(object sender, EventArgs e)
        {
            try
            {
                cdrecno = txtcdrecno.Text.Trim();
                cddreason = txtcdddreason.Text.Trim();
                cddcetino = txtcdddcetino.Text.Trim();
                cddissdate = Convert.ToDateTime(this.dtmcdddidate.Value);
                cddstatus = cmbcdddstatus.Text.Trim();

                sms smsclz = new sms();
                smsclz.cdupdtdata(cdrecno, cddreason, cddcetino, cddissdate, cddstatus);
                MessageBox.Show("successfully saved", "success");
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Unknown Error!", "Message");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Hide();
            Back.Show();
        }

        private void txtcdsdestatus_TextChanged(object sender, EventArgs e)
        {
            if (this.txtcdsdestatus.Text == "Successfully Complete")
            {
                this.dtpcdodidate.Enabled = true;
                this.cmbcdodstatus.Enabled = true;
            }
            else if (this.txtcdsdestatus.Text == "Incomplete")
            {
                MessageBox.Show("That student can't issue a certificate", "Attention");
            }
        }

        private void txtcdsdnicno_TextChanged(object sender, EventArgs e)
        {
            this.btncdsdsearch.Enabled = true;
        }

        private void txtdcdstat_TextChanged(object sender, EventArgs e)
        {
            if (cmbcdddstatus.SelectedIndex == -1)
            {
                txtdcdstat.Visible = true;
            }

            if (txtdcdstat.Text == "Issued")
            {
                this.txtcdddreason.Enabled = false;
                this.dtmcdddidate.Enabled = false;
                this.txtdcdstat.Enabled = false;
            }
        }

        private void txtcdddreason_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcdddreason_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcdddreason.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtcdddreason.Focus();
            }
        
        }

        private void dtpcdodidate_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dtpcdodidate.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                dtpcdodidate.Focus();
            }
        }

    }
}
