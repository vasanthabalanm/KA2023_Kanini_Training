var http = require('http');
var url = require('url');
var file = require('fs');
var events = require('events');


http.createServer(function (req, res) 
{
var nodemailer = require('nodemailer');

    var transporter = nodemailer.createTransport(
        {
            service: 'gmail',
            auth: {
                user: 'vasanthabalanm.kanini@gmail.com',
                pass: 'gkrm reir cmag xqaf'
            }
        }
    );

    var mailOptions =
    {

        from: 'vasanthabalanm.kanini@gmail.com',
        to: 'balanm8014@gmail.com',        //add more comma separated receipients
        subject: 'Sending Email using Node.js',
        text: 'That was easy!'                   // html: '<h1>Welcome</h1><p>That was easy!</p>'
    };

    transporter.sendMail(mailOptions, function (error, info)
    {
        if (error) {
            console.log(error);
        } else {
            console.log('Email sent: ' + info.response);
        }
    });
}).listen(8080);