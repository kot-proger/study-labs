const {Router} = require('express')
const router = Router()
const Todo = require('../models/Todo')

router.post('/add', async (req, res) => {
    try {
        const {text} = req.body

        const todo = await new Todo({
            text,
            completed: false
        })

        await todo.save()

        res.json(todo)
    } 
    catch (error) {
        console.log(error)
    }
})

router.get('/', async (req, res) => {
    try {
        const todo = await Todo.find()

        res.json(todo)
    } 
    catch (error) {
        console.log(error)
    }
})

router.delete('/delete/:id', async (req, res) => {
    try {
        const todo = await Todo.findOneAndDelete({_id: req.params.id})
        res.json(todo)
    } 
    catch (error) {
        console.log(error)
    }
})

router.put('/complete/:id', async (req, res) => {
    try {
        const todo = await Todo.findOne({_id: req.params.id})
        todo.completed = !todo.completed
        
        await todo.save()
        res.json(todo)
    } 
    catch (error) {
        console.log(error)
    }
})

module.exports = router


