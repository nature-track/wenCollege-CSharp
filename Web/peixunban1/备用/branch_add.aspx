<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage_nocss.master" AutoEventWireup="true" CodeBehind="branch_add.aspx.cs" Inherits="Maticsoft.Web.peixunban1.branch_add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<%--<link href="css/style.css" type="text/css" rel="stylesheet" />--%>

    <link href="../jquery-ui-1.12.1.custom/jquery-ui.css" rel="stylesheet" type="text/css" />
    <script src="../jquery-ui-1.12.1.custom/external/jquery/jquery.js" type="text/javascript"></script>
    <script src="../jquery-ui-1.12.1.custom/jquery-ui.js" type="text/javascript"></script>
        <script language='javascript' type='text/javascript'>
            $(document).ready(function () {
                $("#<%=start_time.ClientID %>").datepicker();
                $("#<%=end_time.ClientID %>").datepicker();
                $("#<%=peixunban_name.ClientID %>").focus(function () { $("#pei_id").html("名称与IO申请上一致"); });
                $("#<%=peixunban_name.ClientID %>").blur(function () { $("#pei_id").html(""); });
                $("#slider_num").slider({
                    range: "max",
                    min: 1,
                    max: 60,
                    value: 30,
                    slide: function (event, ui) {
                        $("#<%=num.ClientID %>").val(ui.value);
                    }
                });
                $("#<%=num.ClientID %>").val($("#slider_num").slider("value"));
            }); 
    </script>
    <asp:Literal ID="Literal_css" runat="server"></asp:Literal>
    <link href="css/pure-min.css" rel="stylesheet" type="text/css" />
    <%--<link href="css/form_css.css" rel="stylesheet" type="text/css" />--%>
<%--    <link href="css/form_moblie.css" rel="stylesheet" type="text/css" />--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<br><h1 align="center">学院场地使用信息表 </h1>
    <div class="red" ><p align="center">务必在确认申请成功后再填写此表</p></div>
    <div id="formbox">
    <div class="form">
       <h3>基本信息</h3>
		<div class="item">
			<span class="label"><span class="red">*</span>培训班名称：</span>
			<div class="fl">
				<asp:TextBox ID="peixunban_name" runat="server" class="text" tabindex="1"></asp:TextBox>
                <div id="pei_id" class="shuoming"></div>
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
				<asp:TextBox ID="start_time" runat="server" class="text" tabindex="4"></asp:TextBox>
			</div>
		</div><!--item end-->
        <div class="item">
			<span class="label"><span class="red">*</span>结束时间：</span>
			<div class="fl">
				<asp:TextBox ID="end_time" runat="server" class="text" tabindex="5"></asp:TextBox>
			</div>
		</div><!--item end-->
        <div class="item">
			<span class="label"><span class="red">*</span>培训人数：</span>
			<div class="fl">
            <table>
             <tr>
               <td style="width:85%" ><div id="slider_num" class="text" style="width:95%" ></div></td>
               <td style="width:10%" > <asp:TextBox ID="num" runat="server"  tabindex="5"  class="text"  style="width:90%; " ></asp:TextBox></td>
             </tr>
            </table>
            
              <%--  <a href="../jquery-ui-1.12.1.custom/package.json">../jquery-ui-1.12.1.custom/package.json</a>--%>
                
			</div>
		</div><!--item end-->
        <br />
		<div class="item">
			<span class="label">&nbsp;</span>
            
            <asp:Button    ID="submit" runat="server" Text="提交并下一步" 
                class="pure-button pure-button-primary" onclick="submit_Click"/>
		</div><!--item end-->
    </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

</asp:Content>
