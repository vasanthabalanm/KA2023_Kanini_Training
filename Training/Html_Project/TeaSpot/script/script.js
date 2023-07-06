function justclick(){
    // debugger;
    
    var name = document.getElementById('name').value;
    var mal = document.getElementById('email').value;
    var sb = document.getElementById('subject').value;
    var ms = document.getElementById('message').value;
    var pat = /[a-zA-Z0-9]+@[a-zA-Z0-9.]+/;

    if(name==''){
        document.getElementById('nm').innerHTML='please fill it';
    }
    else{
        document.getElementById('nm').innerHTML=' ';

    }
    if(mal == ''){
        document.getElementById('mail').innerHTML='please fill it';
    }else if(pat.test(mal)){
        document.getElementById('mail').innerHTML=' ';
    }
    else{
        document.getElementById('mail').innerHTML=' give correct input';
    }

    if(sb ==''){
        document.getElementById('sbj').innerHTML='please fill it';
    }else{
        document.getElementById('sbj').innerHTML=' ';
        if(ms==''){
            document.getElementById('msa').innerHTML='please fill it';

        }
        else{
            document.getElementById('msa').innerHTML='';
            document.getElementById('msg').innerHTML='RESPONSE SUBMITTED';
        }
    }

}
  