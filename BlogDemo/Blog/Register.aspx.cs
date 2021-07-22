using Blog.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog
{
    public partial class Register : System.Web.UI.Page
    {
        DBContext db = new DBContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            //给表中的性别绑定数据
            string[] sex = new string[2] { "男", "女" };
            DropDownList1.DataSource = sex;
            DropDownList1.DataBind();

            if (Session["agreeProtocol"] == null)
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["agreeProtocol"] = "yes";
            Panel1.Visible = false;
            Panel2.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string userName = TextBox1.Text.Trim();
            Blogs blogs = db.blogs.FirstOrDefault(u => u.UserName == userName);
            if (blogs == null)
            {
                Label2.Text = "用户名可用";
                Label2.ForeColor = Color.Green;
            }
            else
            {
                Label2.Text = "该用户已存在!";
            }
        }

        //注册
        protected void Button4_Click(object sender, EventArgs e)
        {
            string text1 = TextBox8.Text.Trim();
            string text2 = TextBox10.Text.Trim();
            if (text1 != "" && text2 != "")
            {
                Blogs blogs = db.blogs.FirstOrDefault(u => u.UserName == TextBox1.Text.Trim());
                if (blogs == null)
                {
                    Blogs blogs1 = new Blogs();
                    blogs1.UserName = TextBox1.Text.Trim();
                    blogs1.PassWord = TextBox2.Text.Trim();
                    blogs1.ReallyName = TextBox5.Text.Trim();
                    blogs1.Birthday = TextBox6.Text.Trim();
                    blogs1.Address = TextBox7.Text.Trim();
                    blogs1.PostCode = TextBox8.Text.Trim();
                    blogs1.Email = TextBox9.Text.Trim();
                    blogs1.HomePhone = TextBox10.Text.Trim();
                    blogs1.MobilePhone = TextBox11.Text.Trim();
                    blogs1.QQ = TextBox4.Text.Trim();
                    blogs1.ICQ = TextBox12.Text.Trim();
                    blogs1.Sex = DropDownList1.Text.Trim();
                    blogs1.RegTime = DateTime.Now;
                    //添加用户
                    db.blogs.Add(blogs1);
                    db.SaveChanges();

                    Response.Redirect("~/Login.aspx");
                }
                else
                {
                    Label2.Text = "该用户已存在!";
                }
            }
            else
            {
                if (text1 == "" && text2 == "")
                {
                    Label5.Visible = true;
                    Label6.Visible = true;
                }
                else if (text1 == "")
                {
                    Label5.Visible = true;
                    Label6.Visible = false;
                }
                else
                {
                    Label5.Visible = false;
                    Label6.Visible = true;
                }
            }

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}