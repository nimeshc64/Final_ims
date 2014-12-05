using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InstituteMS
{
    class StudentAttendence
    {
        DBConnect db = new DBConnect();
        public string command;
        public MySqlDataReader read;

        private string month;   
        private string year;
        string status;
        public string Month
        {
            get
            {
                return month;
            }
            set 
            {
                month = value; 
            }
        }

        public string Year
        {
            get 
            { 
                return year;
            }
            set 
            {
                year = value;
            }
        }


      

        public void save(int max,int stuid,int classid)
        {
            try
            {
                command = "INSERT INTO " + db.dbName + ".attendance(attenID,month,year,stuID,classID) VALUES('" + max + "','" + month + "','" + year + "','" + stuid + "','" + classid + "')";
                db.DMLQuery(command,0);
            }
            catch (Exception em)
            {
            }
        }

        public string checksave(int stuid,String month)
        {
            
            try
            {
                status = null;
                db.cmd.CommandText = "SELECT month FROM attendance WHERE stuID='" + stuid + "' AND month='" + month + "' ";
                db.checkConn();
                read = db.cmd.ExecuteReader();
                while (read.Read())
                {
                    status = read.GetString(read.GetOrdinal("month"));
                }
            }
            catch (Exception em)
            {
                MessageBox.Show(em.Message);
            }
            db.checkConn();
            return status; 
        }
      
    }


}
