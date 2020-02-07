function show() {
    var fname = document.getElementById("textbox1").value;
    var lname = document.getElementById("textbox2").value;
    var age = document.getElementById("age").value;
    var address = document.getElementById("address").value;
    var gender = document.getElementById("gender").value;
    confirm("you have entered:" + "\n Name:" + fname + " " + lname + "\n age:" + age + "\n address:" + address + "\n gender:" + gender);
}
function changecolor(val) {
    if ((val.value == "") || (val.value == null)) {
        val.style.background = "red";
    }
    else { val.style.background = "green"; }
}