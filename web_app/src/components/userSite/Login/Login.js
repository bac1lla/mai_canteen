import {useState} from 'react';
import PropTypes from 'prop-types';
import LoginForm from "../LoginForm/LoginForm";
import {useNavigate} from "react-router-dom";


async function userPartialGet(id) {
    let response = await fetch(`http://26.215.218.90:7210/Api/V1/User/PartialGet/${id}`, {
        method: 'GET',
        headers: {
            'accept': '*/*',
            'Content-Type': 'application/json'
        },
    })

    if (response.ok) {
        let json = await response.json();
        console.log("OK")
        console.log(json.tokenValue)
        return json.tokenValue
    } else {
        alert("Ошибка HTTP: " + response.status);
        return ""
    }

}

async function userCreate(login, password, salt, name) {
    let response = await fetch('http://26.215.218.90:7210/Api/V1/User/Create', {
        // mode: 'no-cors',
        method: 'POST',
        headers: {
            'accept': '*/*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            "login": login,
            "password": password,
            "salt": salt,
            "name": name
        })
    })

    if (response.ok) {
        let json = await response.json();
        return await userPartialGet(json.id)
    } else {
        alert("Ошибка HTTP: " + response.status);
        return ""
    }
}

export default function Login({setToken, setSite, user, setUser}) {

    const [username, setUserName] = useState();
    const [password, setPassword] = useState();

    let navigate = useNavigate()

    const handleSubmit = async e => {
        e.preventDefault();
        // let token = await userCreate(username, password, "salt", username)
        let token = "123" // then server is off
        setToken(token)
        let tempPassword = password
        setSite(tempPassword === "1")
        setUser({
            login: username,
            name: username,
            hash: password,
        })
        navigate("/")
    }

    return (
        <div style={styles.login_wrapper}>
            <LoginForm handleSubmit={handleSubmit} setUserName={setUserName} setPassword={setPassword}/>
        </div>
    )
}

Login.propTypes = {
    setToken: PropTypes.func.isRequired
}

const styles = {
    login_wrapper: {
        height: "100vh",
        margin: "auto",
        background: 'rgb(0 0 0 / 4%)',
        marginTop: 0,
        padding: "10% 0",
    },

}