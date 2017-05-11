<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fengongsi_form.aspx.cs" Inherits="Maticsoft.Web.peixunban1.fengongsi_form" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="../js/jquery-1.10.2.min.js"></script>
    <link href="css/style.css" type="text/css" rel="stylesheet" />

</head>
<body>

    <style type="text/css">
*{margin:0;padding:0;list-style-type:none;}
a,img{border:0;}
.form label, .form input, .form select, .form textarea, .form button, .form .label{float:left;font-size:12px;}
.fl{float:left;}.fr{float:right;}.fn{float:none;}
.hide{display:none;}.invisible{visibility:hidden;}.overflow{overflow:hidden;}
.clear{display:block;clear:both;height:0;overflow:hidden;}
body{font:12px/180% Arial, Helvetica, sans-serif,"宋体";}
/* yellow_button */
.yellow_button{background:url(images/yellow_button.png);border:none;cursor:pointer;height:36px;line-height:36px; overflow:hidden; display:inline-block; text-align:center; font-size:14px; font-weight:800; color:#fff;background-position:0 0;width:139px;}
#registsubmit.disabled{background-position:0 -36px;cursor:default!important;}
.red{color:#ff0000;font-family:"宋体";font-weight:normal;}
/* formbox */
#formbox{padding:20px;border:solid 1px #D1D1D1;margin:20px auto;width:880px;}
#formbox h3{font-size:16px;height:32px;color:#3366cc;font-weight:800;border-bottom:solid 1px #D1D1D1;margin:0 0 20px 0;padding:0 10px;}
#formbox .item{padding-top:5px;height:50px;overflow:hidden;line-height:26px;}
#formbox .item a:link,#formbox .item a:visited{text-decoration:underline;}
#formbox .label{width:300px;text-align:right;font-size:14px;}
#formbox .span-150{width:150px;}
#formbox .text{width:240px;height:16px;padding:4px 3px;border:1px solid #bbb;font-size:14px;font-family:arial,"宋体";}
#formbox .text-1{width:100px;}
#formbox .blank{width:16px;height:16px;margin:2px 5px 0;}
#formbox .img img{height:26px;margin:0 5px;}
#formbox .succeed{background:url(images/pwdstrength.gif) no-repeat -105px 0;}
#formbox .yellow_button{font-size:14px;font-weight:bold;color:#fff;border:none;cursor:pointer;}
#formbox .highlight1{border:1px solid #EFA100;outline:2px solid #FFDC97;*border:2px solid #ffcc66;*padding:3px 2px;}
#formbox .highlight2{border:1px solid #f00;outline:1px solid #FFC1C1;color:#f00;}
#formbox .pwdbg{background:#FFF8EB;}
#formbox .focus{color:#999;line-height:22px;*line-height:20px;}
#formbox .null,#formbox .error{color:red;line-height:22px;*line-height:20px;}
#formbox .checkbox{margin-top:6px;*margin-top:2px;}
#formbox #referrer{color:#999;font-size:12px;}
#formbox #protocol{margin:0px 5px 0 0;display:inline;}
#pwdstrength{color:#999;line-height:22px;padding-right:10px;}
#pwdstrength b{float:left;width:104px;height:13px;overflow:hidden;margin-top:5px;*margin-top:3px;}
.strengthA b{background:url(images/pwdstrength.gif) no-repeat 0 0;}
.strengthB b{background:url(images/pwdstrength.gif) no-repeat 0 -13px;}
.strengthC b{background:url(images/pwdstrength.gif) no-repeat 0 -26px;}
</style>

    <form id="form1" runat="server">
<br><h1 align="center">学院场地使用信息表 </h1>
    <div class="red" ><p align="center">务必在确认申请成功后再填写此表</p></div>
<div id="formbox">
	
	<div class="form">
		<h3>基本信息</h3>
		<div class="item">
			<span class="label"><span class="red">*</span>培训班名称：</span>
			<div class="fl">
				<asp:TextBox ID="peixunban_name" runat="server" class="text" tabindex="1"></asp:TextBox>
			</div>
		</div><!--item end-->
				<div class="item">
			<span class="label"><span class="red">*</span>联系人：</span>
			<div class="fl">
				<asp:TextBox ID="contact_per" runat="server" class="text" tabindex="2"></asp:TextBox>
			</div>
		</div><!--item end-->
        <div class="item">
			<span class="label">联系电话：</span>
			<div class="fl">
				<asp:TextBox ID="phone" runat="server" class="text" tabindex="3"></asp:TextBox>
			</div>
		</div><!--item end-->
        <div class="item">
			<span class="label"><span class="red">*</span>开始时间：</span>
			<div class="fl">
				<asp:TextBox ID="sta_time" runat="server" class="text" tabindex="4"></asp:TextBox>
			</div>
		</div><!--item end-->
        <div class="item">
			<span class="label"><span class="red">*</span>结束时间：</span>
			<div class="fl">
				<asp:TextBox ID="end_time" runat="server" class="text" tabindex="5"></asp:TextBox>
			</div>
		</div><!--item end-->

	
		<h3>入住退房时间</h3>
		<div class="item">
			<span class="label"><span class="red">*</span>入住时间：</span>
			<div class="fl">
                <asp:TextBox ID="in_time" runat="server" class="text" tabindex="6"></asp:TextBox>
			</div>
		</div><!--item end-->
		<div class="item">
			<span class="label"><span class="red">*</span>退房时间：</span>
			<div class="fl">
                <asp:TextBox ID="out_time" runat="server" class="text" tabindex="7"></asp:TextBox>
			</div>
		</div><!--item end-->
        <div class="item">
			<span class="label">特殊说明：</span>
			<div class="fl">
                <asp:TextBox ID="event_name" runat="server" class="text" tabindex="8"></asp:TextBox>
			</div>
		</div><!--item end-->
	
		<h3>订餐与订篮球场</h3>
		<div class="item">
			<span class="label"><span class="red">*</span>订餐联系簕竹饭堂：</span>
			<div class="fl">
            <span >电话15874569853</span>
			</div>
		</div><!--item end-->
		<div class="item">
			<span class="label">篮球场使用时间：</span>
			<div class="fl">
                <span class="red">请先与簕竹后勤确认篮球场可用！电话15874569853</span><asp:TextBox ID="TextBox1" runat="server" class="text" tabindex="9"></asp:TextBox>
			</div>
		</div><!--item end-->
        <h3>物资确认</h3>
        <div align="center">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%">
            <Columns>
                <asp:BoundField DataField="name" HeaderText="物资" SortExpression="name" />
                <asp:BoundField DataField="gongyingshang" HeaderText="供应商" 
                    SortExpression="gongyingshang" />
                <asp:BoundField DataField="person" HeaderText="联系人" SortExpression="person" />
                <asp:BoundField DataField="phone" HeaderText="联系电话" SortExpression="phone" />
                <asp:BoundField DataField="beizhu" HeaderText="备注" SortExpression="beizhu" />
            </Columns>
            </asp:GridView>
            </div>
		<div class="item">
            

			<span class="label">房间洗漱用品：</span>
			<div class="fl">
                <asp:DropDownList ID="xishu" runat="server">
                    <asp:ListItem Selected="True" Value="1">简易洗漱用品</asp:ListItem>
                    <asp:ListItem Value="2">旅行套装</asp:ListItem>
                </asp:DropDownList>
                <span class="red">简易洗漱用品免费，旅行套装25元一套</span>
			</div>
		</div><!--item end-->
        <div class="item">
			<span class="label">制作学员证：</span>
			<div class="fl">
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Selected="True" Value="1">简单房卡不需要印名字</asp:ListItem>
                    <asp:ListItem Value="2">学员证需要印名字</asp:ListItem>
                </asp:DropDownList>
                <span class="red">如果需要印名字，可能会产生额外的制卡费用</span>
			</div>
		</div><!--item end-->
                <div class="item">
			<span class="label">学员名单（不做学员证可不上传）：</span>
			<div class="fl">
                <asp:FileUpload ID="FileUpload1" runat="server" /><asp:Button ID="Button1" runat="server"    Text="确定" />
                <span class="red">如果人员名单未确认，可先不上传</span>
			</div>
		</div><!--item end-->
         <h3>其他特殊说明</h3>
         <div class="item">
             <asp:TextBox ID="TextBox2" runat="server" class="text" tabindex="10" 
                 Height="63px" Width="80%" TextMode="MultiLine"></asp:TextBox>
		</div><!--item end-->
        <br />
		<div class="item">
			<span class="label">&nbsp;</span>
            
            <asp:Button    ID="submit" runat="server" Text="确认提交" class="yellow_button disabled"/>
		</div><!--item end-->
		
	</div>
	
</div><!--formbox end-->

<p align="center">请认真填写</p>
    </form>
</body>
</html>
