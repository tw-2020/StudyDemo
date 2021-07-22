using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog
{
    public partial class Friend : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int blogID = Convert.ToInt32(Session["BlogID"].ToString());
            DataSet ds = DBHelper.reDs("select BlogID,UserName,Sex,QQ from tb_Blog where BlogID in (select FriendID from tb_Message where BlogID = " + blogID + ")");
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }


        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string text = TextBox1.Text.Trim();
            DataSet ds = DBHelper.reDs("select  BlogID,UserName,Sex,QQ from tb_Blog where UserName like '%" + text + "%' ");
            if (ds.Tables[0].Rows[0][1].ToString().Length > 10)
            {
                ds.Tables[0].Rows[0][1] = ds.Tables[0].Rows[0][1].ToString().Substring(0, 10) + "...";
            }
            DataList1.DataSource = ds;
            DataList1.DataBind();
        }
    }
}