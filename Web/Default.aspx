<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Maticsoft.Web.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>首页</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
<meta name="description" content="" />
<meta name="author" content="" />
<!-- css -->
<link href="css/bootstrap.min.css" rel="stylesheet" />
<link href="css/fancybox/jquery.fancybox.css" rel="stylesheet">
<link href="css/jcarousel.css" rel="stylesheet" />
<link href="css/flexslider.css" rel="stylesheet" />
<link href="js/owl-carousel/owl.carousel.css" rel="stylesheet"> 
<link href="css/style.css" rel="stylesheet" />
 
<!-- HTML5 shim, for IE6-8 support of HTML5 elements -->
<!--[if lt IE 9]>
      <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->
</head>
<body>
    <form id="form1" runat="server">
<div id="wrapper">
	<!-- start header -->
	<header>
        <div class="navbar navbar-default navbar-static-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="index.html"><img src="img/logo.png" alt="logo"/></a>
                </div>
                <div class="navbar-collapse collapse ">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="index.html">首页</a></li> 
						<li><a href="about.html">学院行事历</a></li>
						<li><a href="services.html">培训工具</a></li>
                        <li><a href="portfolio.html">学院使用申请</a></li>
                        <li><a href="pricing.html">培训照片</a></li>
                        <li><a href="contact.html">课程评价</a></li>
                    </ul>
                </div>
            </div>
        </div>
	</header>
	<!-- end header -->
	<section id="featured">
	 
	<!-- Slider -->
        <div id="main-slider" class="flexslider">
            <ul class="slides">
              <li>
                <img src="img/slides/1.jpg" alt="" />
				<div class="container">
				<div class="row">
				<div class="col-md-12">
                <div class="flex-caption">
                    <h3>温氏学院挂牌成立</h3> 
					<p>2015年5月20日，温氏学院在勒竹旧总部揭牌成立</p>  
                </div>
				</div></div></div>
              </li>
              <li>
                <img src="img/slides/2.jpg" alt="" />
				<div class="container">
				<div class="row">
				<div class="col-md-12">
                <div class="flex-caption">
                    <h3>培训设施</h3> 
					<p>目前学院有一栋培训楼，一栋宿舍楼<br />主要用于集团封闭式培训以及周边分公司干部培训使用</p> 
                </div>
				</div></div></div>
              </li>
              <li>
                <img src="img/slides/3.jpg" alt="" />
				<div class="container">
				<div class="row">
				<div class="col-md-12">
                <div class="flex-caption">
                    <h3>集团干部培训班</h3> 
					<p>每期培训班均邀请董事长或首席进行开班讲话<br />授课老师由经验丰富的高层领导担任</p>  
                </div>
				</div></div></div>
              </li>
            </ul>
        </div>
	<!-- end slider -->
 
	</section>
<%--	<section class="callaction">
	<div class="container">
		<div class="row">
		<div class="col-md-4">
		<img src="img/people.png" alt="" width="100%"/>
		</div>
			<div class="col-md-8">
				<div><h1><span>Our Services</h1><span class="clear spacer_responsive_hide_mobile " style="height:13px;display:block;"></span><p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores quae porro consequatur aliquam. eius magni provident, doloribus omnis minus temporibus perferendis nesciunt quam repellendus nulla nemo ipsum odit corrupti consequuuam.</p>
				<p>Perferendis nesciunt quam repellendus nulla nemo ipsum odit corrupti consequuntur possimus, vero mollitia quam repellendus nulla nemo ipsum odit corrupti consequuntur possimus, vero mollitia velit ad consectetur.</p>
				</div>
			</div>
		</div>
		
	</div>
	</section>--%>
	<section id="content">
	
	
	<div class="container">
		<div class="row">
            <div class="col-sm-4 info-blocks">
                <i class="icon-info-blocks fa fa-bell-o"></i>
                <div class="info-blocks-in">
                    <h3>集团干部培训班</h3>
                    <p>课程评价<br />培训照片<br />学习感悟<a href="weixin/wenxin_url.aspx">weixin/wenxin_url.aspx</a></p>
                </div>
            </div>
            <div class="col-sm-4 info-blocks">
                <i class="icon-info-blocks fa fa-hdd-o"></i>
                <div class="info-blocks-in">
                    <h3>培训工具</h3>
                    <p>倒计时工具<br />座位牌打印<br />...</p>
                </div>
            </div>
            <div class="col-sm-4 info-blocks">
                <i class="icon-info-blocks fa fa-lightbulb-o"></i>
                <div class="info-blocks-in">
                    <h3>学院使用申请</h3>
                    <p>填写申请使用信息表</p>
                </div>
            </div>
        </div>
