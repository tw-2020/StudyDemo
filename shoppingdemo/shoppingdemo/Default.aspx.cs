using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shoppingdemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = DB.reDs("select * from tb_GoodsInfo");
            DataList1.DataSource = ds;
            DataList1.DataBind();
            if (Session["UserName"] == null)
            {
                Panel1.Visible = true;//显示登录面板
                Panel2.Visible = false; //不显示登录名户名显示面板
            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
                labMessage.Text = "欢迎"+Session["UserName"].ToString()+ "光临";
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string userPwd = txtPwd.Text.Trim();
            DataSet dataSet = DB.reDs("select * from tb_User where UserName = '" + userName + "' and Password = '" + userPwd + "'");
            if (dataSet.Tables[0].Rows.Count != 0)
            {
                Session["UserName"] = dataSet.Tables[0].Rows[0][1].ToString();
                labMessage.Text = "欢迎" + userName + "光临";
                Panel1.Visible = false;
                Panel2.Visible = true;
            }
            else
            {
                Response.Write("<script>alert('登录失败！请返回查找原因');</script>");
            }
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "describe")
            {
                string goodsId = e.CommandArgument.ToString();
                string address = "Describe.aspx?GoodsID=" + goodsId;
                Response.Redirect(address);
            }
            if (e.CommandName == "buy")
            {
                if (Session["UserName"] != null)
                {
                    string goodsID = e.CommandArgument.ToString();
                    Response.Redirect("~/ShoppingCart.aspx?GoodsID=" + goodsID);
                }
                else
                {
                    Response.Write("<script>alert('您还没有登录，请先登录再购买！');</script>");
                }
            }
        }
    }
}