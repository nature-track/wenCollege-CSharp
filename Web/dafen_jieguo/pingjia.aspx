<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pingjia.aspx.cs" Inherits="Maticsoft.Web.dafen_jieguo.pingjia" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<meta name="viewport" content="width=device-width, initial-scale=1.0, user-scalable=0, minimum-scale=1.0, maximum-scale=1.0">
<meta name="apple-mobile-web-app-capable" content="yes" />
<meta name="apple-mobile-web-app-status-bar-style" content="default" />
<meta http-equiv="cache-control" content="no-transform"/>
<meta content="telephone=no" name="format-detection">
<meta http-equiv="pragma" content="no-cache">
<meta http-equiv="cache-control" content="no-cache">
<link href="css/css.css" rel="stylesheet" type="text/css">
    <script src="js/jquery-1.11.0.min.js" type="text/javascript"></script>
<style type="text/css">
.textbox
{
    display: block; 
width: 90%; 
height: 10em; 
padding: 0.5em; 
margin:0.5em;
font-size: 1.5em; 
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
</head>
<body>

    <form id="form1" runat="server">
<%--    <div class="bgg1"></div>
<div class="lauguage1"> </div>
<div class="slogan1"><img src="img/slogan1.png"></div>--%>
    <div class="bgg"></div>
       <div class="logo">
    <img src="img/logo2.png">
</div>
  <br />
  <center>
  
    <div class="text1">

                 <div>培训班：<asp:Label ID="peixunban" runat="server" Text="Label"></asp:Label> </div><br />
                  <div >课程名称：<asp:Label ID="kecheng" runat="server" Text="Label"></asp:Label></div><br />
                   <div>讲师：<asp:Label ID="jiangshi" runat="server" Text="Label"></asp:Label></div><br />
                  <div >组名：<asp:Label ID="zuming" runat="server" Text="Label"></asp:Label></div>

        </div>



                                        <asp:GridView ID="VoteView" runat="server" AutoGenerateColumns="False" 
                                            CellPadding="3"
                                            CellSpacing="1" DataKeyNames="id"  AlternatingRowStyle-BackColor="#e6e5e3"
                                            Width="100%">

                                            <Columns>
                                                <asp:TemplateField >
                                                    <ItemTemplate>
                                                        <asp:Label ID="id_Label" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"id") %>'></asp:Label>
                                                    
                                                        <%# DataBinder.Eval(Container.DataItem,"text") %>
                                                        <asp:Panel ID="ItemPanel" runat="server" CssClass="GbText" Direction="LeftToRight"
                                                            Width="100%">
                                                        </asp:Panel>
                                                        
                                                            <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" CssClass="textbox"  Width="90%" Height="10em" Wrap="True" style="overflow: visible" ></asp:TextBox>
                                                       
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Left" />
                                                </asp:TemplateField>
                                            </Columns>
                                            <PagerStyle  HorizontalAlign="Center" />
                                      
                                        </asp:GridView>
                  
                        <asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click"  CssClass="btn2" /> 
                         <asp:Label ID="tixing" runat="server" Text=""></asp:Label>
              
        </center>
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <br />
        <br />
    
    </div>
      
    </form>
</div>
    
</body>
</html>
