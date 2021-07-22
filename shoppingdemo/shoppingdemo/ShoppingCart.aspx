<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="shoppingdemo.ShoppingCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 368px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" border="0" cellpadding="0" cellspacing="0" style="font-size: 10pt; width: 637px;">
                <tr>
                    <td style="width: 637px; height: 120px; background-image: url(Image/购物车/子页头.jpg);" align="left" valign="bottom">
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 630px">
                            <tr>
                                <td align="left" style="width: 159px"></td>
                                <td align="left" style="width: 319px">
                                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/购物车/购物车.jpg" /></td>
                                <td align="right" style="width: 310px"></td>
                                <td style="width: 42px"></td>
                            </tr>
                            <tr>
                                <td align="left" style="width: 159px; height: 17px"></td>
                                <td align="left" style="width: 319px; height: 17px;"></td>
                                <td align="right" style="width: 310px; height: 17px;">
                                    <asp:LinkButton ID="lnkbtnContinue" runat="server" ForeColor="#FF8000">继续购物</asp:LinkButton>&nbsp; 
                                    <asp:LinkButton ID="lnkbtnSettleAccounts" runat="server" ForeColor="#FF8000">结账</asp:LinkButton>&nbsp; 
                                    <asp:LinkButton ID="lnkbtnClear" runat="server" ForeColor="#FF8000">清空购物车</asp:LinkButton>
                                </td>
                                <td style="width: 42px; height: 17px"></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td style="vertical-align: top; text-align: center; background-image: url(Image/购物车/子页中间.jpg); width: 637px; height: 341px;">
                        <asp:DataList ID="dlShoppingCart" runat="server" OnDeleteCommand="dlShoppingCart_DeleteCommand" OnItemCommand="dlShoppingCart_ItemCommand" OnItemDataBound="dlShoppingCart_ItemDataBound">
                            <HeaderTemplate>
                                <table style="width: 368px; font-size: 10pt;" border="0" cellpadding="0" cellspacing="0">
                                    <tr>
                                        <td style="width: 88px; height: 26px;">商品名称</td>
                                        <td style="width: 102px; height: 26px;">单价</td>
                                        <td style="width: 50px; height: 26px;">数量</td>
                                        <td style="width: 76px; height: 26px"></td>
                                        <td style="height: 26px">&nbsp;</td>
                                    </tr>
                                </table>
                            </HeaderTemplate>
                            <FooterTemplate>
                                <table style="width: 368px; font-size: 10pt;" border="0" cellpadding="0" cellspacing="0">
                                    <tr>
                                        <td align="left">合计金额:<%#moneyCount %>￥</td>
                                    </tr>
                                </table>
                            </FooterTemplate>
                            <ItemTemplate>
                                <table style="font-size: 10pt;" border="0" cellpadding="0" cellspacing="0" class="auto-style1">
                                    <tr>
                                        <td>
                                            <asp:Label ID="GoodsName" runat="server" Text='<%# Eval("GoodsName") %>'></asp:Label></td>
                                        <td>
                                            <asp:Label ID="GoodsPrice" runat="server" Text='<%# Eval("GoodsPrice") %>'></asp:Label></td>
                                        <td>
                                            <asp:TextBox ID="txtGoodsNum" runat="server" Height="16px" Width="40px"></asp:TextBox></td>
                                        <td>
                                            <asp:LinkButton ID="lnkbtnUpdateCart" runat="server" CommandArgument='<%# Eval("GoodsID") %>'
                                                CommandName="updateNum" ForeColor="Black">更新购物车</asp:LinkButton></td>
                                        <td>
                                            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("GoodsID") %>' ForeColor="Black">删除</asp:LinkButton></td>
                                    </tr>
                                </table>
                            </ItemTemplate>
                            <FooterStyle BackColor="#FFC080" />
                            <AlternatingItemStyle BackColor="White" />
                            <ItemStyle BackColor="#FFE0C0" />
                            <HeaderStyle BackColor="#FFC080" />
                        </asp:DataList>
                    </td>
                </tr>
                <tr>
                    <td style="height: 140px; text-align: right; background-image: url(Image/购物车/子页底.jpg); width: 637px;"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
