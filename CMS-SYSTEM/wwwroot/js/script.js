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