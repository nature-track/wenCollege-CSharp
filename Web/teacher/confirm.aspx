<%@ Page Title="讲师确认" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="confirm.aspx.cs" Inherits="Maticsoft.Web.teacher.confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<h2 class="demoHeaders">讲师信息确认</h2>
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		openid
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="openid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		提交姓名
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="name" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		微信昵称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="weixn_nickname" runat="server"></asp:Label>
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		更新时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="date_time" runat="server"></asp:Label>
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		确认讲师
	：</td>
	<td height="25" width="*" align="left">
	    <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
		
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="confirm_btn" runat="server" Text="确定" 
                            onclick="confirm_btn_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    </asp:Content>
