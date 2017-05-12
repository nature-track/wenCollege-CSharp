<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Maticsoft.Web.hui_kuan_dan.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../jquery-ui-1.12.1.custom/external/jquery/jquery.js" type="text/javascript"></script>
    <script src="../jquery-ui-1.12.1.custom/jquery-ui.min.js" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 



    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		汇款内容：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txthuikuan_neirong" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		项目名称
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtxiangmu_mingcheng" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		项目总款
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtxiangmu_zongkuan" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		已付金额
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtyifu_jine" runat="server" Width="200px">0.00</asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		支付时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtzhifu_shijian" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		本次申请付款金额
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtbenci_jine" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		预计余款支付时间
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtyuji_yukuan" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		供应商
	：</td>
	<td height="25" width="*" align="left">
	    <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		类别：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtleibie" runat="server" Width="200px"></asp:TextBox>
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
                <asp:Button ID="btnSave" runat="server" Text="保存并生成汇款单"
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
