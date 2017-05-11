<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="weixin_test.aspx.cs" Inherits="Maticsoft.Web.weixin_test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Button" />
    </div>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <asp:Button ID="Button3" runat="server" Text="获取个人信息" onclick="Button3_Click" />
     <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br />
    <asp:Button ID="Button4" runat="server" Text="改备注名字" onclick="Button4_Click" />
    <asp:Button ID="Button5" runat="server" Text="测试获取access_token" 
        onclick="Button5_Click" />
    </form>
   
</body>
</html>
