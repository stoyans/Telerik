function createCalendar(selector, events) {
    var body = document.getElementById('calendar-container');
    var tbl = document.createElement('table');
    tbl.style.width = '800px';
    tbl.setAttribute('border', '1');
    tbl.style.borderCollapse = "collapse";
    var tbdy = document.createElement('tbody');
    var dayOfWeek = ['Sun', 'Mon', 'Tue', 'Wed', 'Thur', 'Fri', 'Sat'];
    var daysOfMonth = 1;
    var dayOfMonth = 1;

    for (var i = 0; i < 10; i++) {
        var tr = document.createElement('tr');
        for (var j = 0; j < 7; j++) { 
            if (i >= 8 && j > 1) {
                break;
            }

            if (i % 2 == 0) {
                var tdHeading = document.createElement('td');
                tdHeading.style.height = '10px';
                tdHeading.style.width = '60px';
                tdHeading.style.fontSize = "13px";
                tdHeading.style.textAlign = 'center';
                tdHeading.setAttribute('border', '1');
                tdHeading.style.backgroundColor = 'lightgray';
                tdHeading.addEventListener('mouseover', onMouseOver, false);
                tdHeading.addEventListener('mouseout', onMouseOut, false);
                tdHeading.addEventListener('click', onMouseClick, false);
                tdHeading.innerHTML = dayOfWeek[j] + ' ' + dayOfMonth + " June 2014";
               
                tr.appendChild(tdHeading)
                dayOfMonth++;
            }
            else {
                var td = document.createElement('td');
                for (var k = 0; k < events.length; k++) {
                    if (daysOfMonth == parseInt(events[k].date)) {
                        td.innerHTML = events[k].title + ' time: ' + events[k].hour + ' Duration: ' + events[k].duration;
                        td.innerHTML.fontsize = "12px";
                    }
                }
                td.addEventListener('click', onMouseClick, false);
                daysOfMonth++;
                td.style.height = "60px";
                tr.appendChild(td)
            }
        }
        
        tbdy.appendChild(tr);
    }

    tbl.appendChild(tbdy);
    body.appendChild(tbl);

    function onMouseOver() {
        this.style.backgroundColor = 'gray';
    }

    function onMouseOut() {
        this.style.backgroundColor = '';
    }

    function onMouseClick() {
        this.style.backgroundColor = 'green';
       // this.setAttribute('selected', 'selected');
    }
}