<%--		<div class="row">
            <div class="col-sm-4 info-blocks">
                <i class="icon-info-blocks fa fa-code"></i>
                <div class="info-blocks-in">
                    <h3>SEO Ready</h3>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores quae porro consequatur aliquam.</p>
                </div>
            </div>
            <div class="col-sm-4 info-blocks">
                <i class="icon-info-blocks fa fa-compress"></i>
                <div class="info-blocks-in">
                    <h3>Fully Responsive</h3>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores quae porro consequatur aliquam.</p>
                </div>
            </div>
            <div class="col-sm-4 info-blocks">
                <i class="icon-info-blocks fa fa-html5"></i>
                <div class="info-blocks-in">
                    <h3>CSS3 + HTML5</h3>
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores quae porro consequatur aliquam.</p>
                </div>
            </div>
        </div>--%>
<%--	     <div class="row">
							<div class="col-md-7">
								<!-- Heading and para -->
								<div class="block-heading-two">
									<h3><span>Why Choose Us?</span></h3>
								</div>
								<p>Sed ut perspiciaatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur. <br><br>Sed ut perspiciaatis iste natus error sit voluptatem probably haven't heard of them accusamus.</p>
								<p>Voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo quasi architecto beatae vitae dicta sunt explicabo.</p>
								
								<p>Tis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur. <br><br>Sed ut perspiciaatis iste natus error sit voluptatem probably haven't heard of them accusamus.</p>
								<p>Voluptatem accusanti veritatis et quasi architecto beatae vitae dicta sunt explicabo quasi architecto beatae vitae dicta sunt explicabo.</p> 
							</div>
							<div class="col-xs-12 col-sm-12 col-md-5">
                 
                    <div class="latest-post-wrap pull-left"> 
						<h3><span>News</span></h3>
                        
                        <!--Post item-->
                        
                          <div class="post-item-wrap pull-left col-sm-6 col-md-12 col-xs-12">
                            <img src="img/news-2.jpg" class="img-responsive post-author-img" alt="">
                            <div class="post-content1 pull-left col-md-9 col-sm-9 col-xs-8">
        	                        <div class="post-title pull-left"><a href="#">Lorem ipsum dolor sitfroifs</a></div>
        	                        <div class="post-meta-top pull-left">
        	                            <ul>
        	                            <li><i class="fa fa-calendar"></i>22 Aug 2016</li> 
										<li><p>Voluptatem accusantium doloremque...</p></li>
        	                            </ul>
        	                        </div>
                                </div> 
                         </div>
						  <div class="post-item-wrap pull-left col-sm-6 col-md-12 col-xs-12">
                            <img src="img/news-1.jpg" class="img-responsive post-author-img" alt="">
                            <div class="post-content1 pull-left col-md-9 col-sm-9 col-xs-8">
        	                        <div class="post-title pull-left"><a href="#">Lorem ipsum dolor sitfroifs</a></div>
        	                        <div class="post-meta-top pull-left">
        	                            <ul>
        	                            <li><i class="fa fa-calendar"></i>22 Sep 2016</li> 
										<li><p>Voluptatem accusantium doloremque...</p></li>
        	                            </ul>
        	                        </div>
                                </div> 
                         </div>
                         <!--Post item-->
                        <div class="post-item-wrap pull-left col-sm-6 col-md-12 col-xs-12">
                            <img src="img/news-2.jpg" class="img-responsive post-author-img" alt="">
                            <div class="post-content1 pull-left col-md-9 col-sm-9 col-xs-8">
        	                        <div class="post-title pull-left"><a href="#">Lorem ipsum dolor sitfroifs</a></div>
        	                        <div class="post-meta-top pull-left">
        	                            <ul>
        	                            <li><i class="fa fa-calendar"></i>22 DEC 2016</li> 
										<li><p>Voluptatem accusantium doloremque...</p></li>
        	                            </ul>
        	                        </div>
                                </div> 
                         </div> 
                            
                        </div>
                    </div>
	
	
							
						</div>--%>
						
	 
	</div>
	
	</section>
	
	<footer>
	<div class="container">
