<%@ Page Title="" Language="C#" MasterPageFile="m_weixin.Master" AutoEventWireup="true" CodeBehind="discuss.aspx.cs" Inherits="Maticsoft.Web.m_weixin.discuss" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style type="text/css">
/* bottomcut */
.bottomcut{position:fixed;bottom:0;left:0;z-index:9999;width:100%;}
*html .bottomcut{position:absolute;}
.bottomcut{font-size:0.5em;background:#EEEEEE;border-top:1px solid #DDDDDD;box-shadow:1px 0px 2px rgba(0,0,0,0.2);}
.toplet{ width:auto; height:1.2em; }
.aaa{ float:left; font-size:1em; margin:1%;}
.bbb{ float:right; font-size:1em; margin:1%;}
.ccc{ width:auto; font-size:1.3em; margin:1em 0.5em;}
.outlet{ width:1auto; margin:1em; border-color:Black; border-width:1px;}
</style>
<script type="text/javascript">
    function f() {
        window.location.href = "dis_index.aspx";
    }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br />
<br />
<br />
<div class="text">
      <asp:Literal ID="shangke_txt" runat="server"></asp:Literal>
<br />
</div>
<br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="95%"  AlternatingRowStyle-BackColor="#e6e5e3">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                <div class="outlet">
                    <div class="toplet" >
                        <div class="aaa"><asp:Literal ID="name" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"name") %>'></asp:Literal></div>
                        <div class="bbb"><asp:Literal ID="time" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"time") %>'></asp:Literal></div>
                    </div>
                    <div class="ccc"><asp:Literal ID="text" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"text") %>'></asp:Literal></div>
                </div>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <input id="Button2" type="button" value="返回" Class="btn2" onclick="f();"/>
    <br />
    <br />
    <br />
    <br />
    <br />
<div class="bottomcut">
	<h1><asp:Button ID="Button1" runat="server" Text="我也要发言"  CssClass="btn2" 
            onclick="Button1_Click"/></h1>

</div><!-- bottomcut -->
    
</asp:Content>
