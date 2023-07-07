var http = require('http');
var url = require('url');
var file = require('fs');
var events = require('events');


http.createServer(function (req, res) 
{
    /*var read = file.createReadStream('./filehandling.js');

    read.on('open',function(){
        res.write('this file is open');
    });*/

    var addevent = function(){
        console.log('I score the first launch');
    }
    var emitter = new events.EventEmitter();
    emitter.on('results out',addevent);
    emitter.emit('results out');
}).listen(8088);
