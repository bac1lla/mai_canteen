import {Button, Form} from "react-bootstrap";

export default function LoginForm ({handleSubmit}) {

    return (
        <Form onSubmit={handleSubmit} style={styles.form}>
            <Form.Group className="mb-3" controlId="formBasicEmail">
                <Form.Label>Email address</Form.Label>
                <Form.Control type="email" placeholder="Enter email" />
                {/*<Form.Text className="text-muted">*/}
                {/*    We'll never share your email with anyone else.*/}
                {/*</Form.Text>*/}
            </Form.Group>

            <Form.Group className="mb-3" controlId="formBasicPassword">
                <Form.Label>Password</Form.Label>
                <Form.Control type="password" placeholder="Password" />
            </Form.Group>
            <Form.Group className="mb-3" controlId="formBasicCheckbox">
                <Form.Check type="checkbox" label="Check me out" />
            </Form.Group>
            <Button variant="primary" type="submit">
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