<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="admin_teacher.aspx.cs" Inherits="Maticsoft.Web.dafen_jieguo.admin_teacker" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../js/chart_code/highcharts.js" type="text/javascript"></script>
    <script src="../js/chart_code/modules/exporting.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table width=100%>
<tr>
    <td>
        <div>温氏科技理念</div>
        <div>陈峰</div>
    </td>
</tr>
<tr>
    <td style="width:30%">
    <div>综合评分</div>
    <div>9.61</div>
    <div id="container" style="min-width: 100px; height: 500px; margin: 0 auto"></div></td>
    <td style="width:70%">
    <div>学员的最大感受：</div>
    <div> 深刻认识科技于企业发展的重要性, 了解
集团下一步科技创新的方向；
 创新是推动力，技术与管理都重要；
 科技与管理密不可分，人才是科技创新的
第一资源，创新驱动的实质是人才的驱动；
 技术将引领企业的发展方向。
</div>
    <div>学员的意见与建议：</div>
    <div> 课时较短，只能了解科技发展历史；
 希望可以更详细的阐述温氏未来科技发展
的思路，陈总裁讲课的时间太少了；
 希望能将集团的成果、管理模式与社会上
其他公司进行对比。
</div>
    </td>
</tr>
</table>




		<script type="text/javascript">

		    Highcharts.chart('container', {
		        chart: {
		            type: 'bar'
		        },
		        title: {
		            text: ''
		        },
		        xAxis: {
		            type: 'category',
		            labels: {
		                rotation: -45,
		                style: {
		                    fontSize: '13px',
		                    fontFamily: 'Verdana, sans-serif'
		                }
		            }
		        },
		        yAxis: {
		            min: 0,
		            title: {
		                text: '学员评分'
		            }
		        },
		        legend: {
		            enabled: false
		        },

		        series: [{
		            name: '学员评分',
		            data: [
            ['预期相似度', 9.56],
            ['授课熟练度',9.71],
            ['授课言语与方法', 9.59],
            ['结构逻辑', 9.71],
            ['内容适当度', 9.53],
            ['控场能力', 9.65],
            ['理论实用性', 9.62],
            ['吸收理解度',9.47],
            ['学员满意度',9.65],
            ['授课技巧',9.65],
        ],
		            dataLabels: {
		                enabled: true,
		                rotation: -90,
		                color: '#FFFFFF',
		                align: 'right',
		                format: '{point.y:.1f}', // one decimal
		                y: 10, // 10 pixels down from the top
		                style: {
		                    fontSize: '13px',
		                    fontFamily: 'Verdana, sans-serif'
		                }
		            }
		        }]
		    });
		</script>


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
