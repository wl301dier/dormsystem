using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace dormsystem
{
    public class DB
    {
         public static SqlConnection CreateConnection()
         {
             //连接dormitory数据库
             SqlConnection conn = new SqlConnection();//建立连接对象
             conn.ConnectionString = "data source =.;user id = sa; password = 123456; initial catalog = dormitory";//连接字符串
             try
             {
                 conn.Open();
             }
             catch (Exception ex)
             {
                 return null;
             }
             return conn;
         }

         public static void DestoryConnection(SqlConnection conn) 
         {
             conn.Close();
         }

         public static int ExecuteScalar(string sql) 
         {
             int result = -1;
             SqlConnection conn = CreateConnection();
             SqlCommand cmd = new SqlCommand(sql, conn);//建立命令对象
             try
             {
                 result = (int)cmd.ExecuteScalar();//执行SQL语句
             }
             catch (Exception ex) 
             {
                 result = -1;
                 conn.Close();
             }
             conn.Close();
             return result;
         }

         //执行增删改
         public static int ExecuteSQL(string sql)
         {
             int result = -1;
             SqlConnection conn = CreateConnection();
             SqlCommand cmd = new SqlCommand(sql, conn);//建立命令对象
             try
             {
                 result = (int)cmd.ExecuteNonQuery();//执行SQL语句
             }
             catch (Exception ex)
             {
                 result = -1;
                 conn.Close();
             }
             conn.Close();
             return result;
         }

         public static SqlDataReader GetDataReader(string sql, SqlConnection conn)
        {
            SqlDataReader dr = null;
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
               dr = cmd.ExecuteReader();
            }
            catch(Exception ex) 
            {
                return null;
            }
            return dr;
            
        }

         public static DataTable GetDataTable(string sql) 
         {
             SqlConnection conn = CreateConnection();
             SqlCommand cmd = new SqlCommand(sql, conn);
             SqlDataAdapter adp = new SqlDataAdapter(cmd);
             DataSet ds = new DataSet();
             adp.Fill(ds,"Temp");
             conn.Close();
             return ds.Tables["Temp"];
         }
    }
}
