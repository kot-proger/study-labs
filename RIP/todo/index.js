const express = require('express')
const mongoose = require('mongoose')
const WebSocket = require('ws');

const app = express()
const server = require('http').createServer(app);
const wss = new WebSocket.Server({server:server});

app.use(express.json({extended: true}))
app.use('/api/todo', require('./routes/todo.route'))

async function start() {
    try {
        await mongoose.connect('mongodb+srv://kot:adept@mycluster.flb6q.mongodb.net/todoBase?retryWrites=true&w=majority')

        wss.on('connection', function connection(ws){
            console.log('New Client Connected');
            ws.send('Welcome to server');

            ws.on('message', function connection(ws){
                console.log('received: %s', message);
            

                wss.clients.forEach(function each(client){
                    if (client !== ws && client.readyState === WebSocket.OPEN){
                        client.send(message);
                    }
                });
            });
        });

        server.listen(5000, () => console.log(`Listening on port: 5000`))
        
    } catch (err) {
        console.error(err)
    }
}

start()