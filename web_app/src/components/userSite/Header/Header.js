import {Link, useNavigate} from "react-router-dom";
import Modal from "../Modal/Modal";
import Login from "../Login/Login";
import {useState} from "react";


export default function HeaderUser({token, setToken}) {

    const [isModal, setModal] = useState({visible: false, data: null})
    const onClose = () => setModal({visible: false, data: isModal.data})
    const navigate = useNavigate()

    return (
        <div style={styles.header}>
            <input style={styles.search} placeholder='Что ищем?'/>
            <div style={styles.buttons}>
                <button onClick={() => !token ? setModal({visible: true, data: null}) : navigate("/my")} style={styles.button_header}>
                    <img src={require("../../../img/user.png")} alt="profile" style={styles.icon}/>
                </button>
                <Link to={"/cart"} style={styles.button_header}>
                    <img src={require("../../../img/cart.png")} alt="search" style={styles.icon}/>
                </Link>
            </div>
            <Modal visible={isModal.visible} onClose={onClose} component={<Login setToken={setToken} />}/>
        </div>
    )
}


const styles = {
    header: {
        // margin: "0 50px",
        marginTop: 5,
        display: 'flex',
        height: '72px',
        background: '#fff',
        justifyContent: 'space-between',
        alignItems: 'center',
        boxSizing: 'border-box',
    },
    search: {
        padding: '8px 16px',
        height: 50,
        borderRadius: '12px',
        backgroundColor: '#f6f6f6',
        cursor: 'pointer',
        boxSizing: 'border-box',
        border: 'none',
        outline: 'none',
        width: "50%"
    },
    buttons: {
        minWidth: 120,
        display: "flex",
        justifyContent: "space-around",
    },
    button_header: {
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        borderRadius: '12px',
        height: 50,
        width: 50,
        boxSizing: 'border-box',
        border: 'none',
        boxShadow: '0 8px 8px 0 rgb(0 0 0 / 4%), 0px -2px 8px 0px rgb(0 0 0 / 4%)',
        background: "#fff",
    },
    icon: {
        width: 24,
        height: 24,
    }


}