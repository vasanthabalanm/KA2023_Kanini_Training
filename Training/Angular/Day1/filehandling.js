var http = require('http');
var file = require('fs');
http.createServer(function(request,response){
    //open in write mode
    /*file.open('sample.txt','w',function(err,file){
        if(err)throw err;
        console.log('saved');
        response.write('saved is done');
    });
    //write file
    file.writeFile('sample.txt','welcometo server side insert in writtng in a file',function(err){
        if(err)throw err;
        console.log('inserted');
        response.write('inserted is done');
    });
    //open the file
    file.readFile('sample.txt',function(err,data){
        if(err)throw err;
        response.writeHead(200,{'Content-Type':'text/html'});
        response.write(data);
        console.log(data);
        return response.end();
    });

    //file append
    file.appendFile('sample.txt','welcometo to node world to see',function(err,file){
        if(err)throw err;
        console.log('append is performed');
        //response.write('inserted is done');
    });
    //file rename
    file.rename('sample.txt','resample.txt',function(err){
        if(err)throw err;
        console.log('renamed is performed');
        //response.write('inserted is done');
    });
    //delete file
    file.unlink('sample.txt',function(err){
        if(err)throw err;
        console.log('Deleted is performed');
        //response.write('inserted is done');
    });*/
    //read html file
    file.readFile('index.html',function(err,data){
        if(err)throw err;
        //response.writeHead(200,{'Content-Type':'text/html'});
        response.write(data);
        //console.log(data);
        return response.end();
    });



}).listen(8088)
