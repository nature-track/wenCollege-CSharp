<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="showlist.aspx.cs" Inherits="Maticsoft.Web.photos.showlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" href="css/index.css" />

   	
   	<!--从底部上升的遮罩效果  开始-->
	
	<div class="content">
		<ul class="contentbox">
        <asp:Literal ID="Literal2" runat="server"></asp:Literal>
			
		</ul>
	</div>
	<!--从底部上升的遮罩效果  结束-->
   
    <script type="text/javascript" src="js/jquery-1.11.2.min.js"></script>
	<script type="text/javascript" src="js/index.js"></script>
	
</asp:Content>
