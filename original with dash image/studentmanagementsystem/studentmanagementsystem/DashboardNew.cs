using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentmanagementsystem
{
    public partial class DashboardNew : Form
    {
        public DashboardNew()
        {
            InitializeComponent();
            //CustomizeDesign();
        }
        
        public void loadform(object Form)
        {
            if (this.panelOpen.Controls.Count > 0)
                this.panelOpen.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelOpen.Controls.Add(f);
            this.panelOpen.Tag = f;
            f.Show();

        }
        private void CustomizeDesign()
        {
            panelSubStaff.Visible = false;
            panelSubCourse.Visible = false;
            panelSubSubject.Visible = false;
            panelSubStudent.Visible = false;
            panelSubPayment.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubStaff.Visible == true)
                panelSubStaff.Visible = false;
            if (panelSubCourse.Visible == true)
                panelSubCourse.Visible = false;
            if (panelSubSubject.Visible == true)
                panelSubSubject.Visible = false;
            if (panelSubStudent.Visible == true)
                panelSubStudent.Visible = false;
            if (panelSubPayment.Visible == true)
                panelSubPayment.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubStaff);
        }
         //showSubMenu(panelSubStaff);
         //loadform(new CourseDetails());

       
        
      
      
        
        private void btnStudent_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelSubStudent);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
           // showSubMenu(panelSubPayment);
        }

        

        private void DashboardNew_Load(object sender, EventArgs e)
        {
            loadform(new Dashpanel());
        }

        private void btnStaffDetails_Click(object sender, EventArgs e)
        {
            loadform(new staffDetails());
            this.panelLeftInside.Visible = true;
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            loadform(new DepartmentDetails());
            this.panelLeftInside.Visible = true;
        }

        private void btnDesignationDtails_Click(object sender, EventArgs e)
        {
            loadform(new DesignationDetails());
            this.panelLeftInside.Visible = true;
        }

        private void btnCourseDetails_Click(object sender, EventArgs e)
        {
            loadform(new CourseDetails());
            this.panelLeftInside.Visible = true;
        }

        private void btnTrade_Click(object sender, EventArgs e)
        {
            loadform(new TradeDetails());
            this.panelLeftInside.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new CourseConductDetailscs());
            this.panelLeftInside.Visible = true;
        }

        private void btnPreQuali_Click(object sender, EventArgs e)
        {
            loadform(new CoursePreQualificationDetails());
        }


        private void btnSubjectCreate_Click(object sender, EventArgs e)
        {
            loadform(new SubjectDetails());
            this.panelLeftInside.Visible = true;
        }

        private void btnAssignemtCreate_Click(object sender, EventArgs e)
        {
            loadform(new AssignmentandProjectDetails());
            this.panelLeftInside.Visible = true;
        }

        private void btnAssignAllocation_Click(object sender, EventArgs e)
        {
            loadform(new AssignmentandProjectAllocationDetails());
            this.panelLeftInside.Visible = true;
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            loadform(new StudentRegistration());
            this.panelLeftInside.Visible = true;
        }

        private void btnExamDetails_Click(object sender, EventArgs e)
        {
            loadform(new ExamDetails());
            this.panelLeftInside.Visible = true;
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            loadform(new AttendanceDetails());
            this.panelLeftInside.Visible = true;
        }

        private void btnCertificate_Click(object sender, EventArgs e)
        {
            loadform(new CertificateDetails());
            this.panelLeftInside.Visible = true;
        }

        private void btnAddmission_Click(object sender, EventArgs e)
        {
            loadform(new AddmissionFee());
            this.panelLeftInside.Visible = true;
        }

        private void btnCourseFee_Click(object sender, EventArgs e)
        {
            loadform(new CourseFeePayment());
            this.panelLeftInside.Visible = true;
        }

        private void btnExamFee_Click(object sender, EventArgs e)
        {
            loadform(new ExamFee());
            this.panelLeftInside.Visible = true;
        }

        private void btnExamPayment_Click(object sender, EventArgs e)
        {
            loadform(new ExamPayment());
            this.panelLeftInside.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new Dashpanel());
            this.panelLeftInside.Visible = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
             
        }

       
    }
}
