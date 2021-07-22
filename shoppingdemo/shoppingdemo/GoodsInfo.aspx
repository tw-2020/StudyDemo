<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoodsInfo.aspx.cs" Inherits="shoppingdemo.GoodsInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" border="0" cellpadding="0" cellspacing="0" width="637">
                <tr>
                    <td style="width: 637px; height: 120px; background-image: url(Image/购物车/子页头.jpg);" align="left" valign="bottom">
                        <table border="0" cellpadding="0" cellspacing="0" style="width: 481px">
                            <tr>
                                <td style="width: 68px"></td>
                                <td style="width: 247px">
                                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/购物车/商品基本信息.jpg" /></td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td style="background-image: url(Image/购物车/子页中间.jpg); width: 637px; height: 341px">
                        <table align="center" border="0" cellpadding="0" cellspacing="0" style="font-size: 10pt; width: 71%;">
                            <tr>
                                <td align="left" style="width: 19px"></td>
                                <td align="left" style="width: 77px">商品名称：</td>
                                <td style="width: 359px">
                                    <asp:TextBox ID="txtGoodsName" runat="server" Height="16px" Width="87px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="请输入商品名称！" ControlToValidate="txtGoodsName"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" style="width: 19px; height: 19px"></td>
                                <td align="left" style="width: 77px">商品类别：</td>
                                <td style="width: 359px">
                                    <asp:TextBox ID="txtKind" runat="server" Width="88px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="请输入商品类别！" ControlToValidate="txtKind"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" style="width: 19px"></td>
                                <td align="left" style="width: 77px">商品价格：</td>
                                <td style="width: 359px">
                                    <asp:TextBox ID="txtGoodsPrice" runat="server" Width="86px">0</asp:TextBox>
                                    ￥<asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="格式错误！" ControlToValidate="txtGoodsPrice" Operator="DataTypeCheck" Type="Currency"></asp:CompareValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" style="width: 19px"></td>
                                <td align="left" style="width: 77px">商品图像：</td>
                                <td style="width: 359px">
                                    <asp:ImageMap ID="imgGoodsPhoto" runat="server" Height="80px" Width="69px">
                                    </asp:ImageMap>
                                    <asp:Label ID="labMessage" runat="server" Text="请选择图片！" ForeColor="Red" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td align="left" style="width: 19px"></td>
                                <td align="left" style="width: 77px"></td>
                                <td style="width: 359px">
                                    <asp:FileUpload ID="fulPhoto" runat="server" />
                                    <asp:Button ID="btnShow" runat="server" Height="21px" Text="显示" Width="41px" OnClick="btnShow_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td align="left" style="width: 19px"></td>
                                <td align="left" style="width: 77px">商品介绍：</td>
                                <td style="width: 359px">
                                    <asp:TextBox ID="txtGoodsDesc" runat="server" Height="76px" TextMode="MultiLine" Width="187px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="请输入商品介绍！" ControlToValidate="txtGoodsDesc"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td style="width: 19px; height: 20px; text-align:center" colspan="1"></td>
                                <td style="height: 20px; text-align:center" colspan="4">
                                    <asp:Button ID="btnInsert" runat="server" Text="添加" Height="23px" Width="48px" OnClick="btnInsert_Click"/>
                                    <asp:Button ID="btnBack" runat="server" Text="返回" Height="22px" Width="48px" OnClick="btnBack_Click"/>
                                </td>                            
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td style="width: 637px; height: 120px; background-image: url(Image/购物车/子页底.jpg);" align="left" valign="bottom">
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
