using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog
{
    public partial class BackGround : System.Web.UI.MasterPage
    {
        DBContext db = new DBContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
            }
            else 
            {
                Label1.Text ="欢迎"+Session["UserName"]+"光临";
                Panel1.Visible = false;
                Panel2.Visible = true;
                //侧边评论
                List<Revert> reverts= db.reverts.OrderByDescending(u => u.Time).ToList();
                for(int i = 0;i<3;i++)
                {
                    if (i == 0)
                    {
                        Label2.Text = reverts[i].Content;
                    }
                    else if (i == 1)
                    {
                        Label3.Text = reverts[i].Content;
                    }
                    else if (i == 2)
                    {
                        Label4.Text = reverts[i].Content;
                    }
                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text.Trim();
            string password = TextBox2.Text.Trim();
            string yanzheng = TextBox3.Text.Trim().ToUpper();
            string realyanzheng = Session["yanzheng"].ToString();

            //先判断验证码是否正确
            if (realyanzheng == yanzheng)
            {
                Blogs blog = db.blogs.FirstOrDefault(t => t.UserName == username && t.PassWord == password);
                if (blog != null)
                {
                    Session["BlogID"] = blog.BlogID;
                    Session["UserName"] = blog.UserName;
                    Label1.Text = "欢迎" + blog.UserName + "光临";
                    Panel2.Visible = true;
                    Panel1.Visible = false;
                }
                else
                {
                    Response.Write("<script>alert('登录失败！请返回查找原因');window.location.href='Login.aspx'</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('验证码输入错误');window.location.href='Login.aspx'</script>");
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Register.aspx");
        }
    }
}