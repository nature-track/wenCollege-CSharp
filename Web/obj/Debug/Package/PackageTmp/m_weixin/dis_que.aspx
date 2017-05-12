<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dis_que.aspx.cs" Inherits="Maticsoft.Web.m_weixin.dis_que" %>

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
    .btn2{ float:left; margin:3%; width:30%;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="bgg"></div>
    <br />
    <br />
    <br />
                 <div class="text1" >
                <p>请写上您的感悟</p>
            </div>
    <center>
    <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" CssClass="textbox"  Width="90%" Height="10em" Wrap="True" style="overflow: visible" ></asp:TextBox>
    </div>
    <div>
      <asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click" CssClass="btn2" />
      <input id="Button3" type="button" value="取消" class="btn2" onclick="javascript:history.back(-1);"/>
    </div>
    </center>
    <div>
    
    </form>
</body>
</html>
