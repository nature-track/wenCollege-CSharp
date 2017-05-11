<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Maticsoft.Web.account.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../jquery-ui-1.12.1.custom/external/jquery/jquery.js" type="text/javascript"></script>
    <script src="../jquery-ui-1.12.1.custom/jquery-ui.min.js" type="text/javascript"></script>
    <style type="text/css">
    .main_table td
    {
    font-size:1em;
    padding:0em;
    text-align:center;
    }
    .main_table td input
    {
        height:1.5em;
        width:100%;
        border:none;
    }
    </style>
         <script language='javascript' type='text/javascript'>
             $(document).ready(function () {
                 $("#<%=luru_time.ClientID %>").datepicker();
             }); 
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    

    <br />
    <h2 class="demoHeaders">温氏学院费用录入单</h2>
    <fieldset>
	    <legend>填表</legend>
	    <div id="controlgroup">
        <table width="100%" >
        <tr>
            <td>
                单据名称：</td>
             <td><asp:TextBox ID="name" runat="server"  Width="100%"></asp:TextBox>
             <div id="name_id" class="red">&nbsp;&nbsp;</div>
             </td>

        </tr>
        <tr>
          <td> 选择类别：</td>
          <td><asp:RadioButtonList ID="leibie" runat="server" AutoPostBack="True" 
        RepeatDirection="Horizontal" RepeatLayout="Table" Width="100%" 
                  onselectedindexchanged="leibie_SelectedIndexChanged" >
        <asp:ListItem Selected="True">培训班费用</asp:ListItem>
        <asp:ListItem>日程运营费用</asp:ListItem>
        <asp:ListItem>固定资产</asp:ListItem>
    </asp:RadioButtonList></td>
        </tr>
        <tr>
          <td>选择培训班：</td>
          <td><asp:DropDownList ID="qishu" runat="server" Width="100%">     </asp:DropDownList>  </td>
        </tr>
        <tr>
            <td>
                备注：</td>
             <td><asp:TextBox ID="beizhu" runat="server" TextMode="MultiLine" Width="100%"></asp:TextBox></td>

        </tr>
        <tr>
           <td>录入行数</td>
           <td>
               <asp:TextBox ID="hangshu" runat="server">5</asp:TextBox>
               <asp:Button ID="hangshu_queding" runat="server" Text="刷新" 
                   onclick="hangshu_queding_Click" />
            </td>
        </tr>
        </table>
       
            


&nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="main_table" Width="100%">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="序号" />
            <asp:TemplateField HeaderText="物资">
                <ItemTemplate>
                    <asp:TextBox ID="wuzi" runat="server" OnTextChanged="buquan"   AutoPostBack="True" CssClass="wuzi_css"></asp:TextBox>
                    
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="单位">
                <ItemTemplate>
                    <asp:TextBox ID="danwei" runat="server" CssClass="danwei_css"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="单价">
                <ItemTemplate>
                    <asp:TextBox ID="danjia" runat="server" CssClass="danjia_css"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="数量">
                <ItemTemplate>
                    <asp:TextBox ID="shuliang" runat="server" CssClass="shuliang_css"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="备注（供应商）">
                <ItemTemplate>
                     <asp:TextBox ID="beizhu" runat="server"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            
             <asp:TemplateField HeaderText="小计">
                <ItemTemplate>
                    <asp:Label ID="xiaoji" runat="server" Text="" CssClass="xiaoji_css"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
        </Columns>
    </asp:GridView>
        </div>

        <br />
        <table class="main_table" width="100%">
        <tr><td>录入人：<asp:DropDownList ID="jingshouren" runat="server" Width="40%"></asp:DropDownList>
            
            </td><td>录入时间：<asp:TextBox ID="luru_time" runat="server" Width="40%"></asp:TextBox>

            </td>
            <td>
            合计：<asp:Label ID="sum" runat="server" Text="0"></asp:Label></td>
            </tr>
        </table>
    </fieldset>
    <br />
    <asp:Button ID="Button1" runat="server" Text="确定" onclick="Button1_Click" UseSubmitBehavior="False" />

    <input id="Button3" type="button" value="取消" />
    <br />

    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    <script type="text/javascript">
        $("#<%=name.ClientID %>").focus(function () { $("#name_id").html("名称用于便于以后查询记忆"); });
        $("#<%=name.ClientID %>").blur(function () { $("#name_id").html("&nbsp;&nbsp;"); });
        $("#<%= GridView1.ClientID %> tr td").find(".wuzi_css").autocomplete({
            source: availableTags
        });
        $("#<%=Button1.ClientID  %>").button();
        $("#Button3").button();
        $("#Button3").click(function () {
            window.location.href = "list.aspx";
        });
        //        $( "#<%= leibie.ClientID %>" ).buttonset();
        $(function () {

            $(".shuliang_css").each(function (e) {
                if ($(this).val() != "") {
                    var sum = 0;
                    var $shuliang = $(this).parent().parent().find(".shuliang_css").val();
                    var $danjia = $(this).parent().parent().find(".danjia_css").val();
                    var $xiaoji = $(this).parent().parent().find(".xiaoji_css");
                    $xiaoji.text(($shuliang * $danjia).toFixed(2));
                    $("#<%= GridView1.ClientID %> ").find(".xiaoji_css").each(function (index, element) {

                        if ($(this).text() != "") {
                            sum +=parseFloat($(this).text());
                        };
                    });
                    $("#<%=sum.ClientID %>").text(sum.toFixed(2));
                    $(this).focus();
                    $(this).select();
                }
            });
            $(".shuliang_css,.danjia_css").change(function (e) {
                var sum = 0;
                var $shuliang = $(this).parent().parent().find(".shuliang_css").val();
                var $danjia = $(this).parent().parent().find(".danjia_css").val();
                var $xiaoji = $(this).parent().parent().find(".xiaoji_css");
                $xiaoji.text($shuliang * $danjia);
                $("#<%= GridView1.ClientID %> ").find(".xiaoji_css").each(function (index, element) {

                    if ($(this).text() != "") {
                        sum += parseFloat($(this).text());
                    };
                });
                $("#<%=sum.ClientID %>").text(sum.toFixed(2));
            })
        })



    </script>
    
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
