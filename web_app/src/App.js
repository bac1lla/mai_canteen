import {BrowserRouter as Router, Routes, Route} from "react-router-dom";
import './App.css';
import Home from './components/Home/Home'
import Header from './components/Header/Header'
import Cafe from './components/Cafe/Cafe'
import Login from './components/Login/Login'
import Cart from "./components/Cart/Cart";
import My from "./components/My/My"
import {useState} from "react";
import useToken from "./components/useToken/useToken";



function App() {


    const [cart, setCart] = useState([])

    const { token, setToken } = useToken();

    if(!token) {
        return <Login setToken={setToken} />
    }

    return (
        <Router>
            <div className="App">
                <Header/>
                <Routes>
                    <Route path="/" element={<Home/>} />
                    <Route path="/cafe/:cafeId" element={<Cafe cart={cart} setCart={setCart}/>}/>
                    <Route path="/cart" element={<Cart cart={cart} setCart={setCart}/>}/>
                    <Route path="my" element={<My setToken={setToken}/>}/>
                </Routes>
            </div>
        </Router>
    );
}

export default App;