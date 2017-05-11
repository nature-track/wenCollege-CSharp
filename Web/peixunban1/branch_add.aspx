<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_nocss.master" AutoEventWireup="true" CodeBehind="branch_add.aspx.cs" Inherits="Maticsoft.Web.peixunban1.branch_add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimum-scale=1.0, maximum-scale=1.0">
<meta name="apple-mobile-web-app-capable" content="yes" />
<meta name="apple-mobile-web-app-status-bar-style" content="default" />
<meta http-equiv="cache-control" content="no-transform"/>
<meta content="telephone=no" name="format-detection">
<meta http-equiv="pragma" content="no-cache">
<meta http-equiv="cache-control" content="no-cache">
<%--<link href="css/style.css" type="text/css" rel="stylesheet" />--%>
    <link href="../dafen_jieguo/css/css.css" rel="stylesheet" type="text/css" />
    <link href="../jquery-ui-1.12.1.custom/jquery-ui.css" rel="stylesheet" type="text/css" />
    <script src="../jquery-ui-1.12.1.custom/external/jquery/jquery.js" type="text/javascript"></script>
    <script src="../jquery-ui-1.12.1.custom/jquery-ui.js" type="text/javascript"></script>
        <script language='javascript' type='text/javascript'>
            $(document).ready(function () {
                $("#<%=start_time.ClientID %>").datepicker();
                $("#<%=end_time.ClientID %>").datepicker();
                $("#<%=peixunban_name.ClientID %>").focus(function () { $("#pei_id").html("名称与IO申请上一致"); });
                $("#<%=peixunban_name.ClientID %>").blur(function () { $("#pei_id").html("&nbsp;&nbsp;"); });
//                $("#slider_num").slider({
//                    range: "max",
//                    min: 1,
//                    max: 60,
//                    value: 30,
//                    slide: function (event, ui) {
//                        $("#<%=num.ClientID %>").val(ui.value);
//                    }
//                });
//                $("#<%=num.ClientID %>").val($("#slider_num").slider("value"));
            }); 
    </script>
    <%--<asp:Literal ID="Literal_css" runat="server"></asp:Literal>--%>
    <link href="css/pure-min.css" rel="stylesheet" type="text/css" />
    <link href="css/form_css.css" rel="stylesheet" type="text/css" />
<%--    <link href="css/form_moblie.css" rel="stylesheet" type="text/css" />--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<br><h1 align="center">学院场地使用信息表 </h1>
    <div class="red" ><p align="center">务必在确认申请成功后再填写此表</p></div>
    <center>
    <fieldset>
       <h3>基本信息</h3>
		<div class="pure-control-group">
			<label ><span class="red">*</span>培训班名称：</label>
				<asp:TextBox ID="peixunban_name" runat="server" class="pure-input-1" placeholder="名称与IO申请上一致"></asp:TextBox>
                <div id="pei_id" class="shuoming">&nbsp;&nbsp;</div>
		</div><!--item end-->
		<div class="pure-control-group">
			<label><span class="red">*</span>联系人：</label>
				<asp:TextBox ID="contact_per" runat="server" class="pure-input-1" placeholder="本次培训班联系人"></asp:TextBox>
		</div><!--item end-->
        <div class="pure-control-group">
			<label>联系电话：</label>
				<asp:TextBox ID="phone" runat="server" class="pure-input-1" placeholder="常用手机"></asp:TextBox>
		</div><!--item end-->
        <div class="pure-control-group">
			<label><span class="red">*</span>开始时间：</label>
				<asp:TextBox ID="start_time" class="pure-input-1" runat="server" ></asp:TextBox>
		</div><!--item end-->
        <div class="pure-control-group">
			<label><span class="red">*</span>结束时间：</label>
			<asp:TextBox ID="end_time" runat="server" class="pure-input-1" ></asp:TextBox>
		</div><!--item end-->
        <div class="pure-control-group">
			<label><span class="red">*</span>培训人数：</label>

<%-- <div id="slider_num" class="text"  ></div>--%>
             <asp:TextBox ID="num" runat="server"  class="pure-input-1" placeholder="只填数字，不能大于60"></asp:TextBox>          
              <%--  <a href="../jquery-ui-1.12.1.custom/package.json">../jquery-ui-1.12.1.custom/package.json</a>--%>
                
		</div><!--item end-->
        <br />
		<div class="pure-control-group">
			<span class="label">&nbsp;</span>
            
            <asp:Button    ID="submit" runat="server" Text="提交并下一步" 
                class="pure-button pure-button-primary" onclick="submit_Click"/>
		</div><!--item end-->
</fieldset>
</center>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

</asp:Content>
