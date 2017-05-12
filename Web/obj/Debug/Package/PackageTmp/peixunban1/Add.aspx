<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Maticsoft.Web.peixunban1.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script language='javascript' type='text/javascript'>
    $(document).ready(function () {
        $("#<%=txtstart_time.ClientID %>").datepicker();
        $("#<%=txtend_time.ClientID %>").datepicker();
    }); 
    </script>
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
		<asp:TextBox id="txtstart_time"  runat="server" Width="200px"></asp:TextBox>
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
		<asp:TextBox id="contact" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		联系电话
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="phone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		备注
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="beizhu" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
    	<tr>
	<td height="25" width="30%" align="right">
		类别
	：</td>
	<td height="25" width="*" align="left">
	    <asp:DropDownList ID="sinal" runat="server" Width="200px">
            <asp:ListItem Value="1">集团培训</asp:ListItem>
            <asp:ListItem Value="2">分公司培训</asp:ListItem>
        </asp:DropDownList>
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
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
