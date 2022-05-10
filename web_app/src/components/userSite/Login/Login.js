import {useState} from 'react';
import PropTypes from 'prop-types';
import LoginForm from "../LoginForm/LoginForm";

async function loginUser(credentials) {
    return fetch('http://localhost:8080/login', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(credentials)
    })
        .then(data => data.json())
}

export default function Login({ setToken }) {

    const [username, setUserName] = useState();
    const [password, setPassword] = useState();

    const handleSubmit = async e => {
        e.preventDefault();
        const token = await loginUser({
            username,
            password
        });
        setToken(token);
    }

    return(
        <div style={styles.login_wrapper}>
            <LoginForm handleSubmit={handleSubmit} />
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
        // marginTop: 50,
        // Width: "70%",
        // margin: "auto",
        // flexDirection: "column",
        // display: "flex",
        // alignItems: "center",
        // justifyContent: "center"
        background: 'rgb(0 0 0 / 4%)',
        marginTop: 0,
        padding: "10% 0",
    },

}