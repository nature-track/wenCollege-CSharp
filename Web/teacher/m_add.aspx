<%@ Page Title="" Language="C#" MasterPageFile="~/weixin_mas.Master" AutoEventWireup="true" CodeBehind="m_add.aspx.cs" Inherits="Maticsoft.Web.teacher.m_add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
.textbox
{
    display: block; 
width: 90%; 
height: 10em; 
padding: 0.5em; 
margin:0.5em;
font-size: 1.5em; 
line-height: 1.428571429; 
color: #555555; 
vertical-align: middle; 
background-color: #ffffff; 
border: 1px solid #cccccc; 
border-radius: 4px; 
-webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); 
box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); 
-webkit-transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s; 
transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s; 
}
.textbox:focus { 
border-color: #66afe9; 
outline: 0; 
-webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,.075), 0 0 8px rgba(102, 175, 233, 0.6); 
box-shadow: inset 0 1px 1px rgba(0,0,0,.075), 0 0 8px rgba(102, 175, 233, 0.6); 
} 
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
             <div class="text1" >
                <p>尊敬的温氏集团讲师，为了保护您的个人信息不被泄露，我们需要对您的微信号进行核实，请在
                下面文本框中输入您的姓名</p>
            </div>
    <asp:TextBox ID="TextBox1" runat="server"  CssClass="textbox"  Width="90%" Height="2em" Wrap="True" style="overflow: visible" ></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="提交"   CssClass="btn2" 
                 onclick="Button1_Click" /> 
</asp:Content>
