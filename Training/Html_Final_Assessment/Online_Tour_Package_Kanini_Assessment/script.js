
function selectedSubjectName() {

    var subjectIdNode = document.getElementById('opt');
    var values1 = subjectIdNode.options[subjectIdNode.selectedIndex].value;
    const num = parseInt(values1);
    //console.log( values);
}

document.getElementById("submit").addEventListener('click', reserveTourPackage)

function reserveTourPackage() {
        let name_pattern=/[a-zA-Z\s]/g;
        let number_pattern=/^[9,8,7]+[0-9]{10}/g;
        let aadhar_pattern=/[1-9]{12}/g;
        let card_pattern=/^[3,4,5]+[0-9]{16}/g;
        let cvv_pattern=/\d{3}/g;
        var check=0;
        var input_name=document.getElementById("name").value;
        var input_number=document.getElementById("mobileNumber").value;
        var input_aadhar=document.getElementById("aadharNumber").value;
        var input_cardno=document.getElementById("cardNumber").value;
        var input_cvv=document.getElementById("cvvNumber").value;

        // if(input_name.match(name_pattern)==null)
        // {
        //     document.getElementById("order").innerHTML='enter a valid name';
        //     check++;
        // }
        // else if(input_number.match(number_pattern)==null){
        //     document.getElementById("order").innerHTML='enter a valid Phone number';
        //     check++;
        // }
        // else if(input_aadhar.match(aadhar_pattern)==null){
        //     document.getElementById("order").innerHTML='enter a valid email Id';
        //     check++;
        // }
        // else if(input_cardno.match(card_pattern)==null){
        //     document.getElementById("order").innerHTML='enter a valid Phone number';
        //     check++;
        // }
        // else if(input_cvv.match(cvv_pattern)==null){
        //     document.getElementById("order").innerHTML='enter a valid email Id';
        //     check++;
        // }
        // else{
            
        // }

        var subjectIdNode = document.getElementById('opt');
        const dt = document.getElementById('doc').value;


        var values1 = subjectIdNode.options[subjectIdNode.selectedIndex].value;


        const num = parseInt(values1);
        var result = document.getElementById("result");
        var slt = document.getElementById('opt').value;
        var values = subjectIdNode.options[subjectIdNode.selectedIndex].text;
        // var sl = parseInt(slt);
        var adlt = document.getElementById('adl').value;
        var ad = parseInt(adlt);
        var chld = document.getElementById('chl').value;
        var cd = parseInt(chld);
        var tot = ad + cd;
         
        // console.log(tot);

        var i;
        if (values == '1 Night & 2 Days') {
            var pr = 2;
            var amt = 11000;
            if (tot > pr) {
                tot -= pr;
                for (i = 0; i < tot; i++) {
                    amt += 3000;
                }
                result.innerHTML = 'Total Amount Rs.' + amt + ' is paid successfully. Your Booking is Confirmed!<br>Your Check-in Date is' + dt;
            } else {
                if(tot==2){
                    result.innerHTML = 'Total Amount Rs.' + amt + ' is paid successfully. Your Booking is Confirmed!<br>Your Check-in Date is' + dt;
                }else{
                    result.innerHTML = 'Please enter valid details';
                }
                
            }



        }
        if (values == '2 Nights & 3 Days') {
            var pr = 3;
            var amt = 20000;
            if (tot > pr) {
                tot -= pr;
                for (i = 0; i < tot; i++) {
                    amt += 3500;
                }
                result.innerHTML = 'Total Amount Rs.' + amt + ' is paid successfully. Your Booking is Confirmed!<br>Your Check-in Date is' + dt;
            } else {
                if(tot==3){
                    result.innerHTML = 'Total Amount Rs.' + amt + ' is paid successfully. Your Booking is Confirmed!<br>Your Check-in Date is' + dt;
                }else{
                    result.innerHTML = 'Please enter valid details';
                }
            }

        }
        if (values == '3 Nights & 4 Days') {
            var pr = 3;
            var amt = 29000;
            if (tot > pr) {
                tot -= pr;
                for (i = 0; i < tot; i++) {
                    amt += 3500;
                }
                result.innerHTML = 'Total Amount Rs.' + amt + ' is paid successfully. Your Booking is Confirmed!<br>Your Check-in Date is' + dt;
            } else {
                if(tot==3){
                    result.innerHTML = 'Total Amount Rs.' + amt + ' is paid successfully. Your Booking is Confirmed!<br>Your Check-in Date is' + dt;
                }else{
                    result.innerHTML = 'Please enter valid details';
                }
            }

        }
        if (values == '4 Nights & 5 Days') {
            var pr = 4;
            var amt = 37000;
            if (tot > pr) {
                tot -= pr;
                for (i = 0; i < tot; i++) {
                    amt += 4000;
                }
                result.innerHTML = 'Total Amount Rs.' + amt + ' is paid successfully. Your Booking is Confirmed!<br>Your Check-in Date is' + dt;
            } else {
                if(tot==4){
                    result.innerHTML = 'Total Amount Rs.' + amt + ' is paid successfully. Your Booking is Confirmed!<br>Your Check-in Date is' + dt;
                }else{
                    result.innerHTML = 'Please enter valid details';
                }
            }

        }
        if (values == '5 Nights & 6 Days') {
            var pr = 4;
            var amt = 45000;
            if (tot > pr) {
                tot -= pr;
                for (i = 0; i < tot; i++) {
                    amt += 4000;
                }
                result.innerHTML = 'Total Amount Rs.' + amt + ' is paid successfully. Your Booking is Confirmed!<br>Your Check-in Date is' + dt;
            }
            else {
                if(tot==4){
                    result.innerHTML = 'Total Amount Rs.' + amt + ' is paid successfully. Your Booking is Confirmed!<br>Your Check-in Date is' + dt;
                }else{
                    result.innerHTML = 'Please enter valid details';
                }
            }

        }

}


