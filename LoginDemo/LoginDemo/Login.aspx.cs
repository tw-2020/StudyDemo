using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginDemo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //实例化公共类
            DB db = new DB();
            //判断 用户名 密码 验证码 匹配
            string name = TextBox1.Text.Trim();
            string pwd = TextBox2.Text.Trim();
            string num = TextBox3.Text.Trim();
            string yanzheng = Session["yanzheng"].ToString();

            if (num != yanzheng)
            {
                Label1.Text = "*您输入的验证码有误*";
            }
            else
            {
                string pwdm5 = db.GetMD5(pwd);
                string sql = @"select * from [db_Student].[dbo].[tb_User] where [UserName]='" + name + "'and Password = '" + pwdm5 + "'";

                SqlDataReader dr = db.SeleDr(sql);
                //datareader开启读
                dr.Read();
                //读一行判断每一行的数据
                if (dr.HasRows)
                {
                    //用户名 密码 存储 session
                    Session["Username"] = dr.GetValue(1);//第二列，下标为1
                    Session["Userpwd"] = dr.GetValue(2);//第三列，下标为2
                                                        //转跳
                    Response.Redirect("~/Main.aspx");//转跳主页面
                }
                else
                {
                    //弹框
                    Response.Write("<script>alert('登录失败');location='login.aspx'</script>");
                }
                //读完关闭
                dr.Close();
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

    }
}