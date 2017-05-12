<%@ Page Title="" Language="C#" MasterPageFile="m_weixin.Master" AutoEventWireup="true" CodeBehind="investigate.aspx.cs" Inherits="Maticsoft.Web.m_weixin.investigate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../dafen_jieguo/css/css.css" rel="stylesheet" type="text/css" />
    <script src="../dafen_jieguo/js/jquery-1.11.0.min.js" type="text/javascript"></script>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  Width="100%" AlternatingRowStyle-BackColor="#e6e5e3">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Panel ID="Panel3" runat="server" CssClass="Panel">
                    <asp:Label ID="id_Label" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"id") %>'></asp:Label>
                    <asp:Label ID="style_Label" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"style") %>'></asp:Label>                 
                    <%# DataBinder.Eval(Container.DataItem,"text") %>
                    </asp:Panel>
                     <fieldset class="big" >                                                     
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" type="radio"  RepeatDirection="Horizontal"  Width="100%" CssClass="c1" RepeatLayout="Flow" RepeatColumns="5">
                            </asp:RadioButtonList>
                         <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>                                        
                     </fieldset>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

    <asp:Button ID="Button2" runat="server" Text="确定" CssClass="btn2" 
        onclick="Button2_Click" />

        <a href="inv_index.aspx" class="btn2">返回</a>
<br />
<br />
</asp:Content>

