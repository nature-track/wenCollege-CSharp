<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="Maticsoft.Web.wuzi_diaoyong.Add" Title="增加页" %>

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
    #controlgroup
    {
        width:100%;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">  
    <div class="ui-widget">
	<div class="ui-state-error ui-corner-all" style="padding: 0 .7em;">
		<p><span class="ui-icon ui-icon-alert" style="float: left; margin-right: .3em;"></span>
		<strong>告知：</strong> 为了方便各分公司来学院进行培训，部分标准化的物品可以直接从学院的库存中领取，最终费用需要摊分，具体摊分细节再议</p>
	</div>
</div>
    <br />
    <h2 class="demoHeaders">温氏学院物料领用单</h2>
    <fieldset>
	    <legend>物资调用申请</legend>
	    <div  id="controlgroup" >  
        <table class="main_table">
          <tr>
             <td >分公司</td><td> <asp:Label ID="fengongsi" runat="server" Text=""></asp:Label></td>
          </tr>
          <tr>
             <td>培训班</td><td><asp:DropDownList ID="qishu" runat="server" Width="100%"></asp:DropDownList></td>
          </tr>
          <tr>
             <td>类型</td><td valign="middle"><asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                  RepeatDirection="Horizontal">
              <asp:ListItem Value="1" Selected="True">领用</asp:ListItem>
              <asp:ListItem Value="2">归还</asp:ListItem>
              </asp:RadioButtonList></td>
              
          </tr>
        </table>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="main_table">
        <Columns>
            <asp:TemplateField HeaderText="物品" SortExpression="name">
                <ItemTemplate>
                    <asp:Label ID="wupin" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="单位" SortExpression="danwei">
                <ItemTemplate>
                    <asp:Label ID="danwei" runat="server" Text='<%# Bind("danwei") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="单价" SortExpression="danjia">
                <ItemTemplate>
                    <asp:Label ID="danjia" runat="server" Text='<%# Bind("danjia") %>' CssClass="danjia_css"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="申请数量">
                <ItemTemplate>
                    <asp:TextBox ID="num" runat="server" CssClass="shuliang_css">0</asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="小计">
                <ItemTemplate>
                    <asp:Label ID="xiaoji" runat="server" Text="" CssClass="xiaoji_css"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="备注">
                <ItemTemplate>
                    <asp:TextBox ID="beizhu" runat="server"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="id" SortExpression="id" Visible="False">
                <ItemTemplate>
                    <asp:Label ID="id" runat="server" Text='<%# Bind("id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
            <br />
        <table class="main_table" width="100%">
        <tr><td>时间：<asp:Literal   ID="shijian" runat="server"></asp:Literal>

            </td>
            <td>
                预计承担费用：<asp:Label ID="sum" runat="server" Text="0"></asp:Label></td>
            </tr>
        </table>
    </div>
    </fieldset>
        <br />

                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" ></asp:Button>
                    <input id="Button3" type="button"   value="取消" />

    <br />
    <br />
    <br />

    <script type="text/javascript">
        $("#<%=btnSave.ClientID  %>").button();
        $("#Button3").button();
        $("#Button3").click(function () {
            window.location.href = "list.aspx";
        });

        $(".shuliang_css").change(function (e) {
            var sum = 0;
            var $shuliang = $(this).parent().parent().find(".shuliang_css").val();
            var $danjia = $(this).parent().parent().find(".danjia_css").text();
            var $xiaoji = $(this).parent().parent().find(".xiaoji_css");
            $xiaoji.text($shuliang * $danjia);
            $("#<%= GridView1.ClientID %> ").find(".xiaoji_css").each(function (index, element) {

                if ($(this).text() != "") {
                    sum += parseFloat($(this).text());
                };
            });
            $("#<%=sum.ClientID %>").text(sum.toFixed(2));
        })
    </script>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
