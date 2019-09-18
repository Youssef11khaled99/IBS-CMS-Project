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

var buttonCounter = 1;
var currentID = 'widget-' + buttonCounter;
console.log(currentID);
function addJQwidget() {
    $('#AddContentHere').append(
        $('<button>Button ' + buttonCounter + '</button>').attr('id', 'widget-' + buttonCounter));
    buttonCounter++;
}

function moveLeft() {
    document.getElementById(currentID).style = "margin-right: auto;";
}

function moveCenter() {
    if (document.getElementById(currentID).style.marginRight == "auto" || document.getElementById(currentID).style.marginRight == "") {
        document.getElementById(currentID).style = "margin-left : 43%";
    } else {
        document.getElementById(currentID).style = "margin-right : 43%";
    }
}

function moveRight() {
    document.getElementById(currentID).style = " margin-left: auto;";
}