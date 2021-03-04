var express = require('express');
var app = express();
var bodyParser = require('body-parser');
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extends: false }));

app.use(express.static(__dirname + '/public'));
app.get('/process', function (req, res) {
    res.send("xin chao " + req.query.name2); 
});
app.post('/process', function (req, res) {
    res.send("xin chao: " + req.body.name);
});
app.listen(5000, function () {
    console.log("Server is listening...");
});