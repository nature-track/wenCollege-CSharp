<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_nocss.master" AutoEventWireup="true" CodeBehind="branch_add2.aspx.cs" Inherits="Maticsoft.Web.peixunban1.branch_add2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimum-scale=1.0, maximum-scale=1.0">
<meta name="apple-mobile-web-app-capable" content="yes" />
<meta name="apple-mobile-web-app-status-bar-style" content="default" />
<meta http-equiv="cache-control" content="no-transform"/>
<meta content="telephone=no" name="format-detection">
<meta http-equiv="pragma" content="no-cache">
<meta http-equiv="cache-control" content="no-cache">
<link href="../dafen_jieguo/css/css.css" rel="stylesheet" type="text/css" />
    <link href="../jquery-ui-1.12.1.custom/jquery-ui.css" rel="stylesheet" type="text/css" />
    <script src="../jquery-ui-1.12.1.custom/external/jquery/jquery.js" type="text/javascript"></script>
    <script src="../jquery-ui-1.12.1.custom/jquery-ui.js" type="text/javascript"></script>
    <script language='javascript' type='text/javascript'>
        $(document).ready(function () {
            $("#<%=start_detail.ClientID %>").focus(function () { $("#str_id").html("例如：“20号下午开始陆续入住，晚上开班”或“28号上午放行李后直接到教室”"); });
            $("#<%=start_detail.ClientID %>").blur(function () { $("#str_id").html("&nbsp;&nbsp;"); });
            $("#<%=end_detail.ClientID %>").focus(function () { $("#end_id").html("例如：“10号午休后退房”或“15号傍晚退房”"); });
            $("#<%=end_detail.ClientID %>").blur(function () { $("#end_id").html("&nbsp;&nbsp;"); });
            $("#<%=num_detail.ClientID %>").focus(function () { $("#num_id").html("预留房间给老师或领导，退房后需立刻打扫等情况"); });
            $("#<%=num_detail.ClientID %>").blur(function () { $("#num_id").html("&nbsp;&nbsp;"); });
            $("#<%=cleaning_fee.ClientID %>").focus(function () { $("#cle_id").html("每个房间100元，楼道清洁每层200元，布草车搬运200元"); });
            $("#<%=cleaning_fee.ClientID %>").blur(function () { $("#cle_id").html("&nbsp;&nbsp;"); });
            $("#<%=fapiao_taitou.ClientID %>").focus(function () { $("#fp_id").html("发票开好，清洁公司的人员会主动与培训班联系人联系"); });
            $("#<%=fapiao_taitou.ClientID %>").blur(function () { $("#fp_id").html("&nbsp;&nbsp;"); });
            $("#<%=fantang.ClientID %>").focus(function () { $("#fan_id").html("修改此文本，通过IO传阅发送给簕竹后勤李翰华，并电话与之确认"); });
            $("#<%=fantang.ClientID %>").blur(function () { $("#fan_id").html("&nbsp;&nbsp;"); });
            $("#<%=basketball_time.ClientID %>").focus(function () { $("#bas_id").html("请先与簕竹后勤确认篮球场可用！电话15874569853"); });
            $("#<%=basketball_time.ClientID %>").blur(function () { $("#bas_id").html("&nbsp;&nbsp;"); });
        }); 
    </script>
    <%--<asp:Literal ID="Literal_css" runat="server"></asp:Literal>--%>
        <link href="css/pure-min.css" rel="stylesheet" type="text/css" />
    <link href="css/form_css.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br><h1 align="center">
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>信息表 </h1>
    <div class="red" ><p align="center">务必在确认申请成功后再填写此表</p></div>
