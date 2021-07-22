<%@ Page Title="" Language="C#" MasterPageFile="~/BackGround.Master" AutoEventWireup="true" CodeBehind="Commont.aspx.cs" Inherits="Blog.Commont" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        #datalist {
            width: 500px;
            height: 500px;
            font-size: 14px;
        }

        #DataList1 {
            margin-left: 100px;
            margin-top: 30px;
        }
        #LinkButton1 {
            color:aqua
        }
    .auto-style1 {
        float: left;
    }
    </style>
    <div id="datalist">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <div style="float: left">
                    评论时间：<asp:Label ID="Label1" runat="server" Text='<%# Eval("Time") %>'></asp:Label>
                </div>
                <div style="margin-left: 100px;" class="auto-style1">
                    评论主题：<asp:Label ID="Label2" runat="server" Text='<%# Eval("Subject") %>'></asp:Label>
                </div>
                <div style="margin-top: 20px;">
                    评论内容：<asp:Label ID="Label3" runat="server" Text='<%# Eval("Content") %>'></asp:Label>
                </div>
                <div style="margin-top: 30px; margin-left: 200px;">
                    发表人：<asp:Label ID="Label4" runat="server" Text='<%# Eval("UserName") %>'></asp:Label>     
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("Subject") %>' OnClick="LinkButton1_Click" >【删除评论】</asp:LinkButton>            
                </div>
                <br />
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
