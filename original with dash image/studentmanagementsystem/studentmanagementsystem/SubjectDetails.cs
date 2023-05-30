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
    public partial class SubjectDetails : Form
    {
        public SubjectDetails()
        {
            InitializeComponent();
            FillTrade();
          
        }
        DashboardNew Back = new DashboardNew();
        conlink sqlcon = new conlink();

        int record_no;
        String trade, course, subject_1, subject_2, subject_3, subject_4, subject_5, subject_6, subject_7, subject_8, subject_9, subject_10, subject_11, subject_12, subject_13, subject_14, subject_15, subject_16, subject_17, subject_18, subject_19, subject_20;

         void FillTrade()
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from tradedetails";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string tName = dr.GetString(1);
                cmbSubTName.Items.Add(tName);
            }

            conn.Close();
            conn.Dispose();
        }

        private void btnSubCreate_Click(object sender, EventArgs e)
        {
            record_no = Convert.ToInt32(this.txtSubRecNo.Text.Trim());
            if (cmbSubTName.Text == "" || cmbSubCName.Text == "" || txtSubS1.Text == "")
            {
                MessageBox.Show("The Data is Empty. Data is required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                trade = this.cmbSubTName.SelectedItem.ToString();
                course = this.cmbSubCName.SelectedItem.ToString();

                subject_1 = this.txtSubS1.Text.Trim();
                subject_2 = this.txtSubS2.Text.Trim();
                subject_3 = this.txtSubS3.Text.Trim();
                subject_4 = this.txtSubS4.Text.Trim();
                subject_5 = this.txtSubS5.Text.Trim();
                subject_6 = this.txtSubS6.Text.Trim();
                subject_7 = this.txtSubS7.Text.Trim();
                subject_8 = this.txtSubS8.Text.Trim();
                subject_9 = this.txtSubS9.Text.Trim();
                subject_10 = this.txtSubS10.Text.Trim();

                MessageBox.Show("Successfully Created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sms smsclz = new sms();
                smsclz.AddSubjectDetailsData(record_no, trade, course, subject_1, subject_2, subject_3, subject_4, subject_5, subject_6, subject_7, subject_8, subject_9, subject_10);

                Clear();
            }
        }

        private void SubjectDetails_Load(object sender, EventArgs e)
        {
            sms smsclz = new sms();
            this.txtSubRecNo.Text = Convert.ToString(smsclz.SubjectGetNextNo());

            this.txtSubS2.Enabled = false;
            this.txtSubS3.Enabled = false;
            this.txtSubS4.Enabled = false;
            this.txtSubS5.Enabled = false;
            this.txtSubS6.Enabled = false;
            this.txtSubS7.Enabled = false;
            this.txtSubS8.Enabled = false;
            this.txtSubS9.Enabled = false;
            this.txtSubS10.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Back.Show();
        }

        private void btnSubUpdate_Click(object sender, EventArgs e)
        {
            if (cmbSubTName.Text == "" || cmbSubCName.Text == "")
            {
                MessageBox.Show("The Data is Empty. Data is required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.cmbSubTName.Enabled = true;
                this.cmbSubCName.Enabled = true;

                this.txtSubS2.Enabled = true;
                this.txtSubS3.Enabled = true;
                this.txtSubS4.Enabled = true;
                this.txtSubS5.Enabled = true;
                this.txtSubS6.Enabled = true;
                this.txtSubS7.Enabled = true;
                this.txtSubS8.Enabled = true;
                this.txtSubS9.Enabled = true;
                this.txtSubS10.Enabled = true;

                string cName = this.cmbSubCName.SelectedItem.ToString();
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd2 = new SqlCeCommand();
                String msql2 = " select * from subjectdetails where(course = '" + cName + "')";
                cmd2.CommandText = msql2;
                cmd2.Connection = conn;
                conn.Open();
                SqlCeDataReader dr1 = cmd2.ExecuteReader();
                while (dr1.Read())
                {
                    txtSubRecNo.Text = dr1[0].ToString();

                    this.txtSubS1.Text = dr1[3].ToString();
                    this.txtSubS1.Text = dr1[3].ToString();
                    this.txtSubS2.Text = dr1[4].ToString();
                    this.txtSubS3.Text = dr1[5].ToString();
                    this.txtSubS4.Text = dr1[6].ToString();
                    this.txtSubS5.Text = dr1[7].ToString();
                    this.txtSubS6.Text = dr1[8].ToString();
                    this.txtSubS7.Text = dr1[9].ToString();
                    this.txtSubS8.Text = dr1[10].ToString();
                    this.txtSubS9.Text = dr1[11].ToString();
                    this.txtSubS10.Text = dr1[12].ToString();

                }
                conn.Close();
                conn.Dispose();

                this.btnSubSave.Visible = true;
                this.txtSubRecNo.Visible = true;
                this.btnSubCreate.Visible = false;
            }
        }

        private void btnSubSave_Click(object sender, EventArgs e)
        {
            try
            {
                int record_no = Convert.ToInt32(this.txtSubRecNo.Text.Trim());

                string trade = cmbSubTName.SelectedItem.ToString();
                string course = cmbSubCName.SelectedItem.ToString();
                string subject_1 = txtSubS1.Text.Trim();
                string subject_2 = txtSubS2.Text.Trim();
                string subject_3 = txtSubS3.Text.Trim();
                string subject_4 = txtSubS4.Text.Trim();
                string subject_5 = txtSubS5.Text.Trim();
                string subject_6 = txtSubS6.Text.Trim();
                string subject_7 = txtSubS7.Text.Trim();
                string subject_8 = txtSubS8.Text.Trim();
                string subject_9 = txtSubS9.Text.Trim();
                string subject_10 = txtSubS10.Text.Trim();

                sms smsclz = new sms();
                smsclz.UpdateSubjectData(record_no, trade, course, subject_1, subject_2, subject_3, subject_4, subject_5, subject_6, subject_7, subject_8, subject_9, subject_10);

                MessageBox.Show("Successfully Updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Not Updated.", "Warning/Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSubReset_Click(object sender, EventArgs e)
        {
            btnSubCreate.Visible = true;
            btnSubSave.Visible = false;
            btnSubUpdate.Enabled = true;
            Clear();
        }

        private void Clear()
        {
           
            //this.cmbSubTName.Text = "";
            //this.cmbSubTName.Text = ""; 
            
            this.txtSubS1.Text = "";
            this.txtSubS2.Text = "";
            this.txtSubS3.Text = "";
            this.txtSubS4.Text = "";
            this.txtSubS5.Text = "";
            this.txtSubS6.Text = "";
            this.txtSubS7.Text = "";
            this.txtSubS8.Text = "";
            this.txtSubS9.Text = "";
            this.txtSubS10.Text = "";

            sms smsclz = new sms();
            this.txtSubRecNo.Text = Convert.ToString(smsclz.SubjectGetNextNo());
        }

        private void btnSubBack_Click(object sender, EventArgs e)
        {
            this.btnSubSave.Visible = false;
            this.btnSubCreate.Visible = true;
            this.cmbSubTName.Enabled = true;
            this.cmbSubCName.Enabled = true;
            
            Clear();
        }

        private void txtSubS1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtSubS2.Enabled = true;
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only alphabetical characters");
            }
        }

        private void txtSubS2_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtSubS3.Enabled = true;
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only alphabetical characters");
            }
        }

        private void txtSubS3_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtSubS4.Enabled = true;
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only alphabetical characters");
            }
        }

        private void txtSubS4_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtSubS5.Enabled = true;
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only alphabetical characters");
            }
        }

        private void txtSubS5_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtSubS6.Enabled = true;
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only alphabetical characters");
            }
        }

        private void txtSubS6_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtSubS7.Enabled = true;
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only alphabetical characters");
            }
        }

        private void txtSubS7_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtSubS8.Enabled = true;
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only alphabetical characters");
            }
        }

        private void txtSubS8_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtSubS9.Enabled = true;
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only alphabetical characters");
            }
        }

        private void txtSubS9_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtSubS10.Enabled = true;
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only alphabetical characters");
            }
        }

        private void txtSubS10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter only alphabetical characters");
            }
        }

        private void cmbSubTName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbSubCName.Items.Clear();
            string trade = this.cmbSubTName.SelectedItem.ToString();
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msql = "select * from coursedetails where(trade = '" + trade + "')";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string cName = dr.GetString(2);
                cmbSubCName.Items.Add(cName);

            }
            conn.Close();
            conn.Dispose();
        }

        private void btnSubCreate_MouseHover_1(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            conn.Open();
            String msql = "select course from SubjectDetails";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                if (dr["course"].ToString().ToUpper() == cmbSubCName.Text.ToUpper())
                {
                    MessageBox.Show("The Data is Exists. Data is required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.cmbSubCName.Text = "";
                }
            }
        }
    }
}
