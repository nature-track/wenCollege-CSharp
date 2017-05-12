<%@ Page Language="c#" CodeBehind="mLogin.aspx.cs" AutoEventWireup="True" Inherits="Maticsoft.Web.Admin.mLogin" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
	<meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimum-scale=1.0, maximum-scale=1.0">
<meta name="apple-mobile-web-app-capable" content="yes" />
<meta name="apple-mobile-web-app-status-bar-style" content="default" />
<meta http-equiv="cache-control" content="no-transform"/>
<meta content="telephone=no" name="format-detection">
<meta http-equiv="pragma" content="no-cache">
<meta http-equiv="cache-control" content="no-cache">
<style type="text/css">
.textbox
{
    display: block; 
width: 90%; 
height: 3em; 
padding: 0.5em; 
margin:0.5em;
font-size: 1em; 
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
    <link href="../dafen_jieguo/css/css.css" rel="stylesheet" type="text/css" />
    <title>系统登录</title>
    <%--<link href="images/login.css" type="text/css" rel="stylesheet">--%>

    <script language="javascript" type="text/javascript">
        function ChangeCode() {

            var date = new Date();
            var myImg = document.getElementById("ImageCheck");
            var GUID = document.getElementById("lblGUID");

            if (GUID != null) {
                if (GUID.innerHTML != "" && GUID.innerHTML != null) {
                    myImg.src = "../ValidateCode.aspx?GUID=" + GUID.innerHTML + "&flag=" + date.getMilliseconds()

                }
            }
            return false;
        }

        function validate() {
            var username = $("txtUsername");
            var password = $("txtPass");
            var checkcode = $("CheckCode");
            if (isEmptyStr(username.value)) {
                alert("请输入用户名！");
                username.focus();
                return false;
            }
            if (isEmptyStr(password.value)) {
                alert("请输入密码！");
                password.focus();
                return false;
            }

//            if (isEmptyStr(checkcode.value)) {
//                alert("请输入验证码！");
//                checkcode.focus();
//                return false;
//            }
            return true;
        }



        function focusNext(nextName, evt, num, t, lastName) {
            evt = (evt) ? evt : event;
            var charCode = (evt.charCode) ? evt.charCode :
((evt.which) ? evt.which : evt.keyCode);
            if (charCode == 13 || charCode == 3) {
                var nextobj = document.getElementById(nextName);
                var lastobj = document.getElementById(lastName);

                if (num == 1 && isEmptyStr(t.value)) {
                    alert("请输入用户名！");
                    t.focus();
                    return false;
                }


                if (num == 2 && isEmptyStr(t.value)) {
                    alert("请输入密码！");
                    t.focus();
                    return false;
                }

                if (lastobj != null && isEmptyStr(lastobj.value)) {
                    alert("请输入用户名！");
                    lastobj.focus();
                    return false;
                }

                nextobj.focus();
                return false;
            }
            return true;
        }


    </script>

    </script>
</head>
<body  >
    <form id="Form1" method="post" runat="server">  
    <%--<div class="bgg"></div>--%>
<%--    <div class="logo">
    <img src="../dafen_jieguo/img/logo.png" />
</div>--%>
    <center>
<%--		<h2><img height="67" src="images/member_t04.jpg" ></h2>--%>
		


        <br />

            <h1>温氏学院管理系统<br />移动端登陆</h1>
        <br />
        <div class="text1" >
            <p>用户名(U):</p>
        </div>
                <input tabindex="1"  name="user" id="txtUsername"  class="textbox" 
                    runat="server" onkeypress="return focusNext('txtPass', event,1,this,null)"><span id="RequiredFieldRFV_txtloginid" style="color:Red;display:none;">*</span>
          <div class="text1" >                                    
            <p>密码(P)</p>
          </div>                                     
            <input id="txtPass" runat="server" class="textbox"  name="user0" 
                onkeypress="return focusNext('CheckCode', event,2,this,'txtUsername')" 
                size="22" tabindex="1" type="password" />
            <input name="txtSam" type="text" id="txtSam" onfocus="this.className=&#39;edboxFocus&#39;;" contenteditable="" onkeydown="if(event.keyCode==13){event.keyCode=9}" style="display:none;">
                                               
                                                    
<%--            <span  class="td" >验证码</span>：
                                               
                            <input class="nemo01" id="CheckCode" tabindex="3" maxlength="22" size="11" name="user"
                                runat="server">
                                                              
                            <a id="A2" href="" onclick="ChangeCode();return false;">
                                <asp:Image ID="ImageCheck" runat="server" ImageUrl="../ValidateCode.aspx?GUID=GUID"
                                    ImageAlign="AbsMiddle" ToolTip="看不清，换一个"></asp:Image></a>--%>
                                                               
            <span class="td" ><asp:Label ID="lblMsg" runat="server" BackColor="Transparent" ForeColor="Red"></asp:Label></span>
                                               
                                                   
            <span> <%--<button type="button" style="Width:73px" onmouseover="this.className=&#39;ButtonMouseOver&#39;" onmouseout="this.className=&#39;Button&#39;" onfocus="this.className=&#39;ButtonMouseOver&#39;" onblur="this.className=&#39;Button&#39;" class="Button" id="btnLogin" accesskey="s" >确定</button>--%>                                                       
                <asp:Button ID="btnLogin" runat="server" Text="确定" onclick="btnLogin_Click" CssClass="btn2"/>
<%--            <asp:ImageButton ID="btnLogin1" runat="server" ImageUrl="images/login_p_img11.gif">
                </asp:ImageButton>--%>
            </span>
            &nbsp;
                                                

            &nbsp;<asp:Label ID="lblGUID" runat="server" Style="display: none"></asp:Label>
        </center>         
    <br>
    </form>
</body>
</html>
