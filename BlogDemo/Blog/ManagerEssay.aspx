<%@ Page Title="" Language="C#" MasterPageFile="~/BackGround.Master" AutoEventWireup="true" CodeBehind="ManagerEssay.aspx.cs" Inherits="Blog.ManagerEssay" %>

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
                margin-left: 180px;
                font-weight: bold;
                color: #973307;
                margin-top: 10px;
            }

        .auto-style1 {
            height: 24px;
        }

        .auto-style4 {
            height: 24px;
            width: 77px;
        }

        .auto-style5 {
            height: 24px;
            width: 41px;
        }

        .auto-style6 {
            height: 24px;
            width: 88px;
        }

        .auto-style7 {
            height: 24px;
            width: 80px;
        }

        #h_t {
            height: 20px;
            width: 350px;
            border-right: 1px solid black;
            border-top: 1px solid black;
            text-align: center;
            font-weight: bold
        }

            #h_t td {
                border-left: 1px solid black;
            }

        #t_m {
            width: 350px;
            text-align: center;
            border-right: 1px solid black;
            border-bottom: 1px solid black
        }

            #t_m td {
                border-left: 1px solid black;
                border-top: 1px solid black
            }

        #select {
            margin-left: 60px;
        }

        #p_2_b {
            width: 540px;
            height: 455px;
            font-size: 14px;
            border: 1px solid black;
        }

            #p_2_b p {
                width: 422px;
                height: 31px;
                text-align: center;
                font-weight: bold;
                color: #973307;
                margin-top: 30px;
            }

            #p_2_b table {
                margin-left: 100px;
            }
    </style>

    <asp:Panel ID="Panel1" runat="server">
        <div id="t_h">

            <p>文章信息管理</p>
            <div id="select">
                输入关键字：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="查找" OnClick="Button1_Click" />
                <asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">添加新文章</asp:LinkButton>
            </div>
            <div style="margin-left: 80px; margin-top: 20px">
                <asp:DataList ID="DataList1" runat="server" Height="33px">
                    <HeaderTemplate>
                        <table id="h_t">
                            <tr>
                                <td>文章主题</td>
                                <td>文章内容</td>
                                <td>创作时间</td>
                                <td>编辑</td>
                                <td>删除</td>
                            </tr>
                        </table>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <table id="t_m">
                            <tr>
                                <td class="auto-style6">
                                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("Subject") %>'></asp:Label>
                                </td>
                                <td class="auto-style4">
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("Content") %>'></asp:Label>
                                </td>
                                <td class="auto-style7">
                                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("Time") %>'></asp:Label>
                                </td>
                                <td class="auto-style5">
                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("Subject") %>' OnClick="LinkButton1_Click">编辑</asp:LinkButton>
                                </td>
                                <td class="auto-style1">
                                    <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%# Eval("Subject") %>' OnClick="LinkButton2_Click">删除</asp:LinkButton>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </div>

        </div>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <div id="p_2_b">
            <p>添加新的文章</p>
            <table>
                <tr>
                    <td>文章主题：</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>文章内容：
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
                        <asp:Button ID="Button2" runat="server" Text="添加" OnClick="Button2_Click" />&nbsp;
                        <asp:Button ID="Button3" runat="server" Text="返回" />
                    </td>
                </tr>
            </table>
        </div>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server">
         <div id="p_2_b">
            <p>编辑文章</p>
            <table>
                  <tr>
                    <td>
                        文章作者：
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>文章主题：</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>文章内容：
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" Height="108px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align: center">
                        <asp:Button ID="Button4" runat="server" Text="修改" OnClick="Button4_Click" />&nbsp;
                        <asp:Button ID="Button5" runat="server" Text="返回" />
                    </td>
                </tr>
            </table>
        </div>
    </asp:Panel>
</asp:Content>
