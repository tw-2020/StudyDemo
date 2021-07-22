using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace LoginDemo
{
    public class DB
    {
        public SqlConnection GetConn()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["Conn1"].ConnectionString);
        }

        //查询
        public DataTable SeleDt(string sql)
        {
            SqlConnection conn = GetConn();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        //增，删，改
        public int ExecSql(string sql)
        {
            int i = 0;
            SqlConnection conn = GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                i = cmd.ExecuteNonQuery();
                return i;
            }
            catch (Exception e)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
        }

        //使用MD5加密算法
        public string GetMD5(string pwd)
        {
            string Returnpwd = "";

            MD5 md5 = MD5.Create();
            //密码转换 字节=》hash计算
            byte[] d = md5.ComputeHash(Encoding.UTF8.GetBytes(pwd));
            //翻转成MD5码
            d.Reverse();

            //截取MD5码 某一部门
            for (int i = 0; i < d.Length - 1; i++)
            {
                Returnpwd = Returnpwd + (d[i] < 198 ? d[i] + 28 : d[i]).ToString();
            }
            return Returnpwd;
        }

        //datareader对象提供只读单向数据的快速传递
        public SqlDataReader SeleDr(string sql)
        {
            SqlConnection conn = GetConn();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }

        //注册方法
        public int Register(User user)
        {
            SqlConnection conn = GetConn();
            conn.Open();
            string sql = "insert into tb_User values('" + user.UserName + "','" + user.Password + "','" + user.Email + "')";
            SqlCommand cmd = new SqlCommand(sql,conn);
            int i = cmd.ExecuteNonQuery();
            return i;
        }
    }
}