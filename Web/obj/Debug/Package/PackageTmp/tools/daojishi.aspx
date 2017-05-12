<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="daojishi.aspx.cs" Inherits="Maticsoft.Web.tools.yj_daojishi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<link href="../styles/global.css" rel="stylesheet" type="text/css" />
	<script type="text/javascript" src="../js/jquery.js" ></script>
    <script type="text/javascript" src="../js/form.js" ></script>
    <script type="text/javascript" src="../js/time.js" ></script>
    <title></title>
</head>
<body id="time_page">
    <form id="form1" runat="server">
    <div>
    	<div class="wrap">
        <h1>
            <asp:Literal ID="Literal1"
                runat="server"></asp:Literal></h1>
        <div id="timer"><span></span><div id="alert"></div></div>
        <div class="quick_bt">
        	<a id="action_bt">暂停</a>
            <a id="reset_bt">重置</a>
        </div>
        <div class="bt_area">
        </div>
        <form id="set_time">
         	<label>其他时间:</label>
           	<input type="text" id="input_hour" class="text_time" value="0" />时<input type="text" id="input_min" class="text_time" value="3" />分<input type="text" id="input_sec" class="text_time" value="0" />秒
            <input type="button" id="time_bt" value="开始计时" />
        </form>
    </div>
    <div class="version_info">温氏集团培训中心培训工具包 V3.0 演讲比赛计时工具 李丹青于2015年8月19日更新  <br />
        <asp:Button ID="Button1" runat="server" Text="更换标题" onclick="Button1_Click" />
        <asp:TextBox ID="biaoti" runat="server" Width="263px"></asp:TextBox></div>
    </div>
    </form>
</body>
</html>
