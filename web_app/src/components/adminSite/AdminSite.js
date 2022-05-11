import HeaderAdmin from "./Header/Header";
import {BrowserRouter as Router, Route, Routes} from "react-router-dom";
import Menu from "./Pages/Menu";
import Orders from "./Pages/Orders";
import StopList from "./Pages/StopList";
import OrderHistory from "./Pages/OrderHistory";

export default function AdminSite({site, setSite}) {
    return (

            <div className="App">
                <HeaderAdmin/>
                <Routes>
                    <Route path="/menu" element={<Menu />}/>
                    <Route path="/" element={<Orders site={site} setSite={setSite}/>}/>
                    <Route path="/stoplist" element={<StopList />}/>
                    <Route path="/orderhistory" element={<OrderHistory />}/>
                </Routes>
            </div>
    )
}