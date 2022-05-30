import { Container, Nav,  Navbar, FormControl, Form, Button} from 'react-bootstrap'
import logo from './LOGO_MAI_CAFE.png'
import {Link} from "react-router-dom";


export default function HeaderAdmin () {
        return (
            <Navbar sticky="top" collapseOnSelect expand="lg" bg="dark" variant="dark" style={{borderRadius: "0 0 18px 18px"}}>
                <Container>

                    <Nav.Link><Link to="/auth">
                        <img
                            src={logo}
                            height="90"
                            width="90"
                            className="d-inline-block align-top"
                            alt="Logo"
                            />
                        <div className="navbar-header">
                        </div>
                    </Link></Nav.Link>
                    <Navbar.Toggle aria-controls="responsive-navbar-nav" />
                            
                    <Navbar.Collapse id="responsive-navbar-nav" >
                        <Nav className="me-auto">
                            <Nav.Link ><Link style={styles.navItem} to="/" > ЗАКАЗЫ </Link></Nav.Link>
                            <Nav.Link ><Link style={styles.navItem} to="/menu" > ИЗМЕНИТЬ МЕНЮ </Link></Nav.Link>
                            <Nav.Link ><Link style={styles.navItem} to="/stoplist" > СТОП-ЛИСТ </Link></Nav.Link>
                            <Nav.Link ><Link style={styles.navItem} to="/orderhistory" > ИСТОРИЯ ЗАКАЗОВ </Link></Nav.Link>
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

const styles = {
    navItem: {
        textDecoration: "none",
        color: "white",
    }
}