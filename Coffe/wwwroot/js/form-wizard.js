

(function( $ ) {
		
    function scroll_to_class(element_class, removed_height) {
        var scroll_to = $(element_class).offset().top - removed_height;
        if($(window).scrollTop() != scroll_to) {
            $('.form-wizard').stop().animate({scrollTop: scroll_to}, 0);
        }
    }

    function bar_progress(progress_line_object, direction) {
        var number_of_steps = progress_line_object.data('number-of-steps');
        var now_value = progress_line_object.data('now-value');
        var new_value = 0;
        if(direction == 'right') {
            new_value = now_value + ( 100 / number_of_steps );
            new_value = Math.round(new_value * 1000) / 1000;
        }
        else if(direction == 'left') {
            new_value = now_value - ( 100 / number_of_steps );
            new_value = Math.round(new_value * 1000) / 1000;
        }
        progress_line_object.attr('style', 'width: ' + new_value + '%;').data('now-value', new_value);
    }

    jQuery(document).ready(function() {

		/*
		 Form
		 */
        $('.form-wizard fieldset:first').fadeIn('slow');

        $('.form-wizard .required').on('focus', function() {
            $(this).removeClass('input-error');
        });

        // next step
        $('.form-wizard .btn-next').on('click', function() {
            var parent_fieldset = $(this).parents('fieldset');
            var next_step = true;
            // navigation steps / progress steps
            var current_active_step = $(this).parents('.form-wizard').find('.form-wizard-step.active');
            var progress_line = $(this).parents('.form-wizard').find('.form-wizard-progress-line');

            // fields validation
            parent_fieldset.find('.required').each(function() {
                if( $(this).val() == "" ) {
                    $(this).addClass('input-error');
                    parent_fieldset.find('.warning').fadeIn();
                    next_step = false;
                }
                else {
                    $(this).removeClass('input-error');
                    parent_fieldset.find('.warning').fadeOut();
                }
            });
            // fields validation

            if( next_step ) {
                parent_fieldset.fadeOut(400, function() {
                    // change icons
                    current_active_step.removeClass('active').addClass('activated').next().addClass('active');
                    // progress bar
                    bar_progress(progress_line, 'right');
                    // show next step
                    $(this).next().fadeIn();
                    // scroll window to beginning of the form
                    scroll_to_class( $('.form-wizard'), 20 );
                });
            }

        });

        // previous step
        $('.form-wizard .btn-previous').on('click', function() {
            // navigation steps / progress steps
            var current_active_step = $(this).parents('.form-wizard').find('.form-wizard-step.active');
            var progress_line = $(this).parents('.form-wizard').find('.form-wizard-progress-line');

            $(this).parents('fieldset').fadeOut(400, function() {
                // change icons
                current_active_step.removeClass('active').prev().removeClass('activated').addClass('active');
                // progress bar
                bar_progress(progress_line, 'left');
                // show previous step
                $(this).prev().fadeIn();
                // scroll window to beginning of the form
                scroll_to_class( $('.form-wizard'), 20 );
            });
        });

        // submit
        $('.form-wizard').on('submit', function(e) {

            // fields validation
            $(this).find('.required:not(.isCopy .required)').not('.isCopy .required').each(function() {  /* not() and :not not working */
					if( $(this).val() == "" && !$(this).closest('.isCopy').length /* not working*/ ) { 
						e.preventDefault(); 
						$(this).addClass('input-error');
						$(this).find('.warning').fadeIn();
					}
					else {
						$(this).removeClass('input-error');
						$(this).find('.warning').fadeOut();
					}
            });
            // fields validation

        });


    });

    String.prototype.replaceAll = function(searchStr, replaceStr) {
        var str = this;
        // no match exists in string?
        if(str.indexOf(searchStr) === -1) {
            // return string
            return str;
        }
        // replace and remove first match, and do another recursirve search/replace
        return (str.replace(searchStr, replaceStr)).replaceAll(searchStr, replaceStr);
    }


	/* custom js */
    jQuery(document).ready(function() {
        var  O=0;
        //select day
        var thisyear = (new Date()).getFullYear();
        for(var d=1;d<32;d++){
            $('select.select-day').append('<option value="'+d+'">'+d+'</option>');
        }
        var months = ['Yanvar','Fevral','Mart','Aprel',"May","İyun",'İyul','Avqust','Sentyabr','Oktyabr','Noyabr','Dekabr'];
        for(var $m=0;$m<months.length;$m++){
            $('select.select-month').append('<option value="'+($m+1)+'">'+months[$m]+'</option>');
        }
        for(var y=1975;y<=thisyear; y++){
            var selected = '';
            if(y==thisyear) selected = "selected";
            $('select.select-year').append('<option '+selected+' value="'+y+'">'+y+'</option>')
        }


        $('[data-toggle_me]').change(function(){
            var toggle_me = $(this).data("toggle_me");
            if($(this).val()!="" && $(this).val()!=0) $("#"+toggle_me).find('[disabled]').removeAttr('disabled').end().slideDown('fast');
            else $("#"+toggle_me).find('input, select').attr('disabled','disabled').end().slideUp('fast');
        })

        $('[data-open]').bind("click",function(e){
            e.preventDefault();
            var modal = $("#"+$(this).data("open"));
            modal.show();
        });
        $('[data-close]').click(function(e){
            e.preventDefault();
            var modal = $("#"+$(this).data("close"));
            modal.hide();
        });
        $('#refer-popup .btn').click(function(){
            var num = $("ul.refers li").length, r1 = $('#refer1').val(), r2=$('#refer2').val(), r3=$('#refer3').val(), r4=$('#refer4').val();
            if(r1 && r4){
                $('#refer-popup input').val("");
                var val = "<tr><td>"+r1+"</td><td>"+r2+"</td><td>"+r3+"</td><td>"+r4+"</td></tr>>";
                $("ul.refers").append('<li>'+r1+' <i class="icon-flaticon-6" title="Sil"></i><input type="hidden" name="refers[]" value="'+val+'" /></li>');
            } else {
                if(!r1) $("#refer1").addClass('input-error');
                if(!r4) $("#refer4").addClass('input-error');
                return false;
            }
        });
        $('ul.refers').on('click','li i',function(){
            $(this).parent().remove();
        });

        $('button[data-copy]').click(function(){
            O++;
            var Original = $("#"+$(this).data("copy"));
            var str = "<div class='isCopy' id='copy"+O+"'>"+Original.html()+"</div>";
            str=str.split('original').join(O);

            Original.before(str);
			 $('#copy'+O).hide().slideDown();
			 return false;
        });
    });
    // image uploader scripts
	/*
	 var $dropzone = $('.image_picker'),
	 $droptarget = $('.drop_target'),
	 $dropinput = $('#inputFile'),
	 $dropimg = $('.image_preview'),
	 $remover = $('[data-action="remove_current_image"]');

	 $dropzone.on('dragover', function() {
	 $droptarget.addClass('dropping');
	 return false;
	 });

	 $dropzone.on('dragend dragleave', function() {
	 $droptarget.removeClass('dropping');
	 return false;
	 });

	 $dropzone.on('drop', function(e) {
	 $droptarget.removeClass('dropping');
	 $droptarget.addClass('dropped');
	 $remover.removeClass('disabled');
	 e.preventDefault();

	 var file = e.originalEvent.dataTransfer.files[0],
	 reader = new FileReader();

	 reader.onload = function(event) {
	 $dropimg.css('background-image', 'url(' + event.target.result + ')');
	 };

	 console.log(file);
	 reader.readAsDataURL(file);

	 return false;
	 });

	 $dropinput.change(function(e) {
	 $droptarget.addClass('dropped');
	 $remover.removeClass('disabled');
	 $('.image_title input').val('');

	 var file = $dropinput.get(0).files[0],
	 reader = new FileReader();

	 reader.onload = function(event) {
	 $dropimg.css('background-image', 'url(' + event.target.result + ')');
	 }

	 reader.readAsDataURL(file);
	 });

	 $remover.on('click', function() {
	 $dropimg.css('background-image', '');
	 $droptarget.removeClass('dropped');
	 $remover.addClass('disabled');
	 $('.image_title input').val('');
	 });

	 $('.image_title input').blur(function() {
	 if ($(this).val() != '') {
	 $droptarget.removeClass('dropped');
	 }
	 });

	 // image uploader scripts
	 */
}( jQuery ));