using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog
{
    public partial class ManagerEssay : System.Web.UI.Page
    {
        DBContext db = new DBContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
            if (!IsPostBack)
            {
                int blogId = Convert.ToInt32(Session["BlogID"].ToString());
                //博客
                DataSet ds = DBHelper.reDs("select * from tb_Article where BlogID = " + blogId);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    DataSet ds2 = DBHelper.reDs("select subject,content,Time from tb_Article where BlogID =" + blogId);
                    if (ds2.Tables[0].Rows[0][1].ToString().Length > 10)
                    {
                        ds2.Tables[0].Rows[0][1] = ds2.Tables[0].Rows[0][1].ToString().Substring(0, 10) + "...";
                    }
                    DataList1.DataSource = ds2;
                    DataList1.DataBind();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string text = TextBox1.Text.Trim();
            DataSet ds = DBHelper.reDs("select  subject,content,Time from tb_Article where Subject like '%" + text + "%' ");

            if (ds.Tables[0].Rows[0][1].ToString().Length > 10)
            {
                ds.Tables[0].Rows[0][1] = ds.Tables[0].Rows[0][1].ToString().Substring(0, 10) + "...";
            }
            DataList1.DataSource = ds;
            DataList1.DataBind();

        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            Panel3.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Article article = new Article();

            article.Subject = TextBox2.Text.Trim().ToString();
            article.Content = TextBox3.Text.Trim().ToString();
            article.Time = DateTime.Now;
            article.Author = Session["UserName"].ToString();
            article.BlogID= Convert.ToInt32(Session["BlogID"].ToString());

            db.articles.Add(article);
            db.SaveChanges();

            Response.Write("<script>alert('添加成功');window.location.href='ManagerEssay.aspx'</script>");
        }


        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = true;
            string subject = ((LinkButton)sender).CommandArgument.ToString();
            Article article = db.articles.FirstOrDefault(u => u.Subject == subject);
            TextBox6.Text = article.Author;
            TextBox4.Text = article.Subject;
            TextBox5.Text = article.Content;

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            string subject = ((LinkButton)sender).CommandArgument.ToString();
            Article article = db.articles.FirstOrDefault(u => u.Subject == subject);
            db.articles.Remove(article);
            db.SaveChanges();
            Response.Write("<script>alert('删除成功');window.location.href='ManagerEssay.aspx'</script>");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Article article = new Article();
            article.Subject = TextBox4.Text.ToString();
            article.Content = TextBox5.Text.ToString();
            db.Entry(article).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}