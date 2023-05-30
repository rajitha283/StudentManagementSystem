using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;

namespace studentmanagementsystem
{
    class sms
    {
        conlink sqlcon = new conlink();
        //Amilaa
        internal void conducAddData(int ConductNo, string conductName, string conductTime, string conductStatus)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = "insert into courseconductdetails values('" + ConductNo + "','" + conductName + "', '" + conductTime + "', '" + conductStatus + "')";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        public int conductGetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = "select max(record_no) from courseconductdetails";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    newNo = Convert.ToInt32(dr[0].ToString());
                }
                conn.Close();
                return (newNo + 1);
            }

            catch (Exception)
            {
                return 1;
            }
        }

        public int tradetGetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = "select max(record_no) from tradedetails";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    newNo = Convert.ToInt32(dr[0].ToString());
                }
                conn.Close();
                return (newNo + 1);
            }

            catch (Exception)
            {
                return 1;
            }
        }

        internal void tradeAddData(int tradeNo, string tradeName, string tradeNote)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = "insert into tradedetails values('" + tradeNo + "','" + tradeName + "', '" + tradeNote + "')";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }



        public int preQualiGetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = "select max(record_no) from prequalificationdetails";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    newNo = Convert.ToInt32(dr[0].ToString());
                }
                conn.Close();
                return (newNo + 1);
            }

            catch (Exception)
            {
                return 1;
            }
        }

        internal void preQualiAddData(int PreQualiNo, string PreQualiName, string PreQualiNote)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink); 
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = "insert into prequalificationdetails values('" + PreQualiNo + "','" + PreQualiName + "', '" + PreQualiNote + "')";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        public int courseGetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink); 
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = "select max(record_no) from coursedetails";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    newNo = Convert.ToInt32(dr[0].ToString());
                }
                conn.Close();
                return (newNo + 1);
            }

            catch (Exception)
            {
                return 1;
            }
        }
       
        internal void updatePreQualiData(int pQuliNo, string pQuliName, string pQuliNote)
        {
            
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                string msql = "UPDATE prequalificationdetails SET preQualificationName = '" + pQuliName + "' , preQualificationDescription = '" + pQuliNote + "' where (!(preQualificationName = '" + pQuliName + "') AND (preQualificationDescription != '" + pQuliNote + "'))";

                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                cmd1.ExecuteNonQuery();

                conn.Close();
                conn.Dispose();
            
        }

        internal void courseAddData(int RecordNo, string Trade, string cFName, string cShortN, string cType, string cYear, string cBatch, string cDuration, DateTime cStartDate, DateTime cEndDate, string cCode, string cFee, string cStatus, string cConductDay, string cConductTime, string PQualiName, string PQualiNote, int maxInstruct, int maxStudent)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink); 
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = "insert into coursedetails values('" + RecordNo + "','" + Trade + "', '" + cFName + "' , '" + cShortN + "','" + cType + "', '" + cYear + "' , '" + cBatch + "' , '" + cDuration + "','" + cStartDate + "', '" + cEndDate + "' , '" + cCode + "' , '" + cFee + "' , '" + cStatus + "','" + cConductDay + "', '" + cConductTime + "' , '" + PQualiName + "' , '" + PQualiNote + "','" + maxInstruct + "', '" + maxStudent + "' )";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        internal int[] GetCodeList()
        {
            int[] CList = new int[1000];
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink); 
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = "Select course_code from coursedetails";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;

            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            int x = 0;
            while (dr.Read())
            {
                CList[x] = Convert.ToInt32(dr[0].ToString());
                x++;
            }
            conn.Close();
            return CList;
        }
        //(c_code, Duration, StartDate, EndDate, Fee, status, ConductDay, ConductTime, pQualiName, pQualiNote, MaxInstruct, MaxStudent);

        internal void updateCourseData(string c_code, string Duration, DateTime StartDate, DateTime EndDate, string Fee, string status, string ConductDay, string ConductTime, string pQualiName, string pQualiNote, int MaxInstruct, int MaxStudent)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink); 
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msql = "UPDATE coursedetails SET duration = '" + Duration + "' , startdate = '" + StartDate + "', enddate = '" + EndDate + "' , fee = '" + Fee + "' , status = '" + status + "', conduct_days = '" + ConductDay + "',conduct_time = '" + ConductTime + "',preQualificationName = '" + pQualiName + "',preQualificationDescription = '" + pQualiNote + "',Max_No_Instructor = '" + MaxInstruct + "',Max_No_students = '" + MaxStudent + "'where course_code = '" + c_code + "'";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        internal void updatecourseconductData(string conductStatus, string Cconduct)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink); 
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msql = "UPDATE courseconductdetails SET conduct_status = '" + conductStatus + "' where record_no = '" + Cconduct + "'";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        internal void updateTradeData(string Tradeno, string tDescription)
        {
            SqlCeConnection conn = new SqlCeConnection("Data Source=C:/Users/User/Documents/studentmanagementsystem.sdf;Password='student@123'");
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msql = "UPDATE tradedetails SET t_description = '" + tDescription + "' where record_no = '" + Tradeno + "'";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }


        //Ishara
        //department details
        public void AddDepData(string DepNo, string DepName, string DepLocation, string DepStatus)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink); 
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msql = "insert into DepartmentDetails values('" + DepNo + "','" + DepName + "','" + DepLocation + "','" + DepStatus + "')";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }


        public int GetNextDepNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink); 
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = "select max(DepNo) from DepartmentDetails";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    newNo = Convert.ToInt32(dr[0].ToString());
                }
                conn.Close();
                return (newNo + 1);
            }

            catch (Exception)
            {
                return 1;
            }
        }


        internal int[] getDepList()
        {
            int[] DepList = new int[1000];
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink); 
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = "select DepNo from DepartmentDetails";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;

            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            int x = 0;
            while (dr.Read())
            {
                DepList[x] = Convert.ToInt32(dr[0].ToString());
                x++;
            }
            conn.Close();
            return DepList;
        }


        internal void updateDepData(string no1, string name1, string location1, string status1)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink); 
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msql = "UPDATE DepartmentDetails SET DepName='" + name1 + "',DepLocation='" + location1 + "',DepStatus='" + status1 + "'Where DepNo='" + no1 + "'";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        //designation details
        internal void AddDesData(string DesNo, string DesName, string DesAgelimit, string DesStatus, DateTime DesFrom, string DesDescription)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink); 
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msql = "insert into DesignationDetails values('" + DesNo + "','" + DesName + "','" + DesAgelimit + "','" + DesStatus + "','" + DesFrom + "','" + DesDescription + "')";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }


        internal void updateDesData(string no1, string name1, string age1, string status1, DateTime from1, string descrip1)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink); 
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msql = "UPDATE DesignationDetails SET DesName='" + name1 + "',DesAgeLimit='" + age1 + "',DesStatus='" + status1 + "',DesFrom='" + from1 + "',DesDescription='" + descrip1 + "'Where DesNo='" + no1 + "'";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }


        internal int[] getDesList()
        {
            int[] DesList = new int[1000];
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink); 
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = "select DesNo from DesignationDetails";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;

            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            int x = 0;
            while (dr.Read())
            {
                DesList[x] = Convert.ToInt32(dr[0].ToString());
                x++;
            }
            conn.Close();
            return DesList;
        }


        public int GetNextDesNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink); 
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = "select max(DesNo) from DesignationDetails";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    newNo = Convert.ToInt32(dr[0].ToString());
                }
                conn.Close();
                return (newNo + 1);
            }

            catch (Exception)
            {
                return 1;
            }
        }

       

        //WDAD
        internal void AddWDADData(string trade, string course_code, string course, double duration, string registrationNo, double AttMonth, int W1, int A1, int W2, int A2, int W3, int A3, int W4, int A4, int W5, int A5, int W6, int A6, int W7, int A7, int W8, int A8, int W9, int A9, int W10, int A10, int W11, int A11, int W12, int A12, int W13, int A13, int W14, int A14, int W15, int A15, int W16, int A16, int W17, int A17, int W18, int A18, int W19, int A19, int W20, int A20, int W21, int A21, int W22, int A22, int W23, int A23, int W24, int A24, int W25, int A25, int W26, int A26, int W27, int A27, int W28, int A28, int W29, int A29, int W30, int A30, int W31, int A31, int TotWorkingDays, int TotAttendedDays)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink); 
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msql = "insert into WorkingDaysAttendedDays values('" + trade + "','" + course_code + "','" + course + "','" + duration + "','" + registrationNo + "','" + AttMonth + "','" + W1 + "','" + A1 + "','" + W2 + "','" + A2 + "','" + W3 + "','" + A3 + "','" + W4 + "','" + A4 + "','" + W5 + "','" + A5 + "','" + W6 + "','" + A6 + "','" + W7 + "','" + A7 + "','" + W8 + "','" + A8 + "','" + W9 + "','" + A9 + "','" + W10 + "','" + A10 + "','" + W11 + "','" + A11 + "','" + W12 + "','" + A12 + "','" + W13 + "','" + A13 + "','" + W14 + "','" + A14 + "','" + W15 + "','" + A15 + "','" + W16 + "','" + A16 + "','" + W17 + "','" + A17 + "','" + W18 + "','" + A18 + "','" + W19 + "','" + A19 + "','" + W20 + "','" + A20 + "','" + W21 + "','" + A21 + "','" + W22 + "','" + A22 + "','" + W23 + "','" + A23 + "','" + W24 + "','" + A24 + "','" + W25 + "','" + A25 + "','" + W26 + "','" + A26 + "','" + W27 + "','" + A27 + "','" + W28 + "','" + A28 + "','" + W29 + "','" + A29 + "','" + W30 + "','" + A30 + "','" + W31 + "','" + A31 + "','" + TotWorkingDays + "','" + TotAttendedDays + "')";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }



        
        //Attendance
        internal void AddAtdata(string trade, string course_code, string course, double duration, string registrationNo, string fullName, double AttMonth, double AttWorkingDays, double AttAttendedDays, double AttMonthlyAvg, double AttFinalAvg, string AttStatus)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink); 
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msql = "insert into AttendanceDetails values('" + trade + "','" + course_code + "','" + course + "','" + duration + "','" + registrationNo + "','" + fullName + "','" + AttMonth + "','" + AttWorkingDays + "','" + AttAttendedDays + "','" + AttMonthlyAvg + "','" + AttFinalAvg + "','" + AttStatus + "')";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        
    


        //Dasuni

       public void AddSubjectDetailsData(int record_no, string trade, string course, string subject_1, string subject_2, string subject_3, string subject_4, string subject_5, string subject_6, string subject_7, string subject_8, string subject_9, string subject_10)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msql = "insert into SubjectDetails values('" + record_no + "','" + trade + "','" + course + "','" + subject_1 + "','" + subject_2 + "','" + subject_3 + "','" + subject_4 + "','" + subject_5 + "','" + subject_6 + "','" + subject_7 + "','" + subject_8 + "','" + subject_9 + "','" + subject_10 + "')";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        public void UpdateSubjectData(int record_no, string trade, string course, string subject_1, string subject_2, string subject_3, string subject_4, string subject_5, string subject_6, string subject_7, string subject_8, string subject_9, string subject_10)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msql = "UPDATE SubjectDetails SET trade = '" + trade + "' , course = '" + course + "', subject_1 = '" + subject_1 + "' , subject_2 = '" + subject_2 + "' , subject_3 = '" + subject_3 + "', subject_4 = '" + subject_4 + "', subject_5 = '" + subject_5 + "', subject_6 = '" + subject_6 + "', subject_7 = '" + subject_7 + "', subject_8 = '" + subject_8 + "', subject_9 = '" + subject_9 + "', subject_10 = '" + subject_10 + "'where record_no = '" + record_no + "'";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }
       
        public int SubjectGetNextNo()
        {
            try
            {
                int record_no = 0;
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = "select max(record_no) from SubjectDetails";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    record_no = Convert.ToInt32(dr[0].ToString());
                }
                conn.Close();
                return (record_no + 1);
            }

            catch (Exception)
            {
                return 1;
            }
        }

        public int AssignmentandProjectGetNextNo()
        {
            try
            {
                int record_no = 0;
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = "select max(record_no) from AssignmentandProjectDetails";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    record_no = Convert.ToInt32(dr[0].ToString());
                }
                conn.Close();
                return (record_no + 1);
            }

            catch (Exception)
            {
                return 1;
            }
        }

        public void AssignmentandProjectAddData(int record_no, string trade, string course, string sub1, string t1ass1, string p1ass1, string t1ass2, string p1ass2, string t1ass3, string p1ass3, string t1ass4, string p1ass4, string pro1, string viva1, string sub2, string t2ass1, string p2ass1, string t2ass2, string p2ass2, string t2ass3, string p2ass3, string t2ass4, string p2ass4, string pro2, string viva2, string sub3, string t3ass1, string p3ass1, string t3ass2, string p3ass2, string t3ass3, string p3ass3, string t3ass4, string p3ass4, string pro3, string viva3, string sub4, string t4ass1, string p4ass1, string t4ass2, string p4ass2, string t4ass3, string p4ass3, string t4ass4, string p4ass4, string pro4, string viva4, string sub5, string t5ass1, string p5ass1, string t5ass2, string p5ass2, string t5ass3, string p5ass3, string t5ass4, string p5ass4, string pro5, string viva5, string sub6, string t6ass1, string p6ass1, string t6ass2, string p6ass2, string t6ass3, string p6ass3, string t6ass4, string p6ass4, string pro6, string viva6, string sub7, string t7ass1, string p7ass1, string t7ass2, string p7ass2, string t7ass3, string p7ass3, string t7ass4, string p7ass4, string pro7, string viva7, string sub8, string t8ass1, string p8ass1, string t8ass2, string p8ass2, string t8ass3, string p8ass3, string t8ass4, string p8ass4, string pro8, string viva8, string sub9, string t9ass1, string p9ass1, string t9ass2, string p9ass2, string t9ass3, string p9ass3, string t9ass4, string p9ass4, string pro9, string viva9, string sub10, string t10ass1, string p10ass1, string t10ass2, string p10ass2, string t10ass3, string p10ass3, string t10ass4, string p10ass4, string pro10, string viva10)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msql = "insert into AssignmentandProjectDetails values('" + record_no + "','" + trade + "','" + course + "','" + sub1 + "','" + t1ass1 + "','" + p1ass1 + "','" + t1ass2 + "','" + p1ass2 + "','" + t1ass3 + "','" + p1ass3 + "','" + t1ass4 + "','" + p1ass4 + "','" + pro1 + "','" + viva1 + "','" + sub2 + "','" + t2ass1 + "','" + p2ass1 + "','" + t2ass2 + "','" + p2ass2 + "','" + t2ass3 + "','" + p2ass3 + "','" + t2ass4 + "','" + p2ass4 + "','" + pro2 + "','" + viva2 + "','" + sub3 + "','" + t3ass1 + "','" + p3ass1 + "','" + t3ass2 + "','" + p3ass2 + "','" + t3ass3 + "','" + p3ass3 + "','" + t3ass4 + "','" + p3ass4 + "','" + pro3 + "','" + viva3 + "','" + sub4 + "','" + t4ass1 + "','" + p4ass1 + "','" + t4ass2 + "','" + p4ass2 + "','" + t4ass3 + "','" + p4ass3 + "','" + t4ass4 + "','" + p4ass4 + "','" + pro4 + "','" + viva4 + "','" + sub5 + "','" + t5ass1 + "','" + p5ass1 + "','" + t5ass2 + "','" + p5ass2 + "','" + t5ass3 + "','" + p5ass3 + "','" + t5ass4 + "','" + p5ass4 + "','" + pro5 + "','" + viva5 + "','" + sub6 + "','" + t6ass1 + "','" + p6ass1 + "','" + t6ass2 + "','" + p6ass2 + "','" + t6ass3 + "','" + p6ass3 + "','" + t6ass4 + "','" + p6ass4 + "','" + pro6 + "','" + viva6 + "','" + sub7 + "','" + t7ass1 + "','" + p7ass1 + "','" + t7ass2 + "','" + p7ass2 + "','" + t7ass3 + "','" + p7ass3 + "','" + t7ass4 + "','" + p7ass4 + "','" + pro7 + "','" + viva7 + "','" + sub8 + "','" + t8ass1 + "','" + p8ass1 + "','" + t8ass2 + "','" + p8ass2 + "','" + t8ass3 + "','" + p8ass3 + "','" + t8ass4 + "','" + p8ass4 + "','" + pro8 + "','" + viva8 + "','" + sub9 + "','" + t9ass1 + "','" + p9ass1 + "','" + t9ass2 + "','" + p9ass2 + "','" + t9ass3 + "','" + p9ass3 + "','" + t9ass4 + "','" + p9ass4 + "','" + pro9 + "','" + viva9 + "','" + sub10 + "','" + t10ass1 + "','" + p10ass1 + "','" + t10ass2 + "','" + p10ass2 + "','" + t10ass3 + "','" + p10ass3 + "','" + t10ass4 + "','" + p10ass4 + "','" + pro10 + "','" + viva10 + "')";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        public void AssignmentandProjectAllocationAddData(string registrationNo, int year, string trade, string course, string sub1name, string sub1ass1, string sub1ass2, string sub1ass3, string sub1ass4, string sub1project, string sub1avg, string sub2name, string sub2ass1, string sub2ass2, string sub2ass3, string sub2ass4, string sub2project, string sub2avg, string sub3name, string sub3ass1, string sub3ass2, string sub3ass3, string sub3ass4, string sub3project, string sub3avg, string sub4name, string sub4ass1, string sub4ass2, string sub4ass3, string sub4ass4, string sub4project, string sub4avg, string sub5name, string sub5ass1, string sub5ass2, string sub5ass3, string sub5ass4, string sub5project, string sub5avg, string sub6name, string sub6ass1, string sub6ass2, string sub6ass3, string sub6ass4, string sub6project, string sub6avg, string sub7name, string sub7ass1, string sub7ass2, string sub7ass3, string sub7ass4, string sub7project, string sub7avg, string sub8name, string sub8ass1, string sub8ass2, string sub8ass3, string sub8ass4, string sub8project, string sub8avg, string sub9name, string sub9ass1, string sub9ass2, string sub9ass3, string sub9ass4, string sub9project, string sub9avg, string sub10name, string sub10ass1, string sub10ass2, string sub10ass3, string sub10ass4, string sub10project, string sub10avg, string totalavg, string status)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msql = "insert into AssignmentandProjectAllocationDetails values('" + registrationNo + "','" + year + "','" + trade + "','" + course + "','" + sub1name + "','" + sub1ass1 + "','" + sub1ass2 + "','" + sub1ass3 + "','" + sub1ass4 + "','" + sub1project + "','" + sub1avg + "','" + sub2name + "','" + sub2ass1 + "','" + sub2ass2 + "','" + sub2ass3 + "','" + sub2ass4 + "','" + sub2project + "','" + sub2avg + "','" + sub3name + "','" + sub3ass1 + "','" + sub3ass2 + "','" + sub3ass3 + "','" + sub3ass4 + "','" + sub3project + "', '" + sub3avg + "','" + sub4name + "','" + sub4ass1 + "','" + sub4ass2 + "','" + sub4ass3 + "','" + sub4ass4 + "','" + sub4project + "','" + sub4avg + "','" + sub5name + "','" + sub5ass1 + "','" + sub5ass2 + "','" + sub5ass3 + "','" + sub5ass4 + "','" + sub5project + "','" + sub5avg + "','" + sub6name + "','" + sub6ass1 + "','" + sub6ass2 + "','" + sub6ass3 + "','" + sub6ass4 + "','" + sub6project + "','" + sub6avg + "','" + sub7name + "','" + sub7ass1 + "','" + sub7ass2 + "','" + sub7ass3 + "','" + sub7ass4 + "','" + sub7project + "','" + sub7avg + "','" + sub8name + "','" + sub8ass1 + "','" + sub8ass2 + "','" + sub8ass3 + "','" + sub8ass4 + "','" + sub8project + "','" + sub8avg + "','" + sub9name + "','" + sub9ass1 + "','" + sub9ass2 + "','" + sub9ass3 + "','" + sub9ass4 + "','" + sub9project + "','" + sub9avg + "','" + sub10name + "','" + sub10ass1 + "','" + sub10ass2 + "','" + sub10ass3 + "','" + sub10ass4 + "','" + sub10project + "','" + sub10avg + "','" + totalavg + "','" + status + "')";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        public void UpdateData(string registrationNo, int year, string trade, string course, string sub1name, string sub1ass1, string sub1ass2, string sub1ass3, string sub1ass4, string sub1project, string sub1avg, string sub2name, string sub2ass1, string sub2ass2, string sub2ass3, string sub2ass4, string sub2project, string sub2avg, string sub3name, string sub3ass1, string sub3ass2, string sub3ass3, string sub3ass4, string sub3project, string sub3avg, string sub4name, string sub4ass1, string sub4ass2, string sub4ass3, string sub4ass4, string sub4project, string sub4avg, string sub5name, string sub5ass1, string sub5ass2, string sub5ass3, string sub5ass4, string sub5project, string sub5avg, string sub6name, string sub6ass1, string sub6ass2, string sub6ass3, string sub6ass4, string sub6project, string sub6avg, string sub7name, string sub7ass1, string sub7ass2, string sub7ass3, string sub7ass4, string sub7project, string sub7avg, string sub8name, string sub8ass1, string sub8ass2, string sub8ass3, string sub8ass4, string sub8project, string sub8avg, string sub9name, string sub9ass1, string sub9ass2, string sub9ass3, string sub9ass4, string sub9project, string sub9avg, string sub10name, string sub10ass1, string sub10ass2, string sub10ass3, string sub10ass4, string sub10project, string sub10avg, string totalavg, string status)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msql = "UPDATE assignmentandprojectallocationdetails SET year ='" + year + "',trade ='" + trade + "',course ='" + course + "',sub1name ='" + sub1name + "',sub1ass1 ='" + sub1ass1 + "',sub1ass2 ='" + sub1ass2 + "',sub1ass3 ='" + sub1ass3 + "',sub1ass4 ='" + sub1ass4 + "',sub1project ='" + sub1project + "',sub1avg ='" + sub1avg + "',sub2name ='" + sub2name + "',sub2ass1 ='" + sub2ass1 + "',sub2ass2 ='" + sub2ass2 + "',sub2ass3 ='" + sub2ass3 + "',sub2ass4 ='" + sub2ass4 + "',sub2project ='" + sub2project + "',sub2avg ='" + sub2avg + "',sub3name ='" + sub3name + "',sub3ass1 ='" + sub3ass1 + "',sub3ass2 ='" + sub3ass2 + "',sub3ass3 ='" + sub3ass3 + "',sub3ass4 ='" + sub3ass4 + "',sub3project ='" + sub3project + "',sub3avg ='" + sub3avg + "',sub4name ='" + sub4name + "',sub4ass1 ='" + sub4ass1 + "',sub4ass2 ='" + sub4ass2 + "',sub4ass3 ='" + sub4ass3 + "',sub4ass4 ='" + sub4ass4 + "',sub4project ='" + sub4project + "',sub4avg ='" + sub4avg + "',sub5name ='" + sub5name + "',sub5ass1 ='" + sub5ass1 + "',sub5ass2 ='" + sub5ass2 + "',sub5ass3 ='" + sub5ass3 + "',sub5ass4 ='" + sub5ass4 + "',sub5project ='" + sub5project + "',sub5avg ='" + sub5avg + "',sub6name ='" + sub6name + "',sub6ass1 ='" + sub6ass1 + "',sub6ass2 ='" + sub6ass2 + "',sub6ass3 ='" + sub6ass3 + "',sub6ass4 ='" + sub6ass4 + "',sub6project ='" + sub6project + "',sub6avg ='" + sub6avg + "',sub7name ='" + sub7name + "',sub7ass1 ='" + sub7ass1 + "',sub7ass2 ='" + sub7ass2 + "',sub7ass3 ='" + sub7ass3 + "',sub7ass4 ='" + sub7ass4 + "',sub7project ='" + sub7project + "',sub7avg ='" + sub7avg + "',sub8name ='" + sub8name + "',sub8ass1 ='" + sub8ass1 + "',sub8ass2 ='" + sub8ass2 + "',sub8ass3 ='" + sub8ass3 + "',sub8ass4 ='" + sub8ass4 + "',sub8project ='" + sub8project + "',sub8avg ='" + sub8avg + "',sub9name ='" + sub9name + "',sub9ass1 ='" + sub9ass1 + "',sub9ass2 ='" + sub9ass2 + "',sub9ass3 ='" + sub9ass3 + "',sub9ass4 ='" + sub9ass4 + "',sub9project ='" + sub9project + "',sub9avg ='" + sub9avg + "',sub10name ='" + sub10name + "',sub10ass1 ='" + sub10ass1 + "',sub10ass2 ='" + sub10ass2 + "',sub10ass3 ='" + sub10ass3 + "',sub10ass4 ='" + sub10ass4 + "',sub10project ='" + sub10project + "',sub10avg ='" + sub10avg + "',totalavg ='" + totalavg + "',status ='" + status + "'where registrationNo = '" + registrationNo + "'";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

    

        //Asiri
        public int ExamFeeGetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = "select max(record_no) from ExamFeeDetails";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    newNo = Convert.ToInt32(dr[0].ToString());
                }
                conn.Close();
                return (newNo + 1);
            }

            catch (Exception)
            {
                return 1;
            }
        }

        internal void examfeeAddData(int RecNo, string year, string fee, DateTime date, string status, string description)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = "insert into ExamFeeDetails (record_no,year,fee,startdate,status,description) values('" + RecNo + "','" + year + "', '" + fee + "', '" + date + "','" + status + "','" + description + "')";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        public int AdFeeGetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = "select max(record_no) from AdmissionFeeDetails";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    newNo = Convert.ToInt32(dr[0].ToString());
                }
                conn.Close();
                return (newNo + 1);
            }

            catch (Exception)
            {
                return 1;
            }
        }

        public int ExamPayGetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = "select max(record_no) from ExamPaymentDetails";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    newNo = Convert.ToInt32(dr[0].ToString());
                }
                conn.Close();
                return (newNo + 1);
            }

            catch (Exception)
            {
                return 1;
            }
        }

        internal void AdFeeAddData(int RecNo, string year, string amount, DateTime date, string status, string description)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = "insert into AdmissionFeeDetails (record_no,year,amount,startdate,status,description) values('" + RecNo + "','" + year + "', '" + amount + "', '" + date + "','" + status + "','" + description + "')";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        internal void CFeeAddData(string reg_no, DateTime regDate, string fname, string year, string trade, string ccode, string cname, string fee, string duration, DateTime sdate, DateTime edate, string amount, DateTime ad_date, string ad_status, string in1_fee, DateTime in1_date, string in1_status, string in2_fee, DateTime in2_date, string in2_status, string in3_fee, DateTime in3_date, string in3_status, string bal, string status)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            var dateTimeFormat = "yyyy-MM-dd";
            String msql = "insert into CourseFeePaymentDetails (registrationNo,fullName,registrationDate,year,trade,course_code,short_name,fee,duration,startdate,enddate,amount,admission_date,admission_status,ins1_fee,ins1_date,ins1_status,ins2_fee,ins2_date,ins2_status,ins3_fee,ins3_date,ins3_status,balance,status) " +
                " values('" + reg_no + "','" + fname + "', '" + regDate.ToString(dateTimeFormat) + "', '" + year + "','" + trade + "','" + ccode + "' ,'" + cname + "' ,'" + fee + "' ,'" + duration + "'  ,'" + sdate.ToString(dateTimeFormat) + "' ,'" + edate.ToString(dateTimeFormat) + "' ,'" + amount + "' ,'" + ad_date.ToString(dateTimeFormat) + "' ,'" + ad_status + "' ,'" + in1_fee + "' ,'" + in1_date.ToString(dateTimeFormat) + "' ,'" + in1_status + "','" + in2_fee + "' ,'" + in2_date.ToString(dateTimeFormat) + "' ,'" + in2_status + "','" + in3_fee + "' ,'" + in3_date.ToString(dateTimeFormat) + "' ,'" + in3_status + "','" + bal + "','" + status + "')";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        internal void ExFeeAddData(string regno, string fname, string regdate, string year, string trade, string cname, string sdate, string edate, string duration, string cpay, string adpay, string ass_status, string shy1_status, string shy2_fee, string shy2_date, string shy2_pstatus, string shy2_status, string shy3_fee, string shy3_date, string shy3_pstatus, string exam_status)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = "insert into ExamPaymentDetails (registrationNo,fullName,registrationDate,year,trade,short_name,duration,startdate,enddate,ass_status,admission_status,status,1shy_exam_status,2shy_fee,2shy_date,2shy_status,2shy_exam_status,3shy_fee,3shy_date,3shy_status,exam_status) values('" + regno + "','" + fname + "', '" + regdate + "', '" + year + "','" + trade + "','" + cname + "' ,'" + duration + "'  ,'" + sdate + "' ,'" + edate + "' ,'" + ass_status + "' ,'" + adpay + "' ,'" + cpay + "' ,'" + shy1_status + "' ,'" + shy2_fee + "','" + shy2_date + "','" + shy2_pstatus + "','" + shy2_status + "','" + shy3_fee + "','" + shy3_date + "','" + shy3_pstatus + "','" + exam_status + "')";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }


        internal int[] getstdList()
        {
            int[] DesList = new int[1000];
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            String msql = "select registrationNo from studentRegistration";
            cmd1.CommandText = msql;
            cmd1.Connection = conn;

            conn.Open();
            SqlCeDataReader dr = cmd1.ExecuteReader();
            int x = 0;
            while (dr.Read())
            {
                DesList[x] = Convert.ToInt32(dr[0].ToString());
                x++;
            }
            conn.Close();
            return DesList;
        }

        internal void CFeeUpdateData(string reg_no, string in1_status, string in2_status, string in3_status, string bal, string status)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();

            var msql = "UPDATE CourseFeePaymentDetails SET ins1_status='" + in1_status + "', ins2_status='" + in2_status + "', ins3_status='" + in3_status + "', balance='" + bal + "', status='" + status + "' WHERE registrationNo = '" + reg_no + "'";

            cmd1.CommandText = msql;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }
    
        //Rajitha
        internal void cetiaddData(string cdrecno, string cdregno, string cdname, string cdnicno, string cdcourse, string cdtrade, string cdyear, string cdsdate, string cdedate, string cdexmstate, string cdocetno, DateTime cdoissdate, string cdostatus, string cddreason, string cddcetino, DateTime cddissdate, string cddstatus)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msq1 = "insert into certificatedetails values('" + cdregno + "', '" + cdname + "', '" + cdnicno + "', '" + cdcourse + "', '" + cdtrade + "', '" + cdyear + "', '" + cdsdate + "', '" + cdedate + "', '" + cdexmstate + "', '" + cdocetno + "', '" + cdoissdate + "', '" + cdostatus + "', '" + cddreason + "', '" + cddcetino + "', '" + cddissdate + "', '" + cddstatus + "', '" + cdrecno + "' )";

            cmd1.CommandText = msq1;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        public int cetifictGetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = "select max(record_no) from certificatedetails";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    newNo = Convert.ToInt32(dr[0].ToString());
                }
                conn.Close();
                return (newNo + 1);
            }

            catch (Exception)
            {
                return 1;
            }
        }


        internal void staffdeaddData(string sfrecno, string sfinm, string sffnm, string sfgender, DateTime sfdob, string sfnic, string sfcon1, string sfcon2, string peraddrs, string reciaddrs, string sfemil, string sfepfno, string sftype, string sfcourse, string sfinstco, string sfalloct, string sfdept, string sfdesig, DateTime sfappodt, string sfstatus, string sfdscrp, string sfolstat, string sfoldscrp, string sfalstat, string sfaldscrp, string sfothrstat, string shothrdscrp)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msq1 = "insert into staffdetails values('" + sfinm + "', '" + sffnm + "', '" + sfgender + "','" + sfdob + "', '" + sfnic + "', '" + sfcon1 + "', '" + sfcon2 + "', '" + peraddrs + "', '" + reciaddrs + "', '" + sfemil + "', '" + sfepfno + "', '" + sftype + "', '" + sfcourse + "', '" + sfinstco + "', '" + sfalloct + "', '" + sfdept + "', '" + sfdesig + "', '" + sfappodt + "', '" + sfstatus + "', '" + sfdscrp + "', '" + sfrecno + "', '" + sfolstat + "', '" + sfoldscrp + "', '" + sfalstat + "', '" + sfaldscrp + "', '" + sfothrstat + "', '" + shothrdscrp + "' )";

            cmd1.CommandText = msq1;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        internal int staffdeGetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = "select max(record_no) from staffdetails";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    newNo = Convert.ToInt32(dr[0].ToString());
                }
                conn.Close();
                return (newNo + 1);
            }

            catch (Exception)
            {
                return 1;
            }
        }

        internal void sturegaddData(string srrecno, string sryear, string srtrade, string srfee, string srduration, string srcourse, string srccode, string srcount, string srsdate, string sredate, string srregno, string srfname, string sriname, string srgender, DateTime srdob, string srnic, string srcontno1, string srcontno2, string srprmntad, string srrecsdd, string sremail, string srgardnm, string srgardadd, string srgardconno1, string srgardconno2, string srpqnm, string srpqdesc, string srpqstat, DateTime srregdate, string srstat, string srdecs, string sradminfee, string srtotfee, string srgtype)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msq1 = "insert into studentRegistration values('" + srrecno + "', '" + sryear + "', '" + srtrade + "', '" + srfee + "', '" + srduration + "', '" + srcourse + "', '" + srccode + "', '" + srcount + "' , '" + srsdate + "', '" + sredate + "', '" + srregno + "', '" + srfname + "', '" + sriname + "', '" + srgender + "', '" + srdob + "', '" + srnic + "', '" + srcontno1 + "', '" + srcontno2 + "', '" + srprmntad + "', '" + srrecsdd + "', '" + sremail + "', '" + srgardnm + "', '" + srgardadd + "', '" + srgardconno1 + "', '" + srgardconno2 + "', '" + srpqnm + "', '" + srpqdesc + "', '" + srpqstat + "', '" + srregdate + "', '" + srstat + "', '" + srdecs + "', '" + sradminfee + "', '" + srtotfee + "', '" + srgtype + "')";

            cmd1.CommandText = msq1;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        internal int sturegGetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = "select max(record_no) from studentRegistration";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    newNo = Convert.ToInt32(dr[0].ToString());
                }
                conn.Close();
                return (newNo + 1);
            }

            catch (Exception)
            {
                return 1;
            }
        }


        internal void examdeaddData(string edregno, string edname, string ednicno, string edyear, string edtrade, string edcourse, string edsdate, string ededate, string edattstat, string edassigstat, string edexamstat, DateTime ed1tdate, string ed1tstat, DateTime ed1pdate, string ed1pstat, string ed1fstat, DateTime ed2tdate, string ed2tstat, DateTime ed2pdate, string ed2pstat, string ed2fstat, DateTime ed3tdate, string ed3tstat, DateTime ed3pdate, string ed3pstat, string ed3fstat, string edrecno)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msq1 = "insert into examdetails values('" + edregno + "','" + edname + "','" + ednicno + "','" + edyear + "','" + edtrade + "','" + edcourse + "','" + edsdate + "','" + ededate + "','" + edattstat + "','" + edassigstat + "','" + edexamstat + "','" + ed1tdate + "', '" + ed1tstat + "', '" + ed1pdate + "','" + ed1pstat + "','" + ed1fstat + "','" + ed2tdate + "','" + ed2tstat + "', '" + ed2pdate + "', '" + ed2pstat + "','" + ed2fstat + "','" + ed3tdate + "','" + ed3tstat + "','" + ed3pdate + "','" + ed3pstat + "','" + ed3fstat + "', '" + edrecno + "')";

            cmd1.CommandText = msq1;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();

            conn.Close();
            conn.Dispose();
        }

        internal int examdeGetNextNo()
        {
            try
            {
                int newNo = 0;
                SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
                SqlCeCommand cmd1 = new SqlCeCommand();
                String msql = "select max(record_no) from examdetails";
                cmd1.CommandText = msql;
                cmd1.Connection = conn;
                conn.Open();
                SqlCeDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    newNo = Convert.ToInt32(dr[0].ToString());
                }
                conn.Close();
                return (newNo + 1);
            }

            catch (Exception)
            {
                return 1;
            }
        }

        internal void stupdtdata(string srrecno, string srfname, string sriname, string srgender, DateTime srdob, string srnic, string srcontno1, string srcontno2, string srprmntad, string srrecsdd, string sremail, string srgardnm, string srgardadd, string srgardconno1, string srgardconno2, DateTime srregdate, string srstat, string srdecs, string srgtype)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msq1 = "update studentRegistration SET fullName ='" + srfname + "', nameWithInitial = '" + sriname + "', gender = '" + srgender + "', dateOfBirth = '" + srdob + "', nicNo = '" + srnic + "', contactNo1 = '" + srcontno1 + "', contactNo2 = '" + srcontno2 + "', permanentAddress = '" + srprmntad + "', recidenceAddress = '" + srrecsdd + "', email = '" + sremail + "', gardianName = '" + srgardnm + "', gardianAddress = '" + srgardadd + "', gardiancontactNo1 = '" + srgardconno1 + "', gardiancontactNo2 = '" + srgardconno2 + "', registrationDate = '" + srregdate + "', status = '" + srstat + "', description = '" + srdecs + "', gardiantype = '" + srgtype + "' where record_no = '" + srrecno + "'";

            cmd1.CommandText = msq1;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();
        }

        internal void delectstudent(string srrecno)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msq1 = "Delete from studentRegistration where (record_no = '" + srrecno + "')";

            cmd1.CommandText = msq1;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();
        }

        internal void sfdupdtdata(string sfrecno, string sfinm, string sffnm, string sfgender, DateTime sfdob, string sfnic, string sfcon1, string sfcon2, string peraddrs, string reciaddrs, string sfemil, string sfolstat, string sfoldscrp, string sfalstat, string sfaldscrp, string sfothrstat, string shothrdscrp, string sftype, string sfcourse, string sfalloct, string sfdept, string sfdesig, string sfstatus, string sfdscrp)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msq1 = "update staffdetails SET nameWithInitial ='" + sfinm + "', fullName = '" + sffnm + "', gender = '" + sfgender + "', dateOfBirth = '" + sfdob + "', nicNo = '" + sfnic + "', contactNo1 = '" + sfcon1 + "', contactNo2 = '" + sfcon2 + "', permanentAddress = '" + peraddrs + "', recidentAddress = '" + reciaddrs + "', email = '" + sfemil + "', type = '" + sftype + "', course = '" + sfcourse + "', allocation = '" + sfalloct + "', department = '" + sfdept + "', designation = '" + sfdesig + "', status = '" + sfstatus + "', description = '" + sfdscrp + "', o/lstatus = '" + sfolstat + "', o/ldescrip = '" + sfoldscrp + "', a/lstatus = '" + sfalstat + "', a/ldescrip = '" + sfaldscrp + "', otherstatus = '" + sfothrstat + "' , otherdescrip = '" + shothrdscrp + "'where record_no = '" + sfrecno + "'";

            cmd1.CommandText = msq1;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();
        }

        internal void deletestaff(string sfrecno)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msq1 = "Delete from staffdetails where (record_no = '" + sfrecno + "')";

            cmd1.CommandText = msq1;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();
        }

        internal void exmupdtdata(string edrecno, DateTime ed2tdate, string ed2tstat, DateTime ed2pdate, string ed2pstat, string ed2fstat, DateTime ed3tdate, string ed3tstat, DateTime ed3pdate, string ed3pstat, string ed3fstat, string edexamstat)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msq1 = "update examdetails SET  [2ndTdate] ='" + ed2tdate + "', [2ndTstatus] = '" + ed2tstat + "', [2ndPdate] = '" + ed2pdate + "', [2ndPstatus] = '" + ed2pstat + "', [2ndFinalStatus] = '" + ed2fstat + "', [3rdTdate] = '" + ed3tdate + "', [3rdTstatus] = '" + ed3tstat + "', [3rdPdate] = '" + ed3pdate + "', [3rdPstatus] = '" + ed3pstat + "', [3rdFinalStatus] = '" + ed3fstat + "', [examStatus] = '" + edexamstat + "' where (record_No = '" + edrecno + "')";

            cmd1.CommandText = msq1;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();
        }

        internal void cdupdtdata(string cdrecno, string cddreason, string cddcetino, DateTime cddissdate, string cddstatus)
        {
            SqlCeConnection conn = new SqlCeConnection(sqlcon.connlink);
            SqlCeCommand cmd1 = new SqlCeCommand();
            string msq1 = "update certificatedetails SET Dreason ='" + cddreason + "', DcertificateNo = '" + cddcetino + "', DissueDate = '" + cddissdate + "', Dstatus = '" + cddstatus + "'where record_no = '" + cdrecno + "'";

            cmd1.CommandText = msq1;
            cmd1.Connection = conn;
            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();
        }
    }
}
