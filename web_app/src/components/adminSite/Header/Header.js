import { Container, Nav, Navbar, FormControl, Form, Button} from 'react-bootstrap'
import logo from './LOGO_MAI_CAFE.png'
import {Link} from "react-router-dom";


export default function HeaderAdmin () {
        return (
            <Navbar sticky="top" collapseOnSelect expand="lg" bg="dark" variant="dark" style={{borderRadius: "0 0 18px 18px"}}>
                <Container>

                    <Link to="/auth">
                        <img
                            src={logo}
                            height="90"
                            width="90"
                            className="d-inline-block align-top"
                            alt="Logo"
                            />
                        <div className="navbar-header">
                        </div>
                    </Link>
                    <Navbar.Toggle aria-controls="responsive-navbar-nav" />
                            
                    <Navbar.Collapse id="responsive-navbar-nav" >
                        <Nav className="me-auto">
                            <Link to="/" > ЗАКАЗЫ </Link>
                            <Link to="/menu" > ИЗМЕНИТЬ МЕНЮ </Link>
                            <Link to="/stoplist" > СТОП-ЛИСТ </Link>
                            <Link to="/orderhistory" > ИСТОРИЯ ЗАКАЗОВ </Link>
                        </Nav>
                        <Form className="d-flex">
                            <FormControl
                                type="text"
                                placeholder="НАЙТИ"
                                className="mx-2 d-inline"
                            />
                            <Button variant="outline-info">ПОИСК</Button>
                        </Form>
                    </Navbar.Collapse>
                </Container>
            </Navbar>

        )
}
