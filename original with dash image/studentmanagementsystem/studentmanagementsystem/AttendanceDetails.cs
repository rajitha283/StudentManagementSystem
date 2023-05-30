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
    public partial class AttendanceDetails : Form
    {
        public AttendanceDetails()
        {
            InitializeComponent();
            FillTrade();
        }


        DashboardNew Back = new DashboardNew();
        conlink sqlcon = new conlink();
        sms smsclz = new sms();

        string registrationNo, trade, course_code, course, fullName, AttStatus;
        double AttFinalAvg, AttMonthlyAvg,AttMonth,duration, AttWorkingDays, AttAttendedDays;
        int W1, W2, W3, W4, W5, W6, W7, W8, W9, W10, W11, W12, W13, W14, W15, W16, W17, W18, W19, W20, W21, W22, W23, W24, W25, W26, W27, W28, W29, W30, W31, A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12, A13, A14, A15, A16, A17, A18, A19, A20, A21, A22, A23, A24, A25, A26, A27, A28, A29, A30, A31, TotWorkingDays, TotAttendedDays;



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Back.Show();
        }




        public void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                registrationNo = this.cmbAtRegNo.SelectedItem.ToString();
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = " select * from studentRegistration where(registrationNo = '" + registrationNo + "')";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())

                {
                    
                        this.txtAtCourseCode.Text = dr[6].ToString();
                        this.txtAtStudentName.Text = dr[11].ToString();
                        this.txtAtCourseDurat.Text = dr[4].ToString();
                    
                }
            }

            catch
            {
                MessageBox.Show("Unable to search. Please select Trade, Course and Register No.", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

            
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.panelWorkingDays.Visible = true;
            txtTrade.Text = cmbAtTrade.Text;
            txtWDCourseCode.Text = txtAtCourseCode.Text;
            txtWDCourseName.Text = cmbAtCourseName.Text;
            txtWDDuration.Text = txtAtCourseDurat.Text;
            txtRegNo.Text = cmbAtRegNo.Text;
            txtWDMonth.Text = cmbAtMonth.Text;

           
        }




        private void AttendanceDetails_Load(object sender, EventArgs e)
        {
            this.panelWorkingDays.Visible = false;
            this.txtAtCourseCode.Enabled = false;
            this.txtAtCourseDurat.Enabled = false;
            this.txtAtStudentName.Enabled = false;
            this.txtAtFinalAvg.Visible = false;
            this.txtAtStatus.Visible = false;
            this.label5.Visible = false;
            this.label15.Visible = false;
            this.label7.Visible = false;
            this.label8.Visible = false;
            this.btnSave.Enabled = false;
            this.btnAdd.Enabled = false;
            this.txtAtWorkDays.Enabled = false;
            this.txtAtDays.Enabled = false;
            this.txtAtAvg.Enabled = false;
            this.txtAtFinalAvg.Enabled = false;
            this.txtAtStatus.Enabled = false;
           
        }




        private void btnBack_Click(object sender, EventArgs e)
        {
            this.panelWorkingDays.Visible = false;
            this.btnCount.Enabled = true;
        }




        private void panelWorkingDays_Paint(object sender, PaintEventArgs e)
        {
            this.txtWDADTotlWorking.Enabled = false;
            this.txtWDADTotAttended.Enabled = false;
            this.txtTrade.Enabled = false;
            this.txtRegNo.Enabled = false;
            this.txtWDCourseName.Enabled = false;
            this.txtWDCourseCode.Enabled = false;
            this.txtWDDuration.Enabled = false;
            this.txtWDMonth.Enabled = false;

            chbA1.Checked = false;
            chbA2.Checked = false;
            chbA3.Checked = false;
            chbA4.Checked = false;
            chbA5.Checked = false;
            chbA6.Checked = false;
            chbA7.Checked = false;
            chbA8.Checked = false;
            chbA9.Checked = false;
            chbA10.Checked = false;
            chbA11.Checked = false;
            chbA12.Checked = false;
            chbA13.Checked = false;
            chbA14.Checked = false;
            chbA15.Checked = false;
            chbA16.Checked = false;
            chbA17.Checked = false;
            chbA18.Checked = false;
            chbA19.Checked = false;
            chbA20.Checked = false;
            chbA21.Checked = false;
            chbA22.Checked = false;
            chbA23.Checked = false;
            chbA24.Checked = false;
            chbA25.Checked = false;
            chbA26.Checked = false;
            chbA27.Checked = false;
            chbA28.Checked = false;
            chbA29.Checked = false;
            chbA30.Checked = false;
            chbA31.Checked = false;

            chbW1.Checked = false;
            chbW2.Checked = false;
            chbW3.Checked = false;
            chbW4.Checked = false;
            chbW5.Checked = false;
            chbW6.Checked = false;
            chbW7.Checked = false;
            chbW8.Checked = false;
            chbW9.Checked = false;
            chbW10.Checked = false;
            chbW11.Checked = false;
            chbW12.Checked = false;
            chbW13.Checked = false;
            chbW14.Checked = false;
            chbW15.Checked = false;
            chbW16.Checked = false;
            chbW17.Checked = false;
            chbW18.Checked = false;
            chbW19.Checked = false;
            chbW20.Checked = false;
            chbW21.Checked = false;
            chbW22.Checked = false;
            chbW23.Checked = false;
            chbW24.Checked = false;
            chbW25.Checked = false;
            chbW26.Checked = false;
            chbW27.Checked = false;
            chbW28.Checked = false;
            chbW29.Checked = false;
            chbW30.Checked = false;
            chbW31.Checked = false;

            txtWDADTotAttended.Text = "";
            txtWDADTotlWorking.Text = "";

            this.chbA1.Enabled = false;
            this.chbA2.Enabled = false;
            this.chbA3.Enabled = false;
            this.chbA4.Enabled = false;
            this.chbA5.Enabled = false;
            this.chbA6.Enabled = false;
            this.chbA7.Enabled = false;
            this.chbA8.Enabled = false;
            this.chbA9.Enabled = false;
            this.chbA10.Enabled = false;
            this.chbA11.Enabled = false;
            this.chbA12.Enabled = false;
            this.chbA13.Enabled = false;
            this.chbA14.Enabled = false;
            this.chbA15.Enabled = false;
            this.chbA16.Enabled = false;
            this.chbA17.Enabled = false;
            this.chbA18.Enabled = false;
            this.chbA19.Enabled = false;
            this.chbA20.Enabled = false;
            this.chbA21.Enabled = false;
            this.chbA22.Enabled = false;
            this.chbA23.Enabled = false;
            this.chbA24.Enabled = false;
            this.chbA25.Enabled = false;
            this.chbA26.Enabled = false;
            this.chbA27.Enabled = false;
            this.chbA28.Enabled = false;
            this.chbA29.Enabled = false;
            this.chbA30.Enabled = false;
            this.chbA31.Enabled = false;


        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }



        private void btnCalculate_Click(object sender, EventArgs e)
        {

            

            if (cmbAtMonth.Text == "")
            {
                MessageBox.Show("Please select Month", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

            else
            {


                double sum = listViewPastAttendance.Items.Cast<ListViewItem>().Sum(lvi => Math.Round(double.Parse(lvi.SubItems[3].Text)));
                double rows = duration - 1;

                if ((txtAtWorkDays.Text == "") && (txtAtDays.Text == ""))
                {
                    MessageBox.Show("Can't Calculate. Please Enter Working Days and Attended Days.", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    this.btnSave.Enabled = false;
                }

                else
                {
                    txtAtAvg.Text = (Math.Round(double.Parse(txtAtDays.Text)) / Math.Round(double.Parse(txtAtWorkDays.Text)) * 100).ToString("#.##");
                    this.btnSave.Enabled = true;
                    


                    if (txtAtFinalAvg.Visible == true)
                    {
                        AttFinalAvg = (sum / rows);
                        txtAtFinalAvg.Text = AttFinalAvg.ToString("#.##");


                        if (AttFinalAvg > 80)
                        {
                            txtAtStatus.Text = "Complete";
                        }
                        else
                        {
                            txtAtStatus.Text = "Incomplete";
                        }
                    }
                }
            }
            
        }

        

        public void btnSave_Click(object sender, EventArgs e)
        {

            registrationNo = this.cmbAtRegNo.SelectedItem.ToString();
            trade = this.cmbAtTrade.SelectedItem.ToString();
            course = this.cmbAtCourseName.SelectedItem.ToString();
            course_code = this.txtAtCourseCode.Text.Trim();
            fullName = this.txtAtStudentName.Text.Trim();
            AttStatus = this.txtAtStatus.Text.Trim();
            AttMonth = Convert.ToDouble(this.cmbAtMonth.Text.Trim());
            duration = Convert.ToDouble(this.txtAtCourseDurat.Text.Trim());
            AttWorkingDays = Convert.ToDouble(this.txtAtWorkDays.Text.Trim());
            AttAttendedDays = Convert.ToDouble(this.txtAtDays.Text.Trim());
            AttMonthlyAvg = Convert.ToDouble(this.txtAtAvg.Text.Trim());

            
            this.btnSave.Enabled = false;
            smsclz.AddAtdata(trade, course_code, course, AttMonth, registrationNo, fullName, AttMonth, AttWorkingDays, AttAttendedDays, AttMonthlyAvg, AttFinalAvg, AttStatus);
            MessageBox.Show("Succesfully Saved", "Message");
            smsclz.AddWDADData(trade, course_code, course, AttMonth, registrationNo, AttMonth, W1, A1, W2, A2, W3, A3, W4, A4, W5, A5, W6, A6, W7, A7, W8, A8, W9, A9, W10, A10, W11, A11, W12, A12, W13, A13, W14, A14, W15, A15, W16, A16, W17, A17, W18, A18, W19, A19, W20, A20, W21, A21, W22, A22, W23, A23, W24, A24, W25, A25, W26, A26, W27, A27, W28, A28, W29, A29, W30, A30, W31, A31, TotWorkingDays, TotAttendedDays);

            Clear();
            
   
        }


        private void Clear()
        {
            cmbAtRegNo.SelectedIndex = -1;
            cmbAtTrade.SelectedIndex = -1;
            cmbAtCourseName.SelectedIndex = -1;
            cmbAtMonth.SelectedIndex = -1;
            txtAtCourseCode.Text = "";
            txtAtCourseDurat.Text = "";
            txtAtStudentName.Text = "";
            txtAtWorkDays.Text = "";
            txtAtDays.Text = "";
            txtAtAvg.Text = "";
            txtAtFinalAvg.Text = "";
            txtAtStatus.Text = "";
            listViewPastAttendance.Items.Clear();
            this.btnAdd.Enabled = false;

        }




         
        public void cmbAtTrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.cmbAtCourseName.Items.Clear();
                this.cmbAtRegNo.Items.Clear();
                txtAtCourseCode.Text = "";
                txtAtCourseDurat.Text = "";
                txtAtStudentName.Text = "";
                cmbAtMonth.SelectedIndex = -1;
                txtAtWorkDays.Text = "";
                txtAtDays.Text = "";
                txtAtAvg.Text = "";
                txtAtFinalAvg.Text = "";
                txtAtStatus.Text = "";
                this.listViewPastAttendance.Items.Clear();

                trade = this.cmbAtTrade.SelectedItem.ToString();
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = " select * from coursedetails where(trade =  '" + trade + "')";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();

                while (dr.Read())
                {

                    fullName = dr.GetString(2);
                    cmbAtCourseName.Items.Add(fullName);
                }
                conn.Close();
                conn.Dispose();
            }
            catch
            {

            }
        }




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
                trade = dr.GetString(1);
                cmbAtTrade.Items.Add(trade);
            }

            conn.Close();
            conn.Dispose();

        }





        public void cmbAtCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                this.cmbAtRegNo.Items.Clear();
                txtAtCourseCode.Text = "";
                txtAtCourseDurat.Text = "";
                txtAtStudentName.Text = "";
                cmbAtMonth.SelectedIndex = -1;
                txtAtWorkDays.Text = "";
                txtAtDays.Text = "";
                txtAtAvg.Text = "";
                txtAtFinalAvg.Text = "";
                txtAtStatus.Text = "";
                this.listViewPastAttendance.Items.Clear();

                fullName = this.cmbAtCourseName.SelectedItem.ToString();
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = " select * from studentRegistration where(course =  '" + fullName + "')";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();

                while (dr.Read())
                {
                    registrationNo = dr.GetString(10);
                    cmbAtRegNo.Items.Add(registrationNo);
                }
                conn.Close();
                conn.Dispose();
            }

            catch
            {

            }
        }





        private void txtAtCourseCode_TextChanged(object sender, EventArgs e)
        {
            try
            {

                registrationNo = this.cmbAtRegNo.SelectedItem.ToString();
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = "select * from AttendanceDetails where(registrationNo = '" + registrationNo + "')";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {

                    listViewPastAttendance.Items.Clear();
                    SqlCeConnection con = new SqlCeConnection(sqlcon.connlink);
                    SqlCeDataAdapter ada = new SqlCeDataAdapter(msql, con);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow drow = dt.Rows[i];
                        ListViewItem listitem = new ListViewItem(drow["AttMonth"].ToString());
                        listitem.SubItems.Add(drow["AttWorkingDays"].ToString());
                        listitem.SubItems.Add(drow["AttAttendedDays"].ToString());
                        listitem.SubItems.Add(drow["AttMonthlyAvg"].ToString());
                        listViewPastAttendance.Items.Add(listitem);
                        listViewPastAttendance.Show();
                        
                    }
                }
            }
            catch
            {

            }
        }


       
        private void btnCount_Click(object sender, EventArgs e)
        {
            trade = this.txtTrade.Text.Trim();
            course_code = this.txtAtCourseCode.Text.Trim();
            course = this.cmbAtCourseName.Text.Trim();
            duration = Convert.ToDouble(this.txtAtCourseDurat.Text.Trim());
            registrationNo = this.txtRegNo.Text.Trim();
            AttMonth = Convert.ToDouble(this.txtWDMonth.Text.Trim());


            if (this.chbW1.Checked == true)
            {
                W1 = 1;
            }
            else
            {
                W1 = 0;
            }

            if (this.chbW2.Checked == true)
            {
                W2 = 1;
            }
            else
            {
                W2 = 0;
            }

            if (this.chbW3.Checked == true)
            {
                W3 = 1;
            }
            else
            {
                W3 = 0;
            }

            if (this.chbW4.Checked == true)
            {
                W4 = 1;
            }
            else
            {
                W4 = 0;
            }

            if (this.chbW5.Checked == true)
            {
                W5 = 1;
            }
            else
            {
                W5 = 0;
            }

            if (this.chbW6.Checked == true)
            {
                W6 = 1;
            }
            else
            {
                W6 = 0;
            }

            if (this.chbW7.Checked == true)
            {
                W7 = 1;
            }
            else
            {
                W7 = 0;
            }

            if (this.chbW8.Checked == true)
            {
                W8 = 1;
            }
            else
            {
                W8 = 0;
            }

            if (this.chbW9.Checked == true)
            {
                W9 = 1;
            }
            else
            {
                W9 = 0;
            }

            if (this.chbW10.Checked == true)
            {
                W10 = 1;
            }
            else
            {
                W10 = 0;
            }

            if (this.chbW11.Checked == true)
            {
                W11 = 1;
            }
            else
            {
                W11 = 0;
            }

            if (this.chbW12.Checked == true)
            {
                W12 = 1;
            }
            else
            {
                W12 = 0;
            }

            if (this.chbW13.Checked == true)
            {
                W13 = 1;
            }
            else
            {
                W13 = 0;
            }

            if (this.chbW14.Checked == true)
            {
                W14 = 1;
            }
            else
            {
                W14 = 0;
            }

            if (this.chbW15.Checked == true)
            {
                W15 = 1;
            }
            else
            {
                W15 = 0;
            }

            if (this.chbW16.Checked == true)
            {
                W16 = 1;
            }
            else
            {
                W16 = 0;
            }

            if (this.chbW17.Checked == true)
            {
                W17 = 1;
            }
            else
            {
                W17 = 0;
            }

            if (this.chbW18.Checked == true)
            {
                W18 = 1;
            }
            else
            {
                W18 = 0;
            }

            if (this.chbW19.Checked == true)
            {
                W19 = 1;
            }
            else
            {
                W19 = 0;
            }

            if (this.chbW20.Checked == true)
            {
                W20 = 1;
            }
            else
            {
                W20 = 0;
            }

            if (this.chbW21.Checked == true)
            {
                W21 = 1;
            }
            else
            {
                W21 = 0;
            }

            if (this.chbW22.Checked == true)
            {
                W22 = 1;
            }
            else
            {
                W22 = 0;
            }

            if (this.chbW23.Checked == true)
            {
                W23 = 1;
            }
            else
            {
                W23 = 0;
            }

            if (this.chbW24.Checked == true)
            {
                W24 = 1;
            }
            else
            {
                W24 = 0;
            }

            if (this.chbW25.Checked == true)
            {
                W25 = 1;
            }
            else
            {
                W25 = 0;
            }

            if (this.chbW26.Checked == true)
            {
                W26 = 1;
            }
            else
            {
                W26 = 0;
            }

            if (this.chbW27.Checked == true)
            {
                W27 = 1;
            }
            else
            {
                W27 = 0;
            }

            if (this.chbW28.Checked == true)
            {
                W28 = 1;
            }
            else
            {
                W28 = 0;
            }

            if (this.chbW29.Checked == true)
            {
                W29 = 1;
            }
            else
            {
                W29 = 0;
            }

            if (this.chbW30.Checked == true)
            {
                W30 = 1;
            }
            else
            {
                W30 = 0;
            }

            if (this.chbW31.Checked == true)
            {
                W31 = 1;
            }
            else
            {
                W31 = 0;
            }


            if (this.chbA1.Checked == true)
            {
                A1 = 1;
            }
            else
            {
                A1 = 0;
            }

            if (this.chbA2.Checked == true)
            {
                A2 = 1;
            }
            else
            {
                A2 = 0;
            }

            if (this.chbA3.Checked == true)
            {
                A3 = 1;
            }
            else
            {
                A3 = 0;
            }

            if (this.chbA4.Checked == true)
            {

                A4 = 1;
            }
            else
            {
                A4 = 0;
            }

            if (this.chbA5.Checked == true)
            {
                A5 = 1;
            }
            else
            {
                A5 = 0;
            }

            if (this.chbA6.Checked == true)
            {
                A6 = 1;
            }
            else
            {
                A6 = 0;
            }

            if (this.chbA7.Checked == true)
            {
                A7 = 1;
            }
            else
            {
                A7 = 0;
            }

            if (this.chbA8.Checked == true)
            {
                A8 = 1;
            }
            else
            {
                A8 = 0;
            }

            if (this.chbA9.Checked == true)
            {
                A9 = 1;
            }
            else
            {
                A9 = 0;
            }

            if (this.chbA10.Checked == true)
            {
                A10 = 1;
            }
            else
            {
                A10 = 0;
            }

            if (this.chbA11.Checked == true)
            {
                A11 = 1;
            }
            else
            {
                A11 = 0;
            }

            if (this.chbA12.Checked == true)
            {
                A12 = 1;
            }
            else
            {
                A12 = 0;
            }

            if (this.chbA13.Checked == true)
            {
                A13 = 1;
            }
            else
            {
                A13 = 0;
            }

            if (this.chbA14.Checked == true)
            {
                A14 = 1;
            }
            else
            {
                A14 = 0;
            }

            if (this.chbA15.Checked == true)
            {
                A15 = 1;
            }
            else
            {
                A15 = 0;
            }

            if (this.chbA16.Checked == true)
            {
                A16 = 1;
            }
            else
            {
                A16 = 0;
            }

            if (this.chbA17.Checked == true)
            {
                A17 = 1;
            }
            else
            {
                A17 = 0;
            }

            if (this.chbA18.Checked == true)
            {
                A18 = 1;
            }
            else
            {
                A18 = 0;
            }

            if (this.chbA19.Checked == true)
            {
                A19 = 1;
            }
            else
            {
                A19 = 0;
            }

            if (this.chbA20.Checked == true)
            {
                A20 = 1;
            }
            else
            {
                A20 = 0;
            }

            if (this.chbA21.Checked == true)
            {
                A21 = 1;
            }
            else
            {
                A21 = 0;
            }

            if (this.chbA22.Checked == true)
            {
                A22 = 1;
            }
            else
            {
                A22 = 0;
            }

            if (this.chbA23.Checked == true)
            {
                A23 = 1;
            }
            else
            {
                A23 = 0;
            }

            if (this.chbA24.Checked == true)
            {
                A24 = 1;
            }
            else
            {
                A24 = 0;
            }

            if (this.chbA25.Checked == true)
            {
                A25 = 1;
            }
            else
            {
                A25 = 0;
            }

            if (this.chbA26.Checked == true)
            {
                A26 = 1;
            }
            else
            {
                A26 = 0;
            }

            if (this.chbA27.Checked == true)
            {
                A27 = 1;
            }
            else
            {
                A27 = 0;
            }

            if (this.chbA28.Checked == true)
            {
                A28 = 1;
            }
            else
            {
                A28 = 0;
            }

            if (this.chbA29.Checked == true)
            {
                A29 = 1;
            }
            else
            {
                A29 = 0;
            }

            if (this.chbA30.Checked == true)
            {
                A30 = 1;
            }
            else
            {
                A30 = 0;
            }

            if (this.chbA31.Checked == true)
            {
                A31 = 1;
            }
            else
            {
                A31 = 0;
            }


            TotWorkingDays = (W1 + W2 + W3 + W4 + W5 + W6 + W7 + W8 + W9 + W10 + W11 + W12 + W13 + W14 + W15 + W16 + W17 + W18 + W19 + W20 + W21 + W22 + W23 + W24 + W25 + W26 + W27 + W28 + W29 + W30 + W31);
            TotAttendedDays = (A1 + A2 + A3 + A4 + A5 + A6 + A7 + A8 + A9 + A10 + A11 + A12 + A13 + A14 + A15 + A16 + A17 + A18 + A19 + A20 + A21 + A22 + A23 + A24 + A25 + A26 + A27 + A28 + A29 + A30 + A31);

            txtWDADTotlWorking.Text = Convert.ToString(TotWorkingDays);
            txtWDADTotAttended.Text = Convert.ToString(TotAttendedDays);

            txtAtDays.Text = txtWDADTotAttended.Text;
            txtAtWorkDays.Text = txtWDADTotlWorking.Text;
        }




        private void cmbAtMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAtCourseDurat.Text == cmbAtMonth.Text)
                {
                    this.txtAtFinalAvg.Visible = true;
                    this.txtAtStatus.Visible = true;
                    this.label5.Visible = true;
                    this.label15.Visible = true;
                    this.label7.Visible = true;
                    this.label8.Visible = true;
                    this.btnSave.Enabled = false;
                }


                else
                {
                    this.txtAtFinalAvg.Visible = false;
                    this.txtAtStatus.Visible = false;
                    this.label5.Visible = false;
                    this.label15.Visible = false;
                    this.label7.Visible = false;
                    this.label8.Visible = false;

                }


                this.btnCount.Enabled = true;
                this.btnCalculate.Enabled = true;
                txtAtAvg.Text = "";
                txtAtFinalAvg.Text = "";
                txtAtStatus.Text = "";
                this.btnAdd.Enabled = true;
                txtAtWorkDays.Text = "";
                txtAtDays.Text = "";

                registrationNo = this.cmbAtRegNo.SelectedItem.ToString();
                AttMonth = Convert.ToInt32(this.cmbAtMonth.SelectedItem.ToString());
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = "select * from AttendanceDetails where(registrationNo = '" + registrationNo + "')and(AttMonth = '" + AttMonth + "')";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    this.btnCount.Enabled = false;
                    this.btnCalculate.Enabled = false;
                    this.btnSave.Enabled = false;
                    this.txtAtAvg.Text = dr[9].ToString();
                    this.txtAtFinalAvg.Text = dr[10].ToString();
                    this.txtAtStatus.Text = dr[11].ToString();
                    this.btnAdd.Enabled = false;

                }
            }

            catch
            {

            }
        }



        private void txtAtAvg_TextChanged(object sender, EventArgs e)
        {
            if(txtAtAvg.Text=="")
            {
                this.btnSave.Enabled = false;
            }

        }

        private void chbW1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW1.Checked == true)
            {
                this.chbA1.Enabled = true;
            }

            else if (chbW1.Checked == false)
            {
                this.chbA1.Checked = false;
                this.chbA1.Enabled = false;
            }

            else
            {
                this.chbA1.Enabled = false;
            }
        }

        private void chbW2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW2.Checked == true)
            {
                this.chbA2.Enabled = true;
            }

            else if (chbW2.Checked == false)
            {
                this.chbA2.Checked = false;
                this.chbA2.Enabled = false;
            }

            else
            {
                this.chbA2.Enabled = false;
            }
        }

        private void chbW3_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW3.Checked == true)
            {
                this.chbA3.Enabled = true;
            }

            else if (chbW3.Checked == false)
            {
                this.chbA3.Checked = false;
                this.chbA3.Enabled = false;
            }

            else
            {
                this.chbA3.Enabled = false;
            }
        }

        private void chbW4_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW4.Checked == true)
            {
                this.chbA4.Enabled = true;
            }

            else if (chbW4.Checked == false)
            {
                this.chbA4.Checked = false;
                this.chbA4.Enabled = false;
            }

            else
            {
                this.chbA4.Enabled = false;
            }
        }

        private void chbW5_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW5.Checked == true)
            {
                this.chbA5.Enabled = true;
            }

            else if (chbW5.Checked == false)
            {
                this.chbA5.Checked = false;
                this.chbA5.Enabled = false;
            }

            else
            {
                this.chbA5.Enabled = false;
            }
        }

        private void chbW6_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW6.Checked == true)
            {
                this.chbA6.Enabled = true;
            }

            else if (chbW6.Checked == false)
            {
                this.chbA6.Checked = false;
                this.chbA6.Enabled = false;
            }

            else
            {
                this.chbA6.Enabled = false;
            }
        }

        private void chbW7_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW7.Checked == true)
            {
                this.chbA7.Enabled = true;
            }

            else if (chbW7.Checked == false)
            {
                this.chbA7.Checked = false;
                this.chbA7.Enabled = false;
            }

            else
            {
                this.chbA7.Enabled = false;
            }
        }

        private void chbW8_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW8.Checked == true)
            {
                this.chbA8.Enabled = true;
            }

            else if (chbW8.Checked == false)
            {
                this.chbA8.Checked = false;
                this.chbA8.Enabled = false;
            }

            else
            {
                this.chbA8.Enabled = false;
            }
        }

        private void chbW9_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW9.Checked == true)
            {
                this.chbA9.Enabled = true;
            }

            else if (chbW9.Checked == false)
            {
                this.chbA9.Checked = false;
                this.chbA9.Enabled = false;
            }

            else
            {
                this.chbA9.Enabled = false;
            }
        }

        private void chbW10_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW10.Checked == true)
            {
                this.chbA10.Enabled = true;
            }

            else if (chbW10.Checked == false)
            {
                this.chbA10.Checked = false;
                this.chbA10.Enabled = false;
            }

            else
            {
                this.chbA10.Enabled = false;
            }
        }

        private void chbW11_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW11.Checked == true)
            {
                this.chbA11.Enabled = true;
            }

            else if (chbW11.Checked == false)
            {
                this.chbA11.Checked = false;
                this.chbA11.Enabled = false;
            }

            else
            {
                this.chbA11.Enabled = false;
            }
        }

        private void chbW12_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW12.Checked == true)
            {
                this.chbA12.Enabled = true;
            }

            else if (chbW12.Checked == false)
            {
                this.chbA12.Checked = false;
                this.chbA12.Enabled = false;
            }

            else
            {
                this.chbA12.Enabled = false;
            }
        }

        private void chbW13_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW13.Checked == true)
            {
                this.chbA13.Enabled = true;
            }

            else if (chbW13.Checked == false)
            {
                this.chbA13.Checked = false;
                this.chbA13.Enabled = false;
            }

            else
            {
                this.chbA13.Enabled = false;
            }
        }

        private void chbW14_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW14.Checked == true)
            {
                this.chbA14.Enabled = true;
            }

            else if (chbW14.Checked == false)
            {
                this.chbA14.Checked = false;
                this.chbA14.Enabled = false;
            }

            else
            {
                this.chbA14.Enabled = false;
            }
        }

        private void chbW15_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW15.Checked == true)
            {
                this.chbA15.Enabled = true;
            }

            else if (chbW15.Checked == false)
            {
                this.chbA15.Checked = false;
                this.chbA15.Enabled = false;
            }

            else
            {
                this.chbA15.Enabled = false;
            }
        }

        private void chbW16_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW16.Checked == true)
            {
                this.chbA16.Enabled = true;
            }

            else if (chbW16.Checked == false)
            {
                this.chbA16.Checked = false;
                this.chbA16.Enabled = false;
            }

            else
            {
                this.chbA16.Enabled = false;
            }
        }

        private void chbW17_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW17.Checked == true)
            {
                this.chbA17.Enabled = true;
            }

            else if (chbW17.Checked == false)
            {
                this.chbA17.Checked = false;
                this.chbA17.Enabled = false;
            }

            else
            {
                this.chbA17.Enabled = false;
            }
        }

        private void chbW18_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW18.Checked == true)
            {
                this.chbA18.Enabled = true;
            }

            else if (chbW18.Checked == false)
            {
                this.chbA18.Checked = false;
                this.chbA18.Enabled = false;
            }

            else
            {
                this.chbA18.Enabled = false;
            }
        }

        private void chbW19_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW19.Checked == true)
            {
                this.chbA19.Enabled = true;
            }

            else if (chbW19.Checked == false)
            {
                this.chbA19.Checked = false;
                this.chbA19.Enabled = false;
            }

            else
            {
                this.chbA19.Enabled = false;
            }
        }

        private void chbW20_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW20.Checked == true)
            {
                this.chbA20.Enabled = true;
            }

            else if (chbW20.Checked == false)
            {
                this.chbA20.Checked = false;
                this.chbA20.Enabled = false;
            }

            else
            {
                this.chbA20.Enabled = false;
            }
        }

        private void chbW21_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW21.Checked == true)
            {
                this.chbA21.Enabled = true;
            }

            else if (chbW21.Checked == false)
            {
                this.chbA21.Checked = false;
                this.chbA21.Enabled = false;
            }

            else
            {
                this.chbA21.Enabled = false;
            }
        }

        private void chbW22_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW22.Checked == true)
            {
                this.chbA22.Enabled = true;
            }

            else if (chbW22.Checked == false)
            {
                this.chbA22.Checked = false;
                this.chbA22.Enabled = false;
            }

            else
            {
                this.chbA22.Enabled = false;
            }
        }

        private void chbW23_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW23.Checked == true)
            {
                this.chbA23.Enabled = true;
            }

            else if (chbW23.Checked == false)
            {
                this.chbA23.Checked = false;
                this.chbA23.Enabled = false;
            }

            else
            {
                this.chbA23.Enabled = false;
            }
        }

        private void chbW24_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW24.Checked == true)
            {
                this.chbA24.Enabled = true;
            }

            else if (chbW24.Checked == false)
            {
                this.chbA24.Checked = false;
                this.chbA24.Enabled = false;
            }

            else
            {
                this.chbA24.Enabled = false;
            }
        }

        private void chbW25_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW25.Checked == true)
            {
                this.chbA25.Enabled = true;
            }

            else if (chbW25.Checked == false)
            {
                this.chbA25.Checked = false;
                this.chbA25.Enabled = false;
            }

            else
            {
                this.chbA25.Enabled = false;
            }
        }

        private void chbW26_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW26.Checked == true)
            {
                this.chbA26.Enabled = true;
            }

            else if (chbW26.Checked == false)
            {
                this.chbA26.Checked = false;
                this.chbA26.Enabled = false;
            }

            else
            {
                this.chbA26.Enabled = false;
            }
        }

        private void chbW27_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW27.Checked == true)
            {
                this.chbA27.Enabled = true;
            }

            else if (chbW27.Checked == false)
            {
                this.chbA27.Checked = false;
                this.chbA27.Enabled = false;
            }

            else
            {
                this.chbA27.Enabled = false;
            }
        }

        private void chbW28_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW28.Checked == true)
            {
                this.chbA28.Enabled = true;
            }

            else if (chbW28.Checked == false)
            {
                this.chbA28.Checked = false;
                this.chbA28.Enabled = false;
            }

            else
            {
                this.chbA28.Enabled = false;
            }
        }

        private void chbW29_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW29.Checked == true)
            {
                this.chbA29.Enabled = true;
            }

            else if (chbW29.Checked == false)
            {
                this.chbA29.Checked = false;
                this.chbA29.Enabled = false;
            }

            else
            {
                this.chbA29.Enabled = false;
            }
        }

        private void chbW30_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW30.Checked == true)
            {
                this.chbA30.Enabled = true;
            }

            else if (chbW30.Checked == false)
            {
                this.chbA30.Checked = false;
                this.chbA30.Enabled = false;
            }

            else
            {
                this.chbA30.Enabled = false;
            }
        }

        private void chbW31_CheckedChanged(object sender, EventArgs e)
        {
            if (chbW31.Checked == true)
            {
                this.chbA31.Enabled = true;
            }

            else if (chbW31.Checked == false)
            {
                this.chbA31.Checked = false;
                this.chbA31.Enabled = false;
            }

            else
            {
                this.chbA31.Enabled = false;
            }
        }

       

    }
}
