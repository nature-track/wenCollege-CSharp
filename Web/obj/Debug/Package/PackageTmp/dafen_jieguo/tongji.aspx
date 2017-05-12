<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tongji.aspx.cs" Inherits="Maticsoft.Web.dafen_jieguo.tongji" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>评估统计</title>
<meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimum-scale=1.0, maximum-scale=1.0">
<meta name="apple-mobile-web-app-capable" content="yes" />
<meta name="apple-mobile-web-app-status-bar-style" content="default" />
<meta http-equiv="cache-control" content="no-transform"/>
<meta content="telephone=no" name="format-detection">
<meta http-equiv="pragma" content="no-cache">
<meta http-equiv="cache-control" content="no-cache">
<link href="css/css.css" rel="stylesheet" type="text/css">
    <script src="js/jquery-1.11.0.min.js" type="text/javascript"></script>
   <style type="text/css">
   .GridViewStyle
{  
    border:2px solid #f7f3e7;
    padding: 4px;
}
.GridViewHeaderStyle
{
    background-color:#e2cb9f;
    text-align: center;
    line-height: 2em;
    color: #8b5c2b;
}
.GridViewRowStyle
{
        text-align: center;
    line-height: 2em
}
   </style>
</head>
<body>

    <form id="form1" runat="server">
        <div class="bgg1"></div>
<div class="lauguage1"> </div>
<div class="slogan1"><img src="img/slogan1.png"></div>
<center>

    <div class="text1">
                 <p>培训班：<asp:Label ID="peixunban" runat="server" Text="Label"></asp:Label></p>
                 </div>
                 <div class="text1" ><p>小组</p></div>
                  <div class="styled-select">
                      <asp:DropDownList ID="fenzu" runat="server" 
                          onselectedindexchanged="fenzu_SelectedIndexChanged" AutoPostBack="True" CssClass="ui-select">
                      </asp:DropDownList>
                      </div>
                    <br />
                      <asp:Button ID="Button2" runat="server" Text="查看问卷回收情况" onclick="Button2_Click"  CssClass="btn2"/>


                    <br />
                     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  Width="90%" AlternatingRowStyle-BackColor="#f7f3e7" CssClass="GridViewStyle">
                     <HeaderStyle CssClass="GridViewHeaderStyle"/>
                     <RowStyle CssClass="GridViewRowStyle"/>  
                         <Columns>
                             <asp:BoundField DataField="kecheng" HeaderText="课程" ReadOnly="True" 
                                 SortExpression="kecheng" />
                             <asp:BoundField DataField="fenshu_count" HeaderText="回收问卷数" ReadOnly="True" 
                                 SortExpression="fenshu_count" />
                         </Columns>
                     </asp:GridView>
                                     <br />
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False"  Width="90%" AlternatingRowStyle-BackColor="#f7f3e7" CssClass="GridViewStyle">
                        <AlternatingRowStyle BackColor="#F7F3E7" />
                                          <HeaderStyle CssClass="GridViewHeaderStyle"/>
                     <RowStyle CssClass="GridViewRowStyle"/> 
                        <Columns>
                            <asp:BoundField DataField="kecheng" HeaderText="已评价课程" 
                                SortExpression="kecheng" />
                        </Columns>
                    </asp:GridView>
                        <asp:Button ID="Button1" runat="server" Text="返回填表" onclick="Button1_Click" CssClass="btn2"/>
                        <asp:Literal ID="Literal1" runat="server"></asp:Literal>

                
</center>
    </form>

</body>
</html>
