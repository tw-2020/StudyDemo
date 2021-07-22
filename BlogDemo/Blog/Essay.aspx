<%@ Page Title="" Language="C#" MasterPageFile="~/BackGround.Master" AutoEventWireup="true" CodeBehind="Essay.aspx.cs" Inherits="Blog.Essay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        #main {
            width: 530px;
            height: 530px;
            font-size: 14px;
            line-height: 20px;
        }

        #h_t {
            width: 500px;
            border: 1px dashed green;
        }

            #h_t td {
                width: 400px;
            }

        #b_p {
            font-size: 12px;
        }

        #less {
            width: 530px;
            height: 200px;
            font-size: 14px;
            line-height: 20px;
        }

            #less table {
                margin-left: 100px;
            }

        #add {
            width: 530px;
            height: 200px;
            font-size: 14px;
            line-height: 20px;
        }

            #add table {
                margin-left: 100px;
            }
    </style>
    <asp:Panel ID="Panel1" runat="server">
        <div id="main">
            <asp:DataList ID="DataList1" runat="server">

                <ItemTemplate>
                    <table id="h_t">
                        <tr>
                            <td>发表时间：<asp:Label ID="Label1" runat="server" Text='<%# Eval("Time") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>主题：<asp:Label ID="Label2" runat="server" Text='<%# Eval("subject") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>文章内容：<asp:Label ID="Label3" runat="server" Text='<%# Eval("content") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="text-align: right">发表人：<asp:Label ID="Label4" runat="server" Text='<%# Eval("Author") %>'></asp:Label>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("subject") %>' OnClick="LinkButton1_Click">【查看评论】</asp:LinkButton>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("Subject") %>' OnClick="LinkButton2_Click">【我要评论】</asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>

            </asp:DataList>
            <div id="b_p">
                <table>
                    <tr>
                        <td>当前页码：[<asp:Label ID="Label5" runat="server" Text="1"></asp:Label>]
                        </td>
                        <td>总页码：[<asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>]
                        </td>
                        <td>&nbsp;
                        <asp:LinkButton ID="LinkButton3" runat="server" Font-Underline="False" ForeColor="Red" OnClick="LinkButton3_Click">第一页</asp:LinkButton>&nbsp;
                        <asp:LinkButton ID="LinkButton4" runat="server" ForeColor="Red" OnClick="LinkButton4_Click">上一页</asp:LinkButton>&nbsp;
                        <asp:LinkButton ID="LinkButton5" runat="server" ForeColor="Red" OnClick="LinkButton5_Click">下一页</asp:LinkButton>&nbsp;
                        <asp:LinkButton ID="LinkButton6" runat="server" Font-Underline="True" ForeColor="Red" OnClick="LinkButton6_Click">最后一页</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <div id="less">
            <asp:Table ID="Table1" runat="server" Height="97px" Width="320px">
                <asp:TableRow>
                    <asp:TableCell>主题：</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow Height="30px">
                    <asp:TableCell>评论内容：</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>评论时间：</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2" s>
                        <asp:Button ID="Button1" runat="server" Text="返回" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server">
        <div id="add">
            <p style="margin-left: 220px">评 论</p>
            <table>
                <tr>
                    <td>
                        主题：
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        请输入您的评论：
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" Height="78px" Width="205px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align:center">
                        <asp:Button ID="Button2" runat="server" Text="提交" OnClick="Button2_Click" />
                        <asp:Button ID="Button3" runat="server" Text="返回" />
                    </td>
                </tr>
            </table>
        </div>
    </asp:Panel>
</asp:Content>
