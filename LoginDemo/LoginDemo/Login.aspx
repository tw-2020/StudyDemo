<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginDemo.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70px;
            height: 27px;
        }
        .auto-style2 {
            width: 154px;
            height: 27px;
        }
        .auto-style3 {
            width: 70px;
            height: 30px;
        }
        .auto-style4 {
            width: 154px;
            height: 30px;
        }
        .auto-style5 {
            height: 30px;
        }
        .auto-style6 {
            width: 70px;
            height: 29px;
        }
        .auto-style7 {
            width: 154px;
            height: 29px;
        }
        .auto-style8 {
            height: 29px;
        }
        .auto-style9 {
            height: 27px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            登录界面：<br />
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style3">用户名：</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style6">密码：</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8"></td>
                </tr>
                <tr>
                    <td class="auto-style6">验证码：</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/YanZheng.aspx"/>
                        <asp:LinkButton ID="LinkButton1" runat="server" Font-Size="12px">看不清，换一张</asp:LinkButton>
                        <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="登  录" Height="23px" Width="63px" />
                    </td>
                    <td class="auto-style2">
                        <asp:Button ID="Button2" runat="server" Text="注  册" OnClick="Button2_Click" />
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
            </table>
        </p>
    </form>
</body>
</html>
