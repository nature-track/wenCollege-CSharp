<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.hui_kuan_dan.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblid" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		huikuan_neirong
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblhuikuan_neirong" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		xiangmu_mingcheng
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblxiangmu_mingcheng" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		xiangmu_zongkuan
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblxiangmu_zongkuan" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		yifu_jine
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblyifu_jine" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		zhifu_shijian
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblzhifu_shijian" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		benci_jine
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbenci_jine" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		yuji_yukuan
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblyuji_yukuan" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		supplier_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsupplier_id" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		leibie
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblleibie" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		beizhu
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbeizhu" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




