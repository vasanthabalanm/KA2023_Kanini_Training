var http = require ("http");
var today = require('./day1')
http.createServer(
    function(req,res){
        res.writeHead(206,{'Content-Type':'text/html'});
        //var n1=10,n2=30;
        //res.write("ans:"+(n1+n2));
        res.write(today.checkdate());
        res.end('<html><body><h1>Nadhaths</h1></body></html>');
    }
).listen(8080)