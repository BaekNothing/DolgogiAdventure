// 모듈을 추출합니다.

var Tesseract = require('tesseract.js')
var fs = require('fs');

var logs;
var imgLocation = 'public/images/image04.jpg';

//파일을 읽을때는, 이친구가 다 읽을때까지 기다리도록 Sync를 붙여야함.
fs.exists(imgLocation,
    function (exists) { //console.log(exists ? "it's there" : "no exists!");
        if(exists == true)
        {
            console.log("It's exist")
            data = fs.readFileSync(imgLocation);
            Tesseract.recognize(data, 'kor')
                     //.progress(function(message){console.log('progress is: ', message)})
                     .then(function(result){
                         logs = result.html;
                         console.log(result)
                         console.log("done")
                     })
        }
        else
        {
            console.log("no exists!");
        }
    });

// 서버를 생성합니다.
var express = require('express');
var app = express();

//서버를 준비할때 동작하는 부분
//나머지는 따로 지정해주지 않으면, 위에서 아래로 실행된다.
app.listen(52273, function () {
        console.log("Server Running at http://127.0.0.1:52273");
});

app.use(function (request, response) {
        response.writeHead(200, { 'Content-Type': 'text/html'});
        //이걸 해줘야 글자가 안깨짐
        response.write('<!doctype html> <head> <meta charset="UTF-8"> <link rel="stylesheet" href="stylesheets/style.css"> <script language="javascript"> console.log("done"); </script>  </head>');
        response.end(logs);
        console.log( "출력" );
        });
