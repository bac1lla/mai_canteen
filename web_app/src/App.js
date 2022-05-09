import {BrowserRouter as Router, Routes, Route} from "react-router-dom";
import './App.css';
import Home from './components/Home/Home'
import Header from './components/Header/Header'
import Cafe from './components/Cafe/Cafe'
import Login from './components/Login'
import Cart from "./components/Cart/Cart";


function App() {


    return (
        <Router>
            <div className="App">
                <Header/>
                <Routes>
                    <Route path="/" element={<Home/>}/>
                    <Route path="/cafe/:cafeId" element={<Cafe/>}/>
                    <Route path="/login" element={<Login/>}/>
                    <Route path="/cart" element={<Cart/>}/>
                </Routes>

            </div>
        </Router>
    );
}

export default App;