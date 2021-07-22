<%@ Page Title="" Language="C#" MasterPageFile="~/BackGround.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Blog.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        #text {
            background-image: url('Images/博客公告.jpg');
            width: 530px;
            height: 530px;
        }

        #text_w {
            font-size: 14px;
            line-height: 20px;
            position: relative;
            top: 100px
        }

        #text p {
            position:relative;
            top:315px;
            left:380px;
            font-size:small;
        }

            #text p a {
                text-decoration:none;
                color:blue;
            }
        .auto-style1 {
            color: #0000FF;
        }
    </style>
    <div id="text">
        <div id="text_w">
            <span>&nbsp;（一）不得利用本网站进行商业广告宣传；</span><br />
            <span>&nbsp;（二）不得利用本网站发送非法文章；</span><br />
            <span>&nbsp;（三）不得利用本网站进行上传非法图片；</span><br />
            <span>&nbsp;（四）互相尊重，对自己的言论行为负责；</span><br />
            <span>&nbsp;（五）普通用户欲删除文章，评论、图片等信息，请与管理员联系；</span><br />
            <span>&nbsp;（六）本网站版权归明日科技公司，不得对本网站进行转载或作为私用；</span><br />
        </div>
        <p class="auto-style1">
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">点击该处浏览博客文章&gt;&gt;</asp:LinkButton>
        </p>
    </div>
</asp:Content>
