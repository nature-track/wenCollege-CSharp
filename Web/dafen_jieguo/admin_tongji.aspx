<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_tongji.aspx.cs" Inherits="Maticsoft.Web.dafen_jieguo.admin_tongji" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        	<link rel="shortcut icon" href="favicon.ico">
    <link rel="Stylesheet" href="../js/jquery_mobile/css/themes/default/jquery.mobile-1.4.5.min.css" />

	<link rel="stylesheet" href="../js/jquery_mobile/_assets/css/jqm-demos.css">
        <meta name="viewport" content="width=device-width, initial-scale=1" />
	<script src="../js/jquery_mobile/js/jquery.js"></script>
	<script src="../js/jquery_mobile/_assets/js/index.js"></script>
	<script src="../js/jquery_mobile/js/jquery.mobile-1.4.5.min.js"></script>
        <style type="text/css"> 

    .ui-grid-a .ui-block-a { width: 25% } 

    .ui-grid-a .ui-block-b {  width: 75% } 
    .ui-grid-a { font-size:1.2em}
    #jieguo{ text-align:center}

</style>

    <script language='javascript' type='text/javascript'>
        $(document).ready(function () {
            jQuery.mobile.ajaxEnabled = false;
        }); 
    </script>
</head>
<body>
<div data-role="page" class="jqm-demos jqm-home">
    <form id="form1" runat="server">
    <div data-role="header" data-theme="a">
    <h1>培训效果评估表</h1>

    </div>
            <div role="main" class="ui-content jqm-content">
                 <div class="ui-grid-a">
                 <div class="ui-block-a"><div class="ui-bar ui-bar-a" style="height:60px">培训班</div></div>
                 <div class="ui-block-b"><div class="ui-bar ui-bar-a" style="height:60px">
                     <asp:DropDownList ID="qishu" runat="server">
                     </asp:DropDownList>
                     </div></div>
                  <div class="ui-block-a"><div class="ui-bar ui-bar-a" style="height:60px">统计形式</div></div>
                  <div class="ui-block-b"><div class="ui-bar ui-bar-a" style="height:60px">
                      <asp:DropDownList ID="tongji" runat="server" 
                           AutoPostBack="True" onselectedindexchanged="tongji_SelectedIndexChanged">
                          <asp:ListItem Value="1">总表统计</asp:ListItem>
                          <asp:ListItem Value="2">分项统计</asp:ListItem>
                      </asp:DropDownList>
                      </div></div>
            </div>
            <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  data-role="table" data-mode="columntoggle" class="ui-body-d table-stripe ui-responsive">
                <Columns>
                    <asp:BoundField DataField="kecheng" HeaderText="课程" ReadOnly="True" 
                        SortExpression="kecheng" />
                    <asp:BoundField DataField="jiangshi" HeaderText="讲师" ReadOnly="True" 
                        SortExpression="jiangshi" />
                    <asp:BoundField DataField="pingjunfen" HeaderText="平均分" ReadOnly="True" 
                        SortExpression="pingjunfen" />
                </Columns>
    </asp:GridView>
            </div>
            <div>
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False"  data-role="table" data-mode="columntoggle" class="ui-body-d table-stripe ui-responsive">
                    <Columns>
                        <asp:BoundField DataField="kecheng" HeaderText="课程" ReadOnly="True" 
                            SortExpression="kecheng" />
                        <asp:BoundField DataField="jiangshi" HeaderText="讲师" 
                            SortExpression="jiangshi" />
                        <asp:BoundField DataField="text" HeaderText="评分项" ReadOnly="True" 
                            SortExpression="text" />
                        <asp:BoundField DataField="count_fenshu" HeaderText="回收问卷数" ReadOnly="True" 
                            SortExpression="count_fenshu" />
                        <asp:BoundField DataField="avg_fenshu" HeaderText="平均分" ReadOnly="True" 
                            SortExpression="avg_fenshu" />
                    </Columns>
                </asp:GridView>
            
            </div>
        </div>
    
   
    </form>
</div>
</body>
</html>
