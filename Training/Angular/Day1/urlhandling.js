const { Console } = require("console");
var http = require ("http");
var url = require('url');

http.createServer(function(request,response){
    /*response.writeHead(200,{'Content-Type':'text/html'});
    response.write(request.url);
    var query = url.parse(request.url,true).query;
    var query1 = query.UN + query.PWD;
    response.write(query1);*/

    var address = 'http://localhost:9399/default.htm?year=2023&month=may';
    var query1 = url.parse(address,true);
    console.log(query1.host);
    console.log(query1.hostname);
    console.log(query1.search);

    var qury2 = query1.query;
    console.log(qury2);
    console.log(qury2.month);
    response.end();

}).listen(9399)