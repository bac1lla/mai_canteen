import { Container, Nav, Navbar, FormControl, Form, Button} from 'react-bootstrap'
import logo from './LOGO_MAI_CAFE.png'


export default function HeaderAdmin () {
        return (
            <Navbar sticky="top" collapseOnSelect expand="lg" bg="dark" variant="dark" style={{borderRadius: "0 0 18px 18px"}}>
                <Container>

                    <Navbar.Brand href="/auth">
                        <img
                            src={logo}
                            height="90"
                            width="90"
                            className="d-inline-block align-top"
                            alt="Logo"
                            />
                        <div className="navbar-header">
                        </div>
                    </Navbar.Brand>
                    <Navbar.Toggle aria-controls="responsive-navbar-nav" />
                            
                    <Navbar.Collapse id="responsive-navbar-nav" >
                        <Nav className="me-auto">
                            <Nav.Link href="/" > ЗАКАЗЫ </Nav.Link>
                            <Nav.Link href="/menu" > ИЗМЕНИТЬ МЕНЮ </Nav.Link>
                            <Nav.Link href="/stoplist" > СТОП-ЛИСТ </Nav.Link>
                            <Nav.Link href="/orderhistory" > ИСТОРИЯ ЗАКАЗОВ </Nav.Link>
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
