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
    public partial class ExamDetails : Form
    {
        string edregno, edname, ednicno, edyear, edtrade, edcourse, edsdate, ededate, edattstat, edassigstat, edexamstat, ed1tstat, ed1pstat, ed1fstat, ed2tstat, ed2pstat, ed2fstat, ed3tstat, ed3pstat, ed3fstat, edrecno;
        DateTime ed1tdate, ed1pdate, ed2tdate, ed2pdate, ed3tdate, ed3pdate;

        conlink sqlcon = new conlink();   // object for connect database link 

        public ExamDetails()
        {
            InitializeComponent();
           /* fillassignment();
            fillattends();*/
        }

       /* private void fillattends()
        {
            //for get attendents validation status
            string srch = this.txtedrno.Text;
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from AttendanceDetails where(registrationNo = '" + srch + "')";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string exdattendsstat = dr.GetString(11);


                txtedastatus.Text = exdattendsstat;
            }

            conn.Close();
            conn.Dispose();
        }*/

        /*private void fillassignment()
        {
            //for get assignment validation status
            string srch = this.txtedrno.Text;
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from assignmentandprojectallocationdetails where(registrationNo = '" + srch + "')";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string exdassistat = dr.GetString(13);


                txtedagstatus.Text = exdassistat;
            }

            conn.Close();
            conn.Dispose();
        }*/

        private void btnedsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                edregno = txtedrno.Text.Trim();         //for add data for database by interface
                edname = txtedname.Text.Trim();
                ednicno = txtednic.Text.Trim();
                edyear = txtedyear.Text.Trim();
                edtrade = txtedtrade.Text.Trim();
                edcourse = txtedcourse.Text.Trim();
                edsdate = txtedsdate.Text.Trim();
                ededate = txtededate.Text.Trim();
                edattstat = txtedastatus.Text.Trim();
                edassigstat = txtedagstatus.Text.Trim();
                edexamstat = txtexdfexmstat.Text.Trim();
                ed1tdate = Convert.ToDateTime(dtpedtheory1.Value);
                ed1tstat = cmbedtheory1.Text.Trim();
                ed1pdate = Convert.ToDateTime(dtpedprctcl1.Value);
                ed1pstat = cmbedprctcl1.Text.Trim();
                ed1fstat = cmbedfstatus1.Text.Trim();
                ed2tdate = Convert.ToDateTime(dtpedtheory2.Value);
                ed2tstat = cmbedtheory2.Text.Trim();
                ed2pdate = Convert.ToDateTime(dtpedprctcl2.Value);
                ed2pstat = cmbedprctcl2.Text.Trim();
                ed2fstat = cmbedfstatus2.Text.Trim();
                ed3tdate = Convert.ToDateTime(dtpedtheory3.Value);
                ed3tstat = cmbedtheory3.Text.Trim();
                ed3pdate = Convert.ToDateTime(dtpedprctcl3.Value);
                ed3pstat = cmbedprctcl3.Text.Trim();
                ed3fstat = cmbedfstatus3.Text.Trim();
                edrecno = txtedrecno.Text.Trim();


                sms smsclz = new sms();
                smsclz.examdeaddData(edregno, edname, ednicno, edyear, edtrade, edcourse, edsdate, ededate, edattstat, edassigstat, edexamstat, ed1tdate, ed1tstat, ed1pdate, ed1pstat, ed1fstat, ed2tdate, ed2tstat, ed2pdate, ed2pstat, ed2fstat, ed3tdate, ed3tstat, ed3pdate, ed3pstat, ed3fstat, edrecno);
                MessageBox.Show("Successfully Submit!", "Message");
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Unknown Error!", "Message");
            }
            
        }

        private void ExamDetails_Load(object sender, EventArgs e)
        {
            sms smsclz = new sms();  //the database class 
            this.txtedrecno.Text = Convert.ToString(smsclz.examdeGetNextNo()); //for get next number for record number 
            this.txtexdfexmstat.Enabled = false;
           

            this.dtpedtheory1.Enabled = false;
            this.cmbedtheory1.Enabled = false;
            this.dtpedprctcl1.Enabled = false;
            this.cmbedprctcl1.Enabled = false;
            this.cmbedfstatus1.Enabled = false;
            this.dtpedtheory2.Enabled = false;
            this.cmbedtheory2.Enabled = false;
            this.dtpedprctcl2.Enabled = false;
            this.cmbedprctcl2.Enabled = false;
            this.cmbedfstatus2.Enabled = false;
            this.dtpedtheory3.Enabled = false;
            this.cmbedtheory3.Enabled = false;
            this.dtpedprctcl3.Enabled = false;
            this.cmbedprctcl3.Enabled = false;
            this.cmbedfstatus3.Enabled = false;

            this.edrdbtnexmatt.Enabled = false;
            this.edrdbtnotherattm.Enabled = false;


           
    
        }
        private void btnedsearch_Click(object sender, EventArgs e)
        {
            //code for get data by search in database 
            string srch = this.txtednic.Text;
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = " select * from studentRegistration where(nicNo = '" + srch + "')";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                this.txtedrno.Text = dr[10].ToString();
                this.txtedname.Text = dr[11].ToString();
                this.txtednic.Text = dr[15].ToString();
                this.txtedyear.Text = dr[1].ToString();
                this.txtedtrade.Text = dr[2].ToString();
                this.txtedcourse.Text = dr[5].ToString();
                this.txtedsdate.Text = dr[8].ToString();
                this.txtededate.Text = dr[9].ToString();
                /*this.txtedastatus.Text = dr[8].ToString();
                this.txtedagstatus.Text = dr[9].ToString();
                this.txtedesatus.Text = dr[10].ToString();
                this.dtpedtheory1.Value = Convert.ToDateTime(dr[11].ToString());
                this.cmbedtheory1.Text = dr[12].ToString();
                this.dtpedprctcl1.Value = Convert.ToDateTime(dr[13].ToString());
                this.cmbedprctcl1.Text = dr[14].ToString();
                this.cmbedfstatus1.Text = dr[15].ToString();
                this.dtpedtheory2.Value = Convert.ToDateTime(dr[16].ToString());
                this.cmbedtheory2.Text = dr[17].ToString();
                this.dtpedprctcl2.Value = Convert.ToDateTime(dr[18].ToString());
                this.cmbedprctcl2.Text = dr[19].ToString();
                this.cmbedfstatus2.Text = dr[20].ToString();
                this.dtpedtheory3.Value = Convert.ToDateTime(dr[21].ToString());
                this.cmbedtheory3.Text = dr[22].ToString();
                this.dtpedprctcl3.Value = Convert.ToDateTime(dr[23].ToString());
                this.cmbedprctcl3.Text = dr[24].ToString();
                this.cmbedfstatus3.Text = dr[25].ToString();*/

            }
            conn.Close();
            conn.Dispose();

            this.txtedname.Enabled = false;
            this.txtedrno.Enabled = false;
            this.txtedyear.Enabled = false;
            this.txtedtrade.Enabled = false;
            this.txtedcourse.Enabled = false;
            this.txtedsdate.Enabled = false;
            this.txtededate.Enabled = false;
           /* this.txtedastatus.Enabled = false;
            this.txtedagstatus.Enabled = false;
            this.txtedesatus.Enabled = false;
            this.dtpedtheory1.Enabled = false;
            this.cmbedtheory1.Enabled = false;
            this.dtpedprctcl1.Enabled = false;
            this.cmbedprctcl1.Enabled = false;
            this.cmbedfstatus1.Enabled = false;
            this.dtpedtheory2.Enabled = false;
            this.cmbedtheory2.Enabled = false;
            this.dtpedprctcl2.Enabled = false;
            this.cmbedprctcl2.Enabled = false;
            this.cmbedfstatus2.Enabled = false;
            this.dtpedtheory3.Enabled = false;
            this.cmbedtheory3.Enabled = false;
            this.dtpedprctcl3.Enabled = false;
            this.cmbedprctcl3.Enabled = false;
            this.cmbedfstatus3.Enabled = false;*/
        }


        private void btnedclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            this.txtedrno.Text = "";
            this.txtedname.Text = ""; 
            this.txtednic.Text = "";
            this.txtedyear.Text = ""; 
            this.txtedtrade.Text = ""; 
            this.txtedcourse.Text = "";
            this.txtedsdate.Text = "";
            this.txtededate.Text = "";
            this.txtedastatus.Text = "";
            this.txtedagstatus.Text = "";
            this.txtexdfexmstat.Text = "";
            this.dtpedtheory1.Value = DateTime.Now;
            this.cmbedtheory1.SelectedIndex = -1;
            this.dtpedprctcl1.Value = DateTime.Now;
            this.cmbedprctcl1.SelectedIndex = -1;
            this.cmbedfstatus1.SelectedIndex = -1;
            this.dtpedtheory2.Value = DateTime.Now;
            this.cmbedtheory2.SelectedIndex = -1;
            this.dtpedprctcl2.Value = DateTime.Now;
            this.cmbedprctcl2.SelectedIndex = -1;
            this.cmbedfstatus2.SelectedIndex = -1;
            this.dtpedtheory3.Value = DateTime.Now;
            this.cmbedtheory3.SelectedIndex = -1;
            this.dtpedprctcl3.Value = DateTime.Now;
            this.cmbedprctcl3.SelectedIndex = -1;
            this.cmbedfstatus3.SelectedIndex = -1;
        }

        private void btnexdcheck_Click(object sender, EventArgs e)
        {
            //check the studen's past exam results
            this.btnexdsave.Visible = true;

            string srch = this.txtedrno.Text;
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = " select * from examdetails where(registrationNo = '" + srch + "')";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {

                this.txtedrecno.Text = dr[26].ToString();
                this.txtedastatus.Text = dr[8].ToString();
                this.txtedagstatus.Text = dr[9].ToString();
                this.txtexdfexmstat.Text = dr[10].ToString();
                this.dtpedtheory1.Value = Convert.ToDateTime(dr[11].ToString());
                this.cmbedtheory1.Text = dr[12].ToString();
                this.dtpedprctcl1.Value = Convert.ToDateTime(dr[13].ToString());
                this.cmbedprctcl1.Text = dr[14].ToString();
                this.cmbedfstatus1.Text = dr[15].ToString();
                this.dtpedtheory2.Value = Convert.ToDateTime(dr[16].ToString());
                this.cmbedtheory2.Text = dr[17].ToString();
                this.dtpedprctcl2.Value = Convert.ToDateTime(dr[18].ToString());
                this.cmbedprctcl2.Text = dr[19].ToString();
                this.cmbedfstatus2.Text = dr[20].ToString();
                this.dtpedtheory3.Value = Convert.ToDateTime(dr[21].ToString());
                this.cmbedtheory3.Text = dr[22].ToString();
                this.dtpedprctcl3.Value = Convert.ToDateTime(dr[23].ToString());
                this.cmbedprctcl3.Text = dr[24].ToString();
                this.cmbedfstatus3.Text = dr[25].ToString();

            }
            conn.Close();
            conn.Dispose();

           
            /*this.txtedastatus.Enabled = false;
            this.txtedagstatus.Enabled = false;
            this.txtedesatus.Enabled = false;
            this.dtpedtheory1.Enabled = false;
            this.cmbedtheory1.Enabled = false;
            this.dtpedprctcl1.Enabled = false;
            this.cmbedprctcl1.Enabled = false;
            this.cmbedfstatus1.Enabled = false;
            this.dtpedtheory2.Enabled = false;
            this.cmbedtheory2.Enabled = false;
            this.dtpedprctcl2.Enabled = false;
            this.cmbedprctcl2.Enabled = false;
            this.cmbedfstatus2.Enabled = false;
            this.dtpedtheory3.Enabled = false;
            this.cmbedtheory3.Enabled = false;
            this.dtpedprctcl3.Enabled = false;
            this.cmbedprctcl3.Enabled = false;
            this.cmbedfstatus3.Enabled = false;*/

            if (cmbedfstatus1.Text == "Incomplete")
            {
                this.dtpedtheory2.Enabled = true;
                this.cmbedtheory2.Enabled = true;
                this.dtpedprctcl2.Enabled = true;
                this.cmbedprctcl2.Enabled = true;
                this.cmbedfstatus2.Enabled = true;
            }

            if (cmbedfstatus2.Text == "Incomplete")
            {
                this.dtpedtheory2.Enabled = false;
                this.cmbedtheory2.Enabled = false;
                this.dtpedprctcl2.Enabled = false;
                this.cmbedprctcl2.Enabled = false;
                this.cmbedfstatus2.Enabled = false;
                this.dtpedtheory3.Enabled = true;
                this.cmbedtheory3.Enabled = true;
                this.dtpedprctcl3.Enabled = true;
                this.cmbedprctcl3.Enabled = true;
                this.cmbedfstatus3.Enabled = true;
            }
            
        }

        private void btnexdsave_Click(object sender, EventArgs e)
        {
            try
            {
                //this function for 2nd and 3rd time exame attempt. 2nd and 3rd time code like update function 
            edrecno = txtedrecno.Text.Trim();
            ed2tdate = Convert.ToDateTime(dtpedtheory2.Value);
            ed2tstat = cmbedtheory2.Text.Trim();
            ed2pdate = Convert.ToDateTime(dtpedprctcl2.Value);
            ed2pstat = cmbedprctcl2.Text.Trim();
            ed2fstat = cmbedfstatus2.Text.Trim();
            ed3tdate = Convert.ToDateTime(dtpedtheory3.Value);
            ed3tstat = cmbedtheory3.Text.Trim();
            ed3pdate = Convert.ToDateTime(dtpedprctcl3.Value);
            ed3pstat = cmbedprctcl3.Text.Trim();
            ed3fstat = cmbedfstatus3.Text.Trim();
            edexamstat = txtexdfexmstat.Text.Trim();

            sms smsclz = new sms();
            smsclz.exmupdtdata(edrecno, ed2tdate, ed2tstat, ed2pdate, ed2pstat, ed2fstat, ed3tdate, ed3tstat, ed3pdate, ed3pstat, ed3fstat, edexamstat);
            MessageBox.Show("successfully updated", "success");
            clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Unknown Error!", "Message");
            }
            
        }

        private void cmbedfstatus1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for get exam final result 
            if (cmbedfstatus1.Text == "Complete")
            {

                txtexdfexmstat.Text = "Successfully Complete";
               

            }
            else
            {
                txtexdfexmstat.Text = " Incomplete";
            }
        }

        private void cmbedfstatus2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for get exam final result
            if (cmbedfstatus2.Text == "Complete")
            {
                
                txtexdfexmstat.Text = "Successfully Complete";
               

            }
            else
            {
                txtexdfexmstat.Text = " Incomplete";
                
            }
        }

        private void cmbedfstatus3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for get exam final result
            if (cmbedfstatus3.Text == "Complete")
            {
                
                txtexdfexmstat.Text = "Successfully Complete";
    

            }
            else
            {
                txtexdfexmstat.Text = " Incomplete";
            }
        }

        private void txtedagstatus_TextChanged(object sender, EventArgs e)
        {
            if ((txtedastatus.Text == "Complete") && (txtedagstatus.Text == "Complete"))
            {
                this.edrdbtnexmatt.Enabled = true;
                this.edrdbtnotherattm.Enabled = true;
            }
        }

        private void txtedastatus_TextChanged(object sender, EventArgs e)
        {
            if ((txtedastatus.Text == "Complete") && (txtedagstatus.Text == "Complete"))
            {
                this.edrdbtnexmatt.Enabled = true;
                this.edrdbtnotherattm.Enabled = true;
            }
        }

        private void edrdbtnexmatt_CheckedChanged(object sender, EventArgs e)
        {
            
            this.dtpedtheory1.Enabled = true;
            this.cmbedtheory1.Enabled = true;
            this.dtpedprctcl1.Enabled = true;
            this.cmbedprctcl1.Enabled = true;
            this.cmbedfstatus1.Enabled = true;

            this.btnexdsave.Visible = false;
            this.edrdbtnotherattm.Enabled = false;
            this.btnexdcheck.Enabled = false;
        }

        private void txtedastatus_MouseClick(object sender, MouseEventArgs e)
        {

            string srch = this.txtedrno.Text;
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from AttendanceDetails where(registrationNo = '" + srch + "')";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string exdattendsstat = dr.GetString(11);


                txtedastatus.Text = exdattendsstat;
            }

            conn.Close();
            conn.Dispose();

            if (txtedastatus.Text != "Complete")
            {
                MessageBox.Show("Attendence exam requirement not completed!", "Message");
                this.txtedastatus.Enabled = false;
                txtedastatus.BackColor = Color.Red;
            }
            else
            {
                this.txtedastatus.Enabled = false;
                txtedastatus.BackColor = Color.White;

            }
            
        }

        private void txtedagstatus_MouseClick(object sender, MouseEventArgs e)
        {
              string srch = this.txtedrno.Text;
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from assignmentandprojectallocationdetails where(registrationNo = '" + srch + "')";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string exdassistat = dr.GetString(75);


                txtedagstatus.Text = exdassistat;
            }

            conn.Close();
            conn.Dispose();
            if (txtedagstatus.Text != "Complete")
            {
                MessageBox.Show("Assignment exam requirement not completed!", "Message");
                this.txtedagstatus.Enabled = false;
                txtedagstatus.BackColor = Color.Red;
            }
            else
            {
                this.txtedagstatus.Enabled = false;
                txtedagstatus.BackColor = Color.White;
            }
        }

        private void edrdbtnotherattm_CheckedChanged(object sender, EventArgs e)
        {
            this.btnexdcheck.Enabled = true;


        }

        private void cmbedtheory1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        
    }
}
