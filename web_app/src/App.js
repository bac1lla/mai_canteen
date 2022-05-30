import './App.css';
import {useState} from "react";
import useToken from "./components/useToken/useToken";
import Login from './components/userSite/Login/Login'
import UserSite from "./components/userSite/UserSite";
import AdminSite from "./components/adminSite/AdminSite";
import 'bootstrap/dist/css/bootstrap.min.css';
import {BrowserRouter as Router} from "react-router-dom";

function checkToken(token, setToken) {

    if (!token) {
        return <Login setToken={setToken}/>
    }

}

function App() {


    const [cart, setCart] = useState([])
    const [site, setSite] = useState(false)
    const [user, setUser] = useState({})
    const [cartHistory, setCartHistory] = useState([])

    const {token, setToken} = useToken();

    if (!token) {
        return (
            <Router>
                <Login setToken={setToken} setSite={setSite} user={user} setUser={setUser}/>
            </Router>
        )
    }

    return (
        <Router>
            {!site ? <UserSite site={site} setSite={setSite} cart={cart} setCart={setCart} setToken={setToken}
                               token={token} user={user} setUser={setUser} cartHistory={cartHistory} setCartHistory={setCartHistory}/> : <AdminSite site={site} setSite={setSite}/>}
        </Router>
    )
}

export default App;