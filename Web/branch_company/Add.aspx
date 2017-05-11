<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Maticsoft.Web.branch_company.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    

培训班名称：<asp:TextBox ID="peixunban" runat="server"></asp:TextBox><br />
开始时间：<asp:TextBox ID="start_time" runat="server"></asp:TextBox><br />
结束时间：<asp:TextBox ID="end_time" runat="server"></asp:TextBox><br />
联系人：<asp:TextBox ID="contact" runat="server"></asp:TextBox><br />
联系电话：<asp:TextBox ID="phone" runat="server"></asp:TextBox><br />
备注：<asp:TextBox ID="备注" runat="server"></asp:TextBox><br />
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		peixunban_id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtpeixunban_id" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		入住时间说明
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstart_detail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		退房时间说明
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
		住宿人数备注
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtnum_detail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		预计分摊清洁费
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtcleaning_fee" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		清洁费发票抬头
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfapiao_taitou" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		使用篮球场时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtbasketball_time" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		饭堂用餐说明
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfantang" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		学员证（房卡）打印
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfangka_print" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		阅读说明
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtyuedu_shuoming" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		fengongsi
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtfengongsi" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		date
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtdate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

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
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