<center>
    <fieldset>
       <h3>宿舍使用具体说明</h3>
		<div class="pure-control-group">
			<label><span class="red">*</span>入住时间具体说明：</label>

				<asp:TextBox ID="start_detail" runat="server" class="pure-input-1" placeholder="例如：“20号下午开始陆续入住，晚上开班”或“28号上午放行李后直接到教室”" Height="4em" TextMode="MultiLine"></asp:TextBox>
                <br /><div id="str_id" class="shuoming">&nbsp;&nbsp;</div>

		</div><!--item end-->
        <div class="pure-control-group">
			<label><span class="red">*</span>退房时间具体说明：</label>

				<asp:TextBox ID="end_detail" runat="server" class="pure-input-1" placeholder="例如：“10号午休后退房”或“15号傍晚退房”" Height="4em" TextMode="MultiLine"></asp:TextBox>
                <br /><div id="end_id" class="shuoming">&nbsp;&nbsp;</div>

		</div><!--item end-->

        <div class="pure-control-group">
			<label>人数特殊说明</label>

				<asp:TextBox ID="num_detail" runat="server" class="pure-input-1" placeholder="预留房间给老师或领导，退房后需立刻打扫等情况"></asp:TextBox>
                <br /><div id="num_id" class="shuoming">&nbsp;&nbsp;</div>

		</div><!--item end-->
        <h3>附加信息</h3>
        <div class="pure-control-group">
			<label><span class="red">*</span>预计承担清洁费用</label>
				<asp:TextBox ID="cleaning_fee" runat="server" class="pure-input-1" ></asp:TextBox>
              <br />  <div id="cle_id" class="shuoming">&nbsp;&nbsp;</div>
		</div><!--item end-->
        <div class="pure-control-group">
			<label><span class="red">*</span>清洁费发票抬头</label>

				<asp:TextBox ID="fapiao_taitou" runat="server" class="pure-input-1"></asp:TextBox>
               <br /> <div id="fp_id" class="shuoming">&nbsp;&nbsp;</div>

		</div><!--item end-->
        <div class="pure-control-group">
			<label>房间洗漱用品：</label>
                <asp:DropDownList ID="xishu" runat="server" class="pure-input-1">
                    <asp:ListItem Selected="True" Value="1">简易洗漱用品</asp:ListItem>
                    <asp:ListItem Value="2">旅行套装</asp:ListItem>
                </asp:DropDownList><br />
                <span class="red">简易洗漱用品免费，旅行套装25元一套</span>

		</div><!--item end-->
        <div class="pure-control-group">
			<label>制作学员证：</label>
                <asp:DropDownList ID="fangka_print" class="pure-input-1" runat="server" >
                    <asp:ListItem Selected="True" Value="1">简单房卡不需要印名字</asp:ListItem>
                    <asp:ListItem Value="2">学员证需要印名字</asp:ListItem>
                </asp:DropDownList><br />
                <span class="red">如果需要印名字，需提前派人来学院制作</span>
		</div><!--item end-->
        <h3>订餐与篮球场使用</h3>
        <div class="pure-control-group" >
			<label><span class="red">*</span>订餐联系簕竹饭堂：</label>
                <asp:TextBox ID="fantang" runat="server" class="pure-input-1" TextMode="MultiLine" Height="10em"></asp:TextBox>
               <br /> <div id="fan_id" class="shuoming">&nbsp;&nbsp;</div>
		</div><!--item end-->
        <div class="pure-control-group" >
			<label>篮球场使用时间：</label>
               <asp:TextBox ID="basketball_time" runat="server" class="pure-input-1" Height="5em" TextMode="MultiLine"></asp:TextBox>
			   <br /> <div id="bas_id" class="shuoming">&nbsp;&nbsp;</div>
		</div><!--item end-->
        <h3>其他特殊说明</h3>
         <div class="pure-control-group">
             <asp:TextBox ID="beizhu" runat="server"  Height="10em" class="pure-input-1" TextMode="MultiLine"></asp:TextBox>
		</div><!--item end-->
        <br />
		<div class="pure-control-group">
			<span class="label">&nbsp;</span>
            
            <asp:Button    ID="submit" runat="server" Text="确认提交" 
                class="pure-button pure-button-primary" onclick="submit_Click"/>
		</div><!--item end-->

</fieldset>
</center>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
