using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog
{
    public partial class Essay : System.Web.UI.Page
    {

        DBContext db = new DBContext(); 
        public int pageNow = 1;

        public  int all = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
            if (Session["BlogID"] == null)
            {
                Response.Write("<script>alert('请登录');window.location.href='Login.aspx'</script>");
            }
            else
            {
                int blogId = Convert.ToInt32(Session["BlogID"].ToString());
                DataSet ds = NowTable(pageNow,blogId);
                DataList1.DataSource = ds;
                DataList1.DataBind();

                DataSet ds2 = DBHelper.reDs("select Time,subject,content,Author from tb_Article where BlogID = " + blogId);
                //查看有多少行数据
                int row = ds2.Tables[0].Rows.Count;
                if (row % 3 != 0)
                {
                    Label6.Text = (row / 3 + 1).ToString();
                    all = row / 3 + 1;
                }
                else
                {
                    Label6.Text = (row / 3).ToString();
                    all = row / 3 ;
                }
               
                Label5.Text = pageNow.ToString();
                
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string subject = (((LinkButton)sender).CommandArgument.ToString()).ToString();
            Revert revert = db.reverts.FirstOrDefault(u => u.Subject == subject);
            if (revert == null)
            {
                Response.Write("<script>alert('本文章还未添加评论');window.location.href='Essay.aspx'</script>");
            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
                Panel3.Visible = false;

                TextBox1.Text = revert.Subject;
                TextBox2.Text = revert.Content;
                TextBox3.Text = revert.Time.ToString();
            }
            
        }


        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            int blogId = Convert.ToInt32(Session["BlogID"].ToString());
            DataSet ds = NowTable(pageNow, blogId);
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            int blogId = Convert.ToInt32(Session["BlogID"].ToString());
            int page = Convert.ToInt32(Label5.Text.ToString()) - 1;
            if (page < 1)
            {
                page = 1;
                DataSet ds = NowTable(page, blogId);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
            else 
            {
                DataSet ds = NowTable(page, blogId);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
            Label5.Text = page.ToString();
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            int blogId = Convert.ToInt32(Session["BlogID"].ToString());
            DataSet ds2 = DBHelper.reDs("select Time,subject,content,Author from tb_Article where BlogID = " + blogId);
            //查看有多少行数据
            int row = ds2.Tables[0].Rows.Count;
            if (row % 3 != 0)
            {
                Label6.Text = (row / 3 + 1).ToString();
                all = row / 3 + 1;
            }
            else
            {
                Label6.Text = (row / 3).ToString();
                all = row / 3;
            }
            int page = Convert.ToInt32(Label5.Text.ToString()) + 1;
            if (page >= all)
            {
                page = all;
                DataSet ds = NowTable(page, blogId);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
            else
            {
                DataSet ds = NowTable(page, blogId);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
            Label5.Text = page.ToString();
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            int blogId = Convert.ToInt32(Session["BlogID"].ToString());
            DataSet ds2 = DBHelper.reDs("select Time,subject,content,Author from tb_Article where BlogID = " + blogId);
            //查看有多少行数据
            int row = ds2.Tables[0].Rows.Count;
            if (row % 3 != 0)
            {
                Label6.Text = (row / 3 + 1).ToString();
                all = row / 3 + 1;
            }
            else
            {
                Label6.Text = (row / 3).ToString();
                all = row / 3;
            }
            DataSet ds = NowTable(all, blogId);
            DataList1.DataSource = ds;
            DataList1.DataBind();
            Label5.Text = all.ToString();
        }


        //分页代码
        public static DataSet NowTable(int num, int blogId)
        {
            DataSet ds = DBHelper.reDs("select top 3 Time,subject,content,Author from tb_Article where ArticleID not in(select top "
                + (num - 1) * 3 + " ArticleID from tb_Article where BlogID = " + blogId + " )");
            return ds;
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = true;

            string msg = (((LinkButton)sender).CommandArgument.ToString()).ToString();
            TextBox4.Text = msg;

           

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string msg = TextBox4.Text.ToString();
            Revert revert = new Revert();
            revert.Subject = msg;
            revert.Time = DateTime.Now;
            revert.Content = TextBox5.Text.Trim();

            db.reverts.Add(revert);
            db.SaveChanges();

            Response.Write("<script>alert('添加成功');window.location.href='Essay.aspx'</script>");
        }
    }
}