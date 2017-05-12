<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="Maticsoft.Web.finance.test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
    <asp:TextBox   ID="TextBox1" runat="server" OnTextChanged="ccc" 
        AutoPostBack="True"></asp:TextBox>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
