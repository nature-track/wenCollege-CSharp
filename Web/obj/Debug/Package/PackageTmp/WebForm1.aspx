<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Maticsoft.Web.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
   用户名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
  <div id="_container">
    <input type="file" size="50" name="File" />
  </div>
  <div>
    <input type="button" value="添加文件(Add)" onclick="addFile()" />
  </div>
  <div style="padding:10px 0">
    <asp:Button runat="server" Text="开始上传" ID="UploadButton" 
      onclick="UploadButton_Click"></asp:Button>
  </div>
  <div>
    <asp:Label ID="strStatus" runat="server" Font-Names="宋体" Font-Bold="True" Font-Size="9pt"
      Width="500px" BorderStyle="None" BorderColor="White"></asp:Label>

</asp:Content>
