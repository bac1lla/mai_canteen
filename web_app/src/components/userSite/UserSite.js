import HeaderUser from "./Header/Header";
import {BrowserRouter as Router, Route, Routes} from "react-router-dom";
import Home from "./Home/Home";
import Cafe from "./Cafe/Cafe";
import Cart from "./Cart/Cart";
import My from "./My/My";
import OrderHistory from "./OrderHistory/OrderHistory";

export default function UserSite({site, setSite, cart, setCart, setToken, token, user, setUser, cartHistory, setCartHistory}) {
    return (
            <div className="App">
                <HeaderUser token={token} setToken={setToken}/>
                <Routes>
                    <Route path="/" element={<Home site={site} setSite={setSite}/>}/>
                    <Route path="/cafe/:cafeId" element={<Cafe cart={cart} setCart={setCart}/>}/>
                    <Route path="/cart" element={<Cart cart={cart} setCart={setCart} cartHistory={cartHistory} setCartHistory={setCartHistory}/>}/>
                    <Route path="my" element={<My setToken={setToken} setSite={setSite} user={user} setUser={setUser}/>}/>
                    <Route path="orderhistory" element={<OrderHistory orderHistory={cartHistory}/>}/>
                </Routes>
            </div>
    )
}