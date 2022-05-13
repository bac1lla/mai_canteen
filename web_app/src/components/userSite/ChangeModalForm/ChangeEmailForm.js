import {Button, Form} from "react-bootstrap";


export default function ChangeEmailForm({user, setUser, onClose}) {

    const handleSubmit = async e => {
        e.preventDefault();
        setUser({name: user.name, login: e.target[0].value, hash: user.hash})
        onClose()
    }

    return (

        <Form onSubmit={handleSubmit} style={styles.form}>
            <p style={styles.title}>Прошлое значение почты:</p>
            <div className="mb-3" style={styles.box}>
                <strong>{user.login}</strong>
            </div>

            <Form.Group className="mb-3" controlId="formBasicEmail">
                <p style={styles.title}>Новое значение:</p>
                <Form.Control type="email" placeholder="Новое значение" name="inputValue"
                    onChange={() => {}}
                />
            </Form.Group>
            <Button className="mb-3" variant="primary" type="submit">
                Submit
            </Button>
        </Form>
    )

}

const styles = {
    form: {
        display: "flex",
        justifyContent: "center",
        flexDirection: "column",
        height: "100%",
        boxShadow: '0 8px 8px 0 rgb(0 0 0 / 4%), 0px -2px 8px 0px rgb(0 0 0 / 4%)',
        margin: "auto",
        padding: "80px 50px",
        borderRadius: 18,
        maxWidth: 600,

    }
}
