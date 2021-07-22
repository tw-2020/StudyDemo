<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="shoppingdemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--顶部登录和展示页面-->
            <asp:Panel ID="Panel1" runat="server">
                <table style="width: 474px" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                        <td style="font-size: 10pt; width: 36px; height: 17px"></td>
                        <td style="font-size: 10pt; height: 17px" align="left">用户名<asp:TextBox ID="txtUserName" runat="server" Width="53px" Height="15px"></asp:TextBox>密码<asp:TextBox
                            ID="txtPwd" runat="server" TextMode="Password" Width="52px" Height="15px"></asp:TextBox>
                            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="登录" Height="20px" /></td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" Width="125px">
                <table style="width: 474px" border="0" cellpadding="0" cellspacing="0">
                    <tr>
                        <td style="font-size: 10pt; width: 36px; height: 17px"></td>
                        <td style="font-size: 10pt; height: 17px" align="left"></td>
                        <asp:Label ID="labMessage" runat="server" Text=""></asp:Label>
                    </tr>
                </table>
            </asp:Panel>
            <!--中部数据展示-->
            <asp:DataList ID="DataList1" runat="server" RepeatColumns="2" OnItemCommand="DataList1_ItemCommand">
                <ItemTemplate>
                    <table style="font-size: 10pt;" border="0" cellpadding="0" cellspacing="0" class="auto-style1">
                        <tr>
                            <td rowspan="4" style="width: 101px">
                                <asp:Image ID="imgGoodsPhoto" runat="server" ImageUrl='<%# Eval("GoodsPhoto") %>' Width="66px" Height="92px" /></td>
                            <td style="width: 201px">名称：<asp:Label ID="labGoodsName" runat="server" Text='<%# Eval("GoodsName") %>'></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="width: 201px">类别：<asp:Label ID="labGoodsKind" runat="server" Text='<%# Eval("GoodsKind") %>'></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="width: 201px">单价：<asp:Label ID="labGoodzPrice" runat="server" Text='<%# Eval("GoodsPrice") %>'></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="width: 201px">
                                <asp:LinkButton ID="lnkbtnGoodsDescribe" runat="server" CommandArgument='<%# Eval("GoodsID")%>' CommandName="describe">详细信息</asp:LinkButton>
                                <asp:LinkButton ID="lnkbtnBuy" runat="server" CommandArgument='<%# Eval("GoodsID") %>' Width="32px" CommandName="buy">购买</asp:LinkButton></td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
            <asp:HyperLink ID="HyperLink1" runat="server" ImageUrl="~/Image/购物车/进入后台按钮.jpg" NavigateUrl="~/GoodsInfo.aspx">HyperLink</asp:HyperLink>
            <br />
        </div>

    </form>
</body>
</html>
