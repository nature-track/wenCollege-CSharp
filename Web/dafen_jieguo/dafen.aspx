<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dafen.aspx.cs" Inherits="Maticsoft.Web.dafen_jieguo.dafen" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>课程评价表</title>
<meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimum-scale=1.0, maximum-scale=1.0">
<meta name="apple-mobile-web-app-capable" content="yes" />
<meta name="apple-mobile-web-app-status-bar-style" content="default" />
<meta http-equiv="cache-control" content="no-transform"/>
<meta content="telephone=no" name="format-detection">
<meta http-equiv="pragma" content="no-cache">
<meta http-equiv="cache-control" content="no-cache">
<link href="css/css.css" rel="stylesheet" type="text/css">
    <script src="js/jquery-1.11.0.min.js" type="text/javascript"></script>
<script type="text/javascript">

    $(document).ready(function () {
        var xScoll = $(window).width();

        if (xScoll > 360) {
            $('label').css('width', '18%');
        } else if (xScoll > 320) {
            $('label').css('width', '28%');
        } else {
            $('label').css('width', '43%');
        }

        $('label').click(function () {
            $(this).prev().is(":checked");
            $(this).css('background-color', '#f7edb8');
            $(this).nextAll().css('background-color', '#f8fbf9');
            $(this).prevAll().css('background-color', '#f8fbf9');

        });


    })
</script>
<style>

	input[type="radio"]{ position: absolute; left:-999em;}
	input[type="radio"] + label:before { background-position: -20px -21px;}	 	
	input[type="radio"]:checked + label:before { background-position: -20px 2px;}

.text1{ width:90%; margin:0 auto}
.top_text div { display:block; color:#8b5c2b; margin-bottom:1%; font-size:1em; text-align:center;}
.top_text div span{ color:#8b5c2b; }
.w1{ width:100%; height:20px}
.w1 img{ width:100%; }
.c1{width:100%}
.c1 tr { width:100%; display:block; height:44px; line-height:44px; margin-bottom:0%;}
.c1 label{ background:#f8fbf9; color:#616a73;width:18%;  text-align: center; font-size:14px; border:#eaeaea 1px solid;height:30px; line-height:30px; display:block; float:left; margin:0.5% 1.4%;border-radius:2px; box-shadow:1px 1px #eaeaea}
.c1 label{width:100%;display:block;}
.c1 input{display:block;}
.Panel{ display:block; color:#616a73; margin:1%; font-size:14px;}	
@media screen and (max-width: 320px) {/*iphone5s */

}
@media screen and (max-width: 320px) and (max-height: 480px){/*iphone4s */


}

</style>

</head>
<body>

    <form id="form1" runat="server">
<%--    <div class="bgg1"></div>
<div class="lauguage1"> </div>
<div class="slogan1"><img src="img/slogan1.png"></div>--%>
    <div class="bgg"></div>
       <div class="logo">
    <img src="img/logo3.png">
  <br />
  <center>
  
    <div class="text1">

                 <div>培训班：<asp:Label ID="peixunban" runat="server" Text="Label"></asp:Label> </div><br />
                  <div >课程名称：<asp:Label ID="kecheng" runat="server" Text="Label"></asp:Label></div><br />
                   <div>讲师：<asp:Label ID="jiangshi" runat="server" Text="Label"></asp:Label></div><br />
                  <div >组名：<asp:Label ID="zuming" runat="server" Text="Label"></asp:Label></div>
                  <br />
                  <p>10分为最满意，1分为最不满意，请根据您的实际感受打分</p>

        </div>
                                        <asp:GridView ID="VoteView" runat="server" AutoGenerateColumns="False" 
                                              OnRowDataBound="VoteView_RowDataBound" 
                                            Width="100%" AlternatingRowStyle-BackColor="#e6e5e3">

                                            <Columns>
                                                <asp:TemplateField >
                                                    <ItemTemplate>
                                                        <asp:Panel ID="Panel3" runat="server" CssClass="Panel">
                                                        <asp:Label ID="id_Label" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"id") %>'></asp:Label>
                                                    
                                                        <%# DataBinder.Eval(Container.DataItem,"text") %>
                                                        </asp:Panel>
                                                        
                                                       
                                                       
                                                        <fieldset class="big" >
                                                        
                                                            <asp:RadioButtonList ID="RadioButtonList2" runat="server" type="radio"  RepeatDirection="Horizontal"  Width="100%" CssClass="c1" RepeatLayout="Flow">
                                                                            <asp:ListItem>10</asp:ListItem>
                                                                            <asp:ListItem Selected="True">9</asp:ListItem>
                                                                            <asp:ListItem>8</asp:ListItem>
                                                                            <asp:ListItem>7</asp:ListItem>
                                                                            <asp:ListItem>6</asp:ListItem>
                                                                            <asp:ListItem>5</asp:ListItem>
                                                                            <asp:ListItem>4</asp:ListItem>
                                                                            <asp:ListItem>3</asp:ListItem>
                                                                            <asp:ListItem>2</asp:ListItem>
                                                                            <asp:ListItem>1</asp:ListItem>
                                                            </asp:RadioButtonList>
                                                            
                                                        </fieldset>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left" />
                                                </asp:TemplateField>
                                            </Columns>
                                            
                                        </asp:GridView>



        <asp:Button ID="Button2" runat="server" Text="提交并下一步" onclick="Button2_Click" CssClass="btn2" />
        </center>
                                        <asp:Label ID="tixing" runat="server" Text=""></asp:Label>
                                        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
<div class="slogan2_"><img src="img/slogan2.png"></div>
                 


        
    </form>

</body>

</html>
