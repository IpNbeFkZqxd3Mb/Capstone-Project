const express = require('express')
const bodyParser = require('body-parser')
const app = express()
const port = process.env.PORT || 8787;
require('./app/routes')(app,{})

app.listen(port,() => {
    console.log('We are live on '+ port)
})