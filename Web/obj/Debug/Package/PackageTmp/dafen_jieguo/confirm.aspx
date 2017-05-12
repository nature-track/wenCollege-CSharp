<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="confirm.aspx.cs" Inherits="Maticsoft.Web.dafen_jieguo.confirm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>课程调查问卷</title>
<meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimum-scale=1.0, maximum-scale=1.0">
<meta name="apple-mobile-web-app-capable" content="yes" />
<meta name="apple-mobile-web-app-status-bar-style" content="default" />
<meta http-equiv="cache-control" content="no-transform"/>
<meta content="telephone=no" name="format-detection">
<meta http-equiv="pragma" content="no-cache">
<meta http-equiv="cache-control" content="no-cache">
<link href="css/css.css" rel="stylesheet" type="text/css">
    <script src="js/jquery-1.11.0.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {

//            $("#Button1").click(function () {
//                window.location.href = "dafen_total.aspx?";
//            })
            $("#Button2").click(function () {
                window.location.href = "start.aspx";
            })
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="bgg"></div>
       <div class="logo">
    <img src="img/logo.png">
</div>
  <center>
<div class="text">
<p>确认信息</p>
</div>

            <div class="text1" >
            <br />
                培训班：<asp:Label ID="peixunban" runat="server" Text="暂无"></asp:Label><br /><br />
                <%--组序号<asp:Label ID="fenzu_id" runat="server" Text=""></asp:Label><br />--%>
                课程名称：<asp:Label ID="kecheng" runat="server" Text="暂无"></asp:Label><br /><br />
        讲师：<asp:Label ID="jiangshi" runat="server" Text="暂无"></asp:Label><br /><br />
        组名：<asp:Label ID="zuming" runat="server" Text="暂无"></asp:Label><br />
            </div>


      <asp:Button ID="Button3" runat="server" Text="开始评分"  class="btn2" 
          onclick="Button3_Click"/>
      <%--<input id="Button1" type="button" value="开始评分" class="btn2" />--%>
      <input id="Button2" type="button" class="btn2"  value="返回" />
</center>
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </form>
</body>
</html>
