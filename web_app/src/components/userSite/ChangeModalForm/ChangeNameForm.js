import {Button, Form} from "react-bootstrap";


export default function ChangeNameForm({user, setUser, onClose}) {


    const handleSubmit = async e => {
        e.preventDefault();
        setUser({login: user.login, name: e.target[0].value, hash: user.hash})
        onClose()
    }

    return (

        <Form onSubmit={handleSubmit} style={styles.form}>
            <p style={styles.title}>Прошлое значение:</p>
            <div className="mb-3" style={styles.box}>
                <strong>{user.name}</strong>
            </div>

            <Form.Group className="mb-3" controlId="formBasic">
                <p style={styles.title}>Новое значение:</p>
                <Form.Control type="text" placeholder="Новое значение" name="inputValue"
                              // onChange={(e) => setUser({...user, key: e.target.value})}
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
