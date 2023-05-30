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
    public partial class StudentRegistration : Form
    {
        string srrecno, sryear, srtrade, srfee, srduration, srcourse, srccode, srcount, srsdate, sredate, srregno, srfname, sriname, srgender, srnic, srcontno1, srcontno2, srprmntad, srrecsdd, sremail, srgardnm, srgardadd, srgardconno1, srgardconno2, srpqnm, srpqdesc, srpqstat, srstat, srdecs, sradminfee, srtotfee, srgtype;
        DateTime srdob, srregdate;

        DashboardNew Back = new DashboardNew();
        conlink sqlcon = new conlink();

        public StudentRegistration()
        {
            InitializeComponent();
            Fillcoursedetails();
            FilladmitionFee();
            txtsrcno1.MaxLength = 10;
            txtsrcno2.MaxLength = 10;
            txtsrgcno1.MaxLength = 10;
            txtsrgcno2.MaxLength = 10;
        }

       public void FilladmitionFee()
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from AdmissionFeeDetails";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string sradminfee = dr.GetString(2);

                txtsradfee.Text = sradminfee;

            }

            conn.Close();
            conn.Dispose();
        }

        void Fillcoursedetails()
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from coursedetails";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string trade = dr.GetString(1);
                cmbsrtrade.Items.Add(trade);

                string cname = dr.GetString(2);
                cmbsrcourse.Items.Add(cname);

                string pqname = dr.GetString(15);
                cmbsrpqname.Items.Add(pqname);

            }

            conn.Close();
            conn.Dispose();
        }



        private void srbtnnext_Click(object sender, EventArgs e)
        {
            pnlsrnext.Visible = true;

        }



        private void btnsrsubmit_Click(object sender, EventArgs e)
        {
        try{
            srrecno = txtsrrcno.Text.Trim();
            sryear = txtsryear.Text.Trim();
            srtrade = cmbsrtrade.Text.Trim();
            srfee = txtsrfee.Text.Trim();
            srduration = txtsrduration.Text.Trim();
            srcourse = cmbsrcourse.Text.Trim();
            srccode = txtsrccode.Text.Trim();
            srcount = txtsrcount.Text.Trim();
            srsdate = txtsrsdate.Text.Trim();
            sredate = txtsredate.Text.Trim();
            srregno = txtsrrno.Text.Trim();
            srfname = txtsrfname.Text.Trim();
            sriname = txtsriname.Text.Trim();
            srgender = cmbsrtype.Text.Trim();
            srdob = Convert.ToDateTime(dtpsrbdate.Value);
            srnic = txtsrnic1.Text.Trim();
            srnic += txtsrnic2.Text.Trim();
            srcontno1 = txtsrgcno1.Text.Trim();
            srcontno2 = txtsrgcno2.Text.Trim();
            srprmntad = txtsraprmnt.Text.Trim();
            srrecsdd = txtsrarcdnt.Text.Trim();
            sremail = txtsraemail.Text.Trim();
            srgardnm = txtsrgname.Text.Trim();
            srgardadd = txtsrgaddrs.Text.Trim();
            srgardconno1 = txtsrgcno1.Text.Trim();
            srgardconno2 = txtsrgcno2.Text.Trim();
            srpqnm = cmbsrpqname.Text.Trim();
            srpqdesc = txtsrpqdesc.Text.Trim();
            srpqstat = cmbsrpqstatus.Text.Trim();
            srregdate = Convert.ToDateTime(dtpsrrdate.Value);
            srstat = cmbsrstatus.Text.Trim();
            srdecs = txtsrdscrptn.Text.Trim();
            sradminfee = txtsradfee.Text.Trim();
            srtotfee = txtsrtotfee.Text.Trim();

            sms smsclz = new sms();
            smsclz.sturegaddData(srrecno, sryear, srtrade, srfee, srduration, srcourse, srccode, srcount, srsdate, sredate, srregno, srfname, sriname, srgender, srdob, srnic, srcontno1, srcontno2, srprmntad, srrecsdd, sremail, srgardnm, srgardadd, srgardconno1, srgardconno2, srpqnm, srpqdesc, srpqstat, srregdate, srstat, srdecs, sradminfee, srtotfee, srgtype);
            MessageBox.Show("Successfully Submit!", "Message");
            clear();
        }
            

            catch (Exception)
            {
                MessageBox.Show("Unknown Error!", "Message");
            }
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            sms smsclz = new sms();
            this.txtsrrcno.Text = Convert.ToString(smsclz.sturegGetNextNo());
            this.btnsrupdate.Enabled = false;
            this.btnsrdelect.Enabled = false;
            this.txtsrnic1.Enabled = false;
            this.btnsgsearch.Enabled = false;
            this.txtsrgname.Enabled = false;
            this.txtsrgaddrs.Enabled = false;
            this.txtsrgcno1.Enabled = false;
            this.txtsrgcno2.Enabled = false;
            this.txtsrrno.Enabled = false;

        
        }

        private void btnsgsearch_Click(object sender, EventArgs e)
        {
            this.btnsrupdate.Enabled = true;
            this.btnsrdelect.Enabled = true;
            this.txtsrgender.Visible = true;
            string srch = this.txtsrnicsrch.Text;
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = " select * from studentRegistration where(nicNo = '" + srch + "')";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                this.txtsrrcno.Text = dr[0].ToString();
                this.txtsryear.Text = dr[1].ToString();
                this.cmbsrtrade.Text = dr[2].ToString();
                this.txtsrfee.Text = dr[3].ToString();
                this.txtsrduration.Text = dr[4].ToString();
                this.cmbsrcourse.Text = dr[5].ToString();
                this.txtsrccode.Text = dr[6].ToString();
                this.txtsrcount.Text = dr[7].ToString();
                this.txtsrsdate.Text = dr[8].ToString();
                this.txtsredate.Text = dr[9].ToString();
                this.txtsrrno.Text = dr[10].ToString();
                this.txtsrfname.Text = dr[11].ToString();
                this.txtsriname.Text = dr[12].ToString();
                this.txtsrgender.Text = dr[13].ToString();
                this.dtpsrbdate.Value = Convert.ToDateTime(dr[14].ToString());
                this.txtsrcno1.Text = dr[16].ToString();
                this.txtsrcno2.Text = dr[17].ToString();
                this.txtsraprmnt.Text = dr[18].ToString();
                this.txtsrarcdnt.Text = dr[19].ToString();
                this.txtsraemail.Text = dr[20].ToString();
                this.txtsrgname.Text = dr[21].ToString();
                this.txtsrgaddrs.Text = dr[22].ToString();
                this.txtsrgcno1.Text = dr[23].ToString();
                this.txtsrgcno2.Text = dr[24].ToString();
                this.cmbsrpqname.Text = dr[25].ToString();
                this.txtsrpqdesc.Text = dr[26].ToString();
                this.cmbsrpqstatus.Text = dr[27].ToString();
                this.dtpsrrdate.Value = Convert.ToDateTime(dr[28].ToString());
                this.cmbsrstatus.Text = dr[29].ToString();
                this.txtsrdscrptn.Text = dr[30].ToString();
                this.txtsradfee.Text = dr[31].ToString();
                this.txtsrtotfee.Text = dr[32].ToString();




            }
            conn.Close();
            conn.Dispose();
            this.cmbsrtrade.Enabled = false;
            this.btnsrsubmit.Enabled = false;
            this.txtsrrcno.Enabled = false;
            this.txtsryear.Enabled = false;
            this.txtsrfee.Enabled = false;
            this.txtsrduration.Enabled = false;
            this.cmbsrcourse.Enabled = false;
            this.txtsrccode.Enabled = false;
            this.txtsrcount.Enabled = false;
            this.txtsrsdate.Enabled = false;
            this.txtsredate.Enabled = false;
            this.txtsrrno.Enabled = false;
            this.txtsrfname.Enabled = false;
            this.txtsriname.Enabled = false;
            this.cmbsrtype.Enabled = false;
            this.dtpsrbdate.Enabled = false;
            this.txtsrnic1.Enabled = false;
            this.txtsrcno1.Enabled = false;
            this.txtsrcno2.Enabled = false;
            this.txtsraprmnt.Enabled = false;
            this.txtsrarcdnt.Enabled = false;
            this.txtsraemail.Enabled = false;
            this.txtsrgname.Enabled = false;
            this.txtsrgaddrs.Enabled = false;
            this.txtsrgcno1.Enabled = false;
            this.txtsrgcno2.Enabled = false;
            this.cmbsrpqname.Enabled = false;
            this.txtsrpqdesc.Enabled = false;
            this.cmbsrpqstatus.Enabled = false;
            this.dtpsrrdate.Enabled = false;
            this.cmbsrstatus.Enabled = false;
            this.txtsrdscrptn.Enabled = false;
            this.txtsradfee.Enabled = false;
            this.txtsrtotfee.Enabled = false;
            this.rdbtnsrfather.Enabled = false;
            this.rdbtnsrmother.Enabled = false;
            this.rdbtnsrother.Enabled = false;
        }

        private void btnsrgenerate_Click(object sender, EventArgs e)
        {
            txtsrrno.Text = txtsrccode.Text + "-" + txtsrrcno.Text;
        }

        private void rdbtnsrfather_CheckedChanged(object sender, EventArgs e)
        {
            this.txtsrgname.Enabled = true;
            this.txtsrgaddrs.Enabled = true;
            this.txtsrgcno1.Enabled = true;
            this.txtsrgcno2.Enabled = true;
            if (rdbtnsrfather.Checked == true)
            {
                srgtype = "father";

            }

        }

        private void rdbtnsrmother_CheckedChanged(object sender, EventArgs e)
        {
            this.txtsrgname.Enabled = true;
            this.txtsrgaddrs.Enabled = true;
            this.txtsrgcno1.Enabled = true;
            this.txtsrgcno2.Enabled = true;
            if (rdbtnsrmother.Checked == true)
            {
                srgtype = "mother";

            }
        }

        private void rdbtnsrother_CheckedChanged(object sender, EventArgs e)
        {
            this.txtsrgname.Enabled = true;
            this.txtsrgaddrs.Enabled = true;
            this.txtsrgcno1.Enabled = true;
            this.txtsrgcno2.Enabled = true;
            if (rdbtnsrother.Checked == true)
            {
                srgtype = "other";

            }
        }

        private void btnsrclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            this.txtsryear.Text = "";
            this.cmbsrtrade.Text = "";
            this.txtsrfee.Text = "";
            this.txtsrduration.Text = "";
            this.cmbsrcourse.SelectedIndex = -1;
            this.txtsrccode.Text = "";
            this.txtsrcount.Text = "";
            this.txtsrsdate.Text = "";
            this.txtsredate.Text = "";
            this.txtsrrno.Text = "";
            this.txtsrfname.Text = "";
            this.txtsriname.Text = "";
            this.cmbsrtype.SelectedIndex = -1;
            this.dtpsrbdate.Value = DateTime.Now;
            this.txtsrnic1.Text = "";
            this.txtsrnic2.Text = "";
            this.txtsrnicsrch.Text = "";
            this.txtsrcno1.Text = "";
            this.txtsrcno2.Text = "";
            this.txtsraprmnt.Text = "";
            this.txtsrarcdnt.Text = "";
            this.txtsraemail.Text = "";
            this.txtsrgname.Text = "";
            this.txtsrgaddrs.Text = "";
            this.txtsrgcno1.Text = "";
            this.txtsrgcno2.Text = "";
            this.cmbsrpqname.SelectedIndex = -1;
            this.txtsrpqdesc.Text = "";
            this.cmbsrpqstatus.SelectedIndex = -1;
            this.dtpsrrdate.Value = DateTime.Now;
            this.cmbsrstatus.SelectedIndex = -1;
            this.txtsrdscrptn.Text = "";
            this.txtsradfee.Text = "";
            this.txtsrtotfee.Text = "";
            this.rdbtnsrfather.Checked = false;
            this.rdbtnsrmother.Checked = false;
            this.rdbtnsrother.Checked = false;
        }

        private void btnsrfback_Click(object sender, EventArgs e)
        {
            pnlsrnext.Hide();
        }

        private void srbtnback_Click(object sender, EventArgs e)
        {
            DashboardNew dshbn = new DashboardNew();
            this.Close();
            dshbn.Show();

        }

        private void cmbsrtrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from coursedetails";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string sryear = dr.GetString(5);

                txtsryear.Text = sryear;

            }

            conn.Close();
            conn.Dispose();
        }

        private void btnsrupdate_Click(object sender, EventArgs e)
        {
            this.txtsrfname.Enabled = true;
            this.txtsriname.Enabled = true;
            this.cmbsrtype.Enabled = true;
            this.dtpsrbdate.Enabled = true;
            this.txtsrnic1.Enabled = true;
            this.txtsrcno1.Enabled = true;
            this.txtsrcno2.Enabled = true;
            this.txtsraprmnt.Enabled = true;
            this.txtsrarcdnt.Enabled = true;
            this.txtsraemail.Enabled = true;
            this.txtsrgname.Enabled = true;
            this.txtsrgaddrs.Enabled = true;
            this.txtsrgcno1.Enabled = true;
            this.txtsrgcno2.Enabled = true;
            this.cmbsrstatus.Enabled = true;
            this.txtsrdscrptn.Enabled = true;
            this.dtpsrrdate.Enabled = true;
            this.rdbtnsrfather.Enabled = true;
            this.rdbtnsrmother.Enabled = true;
            this.rdbtnsrother.Enabled = true;
            this.btnsrsave.Visible = true;
        }

        private void btnsrsave_Click(object sender, EventArgs e)
        {
            try
            {
                srrecno = txtsrrcno.Text.Trim();
                srfname = txtsrfname.Text.Trim();
                sriname = txtsriname.Text.Trim();
                srgender = cmbsrtype.Text.Trim();
                srdob = Convert.ToDateTime(dtpsrbdate.Value);
                srnic = txtsrnicsrch.Text.Trim();
                srcontno1 = txtsrgcno1.Text.Trim();
                srcontno2 = txtsrgcno2.Text.Trim();
                srprmntad = txtsraprmnt.Text.Trim();
                srrecsdd = txtsrarcdnt.Text.Trim();
                sremail = txtsraemail.Text.Trim();
                srgardnm = txtsrgname.Text.Trim();
                srgardadd = txtsrgaddrs.Text.Trim();
                srgardconno1 = txtsrgcno1.Text.Trim();
                srgardconno2 = txtsrgcno2.Text.Trim();
                srpqstat = cmbsrpqstatus.Text.Trim();
                srregdate = Convert.ToDateTime(dtpsrrdate.Value);
                srstat = cmbsrstatus.Text.Trim();
                srdecs = txtsrdscrptn.Text.Trim();
                srgtype = Convert.ToString(rdbtnsrfather.Checked);
                srgtype = Convert.ToString(rdbtnsrmother.Checked);
                srgtype = Convert.ToString(rdbtnsrother.Checked);
                srgender = cmbsrtype.Text.Trim();

                sms smsclz = new sms();
                smsclz.stupdtdata(srrecno, srfname, sriname, srgender, srdob, srnic, srcontno1, srcontno2, srprmntad, srrecsdd, sremail, srgardnm, srgardadd, srgardconno1, srgardconno2, srregdate, srstat, srdecs, srgtype);
                MessageBox.Show("successfully updated", "success");
                clear();
            }
            
             catch (Exception)
            {
                MessageBox.Show("Unknown Error!", "Message");
            }
        }

        private void btnsrdelect_Click(object sender, EventArgs e)
        {
            try{
                srrecno = txtsrrcno.Text.Trim();
                sms smsclz = new sms();
                smsclz.delectstudent(srrecno);

                MessageBox.Show("Delete !");
                clear();
            }
           
             catch (Exception)
            {
                MessageBox.Show("Unknown Error!", "Message");
            }
        }

        public void cmbsrcourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from coursedetails";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string srccode = dr.GetString(10);
                string srfee = dr.GetString(11);
                int srffee = int.Parse(srfee);
                string srsdate = Convert.ToString(dr[8]);
                string sredate = Convert.ToString(dr[9]);
                string srduration = dr.GetString(7);
                string srstucount = dr.GetString(18);

                txtsrccode.Text = srccode;
                txtsrsdate.Text = srsdate;
                txtsredate.Text = sredate;
                txtsrfee.Text= srfee;
                txtsrduration.Text = srduration;
                txtsrcount.Text = srstucount;

                

            }

            conn.Close();
            conn.Dispose();
        }

        private void cmbsrpqname_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from coursedetails";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string srpqdscp = dr.GetString(16);
                txtsrpqdesc.Text = srpqdscp;
            }
            conn.Close();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Back.Show();
        }

        private void txtsrcno1_TextChanged(object sender, EventArgs e)
        {
     
            if (txtsrcno1.Text.Length == 10)
            {
                MessageBox.Show("only you can enter 10 digit !", "Error");
            }
        }

        private void txtsrcno1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsrcno2_TextChanged(object sender, EventArgs e)
        {
            if (txtsrcno2.Text.Length == 10)
            {
                MessageBox.Show("only you can enter 10 digit !", "Error");
            }
        }

        private void txtsrcno2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsrnic1_extChanged(object sender, EventArgs e)
        {
            txtsrnic1.MaxLength = 10;
            if (rdbtnsronic.Checked && txtsrnic1.Text.Length == 10)
            {
             
                MessageBox.Show("only you can enter 10 digits with 'v'");
            }
           
        }

        private void txtsrnic2_TextChanged(object sender, EventArgs e)
        {
            txtsrnic2.MaxLength = 12;
            if (rdbtnsrnnic.Checked && txtsrnic2.Text.Length == 12)
            {
                MessageBox.Show("only you can enter 12 digits !");
            }
        }

        private void rdbtnsrnnic_CheckedChanged(object sender, EventArgs e)
        {
            this.txtsrnic2.Visible = true;
            this.txtsrnicsrch.Visible = false;
            this.btnsgsearch.Enabled = false;
        }

        private void rdbtnsronic_CheckedChanged(object sender, EventArgs e)
        {
            this.txtsrnic1.Enabled = true;
            this.txtsrnic1.Visible = true;
            this.btnsgsearch.Enabled = false;
            this.txtsrnicsrch.Visible = false;
            this.txtsrnic2.Visible = false;
        }

        private void txtsrnic2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rdbtnsrsearch_CheckedChanged(object sender, EventArgs e)
        {
            this.txtsrnicsrch.Visible = true;
            this.txtsrnic1.Visible = false;
            this.txtsrnic2.Visible = false;
        }

        private void txtsrnicsrch_TextChanged(object sender, EventArgs e)
        {
            this.btnsgsearch.Enabled = true;
        }

        private void cmbsrtype_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtsrgcno1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsrgcno2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsrgcno1_TextChanged(object sender, EventArgs e)
        {
            if (txtsrgcno1.Text.Length == 10)
            {
                MessageBox.Show("only you can enter 10 digit !", "Error");
            }
        }

        private void txtsrgcno2_TextChanged(object sender, EventArgs e)
        {
            if (txtsrgcno2.Text.Length == 10)
            {
                MessageBox.Show("only you can enter 10 digit !", "Error");
            }
        }

        private void txtsradfee_TextChanged(object sender, EventArgs e)
        {
           /* SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from AdmissionFeeDetails";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string sradfee = dr.GetString(2);
                txtsradfee.Text = sradfee;
            }
            conn.Close();*/
        }

        private void txtsrtotfee_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int adfee, crsfee, totfee;
                adfee = int.Parse(txtsradfee.Text);
                crsfee = int.Parse(txtsrfee.Text);
                totfee = adfee + crsfee;
                txtsrtotfee.Text = Convert.ToString(totfee);
            }
            catch (Exception)
            {
                MessageBox.Show("Firstly you have to select course!", "Message");
            }
            
        }

        private void dtpsrbdate_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpsrbdate.Value > DateTime.Now.Date)
            {
                 MessageBox.Show("Please select valide date", "Date Error");
                 this.dtpsrbdate.Value = DateTime.Now.Date;
            }
        }

        private void txtsrpqdesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsrfname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsrfname.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsrfname.Focus();
            }
        }

        private void txtsriname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsriname.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsriname.Focus();
            }
        }

        private void txtsrnic1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsrnic1.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsrnic1.Focus();
            }
        }

        private void txtsrnic2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsrnic2.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsrnic2.Focus();
            }
        }

        private void txtsrcno1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsrcno1.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsrcno1.Focus();
            }
        }

        private void txtsraprmnt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsraprmnt.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsraprmnt.Focus();
            }
        }

        private void txtsrarcdnt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsrarcdnt.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsrarcdnt.Focus();
            }
        }

        private void txtsraemail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsraemail.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsraemail.Focus();
            }
        }

        private void txtsrgname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsrgname.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsrgname.Focus();
            }
        }

        private void txtsrgaddrs_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsrgaddrs.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsrgaddrs.Focus();
            }
        }

        private void txtsrgcno1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsrgcno1.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsrgcno1.Focus();
            }
        }

        private void dtpsrrdate_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpsrbdate.Value > DateTime.Now.Date)
            {
                MessageBox.Show("Please select valide date", "Date Error");
                this.dtpsrbdate.Value = DateTime.Now.Date;
            }
        }


       

    }
}