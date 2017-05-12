<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="start.aspx.cs" Inherits="Maticsoft.Web.dafen_jieguo.start" %>

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

</head>
<body>

    
        <form id="form1" runat="server">
        <div class="bgg"></div>
       <div class="logo">
    <img src="img/logo.png">
</div>
  <center>
<div class="text">
<%--<p>您的评价是课程不断改进的重要依据，请认真填写！</p>--%>
      <asp:Literal ID="mem_info" runat="server"></asp:Literal>
<br />
</div>

        <asp:HiddenField ID="buer_hidd" runat="server" />
             <div class="text1" >
                <p>培训班</p>
            </div>
                 
                 <div class="styled-select">
                 <asp:DropDownList ID="qishu" runat="server" 
                         AutoPostBack="True" onselectedindexchanged="qishu_SelectedIndexChanged"    CssClass="ui-select"> </asp:DropDownList></div>
             <div class="text1" >
                <p>课程名称</p>
            </div>
                  <div class="styled-select">
                      <asp:DropDownList ID="kecheng" runat="server"    
                           AutoPostBack="True"  CssClass="ui-select" ></asp:DropDownList></div>
             <div class="text1" >
                <p>组数</p>
            </div>
                 <div class="form-group">
                  <div class="styled-select">
                      <asp:DropDownList ID="fenzu" runat="server"   
                           AutoPostBack="True" CssClass="ui-select">
                                                                                        </asp:DropDownList></div>
               
                 
<%--                 <asp:Button ID="Button3" runat="server" Text="确定" onclick="Button3_Click" CssClass="btn2" /> --%>


               <asp:Button ID="Button1" runat="server" Text="下一步" onclick="Button1_Click"  CssClass="btn2"/>

            <asp:Button ID="Button2" runat="server" Text="查看问卷回收情况" 
                onclick="Button2_Click" CssClass="btn2" />
                <br />
                     <asp:Label ID="tixing" runat="server" Text=""></asp:Label>
                   <asp:Literal ID="Literal1" runat="server"></asp:Literal>
  


                <asp:HiddenField ID="HiddenField1" runat="server" />


</center>


        </form>

</body>
</html>
