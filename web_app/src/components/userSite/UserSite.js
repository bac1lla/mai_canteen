import HeaderUser from "./Header/Header";
import {BrowserRouter as Router, Route, Routes} from "react-router-dom";
import Home from "./Home/Home";
import Cafe from "./Cafe/Cafe";
import Cart from "./Cart/Cart";
import My from "./My/My";

export default function UserSite({site, setSite, cart, setCart, setToken, token, user, setUser}) {
    return (
            <div className="App">
                <HeaderUser token={token} setToken={setToken}/>
                <Routes>
                    <Route path="/" element={<Home site={site} setSite={setSite}/>}/>
                    <Route path="/cafe/:cafeId" element={<Cafe cart={cart} setCart={setCart}/>}/>
                    <Route path="/cart" element={<Cart cart={cart} setCart={setCart}/>}/>
                    <Route path="my" element={<My setToken={setToken} setSite={setSite} user={user} setUser={setUser}/>}/>
                </Routes>
            </div>
    )
}