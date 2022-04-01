const { Schema, model, Types} = require('mongoose')

const schema = new Schema({
    text: {type: String},
    completed: false
})

module.exports = model('Todo', schema)