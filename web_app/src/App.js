import './App.css';
import {useState} from "react";
import useToken from "./components/useToken/useToken";
import Login from './components/userSite/Login/Login'
import UserSite from "./components/userSite/UserSite";
import AdminSite from "./components/adminSite/AdminSite";
import 'bootstrap/dist/css/bootstrap.min.css';
import {BrowserRouter as Router} from "react-router-dom";


function App() {


    const [cart, setCart] = useState([])
    const [site, setSite] = useState(true)

    const {token, setToken} = useToken();

    if (!token) {
        return <Login setToken={setToken}/>
    }

    return (
        <Router>
            {site ? <UserSite site={site} setSite={setSite} cart={cart} setCart={setCart} setToken={setToken} token={token} /> : <AdminSite site={site} setSite={setSite}/>}
        </Router>
    )
}

export default App;