<%--		<div class="row">
			<div class="col-lg-3">
				<div class="widget">
					<h5 class="widgetheading">Our Contact</h5>
					<address>
					<strong>Target company Inc</strong><br>
					JC Main Road, Near Silnile tower<br>
					 Pin-21542 NewYork US.</address>
					<p>
						<i class="icon-phone"></i> (123) 456-789 - 1255-12584 <br>
						<i class="icon-envelope-alt"></i> email@domainname.com
					</p>
				</div>
			</div>
			<div class="col-lg-3">
				<div class="widget">
					<h5 class="widgetheading">Quick Links</h5>
					<ul class="link-list">
						<li><a href="#">Latest Events</a></li>
						<li><a href="#">Terms and conditions</a></li>
						<li><a href="#">Privacy policy</a></li>
						<li><a href="#">Career</a></li>
						<li><a href="#">Contact us</a></li>
					</ul>
				</div>
			</div>
			<div class="col-lg-3">
				<div class="widget">
					<h5 class="widgetheading">Latest posts</h5>
					<ul class="link-list">
						<li><a href="#">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</a></li>
						<li><a href="#">Pellentesque et pulvinar enim. Quisque at tempor ligula</a></li>
						<li><a href="#">Natus error sit voluptatem accusantium doloremque</a></li>
					</ul>
				</div>
			</div>
			<div class="col-lg-3">
				<div class="widget">
					<h5 class="widgetheading">Recent News</h5>
					<ul class="link-list">
						<li><a href="#">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</a></li>
						<li><a href="#">Pellentesque et pulvinar enim. Quisque at tempor ligula</a></li>
						<li><a href="#">Natus error sit voluptatem accusantium doloremque</a></li>
					</ul>
				</div>
			</div>
		</div>--%>
	</div>
	<div id="sub-footer">
		<div class="container">
			<div class="row">
				<div class="col-lg-6">
					<div class="copyright">
						<p>
							Copyright &copy; 2016.Company name All rights reserved.<a target="_blank" href="http://www.17sucai.com/">&#x7F51;&#x9875;&#x6A21;&#x677F;</a>
						</p>
					</div>
				</div>
				<div class="col-lg-6">
					<ul class="social-network">
						<li><a href="#" data-placement="top" title="Facebook"><i class="fa fa-facebook"></i></a></li>
						<li><a href="#" data-placement="top" title="Twitter"><i class="fa fa-twitter"></i></a></li>
						<li><a href="#" data-placement="top" title="Linkedin"><i class="fa fa-linkedin"></i></a></li>
						<li><a href="#" data-placement="top" title="Pinterest"><i class="fa fa-pinterest"></i></a></li>
						<li><a href="#" data-placement="top" title="Google plus"><i class="fa fa-google-plus"></i></a></li>
					</ul>
				</div>
			</div>
		</div>
	</div>
	</footer>
</div>
<a href="#" class="scrollup"><i class="fa fa-angle-up active"></i></a>
    </form>

 <!-- javascript
    ================================================== -->
<!-- Placed at the end of the document so the pages load faster -->
<script type="text/javascript" src="js/jquery.js"></script>
<script type="text/javascript" src="js/jquery.easing.1.3.js"></script>
<script type="text/javascript" src="js/bootstrap.min.js"></script>
<script type="text/javascript" src="js/jquery.fancybox.pack.js"></script>
<script type="text/javascript" src="js/jquery.fancybox-media.js"></script> 
<script type="text/javascript" src="js/portfolio/jquery.quicksand.js"></script>
<script type="text/javascript" src="js/portfolio/setting.js"></script>
<script type="text/javascript" src="js/jquery.flexslider.js"></script>
<script type="text/javascript" src="js/animate.js"></script>
<script type="text/javascript" src="js/custom.js"></script>
<script type="text/javascript" src="js/owl-carousel/owl.carousel.js"></script>
</body>
</html>
