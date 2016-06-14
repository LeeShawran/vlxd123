using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace QL_VatLieuXayDung
{
    class Connect
    {
        
      
         static public OleDbConnection getConnect()
        {
           // chuoicauhinh = "Provider=MSDAORA;Data Source=VLXD;Persist Security Info=True;User ID=system;Password=Canh331994;Unicode=True"
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ConnectionString);
            return conn;
        }
       static public void setConnect(String sv,String user,String pass)
        {
            Properties.Settings.Default.ConnectionString = "Provider=MSDAORA;Data Source=" + sv + ";Persist Security Info=True;User ID=" + user + ";Password=" + pass + ";Unicode=True;Charset=utf8";
            Properties.Settings.Default.Save();
       
       }

       public static int Check_Config()
       {
           if (Properties.Settings.Default.ConnectionString == null || Properties.Settings.Default.ConnectionString=="")
               return 1;// Chuỗi cấu hình không tồn tại     
           try
           {
               OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.ConnectionString);
               if (conn.State == System.Data.ConnectionState.Closed)
                   conn.Open();
               return 0;// Kết nối thành công chuỗi cấu hình hợp lệ        
           }
           catch
           {
               return 2;// Chuỗi cấu hình không phù hợp. 
           }
       }
       public static int Check_ketnoi(String sv, String user, String pass)
       {
           try
           {
               string cnn = "Provider=MSDAORA;Data Source=" + sv + ";Persist Security Info=True;User ID=" + user + ";Password=" + pass + ";Unicode=True;Charset=utf8";
               OleDbConnection conn = new OleDbConnection(cnn);
               if (conn.State == System.Data.ConnectionState.Closed)
                   conn.Open();
               return 1;// Kết nối thành công chuỗi cấu hình hợp lệ        
           }
           catch
           {
               return 0;// Chuỗi cấu hình không phù hợp. 
           }
       }
      
    }
}
