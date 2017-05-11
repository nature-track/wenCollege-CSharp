<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="print.aspx.cs" Inherits="Maticsoft.Web.hui_kuan_dan.print" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <style type="text/css" >
    .biao1 
    {
        width:100%;
        margin:0;
        
    }
    .biao1 td
    {
       font-size:17px;
       
    }
    .biao2
    {
        border-collapse:collapse;border-spacing:0;border-left:1px solid #888;border-top:1px solid #888;
    }
    .biao2 td
    {
        text-align:center;
        height:34px;
    }
    </style>
    <script type="text/javascript">
    
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

<table class="biao1" >
<tr><td><center><strong style="font-size: 20px; font-family: 黑体;">付款申请表</strong></center>  </td></tr>
<tr><td style="text-align:right; height:15px">日期:&nbsp; 
    <asp:Literal ID="date_time" runat="server"></asp:Literal>
    </td></tr>
<tr><td style="text-align:left; height:30px;">申请汇款部门：&nbsp; 温氏学院</td></tr>
<tr><td>
<table class="biao2" width="100%" border="1px" cellpadding="0" cellspacing="0" bordercolor="#000000"  >
    <tr >
      <td style="height:60px;">汇款内容</td><td colspan="8">
        <asp:Literal ID="huikuan_neirong" runat="server"></asp:Literal>
        </td>
    </tr>
    <tr>
      <td>项目名称</td><td colspan="6"><asp:Literal ID="xiangmu_mingcheng"   runat="server"></asp:Literal>
        </td><td>项目总款</td><td>￥<asp:Literal ID="xiangmu_zongkuan" runat="server"></asp:Literal></td>
    </tr>
    <tr>
      <td>已付金额</td><td colspan="2">￥<asp:Literal ID="yifu_jine" runat="server"></asp:Literal></td><td>已付比例</td><td>0</td><td>支付时间</td><td colspan="3">
        <asp:Literal ID="zhifu_shijian" runat="server"></asp:Literal>
        </td>
    </tr>
    <tr>
      <td colspan="2">本次申请付款金额</td><td colspan="2">￥<asp:Literal ID="benci_jine"   runat="server"></asp:Literal>
        </td><td>大写：</td><td colspan="4">
        <asp:Literal ID="RMB" runat="server"></asp:Literal>
        </td>
    </tr>
    <tr>
      <td>未付余款</td><td colspan="3">￥0.00</td><td colspan="2">预计余款支付时间</td><td colspan="3">
        <asp:Literal ID="yuji_yukuan" runat="server"></asp:Literal>
        </td>
    </tr>
    <tr >
      <td rowspan = "3">收款单位</td><td>户名</td><td colspan="7">
        <asp:Literal ID="name" runat="server"></asp:Literal>
        </td>
    </tr>
    <tr>
      <td>开户行</td><td colspan="7">
          <asp:Literal ID="bank" runat="server"></asp:Literal></td>
    </tr>
    <tr>
      <td>账号</td><td colspan="7">
        <asp:Literal ID="bank_num" runat="server"></asp:Literal>
        </td>
    </tr>
</table> 
</td></tr>
<tr><td><table width="100%"><tr><td>经手人：</td><td>证明/验收人：</td><td>财务审核：</td><td>领导审批：</td></tr></table></td></tr>

</table>



    </form>
</body>
</html>
