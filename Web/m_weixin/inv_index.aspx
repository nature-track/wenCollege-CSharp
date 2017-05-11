<%@ Page Title="" Language="C#" MasterPageFile="m_weixin.Master" AutoEventWireup="true" CodeBehind="inv_index.aspx.cs" Inherits="Maticsoft.Web.m_weixin.inv_index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
a { background:#c4c4c2; width:50%; height:2em; display:block; margin:0 auto; text-align:center; line-height:2em;  color:#5c636d; box-shadow:1px 1px #bfbfbf; font-size:1.2em; 
       margin: 2% 0 1% 0;
               -moz-border-radius       : 0.2em;
               -webkit-border-radius    : 0.2em;
               border-radius            : 0.2em;}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  Width="100%" AlternatingRowStyle-BackColor="#e6e5e3" RowStyle-HorizontalAlign="Center">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="id" 
                DataNavigateUrlFormatString="investigate.aspx?inv_n={0}"  
                DataTextField="title" />
        </Columns>
    </asp:GridView>
    <br />
    <a href="index.aspx">返回</a>
</asp:Content>
