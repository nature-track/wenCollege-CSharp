<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="admin_count.aspx.cs" Inherits="Maticsoft.Web.dafen_jieguo.admin_count" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Title -->
<h2 class="demoHeaders">课程评价问卷统计</h2>
            <!--Title end -->

                        <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>培训班：</b>
                    </td>
                    <td class="tdbg"> 
                        <asp:DropDownList ID="qishu" runat="server"                          
                            AutoPostBack="True" onselectedindexchanged="qishu_SelectedIndexChanged">
                        </asp:DropDownList>                      
                    <%--<asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>--%>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="确定"  OnClick="btnSearch_Click" class="button white">
                    </asp:Button>                    
                        
                    </td>

                </tr>
            </table>
            <div id="tabs">
	<ul>
		<li><a href="#tabs-1">汇总分数统计</a></li>
		<li><a href="#tabs-2">分项分数统计</a></li>
		<li><a href="#tabs-3">开放问题反馈</a></li>
        <li><a href="#tabs-4">培训班整体评价的开放问题汇总</a></li>
	</ul>
	<div id="tabs-1">
                  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"   CssClass="main_table" >
                <Columns>
                    <asp:BoundField DataField="kecheng" HeaderText="课程" ReadOnly="True" 
                        SortExpression="kecheng" />
                    <asp:BoundField DataField="jiangshi" HeaderText="讲师" ReadOnly="True" 
                        SortExpression="jiangshi" />
                    <asp:BoundField DataField="pingjunfen" HeaderText="平均分" ReadOnly="True" DataFormatString="{0:#.##}" HtmlEncode="false"
                        SortExpression="pingjunfen" />
                </Columns>
    </asp:GridView>
    </div>
	<div id="tabs-2">
        
                        <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>请选择课程</b>
                    </td>
                    <td class="tdbg"> 
                        <asp:DropDownList ID="kecheng" runat="server"                          
                            AutoPostBack="True" onselectedindexchanged="kecheng_SelectedIndexChanged" >
                        </asp:DropDownList>                      
                    <%--<asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>--%>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="确定"  OnClick="btnSearch_Click" class="button white">
                    </asp:Button>                    
                        
                    </td>

                </tr>
            </table>
            <div class="ui-widget">
	<div class="ui-state-error ui-corner-all" style="padding: 0 .7em; margin:0.7em;">
		<p><span class="ui-icon ui-icon-alert" style="float: left; margin-right: .3em;"></span>
		<strong>注意:</strong> 选择课程后，页面会默认返回第一个工作表，重新点击第二个工作表即可</p>
	</div>
</div>

        </asp:DropDownList>
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False"  CssClass="main_table">
                    <Columns>
                        <asp:BoundField DataField="kecheng" HeaderText="课程" ReadOnly="True" 
                            SortExpression="kecheng" />
                        <asp:BoundField DataField="jiangshi" HeaderText="讲师" 
                            SortExpression="jiangshi" />
                        <asp:BoundField DataField="text" HeaderText="评分项" ReadOnly="True" 
                            SortExpression="text" />
                        <asp:BoundField DataField="count_fenshu" HeaderText="回收问卷数" ReadOnly="True" 
                            SortExpression="count_fenshu" />
                        <asp:BoundField DataField="avg_fenshu" HeaderText="平均分" ReadOnly="True" DataFormatString="{0:#.##}" HtmlEncode="false"
                            SortExpression="avg_fenshu" />
                    </Columns>
                </asp:GridView>
        
    </div>
	<div id="tabs-3">
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False"  CssClass="main_table2">
            <Columns>
                

                <asp:TemplateField HeaderText="课程" SortExpression="kecheng" >
                    <ItemTemplate >
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("kecheng") %>'></asp:Label>
                      <br />  (
                     <asp:Label ID="Label2" runat="server" Text='<%# Bind("jiangshi") %>'></asp:Label>
                     )
                    </ItemTemplate>

                </asp:TemplateField>

                <asp:BoundField DataField="text" HeaderText="问题" SortExpression="text" />
                <asp:BoundField DataField="pingjia" HeaderText="评价" 
                    SortExpression="pingjia" HtmlEncode="false" />
            </Columns>
        </asp:GridView>
    </div>

    <div id="tabs-4">
        <asp:Label ID="yuanyi" runat="server" Text="Label"></asp:Label>
        <br />
                    <asp:GridView ID="GridView4" runat="server"  AutoGenerateColumns="False"  CssClass="main_table2">
                        <Columns>
                            <asp:BoundField DataField="text" HeaderText="问题" SortExpression="text"/>
                       <asp:BoundField DataField="pingjia" HeaderText="反馈" 
                    SortExpression="pingjia" HtmlEncode="false" />
                        </Columns>
                </asp:GridView>
    </div>
</div>

<%--    <script src="../jquery-ui-1.12.1.custom/external/jquery/jquery.js" type="text/javascript"></script>

    <script src="../jquery-ui-1.12.1.custom/jquery-ui.js" type="text/javascript"></script>--%>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
