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
    public partial class staffDetails : Form
    {
        string sfrecno, sfinm, sffnm, sfgender, sfnic, sfcon1, sfcon2, peraddrs, reciaddrs, sfemil, sfepfno, sftype, sfcourse, sfinstco, sfalloct, sfdept, sfdesig, sfstatus, sfdscrp, sfolstat, sfoldscrp, sfalstat, sfaldscrp, sfothrstat, shothrdscrp ;
        DateTime sfdob, sfappodt;

        DashboardNew Back = new DashboardNew();
        conlink sqlcon = new conlink();
        public staffDetails()
        {
            InitializeComponent();
            Fillcoursedetails();
            Filldepartment();
            Filldesignation();

        }

        private void Filldesignation()
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from DesignationDetails";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string dept = dr.GetString(1);
                cmbsfdofcdesig.Items.Add(dept);
            }
        }

        private void Filldepartment()
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from DepartmentDetails";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string dept = dr.GetString(1);
                cmbsfdofdept.Items.Add(dept);
            }
        }

        private void Fillcoursedetails()
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from coursedetails";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string course = dr.GetString(3);
                cmbsfdofcourse.Items.Add(course);
            }
        }

        private void btnsdnext_Click(object sender, EventArgs e)
        {
            pnlsdnxt.Visible = true;

        }

        private void btnsdpback_Click(object sender, EventArgs e)
        {
            pnlsdnxt.Hide();
        }

        private void btnsfdsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                sfrecno = txtsfdrecno.Text.Trim();
                sfinm = txtsfdpdname.Text.Trim();
                sffnm = txtsfdpdfname.Text.Trim();
                sfgender = cmbsfdpdgender.Text.Trim();
                sfdob = Convert.ToDateTime(dtpsfdpdbdate.Text.Trim());
                sfnic = txtsfdpdnic.Text.Trim();
                sfcon1 = txtsfdpdcno1.Text.Trim();
                sfcon2 = txtsfdpdcno2.Text.Trim();
                peraddrs = txtsfdaddprmnt.Text.Trim();
                reciaddrs = txtsfdaddrecdnt.Text.Trim();
                sfemil = txtsfdaddemail.Text.Trim();
                sfepfno = txtsfdodepfno.Text.Trim();
                sftype = cmbsfdoftype.Text.Trim();
                sfcourse = cmbsfdofcourse.Text.Trim();
                sfinstco = txtsfdodintco.Text.Trim();
                sfalloct = cmbsfdofalloc.Text.Trim();
                sfdept = cmbsfdofdept.Text.Trim();
                sfdesig = cmbsfdofcdesig.Text.Trim();
                sfappodt = Convert.ToDateTime(dtpsfdofdtmapoidt.Text.Trim());
                sfstatus = cmbsfdofstatus.Text.Trim();
                sfdscrp = txtsfdofdescrp.Text.Trim();
                sfolstat = cmbsfdeqdol.Text.Trim();
                sfoldscrp = txtsfdeqdol.Text.Trim();
                sfalstat = cmbsfdeqdal.Text.Trim();
                sfaldscrp = txtsfdeqdal.Text.Trim();
                sfothrstat = cmbsfdeqdothr.Text.Trim();
                shothrdscrp = txtsfdeqdothr.Text.Trim();


                sms smsclz = new sms();
                smsclz.staffdeaddData(sfrecno, sfinm, sffnm, sfgender, sfdob, sfnic, sfcon1, sfcon2, peraddrs, reciaddrs, sfemil, sfepfno, sftype, sfcourse, sfinstco, sfalloct, sfdept, sfdesig, sfappodt, sfstatus, sfdscrp, sfolstat, sfoldscrp, sfalstat, sfaldscrp, sfothrstat, shothrdscrp);
                MessageBox.Show("Successfully Submit!", "Message");
                clear();
            }

            catch (Exception)
            {
                MessageBox.Show("Unknown Error!", "Message");
           }
        }

        private void staffDetails_Load(object sender, EventArgs e)
        {
            sms smsclz = new sms();
            this.txtsfdrecno.Text = Convert.ToString(smsclz.staffdeGetNextNo());
            
            this.btnsfddelete.Enabled = false;
            this.btnsfdedit.Enabled = false;
            this.cmbsfdofcourse.Enabled = false;
            this.cmbsfdofalloc.Enabled = false;
            this.txtsfdodintco.Enabled = false;
        }

        private void btnsfdclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            this.txtsfdpdname.Text = "";
            this.txtsfdpdfname.Text = "";
            this.cmbsfdpdgender.SelectedIndex = -1; 
            this.dtpsfdpdbdate.Value = DateTime.Now;
            this.txtsfdpdnic.Text= "";
            this.txtsfdpdcno1.Text= "";
            this.txtsfdpdcno2.Text= "";
            this.txtsfdaddprmnt.Text= "";
            this.txtsfdaddrecdnt.Text= "";
            this.txtsfdaddemail.Text= "";
            this.txtsfdodepfno.Text= "";
            this.cmbsfdoftype.SelectedIndex = -1;
            this.cmbsfdofcourse.SelectedIndex = -1;
            this.txtsfdodintco.Text= "";
            this.cmbsfdofalloc.SelectedIndex = -1;
            this.cmbsfdofdept.SelectedIndex = -1;
            this.cmbsfdofcdesig.SelectedIndex = -1;
            this.dtpsfdofdtmapoidt.Value = DateTime.Now;
            this.cmbsfdofstatus.SelectedIndex = -1;
            this.txtsfdofdescrp.Text= "";
            this.cmbsfdeqdol.SelectedIndex = -1;
            this.txtsfdeqdol.Text= "";
            this.cmbsfdeqdal.SelectedIndex = -1;
            this.txtsfdeqdal.Text= "";
            this.cmbsfdeqdothr.SelectedIndex = -1;
            this.txtsfdeqdothr.Text= "";
            this.txtsfdodepfno.Text = "";
            this.cmbsfdoftype.SelectedIndex = -1; 
            this.cmbsfdofcourse.SelectedIndex = -1;
            this.cmbsfdofalloc.SelectedIndex = -1;
            this.txtsfdodintco.Text = "";
            this.cmbsfdofdept.SelectedIndex = -1;
            this.cmbsfdofcdesig.SelectedIndex = -1;
            this.dtpsfdofdtmapoidt.Value = DateTime.Now;
            this.cmbsfdofstatus.SelectedIndex = -1;
            this.txtsfdofdescrp.Text = "";
        }

        private void btnsdsearch_Click(object sender, EventArgs e)
        {
            
            this.btnsfddelete.Enabled = true;
            this.btnsfdedit.Enabled = true;

            string srch = this.txtsfdpdnic.Text;
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = " select * from staffdetails where(nicNo = '" + srch + "')";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                
                this.txtsfdpdname.Text= dr[0].ToString();
                this.txtsfdpdfname.Text= dr[1].ToString();
                this.cmbsfdpdgender.Text = dr[2].ToString();
                this.dtpsfdpdbdate.Value = Convert.ToDateTime(dr[3].ToString());
                this.txtsfdpdnic.Text= dr[4].ToString();
                this.txtsfdpdcno1.Text= dr[5].ToString();
                this.txtsfdpdcno2.Text= dr[6].ToString();
                this.txtsfdaddprmnt.Text= dr[7].ToString();
                this.txtsfdaddrecdnt.Text= dr[8].ToString();;
                this.txtsfdaddemail.Text= dr[9].ToString();
                this.txtsfdodepfno.Text= dr[10].ToString();
                this.cmbsfdoftype.Text= dr[11].ToString();
                this.cmbsfdofcourse.Text= dr[12].ToString();
                this.txtsfdodintco.Text= dr[13].ToString();
                this.cmbsfdofalloc.Text= dr[14].ToString();
                this.cmbsfdofdept.Text= dr[15].ToString();
                this.cmbsfdofcdesig.Text= dr[16].ToString();
                this.dtpsfdofdtmapoidt.Value = Convert.ToDateTime(dr[17].ToString());
                this.cmbsfdofstatus.Text= dr[18].ToString();
                this.txtsfdofdescrp.Text= dr[19].ToString();
                this.txtsfdrecno.Text = dr[20].ToString();
                this.cmbsfdeqdol.Text= dr[21].ToString();
                this.txtsfdeqdol.Text= dr[22].ToString();
                this.cmbsfdeqdal.Text= dr[23].ToString();
                this.txtsfdeqdal.Text= dr[24].ToString();
                this.cmbsfdeqdothr.Text= dr[25].ToString();
                this.txtsfdeqdothr.Text= dr[26].ToString();
            }
            conn.Close();
            conn.Dispose();
            this.txtsfdrecno.Enabled = false;
            this.txtsfdpdname.Enabled = false;
            this.txtsfdpdfname.Enabled = false;
            this.dtpsfdpdbdate.Enabled = false;
            this.txtsfdpdnic.Enabled = false;
            this.txtsfdpdcno1.Enabled = false;
            this.txtsfdpdcno2.Enabled = false;
            this.txtsfdaddprmnt.Enabled = false;
            this.txtsfdaddrecdnt.Enabled = false;
            this.txtsfdaddemail.Enabled = false;
            this.txtsfdodepfno.Enabled = false;
            this.cmbsfdoftype.Enabled = false;
            this.cmbsfdofcourse.Enabled = false;
            this.txtsfdodintco.Enabled = false;
            this.cmbsfdofalloc.Enabled = false;
            this.cmbsfdofdept.Enabled = false;
            this.cmbsfdofcdesig.Enabled = false;
            this.dtpsfdofdtmapoidt.Enabled = false;
            this.cmbsfdofstatus.Enabled = false;
            this.txtsfdofdescrp.Enabled = false;
            this.cmbsfdeqdol.Enabled = false;
            this.txtsfdeqdol.Enabled = false;
            this.cmbsfdeqdal.Enabled = false;
            this.txtsfdeqdal.Enabled = false;
            this.cmbsfdeqdothr.Enabled = false;
            this.txtsfdeqdothr.Enabled = false;
        }

        private void btnsfdfback_Click(object sender, EventArgs e)
        {

        }

        private void btnsfdedit_Click(object sender, EventArgs e)
        {
            this.btnsfdsave.Visible = true;
        }

        private void btnsfdsave_Click(object sender, EventArgs e)
        {
            try
            {
                sfrecno = txtsfdrecno.Text.Trim();
                sfinm = txtsfdpdname.Text.Trim();
                sffnm = txtsfdpdfname.Text.Trim();
                sfgender = cmbsfdpdgender.Text.Trim();
                sfdob = Convert.ToDateTime(dtpsfdpdbdate.Text.Trim());
                sfnic = txtsfdpdnic.Text.Trim();
                sfcon1 = txtsfdpdcno1.Text.Trim();
                sfcon2 = txtsfdpdcno2.Text.Trim();
                peraddrs = txtsfdaddprmnt.Text.Trim();
                reciaddrs = txtsfdaddrecdnt.Text.Trim();
                sfemil = txtsfdaddemail.Text.Trim();
                sfolstat = cmbsfdeqdol.Text.Trim();
                sfoldscrp = txtsfdeqdol.Text.Trim();
                sfalstat = cmbsfdeqdal.Text.Trim();
                sfaldscrp = txtsfdeqdal.Text.Trim();
                sfothrstat = cmbsfdeqdothr.Text.Trim();
                shothrdscrp = txtsfdeqdothr.Text.Trim();
                sftype = cmbsfdoftype.Text.Trim();
                sfcourse = cmbsfdofcourse.Text.Trim();
                sfalloct = cmbsfdofalloc.Text.Trim();
                sfdept = cmbsfdofdept.Text.Trim();
                sfdesig = cmbsfdofcdesig.Text.Trim();
                sfstatus = cmbsfdofstatus.Text.Trim();
                sfdscrp = txtsfdofdescrp.Text.Trim();

                sms smsclz = new sms();
                smsclz.sfdupdtdata(sfrecno, sfinm, sffnm, sfgender, sfdob, sfnic, sfcon1, sfcon2, peraddrs, reciaddrs, sfemil, sfolstat, sfoldscrp, sfalstat, sfaldscrp, sfothrstat, shothrdscrp, sftype, sfcourse, sfalloct, sfdept, sfdesig, sfstatus, sfdscrp);
                MessageBox.Show("successfully updated", "success");
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Unknown Error!", "Message");
            }
        }

        private void btnsfddelete_Click(object sender, EventArgs e)
        {
            try
            {
                sfrecno = txtsfdrecno.Text.Trim();
                sms smsclz = new sms();
                smsclz.deletestaff(sfrecno);

                MessageBox.Show("Delete !");
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

        private void cmbsfdoftype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbsfdoftype.Text == "Academic")
            {
                this.cmbsfdofcourse.Enabled = true;
                this.cmbsfdofalloc.Enabled = true;
            }
            else
            {
                this.cmbsfdofcourse.Enabled = false;
                this.cmbsfdofalloc.Enabled = false;
            }
        }

        private void cmbsfdpdgender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbsfdpdgender.Text == "Mr")
            {

              this.cmbsfdpdgender.Text = "Male";
              
            }
        }

        private void dtpsfdofdtmapoidt_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpsfdofdtmapoidt.Value <= DateTime.Now.Date)
            {
                MessageBox.Show("Please select valide date", "Error");
                this.dtpsfdofdtmapoidt.Value = DateTime.Now.Date;
            }
        }

        private void dtpsfdpdbdate_ValueChanged(object sender, EventArgs e)
        {
            if (this.dtpsfdpdbdate.Value > DateTime.Now.Date)
            {
                MessageBox.Show("Please select valide date", "Error");
                this.dtpsfdpdbdate.Value = DateTime.Now.Date;
            }
        }

        private void txtsfdpdname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsfdpdname.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsfdpdname.Focus();
            }
        }

        private void txtsfdpdfname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsfdpdfname.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsfdpdfname.Focus();
            }
        }

        private void txtsfdpdnic_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsfdpdnic.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsfdpdnic.Focus();
            }
        }

        private void txtsfdpdcno1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsfdpdcno1.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsfdpdcno1.Focus();
            }
        }

        private void txtsfdaddrecdnt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsfdaddrecdnt.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsfdaddrecdnt.Focus();
            }
        }

        private void txtsfdaddemail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsfdaddemail.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsfdaddemail.Focus();
            }
        }

        private void txtsfdeqdol_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsfdeqdol.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsfdeqdol.Focus();
            }
        }

        private void txtsfdeqdal_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsfdeqdal.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsfdeqdal.Focus();
            }
        }

        private void txtsfdodepfno_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsfdodepfno.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsfdodepfno.Focus();
            }
        }

        private void txtsfdaddprmnt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsfdaddprmnt.Text))
            {
                MessageBox.Show("You can't leave this field", "Attention");
                txtsfdaddprmnt.Focus();
            }
        }

        private void txtsfdpdcno1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsfdpdcno2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }



 
    }
}
