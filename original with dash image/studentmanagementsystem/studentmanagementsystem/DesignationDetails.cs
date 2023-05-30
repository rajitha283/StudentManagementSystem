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
    public partial class DesignationDetails : Form
    {
        public DesignationDetails()
        {
            InitializeComponent();
        }

        DashboardNew dash = new DashboardNew();
        sms smsdb = new sms();
        conlink sqlcon = new conlink();

        String no, name, agelimit, status, description;
        DateTime from;

        


        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
            
                no = this.txtDesNo.Text.Trim();
                name = this.txtDesName.Text.Trim();
                agelimit = this.cmbDesAge.Text.Trim();
                status = this.cmbDesStatus.Text.Trim();
                from = Convert.ToDateTime(this.dtpDesFrom.Text.Trim());
                description = this.txtDesDescrip.Text.Trim();

                

                if ((txtDesName.Text == "") || (cmbDesAge.Text == ""))
                {
                    MessageBox.Show("Can not be Insert null values", "Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                else if (!(System.Text.RegularExpressions.Regex.IsMatch(txtDesName.Text, "^[a-zA-Z ]+$")) && !(txtDesName.Text == ""))
                {
                    MessageBox.Show("Enter only alphabetical characters in Designation Name", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                }

                else if (cmbDesStatus.Text == "")
                {
                    MessageBox.Show("Please select status", "Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                else
                {
                    sms smsdb = new sms();
                    smsdb.AddDesData(no, name, agelimit, status, from, description);
                    MessageBox.Show("Succesfully Added", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Clear();
                }


                
            }

            catch
            {
                MessageBox.Show("Not Added", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }


        public void Clear()
        {
            
            sms smsdb = new sms();
            this.txtDesNo.Text = Convert.ToString(smsdb.GetNextDesNo());
            this.txtDesName.Text = "";
            this.cmbDesAge.SelectedIndex = -1;
            this.cmbDesStatus.SelectedIndex = -1;
            this.dtpDesFrom.Value = System.DateTime.Now;
            this.txtDesDescrip.Text = "";
        }


        private void DesignationDetails_Load(object sender, EventArgs e)
        {
            this.cmbDesNumbers.Visible = false;
            this.btnSave.Visible = false;
            this.btnEdit.Visible = true;
            this.txtDesNo.Enabled = false;
            this.btnBack.Visible = false;
            this.btnClear.Visible = true;
            

            sms smsdb = new sms();
            this.txtDesNo.Text = Convert.ToString(smsdb.GetNextDesNo());
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            Clear();
            this.getDesNoList();

            this.txtDesNo.Visible = false;
            this.cmbDesNumbers.Visible = true;

            this.btnEdit.Visible = false;
            this.btnSave.Visible = true;

            this.btnAdd.Enabled = false;
            this.btnBack.Visible = true;
        }


        private void getDesNoList()
        {
            this.cmbDesNumbers.Items.Clear();
            int[] DesList = (int[])(smsdb.getDesList());

            for (int x = 0; x < DesList.Length; x++)
            {
                if (DesList[x] == 0)
                {
                    break;
                }
                this.cmbDesNumbers.Items.Add(DesList[x]);
            }
        }


        private void cmbDesNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.cmbDesNumbers.Enabled = true;

                string no = this.cmbDesNumbers.SelectedItem.ToString();

                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();

                String msql = "select*from DesignationDetails where (DesNo='" + no + "')";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    this.txtDesName.Text = dr[1].ToString();
                    this.cmbDesAge.Text = dr[2].ToString();
                    this.cmbDesStatus.Text = dr[3].ToString();
                    this.dtpDesFrom.Value = Convert.ToDateTime(dr[4].ToString());
                    this.txtDesDescrip.Text = dr[5].ToString();
                }
                conn.Close();
                conn.Dispose();
            }

            catch
            {

            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            this.btnSave.Enabled = true;

            try
            {
                string no1 = this.cmbDesNumbers.Text.Trim();
                string name1 = this.txtDesName.Text.Trim();
                string age1 = this.cmbDesAge.Text.Trim();
                string status1 = this.cmbDesStatus.Text.Trim();
                DateTime from1 = Convert.ToDateTime(this.dtpDesFrom.Text.Trim());
                string descrip1 = this.txtDesDescrip.Text.Trim();

                smsdb.updateDesData(no1, name1, age1, status1, from1, descrip1);

                MessageBox.Show("Successfully Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);

            }

            catch
            {
                MessageBox.Show("Not Updated", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dash.Show();
        }



        private void txtDesName_TextChanged(object sender, EventArgs e)
        {
            if (!(System.Text.RegularExpressions.Regex.IsMatch(txtDesName.Text, "^[a-zA-Z ]+$")) && !(txtDesName.Text == ""))
            {
                MessageBox.Show("Enter only alphabetical characters", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            cmbDesNumbers.Visible = false;
            txtDesNo.Visible = true;
            this.btnClear.Visible = true;
            this.btnSave.Visible = false;
            this.btnEdit.Visible = true;
            this.btnAdd.Enabled = true;
            this.btnBack.Visible = false;

            Clear();
        }

       
    }
}
