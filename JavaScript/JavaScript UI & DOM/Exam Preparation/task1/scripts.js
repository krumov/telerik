function createCalendar(selector,events){

    var container = document.querySelector(selector);

    var dayBox = document.createElement("div");
    var dayBoxTitle = document.createElement("div");
    var dayBoxContent = document.createElement("div");
    dayBoxContent.className='day-content';
    var weekDays = ["Sun","Mon","Tue","Wed","Thu","Fri","Sat"];
    var selectedBox = null;

    dayBox.appendChild(dayBoxTitle);
    dayBox.appendChild(dayBoxContent);

    // set styles
    dayBox.style.border='1px solid black';
    dayBox.style.width = '120px';
    dayBox.style.height = '120px';
    dayBox.style.display = 'inline-block';

    dayBoxContent.style.float = 'left';

    container.style.width  =  (120*7.5)+'px';

    dayBoxTitle.style.borderBottom = "1px solid black";
    dayBoxTitle.style.backgroundColor = 'lightgrey';
    dayBoxTitle.style.textAlign = 'center';
    dayBoxTitle.style.fontWeight = 'bold';



    function createMonthBoxes (){
        var dayBoxes = [];

        for (var i = 0; i < 30 ; i++) {
            var dayOfWeek = weekDays[i % weekDays.length];
            dayBoxTitle.innerHTML = dayOfWeek +" "+(i+1) + " Jun 2014";
            dayBoxes.push(dayBox.cloneNode(true));
        }
        return dayBoxes;
    }

    function addEvents(boxes,events){
        for (var i = 0; i < events.length; i++) {
            var event = events[i];
            var content = boxes[event.date-1].querySelector('.day-content');
            content.innerHTML = event.hour +" "+ event.title;
        }
    }

    function onBoxMouseOver (ev){
        if(selectedBox !== this) {
            var title = this.firstElementChild;
            title.style.background = 'grey';
        }
    }
    function onBoxMouseout (ev){
        if(selectedBox !== this) {
            var title = this.firstElementChild;
            title.style.background = 'lightgrey';
        }
    }
    function onBoxClick (ev){
        var title = this.firstElementChild;
        if(selectedBox){
            title.style.background = 'lightgrey';
        }

        title.style.backgroundColor = 'white';
        selectedBox = this;
    }

    var boxes = createMonthBoxes();
    addEvents(boxes,events);

    var docFragment = document.createDocumentFragment();

    for(var i = 0; i<boxes.length; i+=1){
        docFragment.appendChild(boxes[i]);
        boxes[i].addEventListener('click', onBoxClick);
        boxes[i].addEventListener('mouseover', onBoxMouseOver);
        boxes[i].addEventListener('mouseout', onBoxMouseout);
    }

    container.appendChild(docFragment);

}