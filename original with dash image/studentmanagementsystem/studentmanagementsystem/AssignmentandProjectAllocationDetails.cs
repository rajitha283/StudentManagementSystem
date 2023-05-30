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
    public partial class AssignmentandProjectAllocationDetails : Form
    {
   
        public AssignmentandProjectAllocationDetails()
        {
            InitializeComponent();
            StuRegistrationNo();
        }
        
        conlink sqlcon = new conlink();

        private void Label()
        {
            try
            {
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql1 = " select * from AssignmentandProjectDetails";
                cmd1.CommandText = msql1;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    this.lbla1t1.Text = dr[4].ToString();
                    this.lbla1p1.Text = dr[5].ToString();
                    this.lbla2t1.Text = dr[6].ToString();
                    this.lbla2p1.Text = dr[7].ToString();
                    this.lbla3t1.Text = dr[8].ToString();
                    this.lbla3p1.Text = dr[9].ToString();
                    this.lbla4t1.Text = dr[10].ToString();
                    this.lbla4p1.Text = dr[11].ToString();
                    this.lblpro1.Text = dr[12].ToString();
                    this.lblviva1.Text = dr[13].ToString();

                    this.lbla1t2.Text = dr[15].ToString();
                    this.lbla1p2.Text = dr[16].ToString();
                    this.lbla2t2.Text = dr[17].ToString();
                    this.lbla2p2.Text = dr[18].ToString();
                    this.lbla3t2.Text = dr[19].ToString();
                    this.lbla3p2.Text = dr[20].ToString();
                    this.lbla4t2.Text = dr[21].ToString();
                    this.lbla4p2.Text = dr[22].ToString();
                    this.lblpro2.Text = dr[23].ToString();
                    this.lblviva2.Text = dr[24].ToString();

                    this.lbla1t3.Text = dr[26].ToString();
                    this.lbla1p3.Text = dr[27].ToString();
                    this.lbla2t3.Text = dr[28].ToString();
                    this.lbla2p3.Text = dr[29].ToString();
                    this.lbla3t3.Text = dr[30].ToString();
                    this.lbla3p3.Text = dr[31].ToString();
                    this.lbla4t3.Text = dr[32].ToString();
                    this.lbla4p3.Text = dr[33].ToString();
                    this.lblpro3.Text = dr[34].ToString();
                    this.lblviva3.Text = dr[35].ToString();

                    this.lbla1t4.Text = dr[37].ToString();
                    this.lbla1p4.Text = dr[38].ToString();
                    this.lbla2t4.Text = dr[39].ToString();
                    this.lbla2p4.Text = dr[40].ToString();
                    this.lbla3t4.Text = dr[41].ToString();
                    this.lbla3p4.Text = dr[42].ToString();
                    this.lbla4t4.Text = dr[43].ToString();
                    this.lbla4p4.Text = dr[44].ToString();
                    this.lblpro4.Text = dr[45].ToString();
                    this.lblviva4.Text = dr[46].ToString();

                    this.lbla1t5.Text = dr[48].ToString();
                    this.lbla1p5.Text = dr[49].ToString();
                    this.lbla2t5.Text = dr[50].ToString();
                    this.lbla2p5.Text = dr[51].ToString();
                    this.lbla3t5.Text = dr[52].ToString();
                    this.lbla3p5.Text = dr[53].ToString();
                    this.lbla4t5.Text = dr[54].ToString();
                    this.lbla4p5.Text = dr[55].ToString();
                    this.lblpro5.Text = dr[56].ToString();
                    this.lblviva5.Text = dr[57].ToString();

                    this.lbla1t6.Text = dr[59].ToString();
                    this.lbla1p6.Text = dr[60].ToString();
                    this.lbla2t6.Text = dr[61].ToString();
                    this.lbla2p6.Text = dr[62].ToString();
                    this.lbla3t6.Text = dr[63].ToString();
                    this.lbla3p6.Text = dr[64].ToString();
                    this.lbla4t6.Text = dr[65].ToString();
                    this.lbla4p6.Text = dr[66].ToString();
                    this.lblpro6.Text = dr[67].ToString();
                    this.lblviva6.Text = dr[68].ToString();

                    this.lbla1t7.Text = dr[70].ToString();
                    this.lbla1p7.Text = dr[71].ToString();
                    this.lbla2t7.Text = dr[72].ToString();
                    this.lbla2p7.Text = dr[73].ToString();
                    this.lbla3t7.Text = dr[74].ToString();
                    this.lbla3p7.Text = dr[75].ToString();
                    this.lbla4t7.Text = dr[76].ToString();
                    this.lbla4p7.Text = dr[77].ToString();
                    this.lblpro7.Text = dr[78].ToString();
                    this.lblviva7.Text = dr[79].ToString();

                    this.lbla1t8.Text = dr[81].ToString();
                    this.lbla1p8.Text = dr[82].ToString();
                    this.lbla2t8.Text = dr[83].ToString();
                    this.lbla2p8.Text = dr[84].ToString();
                    this.lbla3t8.Text = dr[85].ToString();
                    this.lbla3p8.Text = dr[86].ToString();
                    this.lbla4t8.Text = dr[87].ToString();
                    this.lbla4p8.Text = dr[88].ToString();
                    this.lblpro8.Text = dr[89].ToString();
                    this.lblviva8.Text = dr[90].ToString();

                    this.lbla1t9.Text = dr[92].ToString();
                    this.lbla1p9.Text = dr[93].ToString();
                    this.lbla2t9.Text = dr[94].ToString();
                    this.lbla2p9.Text = dr[95].ToString();
                    this.lbla3t9.Text = dr[96].ToString();
                    this.lbla3p9.Text = dr[97].ToString();
                    this.lbla4t9.Text = dr[98].ToString();
                    this.lbla4p9.Text = dr[99].ToString();
                    this.lblpro9.Text = dr[100].ToString();
                    this.lblviva9.Text = dr[101].ToString();

                    this.lbla1t10.Text = dr[103].ToString();
                    this.lbla1p10.Text = dr[104].ToString();
                    this.lbla2t10.Text = dr[105].ToString();
                    this.lbla2p10.Text = dr[106].ToString();
                    this.lbla3t10.Text = dr[107].ToString();
                    this.lbla3p10.Text = dr[108].ToString();
                    this.lbla4t10.Text = dr[109].ToString();
                    this.lbla4p10.Text = dr[110].ToString();
                    this.lblpro10.Text = dr[111].ToString();
                    this.lblviva10.Text = dr[112].ToString();

                }
                conn.Close();
                conn.Dispose();
            }
            catch
            {

            }
        }
        DashboardNew Back = new DashboardNew();
        sms smsclz = new sms();

        void StuRegistrationNo()
        {
            try
            {
                this.cmbAPADRegNo.Items.Clear();
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                string msql = "select * from studentRegistration";
                SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
                SqlCeDataReader dr;
                conn.Open();
                dr = cmd1.ExecuteReader();

                while (dr.Read())
                {
                    string SRegiNo = dr.GetString(10);
                    cmbAPADRegNo.Items.Add(SRegiNo);
                }

                conn.Close();
                conn.Dispose();
            }
            catch
            {

            }
        }

        private void btnAPADSearch_Click_1(object sender, EventArgs e)
        {
            if (cmbAPADRegNo.Text == "")
            {
                MessageBox.Show("The Data is Empty. Data is required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                this.txtAPADYear.Enabled = false;
                this.txtAPADTName.Enabled = false;
                this.txtAPADCName.Enabled = false;

                this.txtAPADSName1.Enabled = false;
                this.txtAPADSName2.Enabled = false;
                this.txtAPADSName3.Enabled = false;
                this.txtAPADSName4.Enabled = false;
                this.txtAPADSName5.Enabled = false;
                this.txtAPADSName6.Enabled = false;
                this.txtAPADSName7.Enabled = false;
                this.txtAPADSName8.Enabled = false;
                this.txtAPADSName9.Enabled = false;
                this.txtAPADSName10.Enabled = false;

                this.txtAPADTAvg.Enabled = false;
                this.txtAPADStatus.Enabled = false;

                string AssignmentandProjectDetails = this.cmbAPADRegNo.SelectedItem.ToString();
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = " select * from studentRegistration where(registrationNo = '" + AssignmentandProjectDetails + "')";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    this.txtAPADTName.Text = dr[2].ToString();
                    this.txtAPADYear.Text = dr[1].ToString();
                    this.txtAPADCName.Text = dr[5].ToString();
                    Label();
                }
                conn.Close();
                conn.Dispose();

                string subjectDetails = this.txtAPADCName.Text.ToString();
                SqlCeConnection conn1 = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd2 = new SqlCeCommand();
                String msql2 = " select * from subjectdetails where(course = '" + subjectDetails + "')";
                cmd2.CommandText = msql2;
                cmd2.Connection = conn1;
                conn1.Open();
                SqlCeDataReader dr1 = cmd2.ExecuteReader();
                while (dr1.Read())
                {
                    this.txtAPADSName1.Text = dr1[3].ToString();
                    this.txtAPADSName2.Text = dr1[4].ToString();
                    this.txtAPADSName3.Text = dr1[5].ToString();
                    this.txtAPADSName4.Text = dr1[6].ToString();
                    this.txtAPADSName5.Text = dr1[7].ToString();
                    this.txtAPADSName6.Text = dr1[8].ToString();
                    this.txtAPADSName7.Text = dr1[9].ToString();
                    this.txtAPADSName8.Text = dr1[10].ToString();
                    this.txtAPADSName9.Text = dr1[11].ToString();
                    this.txtAPADSName10.Text = dr1[12].ToString();

                }
                conn.Close();
                conn.Dispose();

                if (txtAPADSName1.Text != "")
                {

                    this.cmbSAPADAss1N1.Enabled = true;
                    this.cmbSAPADAss2N1.Enabled = true;
                    this.cmbSAPADAss3N1.Enabled = true;
                    this.cmbSAPADAss4N1.Enabled = true;
                    this.cmbSAPADP1.Enabled = true;
                    this.txtSAPADAvg1.Enabled = false;
                }

                if (txtAPADSName2.Text != "")
                {

                    this.cmbSAPADAss1N2.Enabled = true;
                    this.cmbSAPADAss2N2.Enabled = true;
                    this.cmbSAPADAss3N2.Enabled = true;
                    this.cmbSAPADAss4N2.Enabled = true;
                    this.cmbSAPADP2.Enabled = true;
                    this.txtSAPADAvg2.Enabled = false;
                }

                if (txtAPADSName3.Text != "")
                {

                    this.cmbSAPADAss1N3.Enabled = true;
                    this.cmbSAPADAss2N3.Enabled = true;
                    this.cmbSAPADAss3N3.Enabled = true;
                    this.cmbSAPADAss4N3.Enabled = true;
                    this.cmbSAPADP3.Enabled = true;
                    this.txtSAPADAvg3.Enabled = false;
                }

                if (txtAPADSName4.Text != "")
                {

                    this.cmbSAPADAss1N4.Enabled = true;
                    this.cmbSAPADAss2N4.Enabled = true;
                    this.cmbSAPADAss3N4.Enabled = true;
                    this.cmbSAPADAss4N4.Enabled = true;
                    this.cmbSAPADP4.Enabled = true;
                    this.txtSAPADAvg4.Enabled = false;
                }

                if (txtAPADSName5.Text != "")
                {

                    this.cmbSAPADAss1N5.Enabled = true;
                    this.cmbSAPADAss2N5.Enabled = true;
                    this.cmbSAPADAss3N5.Enabled = true;
                    this.cmbSAPADAss4N5.Enabled = true;
                    this.cmbSAPADP5.Enabled = true;
                    this.txtSAPADAvg5.Enabled = false;
                }

                if (txtAPADSName6.Text != "")
                {

                    this.cmbSAPADAss1N6.Enabled = true;
                    this.cmbSAPADAss2N6.Enabled = true;
                    this.cmbSAPADAss3N6.Enabled = true;
                    this.cmbSAPADAss4N6.Enabled = true;
                    this.cmbSAPADP6.Enabled = true;
                    this.txtSAPADAvg6.Enabled = false;
                }

                if (txtAPADSName7.Text != "")
                {

                    this.cmbSAPADAss1N7.Enabled = true;
                    this.cmbSAPADAss2N7.Enabled = true;
                    this.cmbSAPADAss3N7.Enabled = true;
                    this.cmbSAPADAss4N7.Enabled = true;
                    this.cmbSAPADP7.Enabled = true;
                    this.txtSAPADAvg7.Enabled = false;
                }

                if (txtAPADSName8.Text != "")
                {

                    this.cmbSAPADAss1N8.Enabled = true;
                    this.cmbSAPADAss2N8.Enabled = true;
                    this.cmbSAPADAss3N8.Enabled = true;
                    this.cmbSAPADAss4N8.Enabled = true;
                    this.cmbSAPADP8.Enabled = true;
                    this.txtSAPADAvg8.Enabled = false;
                }

                if (txtAPADSName9.Text != "")
                {

                    this.cmbSAPADAss1N9.Enabled = true;
                    this.cmbSAPADAss2N9.Enabled = true;
                    this.cmbSAPADAss3N9.Enabled = true;
                    this.cmbSAPADAss4N9.Enabled = true;
                    this.cmbSAPADP9.Enabled = true;
                    this.txtSAPADAvg9.Enabled = false;
                }

                if (txtAPADSName10.Text != "")
                {
                    this.cmbSAPADAss1N10.Enabled = true;
                    this.cmbSAPADAss2N10.Enabled = true;
                    this.cmbSAPADAss3N10.Enabled = true;
                    this.cmbSAPADAss4N10.Enabled = true;
                    this.cmbSAPADP10.Enabled = true;
                    this.txtSAPADAvg10.Enabled = false;
                }
            }
        }

        string sub1, sub2, sub3, sub4, sub5, sub6, sub7, sub8, sub9, sub10;
        int subjectname = 0;
        
        private void btnAPADCalculation_Click(object sender, EventArgs e)
        {

            if (cmbAPADRegNo.Text =="")
            {
                MessageBox.Show("The Data is Empty. Data is required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                decimal APADSName1, APADSName2, APADSName3, APADSName4, APADSName5, APADSName6, APADSName7, APADSName8, APADSName9, APADSName10, total, total_avg;

                APADSName1 = Convert.ToDecimal(txtSAPADAvg1.Text);
                APADSName2 = Convert.ToDecimal(txtSAPADAvg2.Text);
                APADSName3 = Convert.ToDecimal(txtSAPADAvg3.Text);
                APADSName4 = Convert.ToDecimal(txtSAPADAvg4.Text);
                APADSName5 = Convert.ToDecimal(txtSAPADAvg5.Text);
                APADSName6 = Convert.ToDecimal(txtSAPADAvg6.Text);
                APADSName7 = Convert.ToDecimal(txtSAPADAvg7.Text);
                APADSName8 = Convert.ToDecimal(txtSAPADAvg8.Text);
                APADSName9 = Convert.ToDecimal(txtSAPADAvg9.Text);
                APADSName10 = Convert.ToDecimal(txtSAPADAvg10.Text);

                sub1 = this.txtAPADSName1.Text;
                sub2 = this.txtAPADSName2.Text;
                sub3 = this.txtAPADSName3.Text;
                sub4 = this.txtAPADSName4.Text;
                sub5 = this.txtAPADSName5.Text;
                sub6 = this.txtAPADSName6.Text;
                sub7 = this.txtAPADSName7.Text;
                sub8 = this.txtAPADSName8.Text;
                sub9 = this.txtAPADSName9.Text;
                sub10 = this.txtAPADSName10.Text;

                if (!(sub1 == ""))
                {
                    subjectname = 1;
                }

                if (!(sub2 == ""))
                {
                    subjectname = 1;
                }

                if (!(sub3 == ""))
                {
                    subjectname = 1;
                }

                if (!(sub4 == ""))
                {
                    subjectname = 1;
                }

                if (!(sub5 == ""))
                {
                    subjectname = 1;
                }

                if (!(sub6 == ""))
                {
                    subjectname = 1;
                }

                if (!(sub7 == ""))
                {
                    subjectname = 1;
                }

                if (!(sub8 == ""))
                {
                    subjectname = 1;
                }

                if (!(sub9 == ""))
                {
                    subjectname = 1;
                }

                if (!(sub10 == ""))
                {
                    subjectname = 1;
                }

                total = APADSName1 + APADSName2 + APADSName3 + APADSName4 + APADSName5 + APADSName6 + APADSName7 + APADSName8 + APADSName9 + APADSName10;

                total_avg = (total / subjectname);
                txtAPADTAvg.Text = total_avg.ToString();

                decimal percentage;
                percentage = (total * 100) / subjectname;

                if (percentage >= 80)
                    txtAPADStatus.Text = "Complete";
                else if (percentage <= 79)
                    txtAPADStatus.Text = "Incomplete";
            }
        }

        int year;
        string registrationNo, trade, course, sub1name, sub1ass1, sub1ass2, sub1ass3, sub1ass4, sub1project, sub1avg, sub2name, sub2ass1, sub2ass2, sub2ass3, sub2ass4, sub2project, sub2avg, sub3name, sub3ass1, sub3ass2, sub3ass3, sub3ass4, sub3project, sub3avg, sub4name, sub4ass1, sub4ass2, sub4ass3, sub4ass4, sub4project, sub4avg, sub5name, sub5ass1, sub5ass2, sub5ass3, sub5ass4, sub5project, sub5avg, sub6name, sub6ass1, sub6ass2, sub6ass3, sub6ass4, sub6project, sub6avg, sub7name, sub7ass1, sub7ass2, sub7ass3, sub7ass4, sub7project, sub7avg, sub8name, sub8ass1, sub8ass2, sub8ass3, sub8ass4, sub8project, sub8avg, sub9name, sub9ass1, sub9ass2, sub9ass3, sub9ass4, sub9project, sub9avg, sub10name, sub10ass1, sub10ass2, sub10ass3, sub10ass4, sub10project, sub10avg, sub11name, sub11ass1, sub11ass2, sub11ass3, sub11ass4, sub11project, sub11avg, sub12name, sub12ass1, sub12ass2, sub12ass3, sub12ass4, sub12project, sub12avg, sub13name, sub13ass1, sub13ass2, sub13ass3, sub13ass4, sub13project, sub13avg, sub14name, sub14ass1, sub14ass2, sub14ass3, sub14ass4, sub14project, sub14avg, sub15name, sub15ass1, sub15ass2, sub15ass3, sub15ass4, sub15project, sub15avg, sub16name, sub16ass1, sub16ass2, sub16ass3, sub16ass4, sub16project, sub16avg, sub17name, sub17ass1, sub17ass2, sub17ass3, sub17ass4, sub17project, sub17avg, sub18name, sub18ass1, sub18ass2, sub18ass3, sub18ass4, sub18project, sub18avg, sub19name, sub19ass1, sub19ass2, sub19ass3, sub19ass4, sub19project, sub19avg, sub20name, sub20ass1, sub20ass2, sub20ass3, sub20ass4, sub20project, sub20avg, totalavg, status;
       
        private void btnAPADAdd_Click(object sender, EventArgs e)
        {
           
            if(cmbAPADRegNo.Text =="" || txtAPADTAvg.Text == "0")
            {
                MessageBox.Show("The Data is Empty. Data is required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                registrationNo = this.cmbAPADRegNo.SelectedItem.ToString();
                year = Convert.ToInt32(this.txtAPADYear.Text.Trim());
                trade = this.txtAPADTName.Text.Trim();
                course = this.txtAPADCName.Text.Trim();

                sub1name = this.txtAPADSName1.Text.Trim();
                sub1ass1 = this.cmbSAPADAss1N1.SelectedItem.ToString();
                sub1ass2 = this.cmbSAPADAss2N1.SelectedItem.ToString();
                sub1ass3 = this.cmbSAPADAss3N1.SelectedItem.ToString();
                sub1ass4 = this.cmbSAPADAss4N1.SelectedItem.ToString();
                sub1project = this.cmbSAPADP1.SelectedItem.ToString();
                sub1avg = this.txtSAPADAvg1.Text.Trim();

                sub2name = this.txtAPADSName2.Text.Trim();
                sub2ass1 = this.cmbSAPADAss1N2.SelectedItem.ToString();
                sub2ass2 = this.cmbSAPADAss2N2.SelectedItem.ToString();
                sub2ass3 = this.cmbSAPADAss3N2.SelectedItem.ToString();
                sub2ass4 = this.cmbSAPADAss4N2.SelectedItem.ToString();
                sub2project = this.cmbSAPADP2.SelectedItem.ToString();
                sub2avg = this.txtSAPADAvg2.Text.Trim();

                sub3name = this.txtAPADSName3.Text.Trim();
                sub3ass1 = this.cmbSAPADAss1N3.SelectedItem.ToString();
                sub3ass2 = this.cmbSAPADAss2N3.SelectedItem.ToString();
                sub3ass3 = this.cmbSAPADAss3N3.SelectedItem.ToString();
                sub3ass4 = this.cmbSAPADAss4N3.SelectedItem.ToString();
                sub3project = this.cmbSAPADP3.SelectedItem.ToString();
                sub3avg = this.txtSAPADAvg3.Text.Trim();

                sub4name = this.txtAPADSName4.Text.Trim();
                sub4ass1 = this.cmbSAPADAss1N4.SelectedItem.ToString();
                sub4ass2 = this.cmbSAPADAss2N4.SelectedItem.ToString();
                sub4ass3 = this.cmbSAPADAss3N4.SelectedItem.ToString();
                sub4ass4 = this.cmbSAPADAss4N4.SelectedItem.ToString();
                sub4project = this.cmbSAPADP4.SelectedItem.ToString();
                sub4avg = this.txtSAPADAvg4.Text.Trim();

                sub5name = this.txtAPADSName5.Text.Trim();
                sub5ass1 = this.cmbSAPADAss1N5.SelectedItem.ToString();
                sub5ass2 = this.cmbSAPADAss2N5.SelectedItem.ToString();
                sub5ass3 = this.cmbSAPADAss3N5.SelectedItem.ToString();
                sub5ass4 = this.cmbSAPADAss4N5.SelectedItem.ToString();
                sub5project = this.cmbSAPADP5.SelectedItem.ToString();
                sub5avg = this.txtSAPADAvg5.Text.Trim();

                sub6name = this.txtAPADSName6.Text.Trim();
                sub6ass1 = this.cmbSAPADAss1N6.SelectedItem.ToString();
                sub6ass2 = this.cmbSAPADAss2N6.SelectedItem.ToString();
                sub6ass3 = this.cmbSAPADAss3N6.SelectedItem.ToString();
                sub6ass4 = this.cmbSAPADAss4N6.SelectedItem.ToString();
                sub6project = this.cmbSAPADP6.SelectedItem.ToString();
                sub6avg = this.txtSAPADAvg6.Text.Trim();

                sub7name = this.txtAPADSName7.Text.Trim();
                sub7ass1 = this.cmbSAPADAss1N7.SelectedItem.ToString();
                sub7ass2 = this.cmbSAPADAss2N7.SelectedItem.ToString();
                sub7ass3 = this.cmbSAPADAss3N7.SelectedItem.ToString();
                sub7ass4 = this.cmbSAPADAss4N7.SelectedItem.ToString();
                sub7project = this.cmbSAPADP7.SelectedItem.ToString();
                sub7avg = this.txtSAPADAvg7.Text.Trim();

                sub8name = this.txtAPADSName8.Text.Trim();
                sub8ass1 = this.cmbSAPADAss1N8.SelectedItem.ToString();
                sub8ass2 = this.cmbSAPADAss2N8.SelectedItem.ToString();
                sub8ass3 = this.cmbSAPADAss3N8.SelectedItem.ToString();
                sub8ass4 = this.cmbSAPADAss4N8.SelectedItem.ToString();
                sub8project = this.cmbSAPADP8.SelectedItem.ToString();
                sub8avg = this.txtSAPADAvg8.Text.Trim();

                sub9name = this.txtAPADSName9.Text.Trim();
                sub9ass1 = this.cmbSAPADAss1N9.SelectedItem.ToString();
                sub9ass2 = this.cmbSAPADAss2N9.SelectedItem.ToString();
                sub9ass3 = this.cmbSAPADAss3N9.SelectedItem.ToString();
                sub9ass4 = this.cmbSAPADAss4N9.SelectedItem.ToString();
                sub9project = this.cmbSAPADP9.SelectedItem.ToString();
                sub9avg = this.txtSAPADAvg9.Text.Trim();

                sub10name = this.txtAPADSName10.Text.Trim();
                sub10ass1 = this.cmbSAPADAss1N10.SelectedItem.ToString();
                sub10ass2 = this.cmbSAPADAss2N10.SelectedItem.ToString();
                sub10ass3 = this.cmbSAPADAss3N10.SelectedItem.ToString();
                sub10ass4 = this.cmbSAPADAss4N10.SelectedItem.ToString();
                sub10project = this.cmbSAPADP10.SelectedItem.ToString();
                sub10avg = this.txtSAPADAvg10.Text.Trim();

                totalavg = this.txtAPADTAvg.Text.Trim();
                status = this.txtAPADStatus.Text.Trim();

                sms smsclz = new sms();
                smsclz.AssignmentandProjectAllocationAddData(registrationNo, year, trade, course, sub1name, sub1ass1, sub1ass2, sub1ass3, sub1ass4, sub1project, sub1avg, sub2name, sub2ass1, sub2ass2, sub2ass3, sub2ass4, sub2project, sub2avg, sub3name, sub3ass1, sub3ass2, sub3ass3, sub3ass4, sub3project, sub3avg, sub4name, sub4ass1, sub4ass2, sub4ass3, sub4ass4, sub4project, sub4avg, sub5name, sub5ass1, sub5ass2, sub5ass3, sub5ass4, sub5project, sub5avg, sub6name, sub6ass1, sub6ass2, sub6ass3, sub6ass4, sub6project, sub6avg, sub7name, sub7ass1, sub7ass2, sub7ass3, sub7ass4, sub7project, sub7avg, sub8name, sub8ass1, sub8ass2, sub8ass3, sub8ass4, sub8project, sub8avg, sub9name, sub9ass1, sub9ass2, sub9ass3, sub9ass4, sub9project, sub9avg, sub10name, sub10ass1, sub10ass2, sub10ass3, sub10ass4, sub10project, sub10avg, totalavg, status);
                MessageBox.Show("Successfully Added Assignment and Project Allocation Data", "Message");

                Clear();
            }
        }

        private void btnAPADClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAPADBack_Click_1(object sender, EventArgs e)
        {
           
            this.btnAPADSave.Visible = false;
            this.btnAPADAdd.Visible = true;
            this.cmbAPADRegNo.SelectedIndex = -1;

            this.txtAPADYear.Text = "";
            this.txtAPADTName.Text = "";
            this.txtAPADCName.Text = "";
            this.txtAPADSName1.Text = "";
            this.txtAPADSName2.Text = "";
            this.txtAPADSName3.Text = "";
            this.txtAPADSName4.Text = "";
            this.txtAPADSName5.Text = "";
            this.txtAPADSName6.Text = "";
            this.txtAPADSName7.Text = "";
            this.txtAPADSName8.Text = "";
            this.txtAPADSName9.Text = "";
            this.txtAPADSName10.Text = "";

            Clear();
        }

        private void Clear()
        {
            this.cmbSAPADAss1N1.Text = "";
            this.cmbSAPADAss1N2.Text = "";
            this.cmbSAPADAss1N3.Text = "";
            this.cmbSAPADAss1N4.Text = "";
            this.cmbSAPADAss1N5.Text = "";
            this.cmbSAPADAss1N6.Text = "";
            this.cmbSAPADAss1N7.Text = "";
            this.cmbSAPADAss1N8.Text = "";
            this.cmbSAPADAss1N9.Text = "";
            this.cmbSAPADAss1N10.Text = "";

            this.cmbSAPADAss2N1.Text = "";
            this.cmbSAPADAss2N2.Text = "";
            this.cmbSAPADAss2N3.Text = "";
            this.cmbSAPADAss2N4.Text = "";
            this.cmbSAPADAss2N5.Text = "";
            this.cmbSAPADAss2N6.Text = "";
            this.cmbSAPADAss2N7.Text = "";
            this.cmbSAPADAss2N8.Text = "";
            this.cmbSAPADAss2N9.Text = "";
            this.cmbSAPADAss2N10.Text = "";

            this.cmbSAPADAss3N1.Text = "";
            this.cmbSAPADAss3N2.Text = "";
            this.cmbSAPADAss3N3.Text = "";
            this.cmbSAPADAss3N4.Text = "";
            this.cmbSAPADAss3N5.Text = "";
            this.cmbSAPADAss3N6.Text = "";
            this.cmbSAPADAss3N7.Text = "";
            this.cmbSAPADAss3N8.Text = "";
            this.cmbSAPADAss3N9.Text = "";
            this.cmbSAPADAss3N10.Text = "";

            this.cmbSAPADAss4N1.Text = "";
            this.cmbSAPADAss4N2.Text = "";
            this.cmbSAPADAss4N3.Text = "";
            this.cmbSAPADAss4N4.Text = "";
            this.cmbSAPADAss4N5.Text = "";
            this.cmbSAPADAss4N6.Text = "";
            this.cmbSAPADAss4N7.Text = "";
            this.cmbSAPADAss4N8.Text = "";
            this.cmbSAPADAss4N9.Text = "";
            this.cmbSAPADAss4N10.Text = "";

            this.cmbSAPADP1.Text = "";
            this.cmbSAPADP2.Text = "";
            this.cmbSAPADP3.Text = "";
            this.cmbSAPADP4.Text = "";
            this.cmbSAPADP5.Text = "";
            this.cmbSAPADP6.Text = "";
            this.cmbSAPADP7.Text = "";
            this.cmbSAPADP8.Text = "";
            this.cmbSAPADP9.Text = "";
            this.cmbSAPADP10.Text = "";

            this.txtSAPADAvg1.Text = "";
            this.txtSAPADAvg2.Text = "";
            this.txtSAPADAvg3.Text = "";
            this.txtSAPADAvg4.Text = "";
            this.txtSAPADAvg5.Text = "";
            this.txtSAPADAvg6.Text = "";
            this.txtSAPADAvg7.Text = "";
            this.txtSAPADAvg8.Text = "";
            this.txtSAPADAvg9.Text = "";
            this.txtSAPADAvg10.Text = "";

            this.txtAPADTAvg.Text = "";
            this.txtAPADStatus.Text = "";
           
            sms smsclz = new sms();
        }

        private void btnAPADEdit_Click_1(object sender, EventArgs e)
        {
            this.txtAPADTName.Enabled = false;
            this.txtAPADCName.Enabled = false;
            this.btnAPADSearch.Visible = false;
            this.txtAPADSName1.Visible = true;
            this.txtAPADSName2.Visible = true;
            this.txtAPADSName3.Visible = true;
            this.txtAPADSName4.Visible = true;
            this.txtAPADSName5.Visible = true;
            this.txtAPADSName6.Visible = true;
            this.txtAPADSName7.Visible = true;
            this.txtAPADSName8.Visible = true;
            this.txtAPADSName9.Visible = true;
            this.txtAPADSName10.Visible = true;

            this.btnAPADSearch.Visible = true;
            this.btnAPADSave.Visible = true;
            this.cmbAPADRegNo.Visible = true;
            this.btnAPADAdd.Visible = false;

            StuRegistrationNo();
        }

        private void FillConductNo()
        {
            this.cmbAPADRegNo.Items.Clear();
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            string msql = "select * from courseconductdetails";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr;
            conn.Open();
            dr = cmd1.ExecuteReader();

            while (dr.Read())
            {
                string RegisteredNo = dr.GetString(0);
                cmbAPADRegNo.Items.Add(RegisteredNo);
            }

            conn.Close();
            conn.Dispose();
        }

        private void btnAPADSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                registrationNo = this.cmbAPADRegNo.SelectedItem.ToString();
                year = Convert.ToInt32(this.txtAPADYear.Text.Trim());
                trade = this.txtAPADTName.Text.Trim();
                course = this.txtAPADCName.Text.Trim();
                sub1name = this.txtAPADSName1.Text.Trim();
                sub1ass1 = this.cmbSAPADAss1N1.SelectedItem.ToString();
                sub1ass2 = this.cmbSAPADAss2N1.SelectedItem.ToString();
                sub1ass3 = this.cmbSAPADAss3N1.SelectedItem.ToString();
                sub1ass4 = this.cmbSAPADAss4N1.SelectedItem.ToString();
                sub1project = this.cmbSAPADP1.SelectedItem.ToString();
                sub1avg = this.txtSAPADAvg1.Text.Trim();

                sub2name = this.txtAPADSName2.Text.Trim();
                sub2ass1 = this.cmbSAPADAss1N2.SelectedItem.ToString();
                sub2ass2 = this.cmbSAPADAss2N2.SelectedItem.ToString();
                sub2ass3 = this.cmbSAPADAss3N2.SelectedItem.ToString();
                sub2ass4 = this.cmbSAPADAss4N2.SelectedItem.ToString();
                sub2project = this.cmbSAPADP2.SelectedItem.ToString();
                sub2avg = this.txtSAPADAvg2.Text.Trim();

                sub3name = this.txtAPADSName3.Text.Trim();
                sub3ass1 = this.cmbSAPADAss1N3.SelectedItem.ToString();
                sub3ass2 = this.cmbSAPADAss2N3.SelectedItem.ToString();
                sub3ass3 = this.cmbSAPADAss3N3.SelectedItem.ToString();
                sub3ass4 = this.cmbSAPADAss4N3.SelectedItem.ToString();
                sub3project = this.cmbSAPADP3.SelectedItem.ToString();
                sub3avg = this.txtSAPADAvg3.Text.Trim();

                sub4name = this.txtAPADSName4.Text.Trim();
                sub4ass1 = this.cmbSAPADAss1N4.SelectedItem.ToString();
                sub4ass2 = this.cmbSAPADAss2N4.SelectedItem.ToString();
                sub4ass3 = this.cmbSAPADAss3N4.SelectedItem.ToString();
                sub4ass4 = this.cmbSAPADAss4N4.SelectedItem.ToString();
                sub4project = this.cmbSAPADP4.SelectedItem.ToString();
                sub4avg = this.txtSAPADAvg4.Text.Trim();

                sub5name = this.txtAPADSName5.Text.Trim();
                sub5ass1 = this.cmbSAPADAss1N5.SelectedItem.ToString();
                sub5ass2 = this.cmbSAPADAss2N5.SelectedItem.ToString();
                sub5ass3 = this.cmbSAPADAss3N5.SelectedItem.ToString();
                sub5ass4 = this.cmbSAPADAss4N5.SelectedItem.ToString();
                sub5project = this.cmbSAPADP5.SelectedItem.ToString();
                sub5avg = this.txtSAPADAvg5.Text.Trim();

                sub6name = this.txtAPADSName6.Text.Trim();
                sub6ass1 = this.cmbSAPADAss1N6.SelectedItem.ToString();
                sub6ass2 = this.cmbSAPADAss2N6.SelectedItem.ToString();
                sub6ass3 = this.cmbSAPADAss3N6.SelectedItem.ToString();
                sub6ass4 = this.cmbSAPADAss4N6.SelectedItem.ToString();
                sub6project = this.cmbSAPADP6.SelectedItem.ToString();
                sub6avg = this.txtSAPADAvg6.Text.Trim();

                sub7name = this.txtAPADSName7.Text.Trim();
                sub7ass1 = this.cmbSAPADAss1N7.SelectedItem.ToString();
                sub7ass2 = this.cmbSAPADAss2N7.SelectedItem.ToString();
                sub7ass3 = this.cmbSAPADAss3N7.SelectedItem.ToString();
                sub7ass4 = this.cmbSAPADAss4N7.SelectedItem.ToString();
                sub7project = this.cmbSAPADP7.SelectedItem.ToString();
                sub7avg = this.txtSAPADAvg7.Text.Trim();

                sub8name = this.txtAPADSName8.Text.Trim();
                sub8ass1 = this.cmbSAPADAss1N8.SelectedItem.ToString();
                sub8ass2 = this.cmbSAPADAss2N8.SelectedItem.ToString();
                sub8ass3 = this.cmbSAPADAss3N8.SelectedItem.ToString();
                sub8ass4 = this.cmbSAPADAss4N8.SelectedItem.ToString();
                sub8project = this.cmbSAPADP8.SelectedItem.ToString();
                sub8avg = this.txtSAPADAvg8.Text.Trim();

                sub9name = this.txtAPADSName9.Text.Trim();
                sub9ass1 = this.cmbSAPADAss1N9.SelectedItem.ToString();
                sub9ass2 = this.cmbSAPADAss2N9.SelectedItem.ToString();
                sub9ass3 = this.cmbSAPADAss3N9.SelectedItem.ToString();
                sub9ass4 = this.cmbSAPADAss4N9.SelectedItem.ToString();
                sub9project = this.cmbSAPADP9.SelectedItem.ToString();
                sub9avg = this.txtSAPADAvg9.Text.Trim();

                sub10name = this.txtAPADSName10.Text.Trim();
                sub10ass1 = this.cmbSAPADAss1N10.SelectedItem.ToString();
                sub10ass2 = this.cmbSAPADAss2N10.SelectedItem.ToString();
                sub10ass3 = this.cmbSAPADAss3N10.SelectedItem.ToString();
                sub10ass4 = this.cmbSAPADAss4N10.SelectedItem.ToString();
                sub10project = this.cmbSAPADP10.SelectedItem.ToString();
                sub10avg = this.txtSAPADAvg10.Text.Trim();

                totalavg = this.txtAPADTAvg.Text.Trim();
                totalavg = this.txtAPADStatus.Text.Trim();
              
                sms smsdb = new sms();

                smsdb.UpdateData(registrationNo, year, trade, course, sub1name, sub1ass1, sub1ass2, sub1ass3, sub1ass4, sub1project, sub1avg, sub2name, sub2ass1, sub2ass2, sub2ass3, sub2ass4, sub2project, sub2avg, sub3name, sub3ass1, sub3ass2, sub3ass3, sub3ass4, sub3project, sub3avg, sub4name, sub4ass1, sub4ass2, sub4ass3, sub4ass4, sub4project, sub4avg, sub5name, sub5ass1, sub5ass2, sub5ass3, sub5ass4, sub5project, sub5avg, sub6name, sub6ass1, sub6ass2, sub6ass3, sub6ass4, sub6project, sub6avg, sub7name, sub7ass1, sub7ass2, sub7ass3, sub7ass4, sub7project, sub7avg, sub8name, sub8ass1, sub8ass2, sub8ass3, sub8ass4, sub8project, sub8avg, sub9name, sub9ass1, sub9ass2, sub9ass3, sub9ass4, sub9project, sub9avg, sub10name, sub10ass1, sub10ass2, sub10ass3, sub10ass4, sub10project, sub10avg, totalavg, status);
                MessageBox.Show("Updated Successfully", "Message");
            }
            catch
            {
                MessageBox.Show("Not Updated", "Warning/Error");
            }
        }

        private void AssignmentandProjectAllocationDetails_Load(object sender, EventArgs e)
        {
            this.txtAPADYear.Enabled = false;
            this.txtAPADTName.Enabled = false;
            this.txtAPADCName.Enabled = false;

            this.txtAPADTAvg.Enabled = false;
            this.txtAPADStatus.Enabled = false;

            this.txtAPADSName1.Enabled = false;
            this.txtAPADSName2.Enabled = false;
            this.txtAPADSName3.Enabled = false;
            this.txtAPADSName4.Enabled = false;
            this.txtAPADSName5.Enabled = false;
            this.txtAPADSName6.Enabled = false;
            this.txtAPADSName7.Enabled = false;
            this.txtAPADSName8.Enabled = false;
            this.txtAPADSName9.Enabled = false;
            this.txtAPADSName10.Enabled = false;
            
            this.cmbSAPADAss1N1.Enabled = false;
            this.cmbSAPADAss1N2.Enabled = false;
            this.cmbSAPADAss1N3.Enabled = false;
            this.cmbSAPADAss1N4.Enabled = false;
            this.cmbSAPADAss1N5.Enabled = false;
            this.cmbSAPADAss1N6.Enabled = false;
            this.cmbSAPADAss1N7.Enabled = false;
            this.cmbSAPADAss1N8.Enabled = false;
            this.cmbSAPADAss1N9.Enabled = false;
            this.cmbSAPADAss1N10.Enabled = false;

            this.cmbSAPADAss2N1.Enabled = false;
            this.cmbSAPADAss2N2.Enabled = false;
            this.cmbSAPADAss2N3.Enabled = false;
            this.cmbSAPADAss2N4.Enabled = false;
            this.cmbSAPADAss2N5.Enabled = false;
            this.cmbSAPADAss2N6.Enabled = false;
            this.cmbSAPADAss2N7.Enabled = false;
            this.cmbSAPADAss2N8.Enabled = false;
            this.cmbSAPADAss2N9.Enabled = false;
            this.cmbSAPADAss2N10.Enabled = false;

            this.cmbSAPADAss3N1.Enabled = false;
            this.cmbSAPADAss3N2.Enabled = false;
            this.cmbSAPADAss3N3.Enabled = false;
            this.cmbSAPADAss3N4.Enabled = false;
            this.cmbSAPADAss3N5.Enabled = false;
            this.cmbSAPADAss3N6.Enabled = false;
            this.cmbSAPADAss3N7.Enabled = false;
            this.cmbSAPADAss3N8.Enabled = false;
            this.cmbSAPADAss3N9.Enabled = false;
            this.cmbSAPADAss3N10.Enabled = false;

            this.cmbSAPADAss4N1.Enabled = false;
            this.cmbSAPADAss4N2.Enabled = false;
            this.cmbSAPADAss4N3.Enabled = false;
            this.cmbSAPADAss4N4.Enabled = false;
            this.cmbSAPADAss4N5.Enabled = false;
            this.cmbSAPADAss4N6.Enabled = false;
            this.cmbSAPADAss4N7.Enabled = false;
            this.cmbSAPADAss4N8.Enabled = false;
            this.cmbSAPADAss4N9.Enabled = false;
            this.cmbSAPADAss4N10.Enabled = false;
           
            this.cmbSAPADP1.Enabled = false;
            this.cmbSAPADP2.Enabled = false;
            this.cmbSAPADP3.Enabled = false;
            this.cmbSAPADP4.Enabled = false;
            this.cmbSAPADP5.Enabled = false;
            this.cmbSAPADP6.Enabled = false;
            this.cmbSAPADP7.Enabled = false;
            this.cmbSAPADP8.Enabled = false;
            this.cmbSAPADP9.Enabled = false;
            this.cmbSAPADP10.Enabled = false;
           
            this.txtSAPADAvg1.Enabled = false;
            this.txtSAPADAvg2.Enabled = false;
            this.txtSAPADAvg3.Enabled = false;
            this.txtSAPADAvg4.Enabled = false;
            this.txtSAPADAvg5.Enabled = false;
            this.txtSAPADAvg6.Enabled = false;
            this.txtSAPADAvg7.Enabled = false;
            this.txtSAPADAvg8.Enabled = false;
            this.txtSAPADAvg9.Enabled = false;
            this.txtSAPADAvg10.Enabled = false;
            
        }

        void cal1()
        {
            decimal sub1ass1, sub1ass2, sub1ass3, sub1ass4, sub1project, total, avg;
            sub1ass1 = Convert.ToInt32(cmbSAPADAss1N1.Text);
            sub1ass2 = Convert.ToInt32(cmbSAPADAss2N1.Text);
            sub1ass3 = Convert.ToInt32(cmbSAPADAss3N1.Text);
            sub1ass4 = Convert.ToInt32(cmbSAPADAss4N1.Text);
            sub1project = Convert.ToInt32(cmbSAPADP1.Text);

            total = sub1ass1 + sub1ass2 + sub1ass3 + sub1ass4 + sub1project;
            avg = total / 5;
            txtSAPADAvg1.Text = avg.ToString();
        }

        private void cmbSAPADAss1N1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal1();
        }

        private void cmbSAPADAss2N1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal1();
        }

        private void cmbSAPADAss3N1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal1();
        }

        private void cmbSAPADAss4N1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal1();
        }

        private void cmbSAPADP1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal1();
        }

        void cal2()
        {
            decimal sub2ass1, sub2ass2, sub2ass3, sub2ass4, sub2project, total, avg;
            sub2ass1 = Convert.ToInt32(cmbSAPADAss1N2.Text);
            sub2ass2 = Convert.ToInt32(cmbSAPADAss2N2.Text);
            sub2ass3 = Convert.ToInt32(cmbSAPADAss3N2.Text);
            sub2ass4 = Convert.ToInt32(cmbSAPADAss4N2.Text);
            sub2project = Convert.ToInt32(cmbSAPADP2.Text);

            total = sub2ass1 + sub2ass2 + sub2ass3 + sub2ass4 + sub2project;
            avg = total / 5;
            txtSAPADAvg2.Text = avg.ToString();
        }

        private void cmbSAPADAss1N2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal2();
        }

        private void cmbSAPADAss2N2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal2();
        }

        private void cmbSAPADAss3N2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal2();
        }

        private void cmbSAPADAss4N2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal2();
        }

        private void cmbSAPADP2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal2();
        }

        void cal3()
        {
            decimal sub3ass1, sub3ass2, sub3ass3, sub3ass4, sub3project, total, avg;
            sub3ass1 = Convert.ToInt32(cmbSAPADAss1N3.Text);
            sub3ass2 = Convert.ToInt32(cmbSAPADAss2N3.Text);
            sub3ass3 = Convert.ToInt32(cmbSAPADAss3N3.Text);
            sub3ass4 = Convert.ToInt32(cmbSAPADAss4N3.Text);
            sub3project = Convert.ToInt32(cmbSAPADP3.Text);

            total = sub3ass1 + sub3ass2 + sub3ass3 + sub3ass4 + sub3project;
            avg = total / 5;
            txtSAPADAvg3.Text = avg.ToString();
        }

        private void cmbSAPADAss1N3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal3();
        }

        private void cmbSAPADAss2N3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal3();
        }

        private void cmbSAPADAss3N3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal3();
        }

        private void cmbSAPADAss4N3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal3();
        }

        private void cmbSAPADP3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal3();
        }

        void cal4()
        {
            decimal sub4ass1, sub4ass2, sub4ass3, sub4ass4, sub4project, total, avg;
            sub4ass1 = Convert.ToInt32(cmbSAPADAss1N4.Text);
            sub4ass2 = Convert.ToInt32(cmbSAPADAss2N4.Text);
            sub4ass3 = Convert.ToInt32(cmbSAPADAss3N4.Text);
            sub4ass4 = Convert.ToInt32(cmbSAPADAss4N4.Text);
            sub4project = Convert.ToInt32(cmbSAPADP4.Text);

            total = sub4ass1 + sub4ass2 + sub4ass3 + sub4ass4 + sub4project;
            avg = total / 5;
            txtSAPADAvg4.Text = avg.ToString();
        }

        private void cmbSAPADAss1N4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal4();
        }

        private void cmbSAPADAss2N4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal4();
        }

        private void cmbSAPADAss3N4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal4();
        }

        private void cmbSAPADAss4N4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal4();
        }

        private void cmbSAPADP4_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal4();
        }

        void cal5()
        {
            decimal sub5ass1, sub5ass2, sub5ass3, sub5ass4, sub5project, total, avg;
            sub5ass1 = Convert.ToInt32(cmbSAPADAss1N5.Text);
            sub5ass2 = Convert.ToInt32(cmbSAPADAss2N5.Text);
            sub5ass3 = Convert.ToInt32(cmbSAPADAss3N5.Text);
            sub5ass4 = Convert.ToInt32(cmbSAPADAss4N5.Text);
            sub5project = Convert.ToInt32(cmbSAPADP5.Text);

            total = sub5ass1 + sub5ass2 + sub5ass3 + sub5ass4 + sub5project;
            avg = total / 5;
            txtSAPADAvg5.Text = avg.ToString();
        }

        private void cmbSAPADAss1N5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal5();
        }

        private void cmbSAPADAss2N5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal5();
        }

        private void cmbSAPADAss3N5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal5();
        }

        private void cmbSAPADAss4N5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal5();
        }

        private void cmbSAPADP5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal5();
        }

        void cal6()
        {
            decimal sub6ass1, sub6ass2, sub6ass3, sub6ass4, sub6project, total, avg;
            sub6ass1 = Convert.ToInt32(cmbSAPADAss1N6.Text);
            sub6ass2 = Convert.ToInt32(cmbSAPADAss2N6.Text);
            sub6ass3 = Convert.ToInt32(cmbSAPADAss3N6.Text);
            sub6ass4 = Convert.ToInt32(cmbSAPADAss4N6.Text);
            sub6project = Convert.ToInt32(cmbSAPADP6.Text);

            total = sub6ass1 + sub6ass2 + sub6ass3 + sub6ass4 + sub6project;
            avg = total / 5;
            txtSAPADAvg6.Text = avg.ToString();
        }

        private void cmbSAPADAss1N6_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal6();
        }

        private void cmbSAPADAss2N6_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal6();
        }

        private void cmbSAPADAss3N6_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal6();
        }

        private void cmbSAPADAss4N6_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal6();
        }

        private void cmbSAPADP6_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal6();
        }

        void cal7()
        {
            decimal sub7ass1, sub7ass2, sub7ass3, sub7ass4, sub7project, total, avg;
            sub7ass1 = Convert.ToInt32(cmbSAPADAss1N7.Text);
            sub7ass2 = Convert.ToInt32(cmbSAPADAss2N7.Text);
            sub7ass3 = Convert.ToInt32(cmbSAPADAss3N7.Text);
            sub7ass4 = Convert.ToInt32(cmbSAPADAss4N7.Text);
            sub7project = Convert.ToInt32(cmbSAPADP7.Text);

            total = sub7ass1 + sub7ass2 + sub7ass3 + sub7ass4 + sub7project;
            avg = total / 5;
            txtSAPADAvg7.Text = avg.ToString();
        }

        private void cmbSAPADAss1N7_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal7();
        }

        private void cmbSAPADAss2N7_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal7();
        }

        private void cmbSAPADAss3N7_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal7();
        }

        private void cmbSAPADAss4N7_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal7();
        }

        private void cmbSAPADP7_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal7();
        }

        void cal8()
        {
            decimal sub8ass1, sub8ass2, sub8ass3, sub8ass4, sub8project, total, avg;
            sub8ass1 = Convert.ToInt32(cmbSAPADAss1N8.Text);
            sub8ass2 = Convert.ToInt32(cmbSAPADAss2N8.Text);
            sub8ass3 = Convert.ToInt32(cmbSAPADAss3N8.Text);
            sub8ass4 = Convert.ToInt32(cmbSAPADAss4N8.Text);
            sub8project = Convert.ToInt32(cmbSAPADP8.Text);

            total = sub8ass1 + sub8ass2 + sub8ass3 + sub8ass4 + sub8project;
            avg = total / 5;
            txtSAPADAvg8.Text = avg.ToString();
        }

        private void cmbSAPADAss1N8_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal8();
        }

        private void cmbSAPADAss2N8_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal8();
        }

        private void cmbSAPADAss3N8_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal8();
        }

        private void cmbSAPADAss4N8_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal8();
        }

        private void cmbSAPADP8_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal8();
        }

        void cal9()
        {
            decimal sub9ass1, sub9ass2, sub9ass3, sub9ass4, sub9project, total, avg;
            sub9ass1 = Convert.ToInt32(cmbSAPADAss1N9.Text);
            sub9ass2 = Convert.ToInt32(cmbSAPADAss2N9.Text);
            sub9ass3 = Convert.ToInt32(cmbSAPADAss3N9.Text);
            sub9ass4 = Convert.ToInt32(cmbSAPADAss4N9.Text);
            sub9project = Convert.ToInt32(cmbSAPADP9.Text);

            total = sub9ass1 + sub9ass2 + sub9ass3 + sub9ass4 + sub9project;
            avg = total / 5;
            txtSAPADAvg9.Text = avg.ToString();
        }

        private void cmbSAPADAss1N9_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal9();
        }

        private void cmbSAPADAss2N9_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal9();
        }

        private void cmbSAPADAss3N9_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal9();
        }

        private void cmbSAPADAss4N9_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal9();
        }

        private void cmbSAPADP9_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal9();
        }

        void cal10()
        {
            decimal sub10ass1, sub10ass2, sub10ass3, sub10ass4, sub10project, total, avg;
            sub10ass1 = Convert.ToInt32(cmbSAPADAss1N10.Text);
            sub10ass2 = Convert.ToInt32(cmbSAPADAss2N10.Text);
            sub10ass3 = Convert.ToInt32(cmbSAPADAss3N10.Text);
            sub10ass4 = Convert.ToInt32(cmbSAPADAss4N10.Text);
            sub10project = Convert.ToInt32(cmbSAPADP10.Text);

            total = sub10ass1 + sub10ass2 + sub10ass3 + sub10ass4 + sub10project;
            avg = total / 5;
            txtSAPADAvg10.Text = avg.ToString();
        }

        private void cmbSAPADAss1N10_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal10();
        }

        private void cmbSAPADAss2N10_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal10();
        }

        private void cmbSAPADAss3N10_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal10();
        }

        private void cmbSAPADAss4N10_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal10();
        }

        private void cmbSAPADP10_SelectedIndexChanged(object sender, EventArgs e)
        {
            cal10();
        }

        private void btnAPADAdd_MouseHover_1(object sender, EventArgs e)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            conn.Open();
            String msql = "select registrationNo from AssignmentandProjectAllocationDetails";
            SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
            SqlCeDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                if (dr["registrationNo"].ToString().ToUpper() == cmbAPADRegNo.Text.ToUpper())
                {
                    MessageBox.Show("The Data is Exists. Data is required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.cmbAPADRegNo.Text = "";
                }
            }
        }
    }
}
