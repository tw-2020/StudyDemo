<%@ Page Title="" Language="C#" MasterPageFile="~/BackGround.Master" AutoEventWireup="true" CodeBehind="Friend.aspx.cs" Inherits="Blog.Friend" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        #t_h {
            width: 488px;
            height: 205px;
            font-size: 14px;
            line-height: 20px;
        }

            #t_h p {
                margin-left: 200px;
                font-weight: bold;
                color: #973307;
                margin-top: 10px;
            }

        #h_t {
            height: 20px;
            width: 350px;
            text-align:center;
            font-weight:bold;
        }

            #h_t td {
                
            }

        #m_t {
            height: 20px;
            width: 350px;
            text-align:center;
        }
        #select {
            margin-left:60px;
        }
    </style>
    <div id="t_h">
        <p>联系人信息</p>
        <div id="select">
            输入关键字：<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="查找" />
            <asp:LinkButton ID="LinkButton3" runat="server">添加联系人</asp:LinkButton>
        </div>
        <div style="margin-left: 80px; margin-top: 20px">
            <asp:DataList ID="DataList1" runat="server">
                <HeaderTemplate>
                    <table id="h_t">
                        <tr>
                            <td>姓名</td>
                            <td>性别</td>
                            <td>QQ</td>
                            <td>详情信息</td>
                            <td>删除</td>
                        </tr>
                    </table>
                </HeaderTemplate>

                <ItemTemplate>
                    <table id="m_t">
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text='<%# Eval("UserName") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text='<%# Eval("Sex") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text='<%# Eval("QQ") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("BlogID") %>'>查看</asp:LinkButton>
                            </td>
                            <td>
                                <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("BlogID") %>'>删除</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>

            </asp:DataList>
        </div>
    </div>
</asp:Content>
