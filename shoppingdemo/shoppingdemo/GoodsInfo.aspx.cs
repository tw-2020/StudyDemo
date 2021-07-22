using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shoppingdemo
{
    public partial class GoodsInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                if (Session["UserName"] == null)
                {
                    Response.Write("<script>alert('请先登录');</script>");
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    if (Session["UserName"].ToString() != "mr")
                    {
                        Response.Write("<script>alert('您没有此权限');</script>");
                        Response.Redirect("~/Default.aspx");
                    }
                }
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            string photoName = this.fulPhoto.FileName;//获取上载文件名称
            Boolean fileOk = false;
            if (fulPhoto.HasFile)
            {
                String fileExtension = System.IO.Path.GetExtension(fulPhoto.FileName).ToLower();
                String[] allowedExtensions = { ".gif", ".png", ".jpeg", ".jpg", ".bmp"};
                for (int i = 0; i < allowedExtensions.Length; i++)
                {
                    if (fileExtension == allowedExtensions[i])
                    {
                        fileOk = true;
                    }
                }

                if (fileOk)
                {
                    this.fulPhoto.PostedFile.SaveAs(Server.MapPath("~/Image/") + photoName);//将文件保存在相应的路径下
                    this.imgGoodsPhoto.ImageUrl = "~/Image/" + photoName;//将图片显示在Image控件上
                }
                else
                {
                    Response.Write("<script>alert('请选择.gif,.png,.jpeg,.jpg,.bmp格式的图片文件!');</script>");
                }
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            if (imgGoodsPhoto.ImageUrl != "")
            {
                labMessage.Visible = false;
                string goodsName = txtGoodsName.Text.Trim();
                string goodsKind = txtKind.Text.Trim();
                string goodsPhoto = imgGoodsPhoto.ImageUrl;
                string goodsPrise = txtGoodsPrice.Text.Trim();
                string goodsIntroduce = txtGoodsDesc.Text.Trim();
                bool isInsert = DB.ExSql("insert into tb_GoodsInfo values('" + goodsName + "','" + goodsKind + "','" + goodsPhoto + "','" + goodsPrise + "','" + goodsIntroduce + "')");
                if (isInsert == true)
                {
                    Response.Write("<script>alert('添加成功');</script>");
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    Response.Write("<script>alert('操作失败，请重试！');</script>");
                }
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}