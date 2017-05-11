//单击文本框选中内容
function selectContent(it){
	it.select();
}
function selectAllTextContent(){
	$(':text, textarea').click(function(){selectContent(this);});
}

//设置表单样式
function formatForm(){
	formatTextInput();
	formatButton();
}

//设置文本框样式
function formatTextInput(){
	var list=$(':text');
	list.each(function(index, element) {
		var it=$(this);
        var plus=$('<div class="TextInputDiv"><div class="DivRight"></div></div>');
		plus.insertBefore(it);
		it.appendTo(plus);
		it.focus(function(){plus.removeClass("hover").addClass("focus");});
		it.blur(function(){plus.removeClass("hover focus");});
		it.mouseover(function(){plus.addClass("hover");});
    });
}

//设置按钮样式
function formatButton(){
	var list=$(':submit,:reset,:button');
	list.each(function(index, element) {
		var it=$(this);
        var plus=$('<div class="ButtonDiv"></div>');
		plus.insertBefore(it);
		it.appendTo(plus);
		it.focus(function(){plus.removeClass("hover").addClass("focus");});
		it.blur(function(){plus.removeClass("hover focus");});
		it.mouseover(function(){plus.addClass("hover");});
    });
}