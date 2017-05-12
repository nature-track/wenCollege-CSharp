<%@ Page Title="wuzi_diaoyong" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="Maticsoft.Web.wuzi_diaoyong.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../jquery-ui-1.12.1.custom/external/jquery/jquery.js" type="text/javascript"></script>
    <script src="../jquery-ui-1.12.1.custom/jquery-ui.min.js" type="text/javascript"></script>
    <style type="text/css">
    .main_table td
    {
    font-size:1em;
    padding:0em;
    text-align:center;
    }
    .main_table td input
    {
        height:1.5em;
        width:100%;
        border:none;
    }
    #controlgroup
    {
        width:100%;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <br />
    <h2 class="demoHeaders">温氏学院物料领用单</h2>
    <fieldset>
	    <legend>物资调用查看</legend>
	    <div  >  
         <table class="main_table">
          <tr>
             <td >分公司</td><td> <asp:Label ID="fengongsi" runat="server" Text=""></asp:Label></td>
          </tr>
          <tr>
             <td>培训班</td><td><asp:DropDownList ID="qishu" runat="server" Width="100%" 
                  AutoPostBack="True" onselectedindexchanged="qishu_SelectedIndexChanged"></asp:DropDownList></td>
          </tr>
             
        </table>
        </div>
        <asp:Button ID="Button1" runat="server" Text="查询" onclick="Button1_Click"  /><input id="Button2" type="button"  value="填写申请"   />
        <br />
        <br />
&nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="main_table">
            <Columns>
        		<asp:BoundField DataField="id" HeaderText="id" SortExpression="wuzi_id"  /> 
		        <asp:BoundField DataField="name" HeaderText="物资" SortExpression="name"  /> 
		        <asp:BoundField DataField="fengongsi" HeaderText="分公司" SortExpression="fengongsi"  /> 
		        <asp:BoundField DataField="num" HeaderText="数量" SortExpression="num"   /> 
		        <asp:BoundField DataField="danjia" HeaderText="单价" SortExpression="danjia"  /> 
		        <asp:BoundField DataField="peixunban" HeaderText="培训班" SortExpression="peixunban"  /> 
                <asp:TemplateField HeaderText="类型" SortExpression="style">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("style").ToString()=="1"?"调用":"归还" %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
		        <asp:BoundField DataField="time" HeaderText="时间" SortExpression="time"   />           
            </Columns>
        </asp:GridView>
        
    </fieldset>



                <script type="text/javascript">
                    $("#<%=Button1.ClientID  %>").button();
                    $("#Button2").button();
                    $("#Button2").click(function () {
                        window.location.href = "add.aspx";
                    });
                </script>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
