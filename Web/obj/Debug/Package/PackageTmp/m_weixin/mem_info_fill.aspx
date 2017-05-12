<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mem_info_fill.aspx.cs" Inherits="Maticsoft.Web.m_weixin.mem_info_fill" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimum-scale=1.0, maximum-scale=1.0">
<meta name="apple-mobile-web-app-capable" content="yes" />
<meta name="apple-mobile-web-app-status-bar-style" content="default" />
<meta http-equiv="cache-control" content="no-transform"/>
<meta content="telephone=no" name="format-detection">
<meta http-equiv="pragma" content="no-cache">
<meta http-equiv="cache-control" content="no-cache">
    <link href="../dafen_jieguo/css/css.css" rel="stylesheet" type="text/css" />
    <script src="../js/jquery-1.10.2.min.js" type="text/javascript"></script>
    <style type="text/css">
.textbox
{
    display: block; 
    width:90%;
padding: 0.5em; 
margin:0.5em;
font-size: 1.5em; 
line-height: 1.428571429; 
color: #555555; 
vertical-align: middle; 
background-color: #ffffff; 
border: 1px solid #cccccc; 
border-radius: 4px; 
-webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); 
box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); 
-webkit-transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s; 
transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s; 
}
.textbox:focus { 
border-color: #66afe9; 
outline: 0; 
-webkit-box-shadow: inset 0 1px 1px rgba(0,0,0,.075), 0 0 8px rgba(102, 175, 233, 0.6); 
box-shadow: inset 0 1px 1px rgba(0,0,0,.075), 0 0 8px rgba(102, 175, 233, 0.6); 
} 
</style>
</head>
<body>
    <form id="form1" runat="server">
       <div class="bgg"></div>
       <div class="logo">
       <img src="../dafen_jieguo/img/logo.png" />
       </div>
  <center>

        <div class="text1" >
           <p>培训班</p>
        </div>
        <div class="styled-select">
            <asp:DropDownList ID="qishu" runat="server"   CssClass="ui-select"> </asp:DropDownList>
         </div>
          <div class="text1" >
              <p>姓名</p>
         </div>
         <div class="text1">
            <asp:TextBox ID="name" runat="server" CssClass="textbox"></asp:TextBox>
         </div>

         <asp:Button ID="Button1" runat="server" Text="确定"  CssClass="btn2" 
            onclick="Button1_Click"/>
    </center>
    
    </form>
</body>
</html>
