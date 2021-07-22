using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shoppingdemo
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        public static string moneyCount;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //向购物车中添加商品，如果购物车中已经存在该商品，则商品数量加１，如果是第一次购买，则向购物车中添加一条商品信息
                string userName = Session["UserName"].ToString();
                string goodsID = Request["GoodsID"];
                DataSet ds = DB.reDs("select * from tb_User where UserName = '"+userName+"'");
                string  UserId = ds.Tables[0].Rows[0][0].ToString();
                DataSet dataSet = DB.reDs("select * from tb_Cart where CartID = " + UserId + "and GoodsID = "+ goodsID + "");
                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    DataSet dataSet1 = DB.reDs("select GoodsName,GoodsPrice from tb_GoodsInfo where GoodsID= " + Int32.Parse(goodsID) + "");
                    string p_GoodsName = dataSet1.Tables[0].Rows[0][0].ToString();
                    string p_GoodsPrice = dataSet1.Tables[0].Rows[0][1].ToString();
                    string p_Num = "1";
                    Boolean b=DB.ExSql("insert into tb_Cart values(" + Int32.Parse(UserId) + "," + Int32.Parse(goodsID) + ",'" + p_GoodsName + "','" + p_GoodsPrice + "'," + p_Num + ")");
                }
                else
                {
                    DB.ExSql("update set Num=Num+1 from tb_Cart where CartID = " + UserId + "and GoodsID = " + goodsID + "");
                }

                //显示购物车中的商品信息
                Bind();
            }
        }

        //绑定DataList控件
        public void Bind()
        {
            string userName = Session["UserName"].ToString();
            DataSet ds = DB.reDs("select * from tb_User where UserName = '"+userName+"'");
            DataSet ds2 = DB.reDs("select *,GoodsPrice*Num As Count from tb_Cart where CartID=" + ds.Tables[0].Rows[0][0].ToString()+"");
            float P_fl_Count = 0;
            foreach (DataRow dr in ds2.Tables[0].Rows)
            {
                P_fl_Count += Convert.ToSingle(dr[6]);
            }
            moneyCount = P_fl_Count.ToString();
            dlShoppingCart.DataSource = ds2;
            dlShoppingCart.DataBind();
        }

        //删除购物车中的商品
        protected void dlShoppingCart_DeleteCommand(object source, DataListCommandEventArgs e)
        {
            string userName = Session["UserName"].ToString();
            DataSet ds = DB.reDs("select * from tb_User where UserName = '" + userName + "'");
            string UserId = ds.Tables[0].Rows[0][0].ToString();
            bool P_bool_reVal = DB.ExSql("Delete from tb_Cart where CartID=" + UserId + " and GoodsID=" + e.CommandArgument.ToString());
            if (!P_bool_reVal)
                Response.Write("<script>删除失败，请重试！</script>");
            else
                Bind();
        }

        protected void dlShoppingCart_ItemCommand(object source, DataListCommandEventArgs e)
        {

        }

        protected void dlShoppingCart_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            //用来实现数量文本框中只能输入数字
            TextBox txtGoodsNum = (TextBox)e.Item.FindControl("txtGoodsNum");
            if (txtGoodsNum != null)
            {
                txtGoodsNum.Attributes["onkeyup"] = "value=value.replace(/[^\\d]/g,'')";
            }
        }
    }
}