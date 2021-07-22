<%@ Page Title="" Language="C#" MasterPageFile="~/BackGround.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Blog.Edit" %>

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
            height: 430px;
            border: 1px solid #000;
            font-size: 14px;
            line-height: 20px;
        }

            .text table {
                position: relative;
                top: 20px;
                margin-left: 80px;
            }
    </style>

    <div>
        <p>博客详细信息</p>
        <div class="text">
            <table>
                <tr>
                    <td>用户名：</td>
                    <td class="auto-style2" colspan="2">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>密码：</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>修改密码：</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
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
                        <asp:TextBox ID="TextBox6" runat="server" Width="138px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>家庭地址：</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox7" runat="server" Width="265px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>邮政编码：</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
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
                    <td>注册时间：</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox13" runat="server" ReadOnly="True" TextMode="DateTime"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>IP：</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox14" runat="server" ReadOnly="True">::1</asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
                        <asp:Button ID="Button4" runat="server" Text="修改" OnClick="Button4_Click" />&nbsp;
                        <asp:Button ID="Button5" runat="server" Text="返回" OnClick="Button5_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>
