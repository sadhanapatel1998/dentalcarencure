$(document).ready(function () {

    $("#btn_submit").click(function () {

        var name = document.getElementById('txtname').value.trim();
        var email = document.getElementById('txtemail').value.trim();
        var phone = document.getElementById('txtphone').value.trim();
        var bdate = document.getElementById('date').value.trim();
        var msg = document.getElementById('msg').value.trim();

        if (name.length == 0) {
            alert('Please Enter Name !');
            document.getElementById('txtname').focus();
            return false;
        }
        var tmail = email.toString();
        tmail = tmail.replace(/^\s+|\s+$/g, '');
        if (tmail == "") {
            alert('Please Enter Email Id !');
            document.getElementById('txtemail').focus();
            return false;
        }
        var atpos = email.indexOf("@");
        var dotpos = email.lastIndexOf(".");
        if (atpos < 1 || dotpos < atpos + 2 || dotpos + 2 >= email.length) {
            alert("Not a valid e-mail address");
            document.getElementById('txtemail').select();
            document.getElementById('txtemail').focus();
            return false;
        }
        if (bdate.length == 0) {
            alert('Please Enter Appontment Date !');
            document.getElementById('date').focus();
            return false;
        }


        document.getElementById("btn_submit").disabled = true;
        document.getElementById("btn_submit").value = 'Please wait..';

        $.ajax({
            type: "POST",
            url: "WebService.asmx/BookAppontment",
            data: "{'name':'" + name + "', 'email':'" + email + "', 'phone':'" + phone + "', 'bdate':'" + bdate + "','msg':'" + msg + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: fnsuccesscallback,
            error: fnerrorcallback
        });

        function fnsuccesscallback(data) {
            window.location.href = 'thanks.html';
        }
        function fnerrorcallback(result) {
            var st = 'Mail could not be send !';
            alert(st + '\nPlease contact to Website Administrator. !');
        }
    });

    $("#btnContact").click(function () {

        var name = document.getElementById('txtname').value.trim();
        var email = document.getElementById('txtemail').value.trim();
        var phone = document.getElementById('txtphone').value.trim();
        var query = document.getElementById('txtquery').value.trim();

        if (name.length == 0) {
            alert('Please Enter Name !');
            document.getElementById('txtname').focus();
            return false;
        }
        var tmail = email.toString();
        tmail = tmail.replace(/^\s+|\s+$/g, '');
        if (tmail == "") {
            alert('Please Enter Email Id !');
            document.getElementById('txtemail').focus();
            return false;
        }
        var atpos = email.indexOf("@");
        var dotpos = email.lastIndexOf(".");
        if (atpos < 1 || dotpos < atpos + 2 || dotpos + 2 >= email.length) {
            alert("Not a valid e-mail address");
            document.getElementById('txtemail').select();
            document.getElementById('txtemail').focus();
            return false;
        }

        document.getElementById("btnContact").disabled = true;
        document.getElementById("btnContact").value = 'Please wait..';

        $.ajax({
            type: "POST",
            url: "WebService.asmx/SendQuickContact",
            data: "{'name':'" + name + "', 'email':'" + email + "', 'phone':'" + phone + "','query':'" + query + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: fnsuccesscallback,
            error: fnerrorcallback
        });

        function fnsuccesscallback(data) {
            window.location.href = 'thanks.html';
        }
        function fnerrorcallback(result) {
            var st = 'Mail could not be send !';
            alert(st + '\nPlease contact to Website Administrator. !');
        }
    });

    $("#btnSendQuery").click(function () {
        var name = document.getElementById('txtname').value.trim();
        var email = document.getElementById('txtemail').value.trim();
        var phone = document.getElementById('txtphone').value.trim();
        var apptDate = document.getElementById('txtdate').value.trim();
        var adrs = document.getElementById('txtadrs').value.trim();
        var query = document.getElementById('txtquery').value.trim();

        if (name.length == 0 || name == 'Name') {
            alert('Please Enter Name !');
            document.getElementById('txtname').focus();
            return false;
        }
        var tmail = email.toString();
        tmail = tmail.replace(/^\s+|\s+$/g, '');
        if (tmail == "") {
            alert('Please Enter Email Id !');
            document.getElementById('txtemail').focus();
            return false;
        }
        var atpos = email.indexOf("@");
        var dotpos = email.lastIndexOf(".");
        if (atpos < 1 || dotpos < atpos + 2 || dotpos + 2 >= email.length) {
            alert("Not a valid e-mail address");
            document.getElementById('txtemail').select();
            document.getElementById('txtemail').focus();
            return false;
        }
        var soFar1 = phone.toString();
        soFar1 = soFar1.replace(/^\s+|\s+$/g, '');
        if (soFar1 == "" || soFar1.length < 10 || soFar1 == 'Contact Number') {
            alert('Please Enter Valid Mobile No. of 10 digit !');
            document.getElementById('txtphone').focus();
            return false;
        }

        if (apptDate.length == 0) {
            alert('Please Enter Appointment Date !');
            document.getElementById('txtdate').focus();
            return false;
        }


        $.ajax({
            type: "POST",
            url: "../WebService.asmx/SendLandingPageQuery",
            data: "{'name':'" + name + "', 'email':'" + email + "', 'phone':'" + phone + "', 'apptDate':'" + apptDate + "','adrs':'" + adrs + "', 'query':'" + query + "'}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: fnsuccesscallback,
            error: fnerrorcallback
        });

        function fnsuccesscallback(data) {
            window.location.href = 'thanks.html';
        }
        function fnerrorcallback(result) {
            var st = 'Mail could not be send !';
            alert(st + '\nPlease contact to Website Administrator. !');
        }
    });
});
