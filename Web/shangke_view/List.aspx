<%@ Page Title="shangke_view" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.shangke_view.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->
            <h2 class="demoHeaders">培训班课程安排</h2>
            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>培训班：</b>
                    </td>
                    <td class="tdbg">  
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>     
                    <%--<asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>--%>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" class="button white" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                     <asp:Button ID="Button1" runat="server" Text="添加" onclick="Button1_Click1" class="button white" />
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="id" HeaderText="id" SortExpression="id" ItemStyle-HorizontalAlign="Center"  /> 
		<%--<asp:BoundField DataField="kechengneirong_id" HeaderText="kechengneirong_id" SortExpression="kechengneirong_id" ItemStyle-HorizontalAlign="Center"  /> --%>
		<%--<asp:BoundField DataField="peixunban" HeaderText="peixunban" SortExpression="peixunban" ItemStyle-HorizontalAlign="Center"  />--%> 
		<%--<asp:BoundField DataField="peixunban_id" HeaderText="peixunban_id" SortExpression="peixunban_id" ItemStyle-HorizontalAlign="Center"  />--%> 
		<asp:BoundField DataField="kecheng" HeaderText="课程" SortExpression="kecheng" ItemStyle-HorizontalAlign="Center"  /> 
		<%--<asp:BoundField DataField="jiangshi_id" HeaderText="jiangshi_id" SortExpression="jiangshi_id" ItemStyle-HorizontalAlign="Center"  />--%> 
		<asp:BoundField DataField="jiangshi" HeaderText="讲师" SortExpression="jiangshi" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="keshi" HeaderText="课时" SortExpression="keshi" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="" DataNavigateUrlFormatString="Show.aspx?"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="" DataNavigateUrlFormatString="Modify.aspx?}"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
