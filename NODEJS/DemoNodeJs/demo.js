const http = require('http');
const fs = require('fs');
const request = require('request');
const qs = require('querystring');
var filepath = __dirname + '/public/index copy.html';
const server = http.createServer(function (req, res) {
    if (req.url == '/') {
        res.writeHead(200, {'Content-Type': 'text/html'});
        res.write(fs.readFileSync(filepath,'utf-8'));
        res.end();
    };
    request.get('/process', function (err, res, body) {
        //if (err) console.error(err);
        
        console.log(qs.parse(body));
    });
    request.post('/process', function (err, res, body) {
        var req_data = qs.parse(body);
        console.log(req_data);
    });
});

server.listen(8081, function () {
    console.log('Http Server is listening on port 8081');
});