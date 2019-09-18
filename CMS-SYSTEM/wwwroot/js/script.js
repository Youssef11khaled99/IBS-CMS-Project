function menuIcon(x) {
    x.classList.toggle("change");
}
var toggle = false;
    function switchNavbar() {
        if (toggle) {
            toggle = false;
            closeNav();
        } else {
            toggle = true;
            openNav();
        }

    }
    let c = document.getElementById("mySidenav").children;
    let i;
    function openNav() {
        for (i = 0; i < c.length; i++) {
            c[i].style.fontSize =  "1.2rem";
        }
        document.getElementById("mySidenav").style.width = "200px";
        document.getElementById("main").style.marginLeft = "200px";
        document.getElementById("mySidenav").style.display = "block";
      //document.getElementById("bodyy").style.width = "71vw";
    }
    
    function closeNav() {
        for (i = 0; i < c.length; i++) {
            c[i].style.fontSize =  "0.5rem";
        }
        document.getElementById("mySidenav").style.width = "0";
        document.getElementById("main").style.marginLeft = "0";
      //document.getElementById("bodyy").style.width = "85vw";
    }

    function redirect() {
        var url = "http://127.0.0.1:5500/index.html";
        window.location = url;
}


///AYA:  ADD WIDGET 
function HideAndShow() {
    var content = document.getElementById("content");
    var icon_shape = document.getElementById("hideAndShow");

    if (content.style.display === "none") {
        content.style.display = "block";
        icon_shape.innerHTML = "-";

    } else {
        content.style.display = "none";
        icon_shape.innerHTML = "+";
    }
}

function delete_() {
    document.getElementById("container").remove();
}

function AddWidget() {
    var widget = document.createElement("BUTTON");
    var widgetText = document.createTextNode("Button 1");
    widget.appendChild(widgetText);
    document.getElementById("AddContentHere").appendChild(widget).attr('id', 'firstWidget');
}

function addJQwidget() {
    $('#AddContentHere').append(
        $('<button>Button 1</button>').attr('id', 'firstWidget'));
}

function moveLeft() {
    document.getElementById("firstWidget").style = "float : left";
}

function moveCenter() {
    if (document.getElementById("firstWidget").style.float == "left") {
        document.getElementById("firstWidget").style = "margin-left : 225px"
    }

    if (document.getElementById("firstWidget").style.float == "right") {
        document.getElementById("firstWidget").style = "margin-right : 225px"
    }
}

function moveRight() {
    document.getElementById("firstWidget").style = "float : right";
}