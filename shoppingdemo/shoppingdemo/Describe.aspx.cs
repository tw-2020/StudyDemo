using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shoppingdemo
{
    public partial class Describe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string GoodID = Request["GoodsID"];
            DataSet dataSet = DB.reDs("select * from tb_GoodsInfo where GoodsID = '" + GoodID + "'");
            txtGoodsName.Text = dataSet.Tables[0].Rows[0][1].ToString();
            txtKind.Text = dataSet.Tables[0].Rows[0][2].ToString();
            txtGoodsPrice.Text = dataSet.Tables[0].Rows[0][4].ToString();
            imgGoodsPhoto.ImageUrl = dataSet.Tables[0].Rows[0][3].ToString();
            txtGoodsDesc.Text = dataSet.Tables[0].Rows[0][5].ToString();
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}