<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Maticsoft.Web.fenzu.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../jquery-ui-1.12.1.custom/external/jquery/jquery.js" type="text/javascript"></script>
    <script src="../jquery-ui-1.12.1.custom/jquery-ui.js" type="text/javascript"></script>
    	
        
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
  

    <br />


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server"> 


<!-- Tabs -->
<h2 class="demoHeaders">培训班分组</h2>


                       <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                        <tr>
                            <td class="tdbg">
                
                <table cellSpacing="0" cellPadding="0" width="100%" border="0">
                    <tr>
                    <td height="25" width="30%" align="right">培训班：</td>
                    <td height="25" width="*" align="left"><asp:Label ID="Label2"
                            runat="server" Text="Label"></asp:Label>
                        <asp:Label ID="Label1" runat="server" Text="培训班"></asp:Label><%--<asp:DropDownList ID="DropDownList2" runat="server" >   </asp:DropDownList>--%></td>
                    </tr>
	                <tr>
	                <td height="25" width="30%" align="right">
		                组数
	                ：</td>
	                <td height="25" width="*" align="left">
		
	                    <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Value="1">第一组</asp:ListItem>
                            <asp:ListItem Value="2">第二组</asp:ListItem>
                            <asp:ListItem Value="3">第三组</asp:ListItem>
                            <asp:ListItem Value="4">第四组</asp:ListItem>
                            <asp:ListItem Value="5">第五组</asp:ListItem>
                            <asp:ListItem Value="6">第六组</asp:ListItem>
                            <asp:ListItem Value="7">第七组</asp:ListItem>
                            <asp:ListItem Value="8">第八组</asp:ListItem>
                        </asp:DropDownList>
	                </td></tr>
	                <tr>
	                <td height="25" width="30%" align="right">
		                组名
	                ：</td>
	                <td height="25" width="*" align="left">
		                <asp:TextBox id="txtzuming" runat="server" Width="200px"></asp:TextBox>
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
