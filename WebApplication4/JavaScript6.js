function validate() {
    if (document.regform.Name.value != "") {
        var pat = /([a-z]||[A-Z])-[0-9]{8,30}/;
        if (pat.test(document.regform.Name.value) == false) {
            alert("Please provide your name!");
            document.myform.Name.focus();
            return false;
        }
    }
    //if (document.myform.Name.value == "") {
    //    alert("Please provide your Email!");
    //    document.myform.Email.focus();
    //    return false;
    //}
    //if (document.myform.Zip.value == "" || isNaN(document.myform.Zip.value) ||
    //    (document.myform.Zip.value.length != 5)) {
    //    alert("Please provide a zip in the format#####");
    //    document.myform.Zip.focus();
    //    return false;
    //}
    if (document.myform.Country.value == "-1") {
        alert("Please provide your country!");
        return false;
    }
    return true;
}
}