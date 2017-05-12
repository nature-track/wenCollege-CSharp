<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="list_detail.aspx.cs" Inherits="Maticsoft.Web.account_detail.list_detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../jquery-ui-1.12.1.custom/external/jquery/jquery.js" type="text/javascript"></script>
    <script src="../jquery-ui-1.12.1.custom/jquery-ui.min.js" type="text/javascript"></script>
    <style type="text/css">

    </style>
     <script language='javascript' type='text/javascript'>
         $(document).ready(function () {
             $("#<%=start_time.ClientID %>").datepicker();
             $("#<%=end_time.ClientID %>").datepicker();
         }); 
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <br />
    <h2 class="demoHeaders">温氏学院费用明细单</h2>
    <fieldset>
	    <legend>明细</legend>
	    <div id="controlgroup">
        <table width="100%"  >
          <tr>
          <td>开始时间</td><td><asp:TextBox ID="start_time" runat="server"></asp:TextBox></td>
           <td>结束时间</td><td><asp:TextBox ID="end_time" runat="server"></asp:TextBox></td>   
          </tr>
          <tr>
          <td>培训班</td><td><asp:DropDownList ID="qishu" runat="server"></asp:DropDownList></td>
          <td>经手人</td><td><asp:DropDownList ID="lururen" runat="server"></asp:DropDownList></td>
          </tr>
          <tr>
          <td>简约显示</td><td><asp:CheckBox ID="CheckBox1" runat="server" /></td>
              
          </tr>
          <tr>
          <td colspan="4"><center><asp:Button ID="Button1" runat="server" Text="确定" onclick="Button1_Click" /></center></td>
          </tr>
        </table>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  
                OnRowDataBound="GridView1_RowDataBound" ShowFooter="True" CssClass="main_table2"
          >
        <Columns>
            <asp:BoundField DataField="detail_id" HeaderText="id" 
                SortExpression="detail_id" />
            <asp:BoundField DataField="peixunban" HeaderText="培训班" 
                SortExpression="peixunban" />
            <asp:BoundField DataField="lururen" HeaderText="经手人" SortExpression="lururen" />
            <asp:BoundField DataField="leibei" HeaderText="类别" SortExpression="leibei" />
            <asp:BoundField DataField="wuzi" HeaderText="物品" SortExpression="wuzi" />
            <asp:BoundField DataField="danwei" HeaderText="单位" SortExpression="danwei" />
            <asp:BoundField DataField="danjia" HeaderText="单价" SortExpression="danjia"  DataFormatString="{0:N2}"/>
            <asp:BoundField DataField="shuliang" HeaderText="数量" 
                SortExpression="shuliang" />
            <asp:BoundField DataField="xiaoji" HeaderText="小计" SortExpression="xiaoji" DataFormatString="{0:N2}" />
            <asp:BoundField DataField="beizhu" HeaderText="备注" SortExpression="beizhu" />
            <asp:BoundField DataField="time" HeaderText="录入时间" DataFormatString="{0:yyyy-MM-dd}"  SortExpression="time" />
        </Columns>
    </asp:GridView>
    </div>
    </fieldset>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
