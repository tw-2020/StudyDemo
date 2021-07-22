using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginDemo
{
    public partial class YanZheng : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string num = GetRandom(4);
                GetPic(num);
                Session["yanzheng"] = num;
            }
        }

        //生成随机数
        public string GetRandom(int cishu)
        {
            string Str = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            //字符串转换成数组
            string[] strArry = Str.Split(',');

            Random ra = new Random();
            string str1 = "";

            //中间变量
            for (int i = 0; i < cishu; i++)
            {
                int rit = ra.Next(35);//生成0-34 随机数 数据下标
                str1 = str1 + strArry[rit].ToString();
                //当前 随机数 不是上一次的随机数
            }

            return str1;
        }

        //生成图片
        public void GetPic(string Nstr)
        {
            if (Nstr == null || Nstr.Trim() == string.Empty)
            {
                return;
            }
            //定义普通的长宽
            System.Drawing.Bitmap bm = new System.Drawing.Bitmap(Nstr.Length * 12, 28);
            Graphics gh = Graphics.FromImage(bm);
            Random ra = new Random();
            gh.Clear(Color.White);
            //在画布中绘制背景
            for (int i = 0;i<20;i++)
            {
                int x1 = ra.Next(bm.Width);
                int x2 = ra.Next(bm.Width);
                int y1 = ra.Next(bm.Height);
                int y2 = ra.Next(bm.Height);

                gh.DrawLine(new Pen(Color.Silver), x1, x2, y1, y2);
            }

            //str font
            Font font = new Font("Arial",12,FontStyle.Bold);
            System.Drawing.Drawing2D.LinearGradientBrush brush =
                new System.Drawing.Drawing2D.LinearGradientBrush
                (new Rectangle(0, 0, bm.Width, bm.Height),Color.Red,Color.Black,1.2f,true);
            gh.DrawString(Nstr, font, brush, 2, 2);

            //整合 输出 图片
            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            bm.Save(stream, System.Drawing.Imaging.ImageFormat.Gif);
            Response.ClearContent();
            Response.ContentType = "image/Gif";
            Response.BinaryWrite(stream.ToArray());
        }
    }
}