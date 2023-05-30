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
    public partial class DepartmentDetails : Form
    {
        public DepartmentDetails()
        {
            InitializeComponent();
        }

        DashboardNew dash = new DashboardNew();
        sms smsdb=new sms();
        conlink sqlcon = new conlink();
        
        String no, name, location, status;

        
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {

                no = this.txtDeptNo.Text.Trim();
                name = this.txtDeptName.Text.Trim();
                location = this.txtDeptLocation.Text.Trim();
                status = this.cmbDeptStatus.Text.Trim();
                
                if ((txtDeptName.Text == "") || (txtDeptLocation.Text == ""))
                {
                    MessageBox.Show("Can not be Insert null values", "Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                else if (!(System.Text.RegularExpressions.Regex.IsMatch(txtDeptName.Text, "^[a-zA-Z ]+$")) && !(txtDeptName.Text == ""))
                {
                    MessageBox.Show("Enter only alphabetical characters in Department Name", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop);
                }

                else if (cmbDeptStatus.Text == "")
                {
                    MessageBox.Show("Please select status", "Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                else
                {
                    sms smsdb = new sms();
                    smsdb.AddDepData(no, name, location, status);
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


        private void DepartmentDetails_Load(object sender, EventArgs e)
        {
           this.cmbDepNumbers.Visible = false;
           this.btnSave.Visible = false;
           this.btnEdit.Visible = true;
           this.btnClear.Visible = true;
           this.txtDeptNo.Enabled = false;
           this.cmbDepNumbers.Enabled = false;
           this.btnBack.Visible = false;

           sms smsdb = new sms();
           this.txtDeptNo.Text = Convert.ToString(smsdb.GetNextDepNo());
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            Clear();
            this.getDepNoList();

            this.txtDeptNo.Visible = false;
            this.cmbDepNumbers.Visible = true;
            this.cmbDepNumbers.Enabled = true;

            this.btnEdit.Visible = false;
            this.btnSave.Visible = true;

            this.btnAdd.Enabled = false;
            this.btnBack.Visible = true;
            
        }


        public void Clear()
        {
            sms smsdb = new sms();
            this.txtDeptNo.Text = Convert.ToString(smsdb.GetNextDepNo());
            this.txtDeptName.Text = "";
            this.txtDeptLocation.Text = "";
            this.cmbDeptStatus.SelectedIndex = -1;
            this.cmbDepNumbers.SelectedIndex = -1;
        }


        private void cmbDepNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.cmbDepNumbers.Enabled = true;
                string no = this.cmbDepNumbers.SelectedItem.ToString();

                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();

                String msql = "select*from DepartmentDetails where (DepNo='" + no + "')";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    this.txtDeptName.Text = dr[1].ToString();
                    this.txtDeptLocation.Text = dr[2].ToString();
                    this.cmbDeptStatus.Text = dr[3].ToString();
                }
                conn.Close();
                conn.Dispose();
            }

            catch
            {

            }
        }


        private void getDepNoList()
        {
            this.cmbDepNumbers.Items.Clear();
            int[] DepList = (int[])(smsdb.getDepList());

            for (int x = 0; x < DepList.Length; x++)
            {
                if (DepList[x] == 0)
                {
                    break;
                }
                this.cmbDepNumbers.Items.Add(DepList[x]);
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                string no1 = this.cmbDepNumbers.Text.Trim();
                string name1 = this.txtDeptName.Text.Trim();
                string location1 = this.txtDeptLocation.Text.Trim();
                string status1 = this.cmbDeptStatus.Text.Trim();

                smsdb.updateDepData(no1, name1, location1, status1);
                
                MessageBox.Show("Successfully Updated", "Message",MessageBoxButtons.OK,MessageBoxIcon.None);
                
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

        private void txtDeptName_TextChanged(object sender, EventArgs e)
        {
            if (!(System.Text.RegularExpressions.Regex.IsMatch(txtDeptName.Text, "^[a-zA-Z ]+$")) && !(txtDeptName.Text == ""))
            {
                MessageBox.Show("Enter only alphabetical characters","Message",MessageBoxButtons.RetryCancel,MessageBoxIcon.Stop);
            }

        }




        private void btnBack_Click(object sender, EventArgs e)
        {
            cmbDepNumbers.Visible = false;
            txtDeptNo.Visible = true;
            this.btnClear.Visible = true;
            this.btnSave.Visible = false;
            this.btnEdit.Visible = true;
            this.btnAdd.Enabled = true;
            this.btnBack.Visible = false;

            Clear();

        }

       
    }
}
