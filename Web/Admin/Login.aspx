<%@ Page Language="c#" CodeBehind="Login.aspx.cs" AutoEventWireup="True" Inherits="Maticsoft.Web.Admin.Login" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
<head>
    <title>系统登录</title>
    <link href="images/login.css" type="text/css" rel="stylesheet">

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

            if (isEmptyStr(checkcode.value)) {
                alert("请输入验证码！");
                checkcode.focus();
                return false;
            }
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
<body  leftmargin="0" topmargin="0" marginheight="0" marginwidth="0">
    <form id="Form1" method="post" runat="server">  
    
       <table border="0" style="width: 100%; height: 100%">
        <tbody><tr>
            <td align="center" valign="middle">
                <table border="0" cellpadding="0" cellspacing="0" class="box1">
                    <tbody><tr>
                        <td align="left">
                            <table border="0" cellpadding="0" cellspacing="0" class="box2" style="width: 100%; height: 100%">
                                <tbody><tr>
                                    <td valign="top">
                                        <table border="0" cellpadding="0" cellspacing="0" width="100%">
                                            <tbody><tr>
                                                <td class="logintitle" align="left">
                                                    <span id="lblLogin" class="ttTable0">登录到 温氏学院后台管理系统</span>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td nowrap="nowrap" style="background-color: white; padding-right: 5px; width: 395">
                                                    <img height="67" src="images/member_t04.jpg" >
                                                </td>
                                            </tr>
                                            <tr>
                                                <td class="line" height="5">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td height="10">
                                                </td>
                                            </tr>
                                        </tbody></table>
                                        <table border="0" cellpadding="0" cellspacing="0">
                                            <tbody><tr>
                                                <td align="right" width="20">
                                                    &nbsp;
                                                </td>
                                                <td>
                                                    <span id="lblLoginID" class="td">用户名(U):</span>
                                                </td>
                                                <td width="15">
                                                </td>
                                                <td height="30">
                                                      <input tabindex="1"  name="user" id="txtUsername" maxlength="20" class="edboxRequire" onfocus="this.className=&#39;edboxFocus&#39;;" style="width:250px;"
                                                            runat="server" onkeypress="return focusNext('txtPass', event,1,this,null)"><span id="RequiredFieldRFV_txtloginid" style="color:Red;display:none;">*</span>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                </td>
                                                <td>
                                                    <span id="lblPwd" class="td">密码(P)</span>
                                                </td>
                                                <td>
                                                </td>
                                                <td height="30" style="padding-bottom: 5px">
                                                    <input id="txtPass" runat="server" class="nemo01" maxlength="22" name="user0" 
                                                        onkeypress="return focusNext('CheckCode', event,2,this,'txtUsername')" 
                                                        size="22" tabindex="1" type="password" />
                                                    <input name="txtSam" type="text" id="txtSam" onfocus="this.className=&#39;edboxFocus&#39;;" contenteditable="" onkeydown="if(event.keyCode==13){event.keyCode=9}" style="display:none;">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                </td>
                                                <td>
                                                    
                                                   <span  class="td" >验证码</span>：</td>
                                                <td>
                                                </td>
                                                <td>
                                                                                                            <table width="100%%" height="25" border="0" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td width="70%" align="left">
                                                                    <input class="nemo01" id="CheckCode" tabindex="3" maxlength="22" size="11" name="user"
                                                                        runat="server">
                                                                </td>
                                                                <td width="30%" align="left">
                                                                    <a id="A2" href="" onclick="ChangeCode();return false;">
                                                                        <asp:Image ID="ImageCheck" runat="server" ImageUrl="../ValidateCode.aspx?GUID=GUID"
                                                                            ImageAlign="AbsMiddle" ToolTip="看不清，换一个"></asp:Image></a>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                </td>
                                                <td>
                                                </td>
                                                <td>
                                                </td>
                                                <td style="height: 10px;">
                                                    <span class="td" ><asp:Label ID="lblMsg" runat="server" BackColor="Transparent" ForeColor="Red"></asp:Label></span>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                </td>
                                                <td>
                                                </td>
                                                <td>
                                                </td>
                                                <td>
                                                    
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                </td>
                                                <td>
                                                </td>
                                                <td>
                                                </td>
                                                <td align="centre">
                                                   
                                                    <span> <%--<button type="button" style="Width:73px" onmouseover="this.className=&#39;ButtonMouseOver&#39;" onmouseout="this.className=&#39;Button&#39;" onfocus="this.className=&#39;ButtonMouseOver&#39;" onblur="this.className=&#39;Button&#39;" class="Button" id="btnLogin" accesskey="s" >确定</button>--%>                                                       
                                                    <asp:ImageButton ID="btnLogin" runat="server" ImageUrl="images/login_p_img11.gif">
                                                        </asp:ImageButton>
                                                    </span>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                        </tbody></table>
                                    </td>
                                </tr>
                            </tbody></table>
                        </td>
                    </tr>
                </tbody></table>
            </td>
        </tr>
    </tbody></table> 
    <br>
    <br>
    <br>
    <br>
    <br>
    <table width="620" border="0" align="center" cellpadding="0" cellspacing="0">
        <tbody>
            <tr>
                <td width="620">
                    <img height="11" src="images/login_p_img02.gif" width="650">
                </td>
            </tr>
            <tr>
                <td align="center" background="images/login_p_img03.gif">
                    <br>
                    <table width="570" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td>
                                <table cellspacing="0" cellpadding="0" width="570" border="0">
                                    <tbody>
                                        <tr>
                                            <td width="245" height="80" align="center" valign="top">
                                                <img height="67" src="images/member_t04.jpg" width="245">
                                            </td>
                                            <td align="right" valign="top">
                                                <br>
                                                &nbsp;
                                                <img height="9" src="images/point07.gif" width="13" border="0"><a href="#" onclick="window.external.addFavorite('http://www.maticsoft.com','动软管理系统')">加入收藏</a>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;<asp:Label ID="lblGUID" runat="server" Style="display: none"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <img src="images/a_te01.gif" width="570" height="3">
                            </td>
                        </tr>
                        <tr>
                            <td align="center" background="images/a_te02.gif">
                                <table width="520" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td width="123" height="120">
                                            <img height="95" src="images/login_p_img05.gif" width="123" border="0">
                                        </td>
                                        <td align="center">
                                            <table cellspacing="0" cellpadding="0" border="0">
                                                <tr>
                                                    <td width="210" height="25" valign="top">
                                                        用户名：
                                                      
                                                    </td>
                                                    <td width="80" rowspan="3" align="right" valign="middle">
                                                        &nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td valign="bottom" height="12">
                                                        密&nbsp;&nbsp; 码：
                                                        
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td valign="bottom" height="13">

                                                    </td>
                                                </tr>
                                            </table>
                                            <br>
                                            
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td bgcolor="#d5d5d5">
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                    <tr>
                                        <td height="70" align="center">
                                            传承文化&nbsp; 成就梦想
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <img height="11" src="images/login_p_img04.gif" width="650">
                </td>
            </tr>
        </tbody>
    </table>
    <br>
    </form>
</body>
</html>
