const express = require('express');
const cors = require('cors')
const app = express();

app.use(cors());

const users = [
    {
        username: "123@123",
        password: "123"
    },
    {
        username: "1234@1234",
        password: "1234"
    }
]



app.use('/login', (req, res) => {
    console.log(req.body)
    // console.log(req.body)
    res.send({
        token: 'test123'
    });
});

app.listen(8080, () => console.log('API is running on http://localhost:8080/login'));