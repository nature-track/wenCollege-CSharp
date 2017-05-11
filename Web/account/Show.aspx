<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="Maticsoft.Web.account.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../jquery-ui-1.12.1.custom/external/jquery/jquery.js" type="text/javascript"></script>
    <script src="../jquery-ui-1.12.1.custom/jquery-ui.min.js" type="text/javascript"></script>
    <style type="text/css">

    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h2 class="demoHeaders">温氏学院费用录入单</h2>
    <fieldset>
	    <legend>单号：<asp:Label id="lblid" runat="server"></asp:Label>
	    </legend>
	    <div >
        <table class="main_table" >
        <tr>
            <td>
                单据名称：</td>
             <td><asp:Label id="lblname" runat="server"  Width="100%"></asp:Label>
             </td>

        </tr>
        <tr>
          <td> 类别：</td>
          <td> <asp:Label id="lblleibei" runat="server"  Width="100%"></asp:Label> </td>
        </tr>
        <tr>
          <td>培训班：</td>
          <td><asp:Label id="lblpeixunban_id" runat="server"  Width="100%"></asp:Label>  </td>
        </tr>
        <tr>
            <td>
                备注：</td>
             <td><asp:Label id="lblbeizhu" runat="server"  Width="100%"></asp:Label></td>

        </tr>
        </table>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="main_table" Width="100%">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="序号" />
            <asp:BoundField DataField="wuzi" HeaderText="物资" />
            <asp:BoundField DataField="danwei" HeaderText="单位" />
            <asp:BoundField DataField="danjia" HeaderText="单价" />
            <asp:BoundField DataField="shuliang" HeaderText="数量" />
            <asp:BoundField DataField="beizhu" HeaderText="备注（供应商）" />
            <asp:BoundField DataField="xiaoji" HeaderText="小计" />
 
            
        </Columns>
    </asp:GridView>
        </div>

        <br />
        <table class="main_table" width="100%">
        <tr><td>录入人：<asp:Label id="lbllururen" runat="server"></asp:Label></td><td>录入时间：<asp:Label id="lbltime" runat="server"></asp:Label>

            </td>
            <td>
            合计：<asp:Label ID="sum_id" runat="server" Text="0.00"></asp:Label></td>
            </tr>
        </table>
        <br />
        <center><input id="Button1" type="button" value="返回" />&nbsp;&nbsp;<asp:Button 
                ID="Button2" runat="server"  Text="生成汇款单" onclick="Button2_Click" /> </center>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <br />
        </fieldset>

        <script type="text/javascript">
            $("#Button1").button();
            $("#<%=Button2.ClientID %>").button();
            $("#Button1").click(function () {
                window.location.href = "list.aspx";
            });
    </script>
                               

</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




