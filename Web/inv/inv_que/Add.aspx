<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Maticsoft.Web.inv_que.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">   
请选择调查问卷： <asp:DropDownList ID="inv_que_n" runat="server">
            </asp:DropDownList>
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">

	<tr>
	<td height="25" width="30%" align="right">
		问题
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttext" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		类型：</td>
	<td height="25" width="*" align="left">
       <asp:DropDownList ID="style_dro" runat="server">
           <asp:ListItem Selected="True">单选题</asp:ListItem>
           <asp:ListItem>打分题</asp:ListItem>
           <asp:ListItem>问答题</asp:ListItem>
        </asp:DropDownList>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		备注：</td>
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
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
