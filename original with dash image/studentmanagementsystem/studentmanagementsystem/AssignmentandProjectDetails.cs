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
    public partial class AssignmentandProjectDetails : Form
    {
        public AssignmentandProjectDetails()
        {
            InitializeComponent();
            FillTrade();
            
        }

        DashboardNew Back = new DashboardNew();
        sms smsclz = new sms();
        conlink sqlcon = new conlink();

        int record_no;
        String trade, course, sub1, t1ass1, p1ass1, t1ass2, p1ass2, t1ass3, p1ass3, t1ass4, p1ass4, pro1, viva1, sub2, t2ass1, p2ass1, t2ass2, p2ass2, t2ass3, p2ass3, t2ass4, p2ass4, pro2, viva2, sub3, t3ass1, p3ass1, t3ass2, p3ass2, t3ass3, p3ass3, t3ass4, p3ass4, pro3, viva3, sub4, t4ass1, p4ass1, t4ass2, p4ass2, t4ass3, p4ass3, t4ass4, p4ass4, pro4, viva4, sub5, t5ass1, p5ass1, t5ass2, p5ass2, t5ass3, p5ass3, t5ass4, p5ass4, pro5, viva5, sub6, t6ass1, p6ass1, t6ass2, p6ass2, t6ass3, p6ass3, t6ass4, p6ass4, pro6, viva6, sub7, t7ass1, p7ass1, t7ass2, p7ass2, t7ass3, p7ass3, t7ass4, p7ass4, pro7, viva7, sub8, t8ass1, p8ass1, t8ass2, p8ass2, t8ass3, p8ass3, t8ass4, p8ass4, pro8, viva8, sub9, t9ass1, p9ass1, t9ass2, p9ass2, t9ass3, p9ass3, t9ass4, p9ass4, pro9, viva9, sub10, t10ass1, p10ass1, t10ass2, p10ass2, t10ass3, p10ass3, t10ass4, p10ass4, pro10, viva10;

        void FillTrade()
        {
            try
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
                    cmbAPDTName.Items.Add(tName);
                }
                conn.Close();
                conn.Dispose();
            }
            catch
            {

            }
        }

        private void btnAPDAdd_Click(object sender, EventArgs e)
        {
            record_no = Convert.ToInt32(this.txtAPDRecNo.Text.Trim());

            if (cmbAPDTName.Text == "" || cmbAPDCName.Text == "")
            {
                MessageBox.Show("The Data is Empty. Data is required.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                trade = this.cmbAPDTName.SelectedItem.ToString();
                course = this.cmbAPDCName.SelectedItem.ToString();

                sub1 = this.txtAPDSName1.Text.Trim();
                t1ass1 = this.chbAPDT1Ass1.Text.Trim();
                p1ass1 = this.chbAPDP1Ass1.Text.Trim();
                t1ass2 = this.chbAPDT1Ass2.Text.Trim();
                p1ass2 = this.chbAPDP1Ass2.Text.Trim();
                t1ass3 = this.chbAPDT1Ass3.Text.Trim();
                p1ass3 = this.chbAPDP1Ass3.Text.Trim();
                t1ass4 = this.chbAPDT1Ass4.Text.Trim();
                p1ass4 = this.chbAPDP1Ass4.Text.Trim();
                pro1 = this.chbAPDPro1.Text.Trim();
                viva1 = this.chbAPDViva1.Text.Trim();

                sub2 = this.txtAPDSName2.Text.Trim();
                t2ass1 = this.chbAPDT2Ass1.Text.Trim();
                p2ass1 = this.chbAPDP2Ass1.Text.Trim();
                t2ass2 = this.chbAPDT2Ass2.Text.Trim();
                p2ass2 = this.chbAPDP2Ass2.Text.Trim();
                t2ass3 = this.chbAPDT2Ass3.Text.Trim();
                p2ass3 = this.chbAPDP2Ass3.Text.Trim();
                t2ass4 = this.chbAPDT2Ass4.Text.Trim();
                p2ass4 = this.chbAPDP2Ass4.Text.Trim();
                pro2 = this.chbAPDPro2.Text.Trim();
                viva2 = this.chbAPDViva2.Text.Trim();

                sub3 = this.txtAPDSName3.Text.Trim();
                t3ass1 = this.chbAPDT3Ass1.Text.Trim();
                p3ass1 = this.chbAPDP3Ass1.Text.Trim();
                t3ass2 = this.chbAPDT3Ass2.Text.Trim();
                p3ass2 = this.chbAPDP3Ass2.Text.Trim();
                t3ass3 = this.chbAPDT3Ass3.Text.Trim();
                p3ass3 = this.chbAPDP3Ass3.Text.Trim();
                t3ass4 = this.chbAPDT3Ass4.Text.Trim();
                p3ass4 = this.chbAPDP3Ass4.Text.Trim();
                pro3 = this.chbAPDPro3.Text.Trim();
                viva3 = this.chbAPDViva3.Text.Trim();

                sub4 = this.txtAPDSName4.Text.Trim();
                t4ass1 = this.chbAPDT4Ass1.Text.Trim();
                p4ass1 = this.chbAPDP4Ass1.Text.Trim();
                t4ass2 = this.chbAPDT4Ass2.Text.Trim();
                p4ass2 = this.chbAPDP4Ass2.Text.Trim();
                t4ass3 = this.chbAPDT4Ass3.Text.Trim();
                p4ass3 = this.chbAPDP4Ass3.Text.Trim();
                t4ass4 = this.chbAPDT4Ass4.Text.Trim();
                p4ass4 = this.chbAPDP4Ass4.Text.Trim();
                pro4 = this.chbAPDPro4.Text.Trim();
                viva4 = this.chbAPDViva4.Text.Trim();

                sub5 = this.txtAPDSName5.Text.Trim();
                t5ass1 = this.chbAPDT5Ass1.Text.Trim();
                p5ass1 = this.chbAPDP5Ass1.Text.Trim();
                t5ass2 = this.chbAPDT5Ass2.Text.Trim();
                p5ass2 = this.chbAPDP5Ass2.Text.Trim();
                t5ass3 = this.chbAPDT5Ass3.Text.Trim();
                p5ass3 = this.chbAPDP5Ass3.Text.Trim();
                t5ass4 = this.chbAPDT5Ass4.Text.Trim();
                p5ass4 = this.chbAPDP5Ass4.Text.Trim();
                pro5 = this.chbAPDPro5.Text.Trim();
                viva5 = this.chbAPDViva5.Text.Trim();

                sub6 = this.txtAPDSName6.Text.Trim();
                t6ass1 = this.chbAPDT6Ass1.Text.Trim();
                p6ass1 = this.chbAPDP6Ass1.Text.Trim();
                t6ass2 = this.chbAPDT6Ass2.Text.Trim();
                p6ass2 = this.chbAPDP6Ass2.Text.Trim();
                t6ass3 = this.chbAPDT6Ass3.Text.Trim();
                p6ass3 = this.chbAPDP6Ass3.Text.Trim();
                t6ass4 = this.chbAPDT6Ass4.Text.Trim();
                p6ass4 = this.chbAPDP6Ass4.Text.Trim();
                pro6 = this.chbAPDPro6.Text.Trim();
                viva6 = this.chbAPDViva6.Text.Trim();

                sub7 = this.txtAPDSName7.Text.Trim();
                t7ass1 = this.chbAPDT7Ass1.Text.Trim();
                p7ass1 = this.chbAPDP7Ass1.Text.Trim();
                t7ass2 = this.chbAPDT7Ass2.Text.Trim();
                p7ass2 = this.chbAPDP7Ass2.Text.Trim();
                t7ass3 = this.chbAPDT7Ass3.Text.Trim();
                p7ass3 = this.chbAPDP7Ass3.Text.Trim();
                t7ass4 = this.chbAPDT7Ass4.Text.Trim();
                p7ass4 = this.chbAPDP7Ass4.Text.Trim();
                pro7 = this.chbAPDPro7.Text.Trim();
                viva7 = this.chbAPDViva7.Text.Trim();

                sub8 = this.txtAPDSName8.Text.Trim();
                t8ass1 = this.chbAPDT8Ass1.Text.Trim();
                p8ass1 = this.chbAPDP8Ass1.Text.Trim();
                t8ass2 = this.chbAPDT8Ass2.Text.Trim();
                p8ass2 = this.chbAPDP8Ass2.Text.Trim();
                t8ass3 = this.chbAPDT8Ass3.Text.Trim();
                p8ass3 = this.chbAPDP8Ass3.Text.Trim();
                t8ass4 = this.chbAPDT8Ass4.Text.Trim();
                p8ass4 = this.chbAPDP8Ass4.Text.Trim();
                pro8 = this.chbAPDPro8.Text.Trim();
                viva8 = this.chbAPDViva8.Text.Trim();

                sub9 = this.txtAPDSName9.Text.Trim();
                t9ass1 = this.chbAPDT9Ass1.Text.Trim();
                p9ass1 = this.chbAPDP9Ass1.Text.Trim();
                t9ass2 = this.chbAPDT9Ass2.Text.Trim();
                p9ass2 = this.chbAPDP9Ass2.Text.Trim();
                t9ass3 = this.chbAPDT9Ass3.Text.Trim();
                p9ass3 = this.chbAPDP9Ass3.Text.Trim();
                t9ass4 = this.chbAPDT9Ass4.Text.Trim();
                p9ass4 = this.chbAPDP9Ass4.Text.Trim();
                pro9 = this.chbAPDPro9.Text.Trim();
                viva9 = this.chbAPDViva9.Text.Trim();

                sub10 = this.txtAPDSName10.Text.Trim();
                t10ass1 = this.chbAPDT10Ass1.Text.Trim();
                p10ass1 = this.chbAPDP10Ass1.Text.Trim();
                t10ass2 = this.chbAPDT10Ass2.Text.Trim();
                p10ass2 = this.chbAPDP10Ass2.Text.Trim();
                t10ass3 = this.chbAPDT10Ass3.Text.Trim();
                p10ass3 = this.chbAPDP10Ass3.Text.Trim();
                t10ass4 = this.chbAPDT10Ass4.Text.Trim();
                p10ass4 = this.chbAPDP10Ass4.Text.Trim();
                pro10 = this.chbAPDPro10.Text.Trim();
                viva10 = this.chbAPDViva10.Text.Trim();

                if (chbAPDT1Ass1.Checked == true)
                {
                    t1ass1 = "T";
                }
                if (chbAPDP1Ass1.Checked == true)
                {
                    p1ass1 = "P";
                }
                if (chbAPDT1Ass2.Checked == true)
                {
                    t1ass2 = "T";
                }
                if (chbAPDP1Ass2.Checked == true)
                {
                    p1ass2 = "P";
                }
                if (chbAPDT1Ass3.Checked == true)
                {
                    t1ass3 = "T";
                }
                if (chbAPDP1Ass3.Checked == true)
                {
                    p1ass3 = "P";
                }
                if (chbAPDT1Ass4.Checked == true)
                {
                    t1ass4 = "T";
                }
                if (chbAPDP1Ass4.Checked == true)
                {
                    p1ass4 = "P";
                }
                if (chbAPDPro1.Checked == true)
                {
                    pro1 = "Pro";
                }
                if (chbAPDViva1.Checked == true)
                {
                    viva1 = "V";
                }

                if (chbAPDT2Ass1.Checked == true)
                {
                    t2ass1 = "T";
                }
                if (chbAPDP2Ass1.Checked == true)
                {
                    p2ass1 = "P";
                }
                if (chbAPDT2Ass2.Checked == true)
                {
                    t2ass2 = "T";
                }
                if (chbAPDP2Ass2.Checked == true)
                {
                    p2ass2 = "P";
                }
                if (chbAPDT2Ass3.Checked == true)
                {
                    t2ass3 = "T";
                }
                if (chbAPDP2Ass3.Checked == true)
                {
                    p2ass3 = "P";
                }
                if (chbAPDT2Ass4.Checked == true)
                {
                    t2ass4 = "T";
                }
                if (chbAPDP2Ass4.Checked == true)
                {
                    p2ass4 = "P";
                }
                if (chbAPDPro2.Checked == true)
                {
                    pro2 = "Pro";
                }
                if (chbAPDViva2.Checked == true)
                {
                    viva2 = "V";
                }

                if (chbAPDT3Ass1.Checked == true)
                {
                    t3ass1 = "T";
                }
                if (chbAPDP3Ass1.Checked == true)
                {
                    p3ass1 = "P";
                }
                if (chbAPDT3Ass2.Checked == true)
                {
                    t3ass2 = "T";
                }
                if (chbAPDP3Ass2.Checked == true)
                {
                    p3ass2 = "P";
                }
                if (chbAPDT3Ass3.Checked == true)
                {
                    t3ass3 = "T";
                }
                if (chbAPDP3Ass3.Checked == true)
                {
                    p3ass3 = "P";
                }
                if (chbAPDT3Ass4.Checked == true)
                {
                    t3ass4 = "T";
                }
                if (chbAPDP3Ass4.Checked == true)
                {
                    p3ass4 = "P";
                }
                if (chbAPDPro3.Checked == true)
                {
                    pro3 = "Pro";
                }
                if (chbAPDViva3.Checked == true)
                {
                    viva3 = "V";
                }

                if (chbAPDT4Ass1.Checked == true)
                {
                    t4ass1 = "T";
                }
                if (chbAPDP4Ass1.Checked == true)
                {
                    p4ass1 = "P";
                }
                if (chbAPDT4Ass2.Checked == true)
                {
                    t4ass2 = "T";
                }
                if (chbAPDP4Ass2.Checked == true)
                {
                    p4ass2 = "P";
                }
                if (chbAPDT4Ass3.Checked == true)
                {
                    t4ass3 = "T";
                }
                if (chbAPDP4Ass3.Checked == true)
                {
                    p4ass3 = "P";
                }
                if (chbAPDT4Ass4.Checked == true)
                {
                    t4ass4 = "T";
                }
                if (chbAPDP4Ass4.Checked == true)
                {
                    p4ass4 = "P";
                }
                if (chbAPDPro4.Checked == true)
                {
                    pro4 = "Pro";
                }
                if (chbAPDViva4.Checked == true)
                {
                    viva4 = "V";
                }

                if (chbAPDT5Ass1.Checked == true)
                {
                    t5ass1 = "T";
                }
                if (chbAPDP5Ass1.Checked == true)
                {
                    p5ass1 = "P";
                }
                if (chbAPDT5Ass2.Checked == true)
                {
                    t5ass2 = "T";
                }
                if (chbAPDP5Ass2.Checked == true)
                {
                    p5ass2 = "P";
                }
                if (chbAPDT5Ass3.Checked == true)
                {
                    t5ass3 = "T";
                }
                if (chbAPDP5Ass3.Checked == true)
                {
                    p5ass3 = "P";
                }
                if (chbAPDT5Ass4.Checked == true)
                {
                    t5ass4 = "T";
                }
                if (chbAPDP5Ass4.Checked == true)
                {
                    p5ass4 = "P";
                }
                if (chbAPDPro5.Checked == true)
                {
                    pro5 = "Pro";
                }
                if (chbAPDViva5.Checked == true)
                {
                    viva5 = "V";
                }

                if (chbAPDT6Ass1.Checked == true)
                {
                    t6ass1 = "T";
                }
                if (chbAPDP6Ass1.Checked == true)
                {
                    p6ass1 = "P";
                }
                if (chbAPDT6Ass2.Checked == true)
                {
                    t6ass2 = "T";
                }
                if (chbAPDP6Ass2.Checked == true)
                {
                    p6ass2 = "P";
                }
                if (chbAPDT6Ass3.Checked == true)
                {
                    t6ass3 = "T";
                }
                if (chbAPDP6Ass3.Checked == true)
                {
                    p6ass3 = "P";
                }
                if (chbAPDT6Ass4.Checked == true)
                {
                    t6ass4 = "T";
                }
                if (chbAPDP6Ass4.Checked == true)
                {
                    p6ass4 = "P";
                }
                if (chbAPDPro6.Checked == true)
                {
                    pro6 = "Pro";
                }
                if (chbAPDViva6.Checked == true)
                {
                    viva6 = "V";
                }

                if (chbAPDT7Ass1.Checked == true)
                {
                    t7ass1 = "T";
                }
                if (chbAPDP7Ass1.Checked == true)
                {
                    p7ass1 = "P";
                }
                if (chbAPDT7Ass2.Checked == true)
                {
                    t7ass2 = "T";
                }
                if (chbAPDP7Ass2.Checked == true)
                {
                    p7ass2 = "P";
                }
                if (chbAPDT7Ass3.Checked == true)
                {
                    t7ass3 = "T";
                }
                if (chbAPDP7Ass3.Checked == true)
                {
                    p7ass3 = "P";
                }
                if (chbAPDT7Ass4.Checked == true)
                {
                    t7ass4 = "T";
                }
                if (chbAPDP7Ass4.Checked == true)
                {
                    p7ass4 = "P";
                }
                if (chbAPDPro7.Checked == true)
                {
                    pro7 = "Pro";
                }
                if (chbAPDViva7.Checked == true)
                {
                    viva7 = "V";
                }

                if (chbAPDT8Ass1.Checked == true)
                {
                    t8ass1 = "T";
                }
                if (chbAPDP8Ass1.Checked == true)
                {
                    p8ass1 = "P";
                }
                if (chbAPDT8Ass2.Checked == true)
                {
                    t8ass2 = "T";
                }
                if (chbAPDP8Ass2.Checked == true)
                {
                    p8ass2 = "P";
                }
                if (chbAPDT8Ass3.Checked == true)
                {
                    t8ass3 = "T";
                }
                if (chbAPDP8Ass3.Checked == true)
                {
                    p8ass3 = "P";
                }
                if (chbAPDT8Ass4.Checked == true)
                {
                    t8ass4 = "T";
                }
                if (chbAPDP8Ass4.Checked == true)
                {
                    p8ass4 = "P";
                }
                if (chbAPDPro8.Checked == true)
                {
                    pro8 = "Pro";
                }
                if (chbAPDViva8.Checked == true)
                {
                    viva8 = "V";
                }

                if (chbAPDT9Ass1.Checked == true)
                {
                    t9ass1 = "T";
                }
                if (chbAPDP9Ass1.Checked == true)
                {
                    p9ass1 = "P";
                }
                if (chbAPDT9Ass2.Checked == true)
                {
                    t9ass2 = "T";
                }
                if (chbAPDP9Ass2.Checked == true)
                {
                    p9ass2 = "P";
                }
                if (chbAPDT9Ass3.Checked == true)
                {
                    t9ass3 = "T";
                }
                if (chbAPDP9Ass3.Checked == true)
                {
                    p9ass3 = "P";
                }
                if (chbAPDT9Ass4.Checked == true)
                {
                    t9ass4 = "T";
                }
                if (chbAPDP9Ass4.Checked == true)
                {
                    p9ass4 = "P";
                }
                if (chbAPDPro9.Checked == true)
                {
                    pro9 = "Pro";
                }
                if (chbAPDViva9.Checked == true)
                {
                    viva9 = "V";
                }

                if (chbAPDT10Ass1.Checked == true)
                {
                    t10ass1 = "T";
                }
                if (chbAPDP10Ass1.Checked == true)
                {
                    p10ass1 = "P";
                }
                if (chbAPDT10Ass2.Checked == true)
                {
                    t10ass2 = "T";
                }
                if (chbAPDP10Ass2.Checked == true)
                {
                    p10ass2 = "P";
                }
                if (chbAPDT10Ass3.Checked == true)
                {
                    t10ass3 = "T";
                }
                if (chbAPDP10Ass3.Checked == true)
                {
                    p10ass3 = "P";
                }
                if (chbAPDT10Ass4.Checked == true)
                {
                    t10ass4 = "T";
                }
                if (chbAPDP10Ass4.Checked == true)
                {
                    p10ass4 = "P";
                }
                if (chbAPDPro10.Checked == true)
                {
                    pro10 = "Pro";
                }
                if (chbAPDViva10.Checked == true)
                {
                    viva10 = "V";
                }

                sms smsclz = new sms();
                this.txtAPDRecNo.Text = Convert.ToString(smsclz.AssignmentandProjectGetNextNo());
                smsclz.AssignmentandProjectAddData(record_no, trade, course, sub1, t1ass1, p1ass1, t1ass2, p1ass2, t1ass3, p1ass3, t1ass4, p1ass4, pro1, viva1, sub2, t2ass1, p2ass1, t2ass2, p2ass2, t2ass3, p2ass3, t2ass4, p2ass4, pro2, viva2, sub3, t3ass1, p3ass1, t3ass2, p3ass2, t3ass3, p3ass3, t3ass4, p3ass4, pro3, viva3, sub4, t4ass1, p4ass1, t4ass2, p4ass2, t4ass3, p4ass3, t4ass4, p4ass4, pro4, viva4, sub5, t5ass1, p5ass1, t5ass2, p5ass2, t5ass3, p5ass3, t5ass4, p5ass4, pro5, viva5, sub6, t6ass1, p6ass1, t6ass2, p6ass2, t6ass3, p6ass3, t6ass4, p6ass4, pro6, viva6, sub7, t7ass1, p7ass1, t7ass2, p7ass2, t7ass3, p7ass3, t7ass4, p7ass4, pro7, viva7, sub8, t8ass1, p8ass1, t8ass2, p8ass2, t8ass3, p8ass3, t8ass4, p8ass4, pro8, viva8, sub9, t9ass1, p9ass1, t9ass2, p9ass2, t9ass3, p9ass3, t9ass4, p9ass4, pro9, viva9, sub10, t10ass1, p10ass1, t10ass2, p10ass2, t10ass3, p10ass3, t10ass4, p10ass4, pro10, viva10);

                MessageBox.Show("Successfully Added Assignment and Project", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }

        private void Clear()
        {

            this.cmbAPDTName.Text = "";
            this.cmbAPDCName.Text = "";

            this.txtAPDSName1.Text = "";
            this.txtAPDSName2.Text = "";
            this.txtAPDSName3.Text = "";
            this.txtAPDSName4.Text = "";
            this.txtAPDSName5.Text = "";
            this.txtAPDSName6.Text = "";
            this.txtAPDSName7.Text = "";
            this.txtAPDSName8.Text = "";
            this.txtAPDSName9.Text = "";
            this.txtAPDSName10.Text = "";

            chbAPDT1Ass1.Checked = false;
            chbAPDP1Ass1.Checked = false;
            chbAPDT1Ass2.Checked = false;
            chbAPDP1Ass2.Checked = false;
            chbAPDT1Ass3.Checked = false;
            chbAPDP1Ass3.Checked = false;
            chbAPDT1Ass4.Checked = false;
            chbAPDP1Ass4.Checked = false;
            chbAPDPro1.Checked = false;
            chbAPDViva1.Checked = false;

            chbAPDT2Ass1.Checked = false;
            chbAPDP2Ass1.Checked = false;
            chbAPDT2Ass2.Checked = false;
            chbAPDP2Ass2.Checked = false;
            chbAPDT2Ass3.Checked = false;
            chbAPDP2Ass3.Checked = false;
            chbAPDT2Ass4.Checked = false;
            chbAPDP2Ass4.Checked = false;
            chbAPDPro2.Checked = false;
            chbAPDViva2.Checked = false;

            chbAPDT3Ass1.Checked = false;
            chbAPDP3Ass1.Checked = false;
            chbAPDT3Ass2.Checked = false;
            chbAPDP3Ass2.Checked = false;
            chbAPDT3Ass3.Checked = false;
            chbAPDP3Ass3.Checked = false;
            chbAPDT3Ass4.Checked = false;
            chbAPDP3Ass4.Checked = false;
            chbAPDPro3.Checked = false;
            chbAPDViva3.Checked = false;

            chbAPDT4Ass1.Checked = false;
            chbAPDP4Ass1.Checked = false;
            chbAPDT4Ass2.Checked = false;
            chbAPDP4Ass2.Checked = false;
            chbAPDT4Ass3.Checked = false;
            chbAPDP4Ass3.Checked = false;
            chbAPDT4Ass4.Checked = false;
            chbAPDP4Ass4.Checked = false;
            chbAPDPro4.Checked = false;
            chbAPDViva4.Checked = false;

            chbAPDT5Ass1.Checked = false;
            chbAPDP5Ass1.Checked = false;
            chbAPDT5Ass2.Checked = false;
            chbAPDP5Ass2.Checked = false;
            chbAPDT5Ass3.Checked = false;
            chbAPDP5Ass3.Checked = false;
            chbAPDT5Ass4.Checked = false;
            chbAPDP5Ass4.Checked = false;
            chbAPDPro5.Checked = false;
            chbAPDViva5.Checked = false;

            chbAPDT6Ass1.Checked = false;
            chbAPDP6Ass1.Checked = false;
            chbAPDT6Ass2.Checked = false;
            chbAPDP6Ass2.Checked = false;
            chbAPDT6Ass3.Checked = false;
            chbAPDP6Ass3.Checked = false;
            chbAPDT6Ass4.Checked = false;
            chbAPDP6Ass4.Checked = false;
            chbAPDPro6.Checked = false;
            chbAPDViva6.Checked = false;

            chbAPDT7Ass1.Checked = false;
            chbAPDP7Ass1.Checked = false;
            chbAPDT7Ass2.Checked = false;
            chbAPDP7Ass2.Checked = false;
            chbAPDT7Ass3.Checked = false;
            chbAPDP7Ass3.Checked = false;
            chbAPDT7Ass4.Checked = false;
            chbAPDP7Ass4.Checked = false;
            chbAPDPro7.Checked = false;
            chbAPDViva7.Checked = false;

            chbAPDT8Ass1.Checked = false;
            chbAPDP8Ass1.Checked = false;
            chbAPDT8Ass2.Checked = false;
            chbAPDP8Ass2.Checked = false;
            chbAPDT8Ass3.Checked = false;
            chbAPDP8Ass3.Checked = false;
            chbAPDT8Ass4.Checked = false;
            chbAPDP8Ass4.Checked = false;
            chbAPDPro8.Checked = false;
            chbAPDViva8.Checked = false;

            chbAPDT9Ass1.Checked = false;
            chbAPDP9Ass1.Checked = false;
            chbAPDT9Ass2.Checked = false;
            chbAPDP9Ass2.Checked = false;
            chbAPDT9Ass3.Checked = false;
            chbAPDP9Ass3.Checked = false;
            chbAPDT9Ass4.Checked = false;
            chbAPDP9Ass4.Checked = false;
            chbAPDPro9.Checked = false;
            chbAPDViva9.Checked = false;

            chbAPDT10Ass1.Checked = false;
            chbAPDP10Ass1.Checked = false;
            chbAPDT10Ass2.Checked = false;
            chbAPDP10Ass2.Checked = false;
            chbAPDT10Ass3.Checked = false;
            chbAPDP10Ass3.Checked = false;
            chbAPDT10Ass4.Checked = false;
            chbAPDP10Ass4.Checked = false;
            chbAPDPro10.Checked = false;
            chbAPDViva10.Checked = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Back.Show();
        }

        private void btnAPDClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void AssignmentandProjectDetails_Load(object sender, EventArgs e)
        {
            this.txtAPDSName1.Enabled = false;
            this.txtAPDSName2.Enabled = false;
            this.txtAPDSName3.Enabled = false;
            this.txtAPDSName4.Enabled = false;
            this.txtAPDSName5.Enabled = false;
            this.txtAPDSName6.Enabled = false;
            this.txtAPDSName7.Enabled = false;
            this.txtAPDSName8.Enabled = false;
            this.txtAPDSName9.Enabled = false;
            this.txtAPDSName10.Enabled = false;

            sms smsclz = new sms();
            this.txtAPDRecNo.Text = Convert.ToString(smsclz.AssignmentandProjectGetNextNo());
        }

        private void cmbAPDCName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string subjectDetails = this.cmbAPDCName.SelectedItem.ToString();
                SqlCeConnection conn2 = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd2 = new SqlCeCommand();
                String msql2 = " select * from subjectdetails where(course = '" + subjectDetails + "')";
                cmd2.CommandText = msql2;
                cmd2.Connection = conn2;
                conn2.Open();
                SqlCeDataReader dr1 = cmd2.ExecuteReader();
                while (dr1.Read())
                {
                    this.txtAPDSName1.Text = dr1[3].ToString();
                    this.txtAPDSName2.Text = dr1[4].ToString();
                    this.txtAPDSName3.Text = dr1[5].ToString();
                    this.txtAPDSName4.Text = dr1[6].ToString();
                    this.txtAPDSName5.Text = dr1[7].ToString();
                    this.txtAPDSName6.Text = dr1[8].ToString();
                    this.txtAPDSName7.Text = dr1[9].ToString();
                    this.txtAPDSName8.Text = dr1[10].ToString();
                    this.txtAPDSName9.Text = dr1[11].ToString();
                    this.txtAPDSName10.Text = dr1[12].ToString();

                }
                conn2.Close();
                conn2.Dispose();
            }
            catch
            {

            }
        }

        private void cmbAPDTName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.cmbAPDCName.Items.Clear();
                string trade = this.cmbAPDTName.SelectedItem.ToString();
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
                    cmbAPDCName.Items.Add(cName);

                }
                conn.Close();
                conn.Dispose();
            }
            catch
            {

            }
        }

        private void btnAPDUpload1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:/Student Management System -  Group G/MyFolder/");

        }

        private void btnAPDUpload2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:/Student Management System -  Group G/MyFolder/");

        }

        private void btnAPDUpload3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:/Student Management System -  Group G/MyFolder/");
        }

        private void btnAPDUpload4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:/Student Management System -  Group G/MyFolder/");
        }

        private void btnAPDUpload5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:/Student Management System -  Group G/MyFolder/");
        }

        private void btnAPDUpload6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:/Student Management System -  Group G/MyFolder/");
        }

        private void btnAPDUpload7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:/Student Management System -  Group G/MyFolder/");
        }

        private void btnAPDUpload8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:/Student Management System -  Group G/MyFolder/");
        }

        private void btnAPDUpload9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:/Student Management System -  Group G/MyFolder/");
        }

        private void btnAPDUpload10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:/Student Management System -  Group G/MyFolder/");
        }
    }
}
