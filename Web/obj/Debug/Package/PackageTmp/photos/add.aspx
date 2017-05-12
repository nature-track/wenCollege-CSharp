<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="Maticsoft.Web.photos.add" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link href="uploadify/uploadify.css" type="text/css" rel="stylesheet" />
<script type="text/javascript" src="uploadify/jquery-1.4.2.min.js"></script>
<script type="text/javascript" src="uploadify/swfobject.js"></script>
<script type="text/javascript" src="uploadify/jquery.uploadify.v2.1.4.min.js"></script>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
       <script type="text/javascript">
           function addFile() {
               var div = document.createElement("div");
               var f = document.createElement("input");
               f.setAttribute("type", "file")
               f.setAttribute("name", "File")
               f.setAttribute("size", "50")
               div.appendChild(f)
               var d = document.createElement("input");
               d.setAttribute("type", "button")
               d.setAttribute("onclick", "deteFile(this)");
               d.setAttribute("value", "移除")
               div.appendChild(d)
               document.getElementById("_container").appendChild(div);
           }

           function deteFile(o) {
               while (o.tagName != "DIV") o = o.parentNode;
               o.parentNode.removeChild(o);
           }
  </script>

</head>

  <h3>多文件上传</h3>
   所属培训班：<asp:DropDownList ID="qishu_dro" runat="server">
       </asp:DropDownList>
       <br />
   分类：<asp:DropDownList ID="fenlei_dro"   runat="server">
           <asp:ListItem Value="开班分组">开班分组</asp:ListItem>
           <asp:ListItem Value="素质拓展">素质拓展</asp:ListItem>
           <asp:ListItem Value="企业文化分享">企业文化分享</asp:ListItem>
           <asp:ListItem Value="工作经验分享">工作经验分享</asp:ListItem>
           <asp:ListItem Value="辩论赛">辩论赛</asp:ListItem>
           <asp:ListItem Value="个人演讲">个人演讲</asp:ListItem>
           <asp:ListItem Value="篮球赛与晚会">篮球赛与晚会</asp:ListItem>
           <asp:ListItem Value="颁奖">颁奖</asp:ListItem>
           <asp:ListItem Value="其他">其他</asp:ListItem>
       </asp:DropDownList>
       
       <br />
       自定义分类<asp:TextBox ID="fenlei_txt" runat="server"></asp:TextBox>
       <br />
       <div id="_container">
    <input type="file" size="50" name="File" />
  </div>
  <div>
  <br />
    <input type="button" value="添加文件(Add)" onclick="addFile()" />
  </div>
  <div style="padding:10px 0">
    <asp:Button runat="server" Text="开始上传" ID="UploadButton" 
      onclick="UploadButton_Click"></asp:Button>
  </div>
  <div>
    <asp:Label ID="strStatus" runat="server" Font-Names="宋体" Font-Bold="True" Font-Size="9pt"
      Width="500px" BorderStyle="None" BorderColor="White"></asp:Label>

    </form>
</body>
</body>
</html>
