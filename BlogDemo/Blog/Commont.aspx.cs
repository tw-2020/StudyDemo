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
    public partial class Commont : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int blogId = Convert.ToInt32(Session["BlogID"].ToString());
            string subject = Request.QueryString["subject"];

            if (subject != null)
            {
                DataSet dataSet = DBHelper.reDs("select tb_Revert.Time,tb_Revert.Subject,tb_Revert.Content,tb_Blog.UserName from tb_Revert join tb_Blog on tb_Revert.BlogID=tb_Blog.BlogID and tb_Revert.BlogID=" + blogId + "and tb_Revert.subject ='" + subject + "'");
                DataList1.DataSource = dataSet;
                DataList1.DataBind();
            }
            else 
            {
                DataSet ds = DBHelper.reDs("select tb_Revert.Time,tb_Revert.Subject,tb_Revert.Content,tb_Blog.UserName from tb_Revert join tb_Blog on tb_Revert.BlogID=tb_Blog.BlogID and tb_Revert.BlogID=" + blogId);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }


            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string msg = (((LinkButton)sender).CommandArgument.ToString()).ToString();
            bool del = DBHelper.ExSql("delete from tb_Revert where Subject ='"+msg+"'" );
            if (del == true)
            {
                Response.Redirect("Commont.aspx");
            }
        }
    }
}