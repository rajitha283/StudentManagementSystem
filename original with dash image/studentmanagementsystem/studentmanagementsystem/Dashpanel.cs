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
    public partial class Dashpanel : Form
    {
        public Dashpanel()
        {
            InitializeComponent();
            countStudents();
            countStaff();
            countCourse();
            displaydate();
        }

        sms smsclz = new sms();
        conlink sqlcon = new conlink();

      void countStudents()
      {
        
          try
            {
                lblTotalStudents.Text = "";


                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                conn.Open();
                string msql = "select count(record_no) from studentRegistration";
                SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
                Int32 count = Convert.ToInt32(cmd1.ExecuteScalar());
                if (count > 0)
                {
                    lblTotalStudents.Text = Convert.ToString(count.ToString()); //For example a Label
                }
                else
                {
                    lblTotalStudents.Text = "0";
                }


                
                conn.Close();
                conn.Dispose();
            }
            catch
            {

            }

      }
      void countStaff()
      {

          try
          {
              lblTotalStaff.Text = "";


              SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
              conn.Open();
              string msql = "select count(record_no) from staffdetails";
              SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
              Int32 count = Convert.ToInt32(cmd1.ExecuteScalar());
              if (count > 0)
              {
                  lblTotalStaff.Text = Convert.ToString(count.ToString()); //For example a Label
              }
              else
              {
                  lblTotalStaff.Text = "0";
              }



              conn.Close();
              conn.Dispose();
          }
          catch
          {

          }

      }

      void countCourse()
      {

          try
          {
              lblTotalCourse.Text = "";


              SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
              conn.Open();
              string msql = "select count(record_no) from coursedetails";
              SqlCeCommand cmd1 = new SqlCeCommand(msql, conn);
              Int32 count = Convert.ToInt32(cmd1.ExecuteScalar());
              if (count > 0)
              {
                  lblTotalCourse.Text = Convert.ToString(count.ToString()); //For example a Label
              }
              else
              {
                  lblTotalCourse.Text = "0";
              }



              conn.Close();
              conn.Dispose();
          }
          catch
          {

          }

      }
      void displaydate()
      {
          lblDisplayDate.Text = DateTime.Now.ToString();
      }



        
        //SqlConnection conn = new SqlConnection("ConnectionString");
        //conn.Open();
        //SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM table_name", conn);
        //Int32 count = Convert.ToInt32(comm.ExecuteScalar());
        //if (count > 0)
        //{
        //    lblCount.Text = Convert.ToString(count.ToString()); //For example a Label
        //}
        //else
        //{
        //    lblCount.Text = "0";
        //}
        //conn.Close(); //Remember close the connection
       

        
        

        

        

        

       

       
    }
}
