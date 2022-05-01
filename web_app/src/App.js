import {BrowserRouter as Router, Routes, Route} from "react-router-dom";
import './App.css';
import Home from './components/Home/Home'
import Header from './components/Header/Header'
import Cafe from './components/Cafe/Cafe'
import Meal from './components/Meal'
import Login from './components/Login'

function App() {
    return (
        <Router>
            <div className="App">
                <Header/>
                <Routes>
                    <Route path="/" element={<Home/>}/>
                    <Route path="/cafe/:cafeId" element={<Cafe/>}/>
                    <Route path="/meal" element={<Meal/>}/>
                    <Route path="/login" element={<Login/>}/>
                </Routes>
            </div>
        </Router>
    );
}

export default App;
