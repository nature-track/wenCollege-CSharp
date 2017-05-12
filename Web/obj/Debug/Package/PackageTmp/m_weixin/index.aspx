<%@ Page Title="" Language="C#" MasterPageFile="m_weixin.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Maticsoft.Web.weixin.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<asp:Literal ID="huanying_ci" runat="server"></asp:Literal>
<a href="mem_info_fill.aspx" class="btn2">填写个人信息</a>
<a href="../dafen_jieguo/start.aspx" class="btn2">课程评价</a>
<a href="inv_index.aspx" class="btn2">调查反馈</a>
<a href="dis_index.aspx" class="btn2">课程交流</a>

</asp:Content>
