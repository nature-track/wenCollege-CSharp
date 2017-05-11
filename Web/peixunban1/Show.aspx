<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.peixunban1.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">

	<tr>
	<td height="25" width="30%" align="right">
		开始时间：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstart_time" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		结束时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblend_time" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		培训班名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblname" runat="server"></asp:Label>
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		联系人
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="contact" runat="server"></asp:Label>
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		联系电话
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="phone" runat="server"></asp:Label>
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		具体入住明细
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="start_detail" runat="server"></asp:Label>
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		具体退房明细
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="end_detail" runat="server"></asp:Label>
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		培训人数
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="num" runat="server"></asp:Label>
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		人数具体说明
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="num_detail" runat="server"></asp:Label>
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		预计清洁费用
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="cleaning_fee" runat="server"></asp:Label>
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		发票抬头
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="fapiao_taitou" runat="server"></asp:Label>
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		篮球场使用时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="basketball_time" runat="server"></asp:Label>
	</td></tr>
     <tr>
	<td height="25" width="30%" align="right">
		通知饭堂订餐
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="fantang" runat="server"></asp:Label>
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		是否需要制作学员证
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="fangka_print" runat="server"></asp:Label>
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		是否需要洗漱用品
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="xishu_yongpin" runat="server"></asp:Label>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		备注
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="beizhu" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
                <tr>
                <td style="text-align:center">
                 <a href="List.aspx" style="margin:2px; padding:2px 3px; background-color:Gray; color:White" >  返回  </a>  
                </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




