using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginDemo
{
    public partial class Register : System.Web.UI.Page
    {
        DB db = new DB();
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userName = TextBox2.Text;
            string pwd = db.GetMD5(TextBox3.Text);
            string email = TextBox4.Text;

            //注册的语句
            string sql = "insert into tb_User(UserName, PassWord, Email)" +
                " values('" + userName + "', '" + pwd + "', '" + email + "')";

            //调用方法
            int i = db.ExecSql(sql);

            if (i == 1)
            {
                Response.Write("<script>alert('注册成功');location='login.aspx'</script>");
            }
            else if (i == -1)
            {
                Response.Write("<script>alert('注册失败');location='login.aspx'</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //返回登录页面
            Response.Redirect("~/Login.aspx");
        }


        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string userName = TextBox2.Text.Trim();
            string sql = "select * from tb_User where Username = " + userName + "";
            DataTable dt = db.SeleDt(sql);
            if (dt.Rows.Count != 0)
            {
                Label1.Text = "账户名已被注册";
            }
            else
            {
                Label1.Text = "该账户名可用";
            }
        }
    }
}