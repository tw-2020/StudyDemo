<%@ Page Title="" Language="C#" MasterPageFile="~/BackGround.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Blog.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        p {
            width: 422px;
            height: 31px;
            text-align: center;
            font-weight: bold;
            color: #973307;
            margin-top: 30px;
        }

        .text {
            width: 488px;
            height: 205px;
            border: 1px solid #000;
            font-size: 14px;
            line-height: 20px;
            height: 211px;
        }

        .text2 {
            width: 488px;
            height: 400px;
            border: 1px solid #000;
            font-size: 14px;
            line-height: 20px;
        }

            .text2 table {
                position: relative;
                top: 20px;
                margin-left: 80px;
            }

    </style>
    <asp:Panel ID="Panel1" runat="server">
        <div>
            <p>用户注册协议</p>
            <div class="text">
                <span>&nbsp;&nbsp;为了更好的管理和维护网站，请您自觉遵守以下条款:</span><br />
                <br />
                <span>&nbsp;&nbsp;（一）不得利用本网站进行商业广告宣传；</span><br />
                <span>&nbsp;&nbsp;（二）不得利用本网站发送非法文章；</span><br />
                <span>&nbsp;&nbsp;（三）不得利用本网站进行上传非法图片；</span><br />
                <span>&nbsp;&nbsp;（四）互相尊重，对自己的言论行为负责；</span><br />
                <span>&nbsp;&nbsp;（五）普通用户欲删除文章，评论、图片等信息，请与管理员联系；</span><br />
                <span>&nbsp;&nbsp;（六）本网站版权归明日科技公司，不得对本网站进行转载或作为私用；</span><br />
                <br />
                <div style="text-align: center">
                    <asp:Button ID="Button1" runat="server" Text="同意以上条款" OnClick="Button1_Click" />
                    <asp:Button ID="Button2" runat="server" Text="不同意" />
                </div>

            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <div>
            <p>注册资料</p>
            <div class="text2">
                <table>
                    <tr>
                        <td>用户名：</td>
                        <td class="auto-style2" colspan="2">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            <asp:Button ID="Button3" runat="server" Text="检测用户" Width="69px" OnClick="Button3_Click" style="height: 21px" />
                            <div><asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label></div>
                        </td>
                    </tr>
                    <tr>
                        <td>密码：</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>确认密码：</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="两次密码不一致" ForeColor="Red"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>性别：</td>
                        <td class="auto-style2">
                            <asp:DropDownList ID="DropDownList1" runat="server">
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>真实姓名：</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>生日：</td>
                        <td>
                            <asp:TextBox ID="TextBox6" runat="server" Width="243px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>家庭地址：</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>邮政编码：</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                            <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="*"></asp:Label>
                            <asp:Label ID="Label5" runat="server" ForeColor="Red" Text="请输入邮政编码" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>E-mail：</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>家庭电话</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                            <asp:Label ID="Label4" runat="server" ForeColor="Red" Text="*"></asp:Label>
                            <asp:Label ID="Label6" runat="server" ForeColor="Red" Text="请输入家庭电话" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>手机号码：</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>QQ：</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>ICQ：</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2" style="text-align: center">
                            <asp:Button ID="Button4" runat="server" Text="确定" OnClick="Button4_Click" />&nbsp;
                            <asp:Button ID="Button5" runat="server" Text="返回" OnClick="Button5_Click" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </asp:Panel>

</asp:Content>
