﻿function getAlert() {
    var m1 = isNaN("2");//check input is number
    var m2 = isNaN("Raman");
    var m3 = isNaN(4222);
    var d = eval("45+5");
    document.getElementById("ref").innerHTML += m1 + "<br>";
    document.getElementById("ref").innerHTML += m2 + "<br>";
    document.getElementById("ref").innerHTML += m3 + "<br>";
    document.getElementById("ref").innerHTML += d + "<br>";
    var m5 = parseInt("10", 2);//to convert str to num  using specific base
    var m6 = parseInt("11", 8);
    var m7 = parseInt("15", 10);
    var m8 = parseInt("123.345");
    document.getElementById("ref").innerHTML += m5 + "<br>";
    document.getElementById("ref").innerHTML += m6 + "<br>";
    document.getElementById("ref").innerHTML += m7 + "<br>";
    document.getElementById("ref").innerHTML += m8 + "<br>";
} getAlert();