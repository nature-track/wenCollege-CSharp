<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="print_name3.aspx.cs" Inherits="Maticsoft.Web.tools.print_name3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="../js/jquery-1.10.2.min.js"></script>

    <style type="text/css">
	*{ padding:0; margin:0;}
	.one_piece{width:600px; margin:0 auto;border:1px solid #ccc; overflow:hidden;page-break-after :always; border-top:none;}
	.one_piece .small_name{position:relative;height:358px; border-top:1px solid #ccc;}
	.one_piece .small_name div{ float:left;}
	.one_piece .small_name .name{ width:280px; line-height:260px; margin-top:70px; font-size:80px; text-align:center; border-right:1px solid #000; font-family:"微软雅黑";}
	.one_piece .small_name .sentense{ font-family:"微软雅黑"; padding:20px;}
	.one_piece .small_name .row2{width:284px; padding-right:15px;font-size:28px; line-height:45px; margin-top:130px;}
	.one_piece .small_name .row3{width:284px; padding-right:15px;font-size:30px; line-height:43px; margin-top:110px;}
	.one_piece .small_name .row4{width:284px; padding-top:15px; padding-right:15px;font-size:26px; line-height:45px; margin-top:105px;}
	.one_piece .small_name .row5{width:275px; padding-right:15px;font-size:25px; line-height:38px; margin-top:80px;}
	.one_piece .small_name .row55{width:275px; padding-right:15px;font-size:24px; line-height:36px; margin-top:70px;}
	.one_piece .small_name .row6{width:275px; padding-right:15px;font-size:23px; line-height:36px; margin-top:70px;}
	.one_piece .small_name .row7{width:289px; padding-top:15px; padding-right:15px;font-size:20px; line-height:35px; margin-top:80px;}
	.one_piece .small_name .sentense p{ text-align:right; padding-top:20px;}
	.one_piece .big_name{position:relative;height:358px; border-top: 1px solid #ccc; text-align:center; font-family: "微软雅黑";}
	.one_piece .big_name small{ font-size:50px;line-height:200px; display:block; height:190px; overflow:visible;}
	.one_piece .big_name span{line-height:100px; font-size:160px; display:block; }
	.one_piece img{ width:630px; position:absolute; top:10px; left:80px;}
	.page_break{page-break-after :always;}
</style>

            <script type="text/javascript">
                //请使用IE或者Chrome浏览器打印，左右页边距设为30mm
                var name_str = ' <%=str() %>';
                //在此写入学员所属公司与姓名，公司与姓名间以逗号分割，不同人的信息以分号分隔。例："公司,姓名;公司,姓名"。

                var name_list = new Array(); ;
                var one_piece = '<div class="one_piece"></div>'; //单个台卡通用代码
                var big_div = '<div class="big_name"><img src="logo.png" /><small></small><span></span></div>'; //正面代码
                var small_div = '<div class="small_name"><img src="logo.png" /><div class="name"><span></span></div><div class="sentense row3"></div></div>'; //背面代码
                var sentense_list = [
						['row6', '情况是在不断的变化，要使自己的思想适应新的情况，就得学习。<br />——毛泽东引自《在中国共产党全国宣传工作会议上的讲话》'],
						['row5', '学习这件事不在乎有没有人教你，最重要的是在于你自己有没有觉悟和恒心。<p>——法布尔</p>'],
						['row4', '学者贵知其当然与所以然，若偶能然，不得谓为学。<p>——孙中山</p>'],
						['row3', '<center>人之进学在于思，<br />思则能知是与非。</center><p>——朱熹</p>'],
						['row2', '业精于勤，荒于嬉。<p>——韩愈</p>'],
						['row3', '<center>知不足者好学，<br />耻不问者自满。</center><p>——林逋</p>'],
						['row3', '学习必须与实干相结合。<p>——泰戈尔</p>'],
						['row3', '不读书的人，<br />思想就会停止。<p>——狄德罗</p>'],
						['row3', '<center>富贵必从勤苦得，<br  />男儿须读五车书。</center><p>——杜甫</p>'],
						['row4', '三人行，必有我师焉。择其善者而从之，其不善者而改之。<p>——孔子</p>'],
						['row4', '夫学须志也，才须学也。非学无以广才，非志无以成学。<p>——诸葛亮</p>'],
						['row3', '书犹药也，<br />善读之可以医愚。<p>——刘向</p>'],
						['row3', '<center>家贫志不移，<br />贪读如饥渴。</center><p>——范仲淹</p>'],
						['row3', '<center>人无贤愚，<br />非学曷成？</center><p>——陆以田</p>'],
						['row3', '<center>读不在三更五鼓，<br />功只怕一曝十寒。</center><p>——郭沫若</p>'],
						['row4', '读书譬如饮食，从容咀嚼，其味必长；大嚼大咀，终不知味也。<p>——朱熹</p>'],
						['row3', '<center>玉不啄，不成器；<br />人不学，不知道。</center><p>——《礼记》</p>'],
						['row4', '聪明在于学习，天才在于积累。所谓天才，实际上是依靠学习。<p>——华罗庚</p>'],
						['row5', '我所遇见的每一个人，或多或少都是我的老师，因为我从他们身上学到了东西。<p>——爱默生</p>'],
						['row3', '<center>博学笃志，<br />神闲气静。</center><p>——王永彬</p>'],
						['row3', '独学而无友，<br />则孤陋而寡闻。<p>——孔子</p>'],
						['row3', '<center>读万卷书，<br />行万里路。</center><p>——刘彝</p>'],
						['row3', '天赋如同自然花木，<br />要用学习来修剪。<p>——培根</p>'],
						['row3', '<center>读书谓已多，<br />抚事知不足。</center><p>——王安石</p>'],
						['row3', '<center>鸟欲高飞先振翅，<br />人求上进先读书。</center><p>——李苦禅</p>'],
						['row3', '<center>旧书不厌百回读，<br />熟读精思子自知。</center><p>——苏轼</p>'],
						['row3', '<center>学必求其心得，<br />业必贵其专精。</center><p>——章学诚</p>'],
						['row3', '<center>聪明在于勤奋，<br />天才在于积累。</center><p>——华罗庚</p>'],
						['row3', '<center>学者贵于行之，<br />而不贵于知之。</center><p>——司马光</p>'],
						['row3', '倘能生存，<br/>我当然仍要学习。<p>——鲁迅</p>'],
						['row5', '学习如果想有成效，就必须专心。学习本身是一件艰苦的事，只有付出艰苦的劳动，才会有相应的收获。<p>——谷超豪</p>'],
						['row3', '学习要有三心,一信心,二决心,三恒心。<p>——陈景润</p>'],
						['row3', '越学习，<br />越发现自己的无知。<p>——笛卡尔</p>'],
						['row3', '善学者，<br />假人之长以补其短。<p>——吕不韦</p>'],
						['row3', '<center>物之成于气，<br />人之成于学。</center><p>——陈确</p>'],
						['row4', '如果不想在世界上虚度一生，那就要学习一辈子。<p>——高尔基</p>'],
						['row3', '<center>熟读唐诗三百首，<br />不会作诗也会吟。</center><p>——孙洙</p>'],
						['row3', '不怨天，不尤人，下学而上达。<p>——《论语》</p>'],
						['row3', '聪明的人有长的耳朵和短的舌头。<p>——弗莱格</p>'],
						['row4', '与其用华丽的外衣装饰自己，不如用知识武装自己。<p>——马克思</p>'],
						['row5', '我们不需要死读硬记，我们需要用基本的知识来发展和增进每个学习者的思考力。<p>——列宁</p>'],
						['row4', '无贵无贱，无长无少，道之所存，师之所存也。<p>——韩愈</p>'],
						['row3', '学习知识要善于思考，思考，再思考。<p>——爱因斯坦</p>'],
						['row3', '好学则老而不衰，<br />可免好得之患。<p>——申涵光</p>'],
						['row3', '<center>书到用时方恨少，<br />事非经过不知难。</center><p>——陆游</p>']
						];
                var do_one_piece = function (i) {
                    var one1 = $(one_piece);
                    var one2 = $(one_piece);
                    for (var j = 0; j < 3; j++) {
                        var t = i * 3 + j;
                        if (t >= name_list.length) break;
                        var b = $(big_div);
                        var s = $(small_div);
                        b.find("small").html(name_list[t][0]);
                        b.find("span").html(name_list[t][1]);
                        s.find("span").html(name_list[t][1]);
                        if (t >= sentense_list.length) t -= sentense_list.length;
                        s.find(".sentense").addClass(sentense_list[t][0]).html(sentense_list[t][1]);
                        one1.append(s);
                        one2.append(b);
                    }
                    $(document.body).append(one1).append(one2);
                };
                var do_name_list = function () {
                    //name_list=name_str.split(/[ ,，、]+/);
                    var tmp = name_str.split(";"), tmp2;
                    for (i = 0; i < tmp.length; i++) {
                        tmp2 = tmp[i].split(",");
                        name_list.push([tmp2[0], tmp2[1]]);

                    }
                };
                $(function () {
                    do_name_list();
                    if (name_list.length < 1) return;
                    var pageno = name_list.length % 3 == 0 ? parseInt(name_list.length / 3) : parseInt(name_list.length / 3 + 1);
                    for (i = 0; i < pageno; i++) {
                        do_one_piece(i);
                    }
                });
            </script>


</head>
<body>
    <form id="form1" runat="server">
    <div>

    </div>
    </form>
</body>
</html>
