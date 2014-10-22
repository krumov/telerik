(function ($) {
    $.fn.dropdown = function () {
        $this = $(this);
        $this.css("display","none");
        var $div = $('<div class="dropdown-list-container"></div>');
        var $ul = $('<ul class="dropdown-list-options"></ul>');
        $div.append($ul);

        var numOfOptions = $this.find("option").length;

        for (var i = 0; i < numOfOptions; i++) {
            var $li = $("<li class='dropdown-list-option' data-value=" +
                i + ">" + $('option[value='+(i+1)+']').text() + "</li>");
            $ul.append($li);
        }

        $('body').append($div);

        $('li').on('click',function(){
           $li = $(this);
            $optionElement = $('option[value='+ (parseInt($li.attr("data-value"))+1) +']');

            if($optionElement.attr('selected') == 'selected'){
                $optionElement.removeAttr('selected');
            }else{
                $optionElement.attr('selected','selected');
            }
        })
    };
}(jQuery));