<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_nocss.master" AutoEventWireup="true" CodeBehind="branch_add2.aspx.cs" Inherits="Maticsoft.Web.peixunban1.branch_add2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../jquery-ui-1.12.1.custom/jquery-ui.css" rel="stylesheet" type="text/css" />
    <script src="../jquery-ui-1.12.1.custom/external/jquery/jquery.js" type="text/javascript"></script>
    <script src="../jquery-ui-1.12.1.custom/jquery-ui.js" type="text/javascript"></script>
    <script language='javascript' type='text/javascript'>
        $(document).ready(function () {
            $("#<%=start_detail.ClientID %>").focus(function () { $("#str_id").html("例如：“20号下午开始陆续入住，晚上开班”或“28号上午放行李后直接到教室”"); });
            $("#<%=start_detail.ClientID %>").blur(function () { $("#str_id").html(""); });
            $("#<%=end_detail.ClientID %>").focus(function () { $("#end_id").html("例如：“10号午休后退房”或“15号傍晚退房”"); });
            $("#<%=end_detail.ClientID %>").blur(function () { $("#end_id").html(""); });
            $("#<%=num_detail.ClientID %>").focus(function () { $("#num_id").html("预留房间给老师或领导，退房后需立刻打扫等情况"); });
            $("#<%=num_detail.ClientID %>").blur(function () { $("#num_id").html(""); });
            $("#<%=cleaning_fee.ClientID %>").focus(function () { $("#cle_id").html("每个房间100元，楼道清洁每层200元，布草车搬运200元"); });
            $("#<%=cleaning_fee.ClientID %>").blur(function () { $("#cle_id").html(""); });
            $("#<%=fapiao_taitou.ClientID %>").focus(function () { $("#fp_id").html("发票开好，清洁公司的人员会主动与培训班联系人联系"); });
            $("#<%=fapiao_taitou.ClientID %>").blur(function () { $("#fp_id").html(""); });
            $("#<%=fantang.ClientID %>").focus(function () { $("#fan_id").html("修改此文本，通过IO传阅发送给簕竹后勤李翰华，并电话与之确认"); });
            $("#<%=fantang.ClientID %>").blur(function () { $("#fan_id").html(""); });
            $("#<%=basketball_time.ClientID %>").focus(function () { $("#bas_id").html("请先与簕竹后勤确认篮球场可用！电话15874569853"); });
            $("#<%=basketball_time.ClientID %>").blur(function () { $("#bas_id").html(""); });
        }); 
    </script>
    <asp:Literal ID="Literal_css" runat="server"></asp:Literal>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br><h1 align="center">
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>信息表 </h1>
    <div class="red" ><p align="center">务必在确认申请成功后再填写此表</p></div>
    <div id="formbox">
    <div class="form">
       <h3>宿舍使用具体说明</h3>
		<div class="item">
			<span class="label"><span class="red">*</span>入住时间具体说明：</span>
			<div class="fl">
				<asp:TextBox ID="start_detail" runat="server" class="text" tabindex="1"></asp:TextBox>
                <br /><div id="str_id" class="shuoming"></div>
			</div>
		</div><!--item end-->
        <div class="item">
			<span class="label"><span class="red">*</span>退房时间具体说明：</span>
			<div class="fl">
				<asp:TextBox ID="end_detail" runat="server" class="text" tabindex="1"></asp:TextBox>
                <br /><div id="end_id" class="shuoming"></div>
			</div>
		</div><!--item end-->

        <div class="item">
			<span class="label">人数特殊说明</span>
			<div class="fl">
				<asp:TextBox ID="num_detail" runat="server" class="text" tabindex="1"></asp:TextBox>
                <br /><div id="num_id" class="shuoming"></div>
			</div>
		</div><!--item end-->
        <h3>附加信息</h3>
        <div class="item">
			<span class="label"><span class="red">*</span>预计承担清洁费用</span>
			<div class="fl">
				<asp:TextBox ID="cleaning_fee" runat="server" class="text" tabindex="1"></asp:TextBox>
              <br />  <div id="cle_id" class="shuoming"></div>
			</div>
		</div><!--item end-->
        <div class="item">
			<span class="label"><span class="red">*</span>清洁费发票抬头</span>
			<div class="fl">
				<asp:TextBox ID="fapiao_taitou" runat="server" class="text" tabindex="1"></asp:TextBox>
               <br /> <div id="fp_id" class="shuoming"></div>
			</div>
		</div><!--item end-->
        <div class="item">
			<span class="label">房间洗漱用品：</span>
			<div class="fl">
                <asp:DropDownList ID="xishu" class="text" runat="server">
                    <asp:ListItem Selected="True" Value="1">简易洗漱用品</asp:ListItem>
                    <asp:ListItem Value="2">旅行套装</asp:ListItem>
                </asp:DropDownList><br />
                <span class="red">简易洗漱用品免费，旅行套装25元一套</span>
			</div>
		</div><!--item end-->
        <div class="item">
			<span class="label">制作学员证：</span>
			<div class="fl">
                <asp:DropDownList ID="fangka_print" class="text" runat="server">
                    <asp:ListItem Selected="True" Value="1">简单房卡不需要印名字</asp:ListItem>
                    <asp:ListItem Value="2">学员证需要印名字</asp:ListItem>
                </asp:DropDownList><br />
                <span class="red">如果需要印名字，需提前派人来学院制作</span>
			</div>
		</div><!--item end-->
        <h3>订餐与篮球场使用</h3>
        <div class="item" style="height:11em;">
			<span class="label"><span class="red">*</span>订餐联系簕竹饭堂：</span>
			<div class="fl">
                <asp:TextBox ID="fantang" runat="server" class="text" tabindex="1" TextMode="MultiLine" Height="40px"></asp:TextBox>
               <br /> <div id="fan_id" class="shuoming"></div>
			</div>
		</div><!--item end-->
        <div class="item" style="height:9em;">
			<span class="label">篮球场使用时间：</span>
			<div class="fl">
                <span class="red"></span><asp:TextBox ID="basketball_time" runat="server" class="text" tabindex="9"></asp:TextBox>
			   <br /> <div id="bas_id" class="shuoming"></div>
            </div>
		</div><!--item end-->
        <h3>其他特殊说明</h3>
         <div class="item">
             <asp:TextBox ID="beizhu" runat="server" class="text" tabindex="10" 
                 Height="63px" Width="80%" TextMode="MultiLine"></asp:TextBox>
		</div><!--item end-->
        <br />
		<div class="item">
			<span class="label">&nbsp;</span>
            
            <asp:Button    ID="submit" runat="server" Text="确认提交" 
                class="yellow_button disabled" onclick="submit_Click"/>
		</div><!--item end-->
        </div>
    </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
