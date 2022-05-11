const express = require('express');
const cors = require('cors');
const app = express();
const bodyParser = require('body-parser')

app.use(express.json())
app.use(express.urlencoded({ extended: true}));
app.use(cors());

const users = [
    {
        username: "123@123",
        password: "123",
        role: "admin"
    },
    {
        username: "1234@1234",
        password: "1234",
        role: "user"
    },
    {
        username: "12345@12345",
        password: "12345",
        role: "user"
    },
]

function checkUser({username, password}) {

    return users.find(e => e.username === username && e.password === password) ?? null
}

app.use('/login', (req, res) => {
    console.log(req.body)

    if (checkUser(req.body)) {
        res.send({
            token: 'test123',
            role: checkUser(req.body).role
        })
    } else {
        res.status(400);
        res.send('None shall pass');
    }
});

app.listen(8080, () => console.log('API is running on http://localhost:8080/login'));