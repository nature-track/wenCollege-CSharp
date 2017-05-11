var timer;
$(function(){
	selectAllTextContent();
	formatForm();
	timer=new Timer();
	timer.setAction();
});

//设定计时时间
function Timer(){
	var hour=0,minute=3,second=0,down=-1,h=0,m=0,s=0,timer,str;
	var quick_arr=[2,3,4,5,6,10];
	var show=$("#timer span"),notice=$("#timer #alert");
	var audioElement = document.createElement('audio');
    audioElement.setAttribute('src', '2104.wav');
	var setTimer=function(){//读取填写的时间
		hour=parseInt($('#input_hour').val());
		minute=parseInt($('#input_min').val());
		second=parseInt($('#input_sec').val());
	}
	var bt_time=function(val){//设置开始按钮
		if(val){//可以使用
			$('#time_bt').removeAttr("disabled").removeClass("disable").click(function(){start(0);});
		}else{//禁用
			$('#time_bt').attr("disabled",true).addClass("disable").unbind("click");
		}
	}
	var bt_reset=function(val){//设置重置按钮
		if(val){//可以使用
			$('#reset_bt').removeClass("disable").click(resetTimer);
		}else{//禁用
			$('#reset_bt').addClass("disable").unbind("click");
		}
	}
	var bt_quick_single=function(val,t){//设置快速开始按钮
		if(val){//可以使用
			$('#bt_'+t).removeClass("disable").click(function(){start(t);});
		}else{//禁用
			$('#bt_'+t).addClass("disable").unbind("click");
		}
	}
	var bt_quick=function(val){
		for(var i=0;i<quick_arr.length;i++){
			bt_quick_single(val,quick_arr[i]);
		}
	}
	var bt_action=function(val){//暂停按钮
		if(val==1){//可以使用
			$('#action_bt').text("暂停").removeClass("disable").unbind("click").click(pause);
		}else if(val==0){//继续
			$('#action_bt').text("继续").unbind("click").click(function(){start(-1);});
		}else{//禁用
			$('#action_bt').text("暂停").addClass("disable").unbind("click");
		}
	}
	var showDown=function(){//显示倒计时的时间
		s=down%60;
		m=parseInt(down/60);
		h=parseInt(down/3600);
		str=h+"时"+m+"分"+s+"秒";
		show.html(str);
	}
	var countTime=function(){//超时计时
		if(++s%30==0){
			audioElement.play();
		}
		if(s==60){
			m++;
			s=0;
			if(m==60){
				h++;
				m=0;
			}
		}
		showTime();
	}
	var countDown=function(){//倒计时
		str="";
		down--;
		s=down%60;
		m=down%3600;
		h=parseInt(down/3600);
		showDown();
		//超时开始
		if(down==0){
			show.addClass('notice');
			show.html("时间到");
			audioElement.play();
			clearInterval(timer);
			h=m=s=0;
			notice.show();
			timer=setInterval(countTime,1000);
		}
	}
	var showTime=function(){//显示超时的时间
		str="超时："+h+"时"+m+"分"+s+"秒";
		notice.html(str);
	}
	var start=function(val){//开始计时
		if(val>0) {//快速开始
			hour=0,minute=val,second=0;
		}else if(val==0){//设置开始
			setTimer();
		}//小于0则是暂停开始
		//按钮更改
		bt_action(1);//允许暂停
		bt_time(false);//不能重新计时
		bt_reset(true);//允许重置
		bt_quick(false);
		//倒计时开始
		if(down<0){//重头开始
			down=hour*3600+minute*60+second;
			showDown();
			timer=setInterval(countDown,1000);
		}else if(down==0){//超时开始
			timer=setInterval(countTime,1000);
		}else{//继续
			timer=setInterval(countDown,1000);
		}
	};
	var pause=function(){//暂停
		clearInterval(timer);
		bt_action(0);
	}
	var resetTimer=function(){
		clearInterval(timer);
		$('#action_bt').unbind('click').click(start);
		h=0,m=0,s=0,down=-1;
		show.html("");
		show.removeClass('notice');
		$("#alert").hide();
		bt_time(true);
		bt_quick(true);
		bt_action(-1);
		bt_reset(false);
	}
	var playSound=function(){
		$('embed').remove();  
        $('body').append('<embed src="button.wav" autostart="true" hidden="true" loop="false">'); 
	}
	this.setAction=function(){//初始化
		for(var i=quick_arr.length-1;i>-1;i--){
			$(".quick_bt").prepend('<a id="bt_'+quick_arr[i]+'">'+quick_arr[i]+'分钟</a>');
		}
		bt_quick(true);
		bt_time(true);
		bt_action(-1);
		bt_reset(false);
	}
}