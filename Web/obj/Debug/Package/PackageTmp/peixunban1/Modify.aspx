<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="Maticsoft.Web.peixunban1.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">

	<tr>
	<td height="25" width="30%" align="right">
		开始时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstart_time" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		结束时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtend_time" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		培训班名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtname" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		联系人
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcontact" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		电话
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtphone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		入住时间明细
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstart_detail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		退房时间明细
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtend_detail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		人数
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtnum" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		人数明细
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtnum_detail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		清洁费
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcleaning_fee" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		发票抬头
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfapiao_taitou" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		篮球场使用时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtbasketball_time" runat="server" Width="200px" ></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		饭堂订餐
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfantang" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		学员证打印
	：</td>
	<td height="25" width="*" align="left">
<%--		<asp:TextBox id="txtfangka_print" runat="server" Width="200px"></asp:TextBox>--%>
        <asp:DropDownList ID="fangka_print" runat="server" Width="200px">
                    <asp:ListItem  Value="1">简单房卡不需要印名字</asp:ListItem>
                    <asp:ListItem Value="2">学员证需要印名字</asp:ListItem>
                </asp:DropDownList>
	</td></tr>
    <tr>
	<td height="25" width="30%" align="right">
		洗漱用品
	：</td>
	<td height="25" width="*" align="left">
<%--		<asp:TextBox id="xishu_yongpin" runat="server" Width="200px"></asp:TextBox>--%>
                <asp:DropDownList ID="xishu" runat="server" Width="200px">
                    <asp:ListItem  Value="1">简易洗漱用品</asp:ListItem>
                    <asp:ListItem Value="2">旅行套装</asp:ListItem>
                </asp:DropDownList>
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		备注
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbeizhu" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

