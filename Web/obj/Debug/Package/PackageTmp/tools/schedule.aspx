<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="schedule.aspx.cs" Inherits="Maticsoft.Web.tools.schedule" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head  runat="server">
        <title>学院行事日历</title>
	<meta name="author" content="Jquery-School" />
<meta name="Copyright" content="Jquery-School,www.jq-school.com" />
<meta name="Keywords" content"分享一款简洁大气的日程安排Jquery特效,Jquery插件,Jquery原创,Jquery资源,Jquery特效,js特效,div+css,JquerySchool" />
<meta name="description" content="JquerySchool是一个专门分享jquery资源、jquery插件、jquery特效的一个网站,完全开放源代码,把实际开发中应用最多、最实用的Jquery资源抽取出来再加以精心编排,让广大网友能以最短的时间、花最少的精力去真正掌握jQuery开发的知识。" />
<meta name="description" content="">
<meta name="viewport" content="width=device-width">
<link rel="stylesheet" href="css/bootstrap.css">
<link rel="stylesheet" href="css/fullcalendar.css">
<link rel="stylesheet" href="css/fullcalendar.print.css" media='print'>
<link rel="stylesheet" href="css/style.css">
</head>
<body>
    <form id="form1" runat="server">
	<div class="container">
	<div class="content">
		<div class="row-fluid">
			<div class="span12">
				<div class="box">
					<div class="box-head">
						<h3>学院行事日历</h3>
					</div>
					<div class="box-content box-nomargin">
						<div class="calendar"></div>
					</div>
				</div>
			</div>
		</div>
	</div>	
	</div>
</div>	
<script src="http://www.jq-school.com/js/jquery-1.7.2.min.js" type="text/javascript"></script>
<script src="js/fullcalendar.min.js"></script>
<script src="js/custom.js"></script>
<script type="text/javascript">
    // - CALENDAR
    var date = new Date();
    var d = date.getDate();
    var m = date.getMonth();
    var y = date.getFullYear();

    if ($('.calendar').length > 0) {
        $('.calendar').fullCalendar({
            header: {
                left: 'prev,next,today',
                center: 'title',
                right: 'month,agendaWeek,agendaDay'
            },
            buttonText: {
                today: 'Jump to current day'
            },
            editable: true,
            events: [

            <%=loadeven() %>
            <%=loadeven2() %>
//			{
//			    title: 'All Day Event',
//			    start: new Date(y, m, 1)
//			},
//			{
//			    title: '46期干部培训班',
//			    start: new Date(y, m, 28),
//			    end: new Date(y, m, 30)
//			},
//			{
//			    id: 999,
//			    title: 'Repeating Event',
//			    start: new Date(y, m, d - 3, 16, 0),
//			    allDay: false
//			},
//			{
//			    id: 999,
//			    title: 'Repeating Event',
//			    start: new Date(y, m, d + 4, 16, 0),
//			    allDay: false
//			},
//			{
//			    title: 'Meeting',
//			    start: new Date(y, m, d, 10, 30),
//			    allDay: false
//			},
//			{
//			    title: 'Lunch',
//			    start: new Date(y, m, d, 12, 0),
//			    end: new Date(y, m, d, 14, 0),
//			    allDay: false
//			},
//			{
//			    title: 'Birthday Party',
//			    start: new Date(y, m, d + 1, 19, 0),
//			    end: new Date(y, m, d + 1, 22, 30),
//			    allDay: false
//			},
//			{
//			    title: 'Click for Google',
//			    start: new Date(y, m, 28),
//			    end: new Date(y, m, 29),
//			    url: '../../google.com/default.htm'
//			}
			]
        });
    }

</script>
    </form>
</body>
</html>
