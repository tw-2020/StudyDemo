using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog
{
    public partial class Edit : System.Web.UI.Page
    {
        DBContext db = new DBContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int blogId = Convert.ToInt32(Session["BlogID"].ToString());
                Blogs blogs = db.blogs.FirstOrDefault(u => u.BlogID == blogId);
                TextBox1.Text = blogs.UserName;
                TextBox2.Text = blogs.PassWord;
                TextBox5.Text = blogs.ReallyName;
                TextBox6.Text = blogs.Birthday;
                TextBox7.Text = blogs.Address;
                TextBox8.Text = blogs.PostCode;
                TextBox9.Text = blogs.Email;
                TextBox10.Text = blogs.HomePhone;
                TextBox11.Text = blogs.MobilePhone;
                TextBox4.Text = blogs.QQ;
                TextBox12.Text = blogs.ICQ;
                string[] sex = { "男", "女" };
                DropDownList1.DataSource = sex;
                DropDownList1.DataBind();
                TextBox13.Text = blogs.RegTime.ToString();
            }
            

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string userName = Session["UserName"].ToString();
            Blogs blogs = db.blogs.FirstOrDefault(u => u.UserName == userName);
            blogs.UserName = TextBox1.Text.Trim();
            blogs.PassWord = TextBox3.Text.Trim();
            blogs.Sex = DropDownList1.Text.Trim();
            blogs.ReallyName = TextBox5.Text.Trim();
            blogs.Birthday = TextBox6.Text.Trim();
            blogs.Address = TextBox7.Text.Trim();
            blogs.PostCode = TextBox8.Text.Trim();
            blogs.Email = TextBox9.Text.Trim();
            blogs.HomePhone = TextBox10.Text.Trim();
            blogs.MobilePhone = TextBox11.Text.Trim();
            blogs.QQ = TextBox4.Text.Trim();
            blogs.ICQ = TextBox12.Text.Trim();

            db.Entry(blogs).State = EntityState.Modified;
            db.SaveChanges();

            Response.Write("<script>alert('修改成功');window.location.href='Edit.aspx'</script>");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}