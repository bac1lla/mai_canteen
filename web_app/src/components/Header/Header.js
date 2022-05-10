import {Link} from "react-router-dom";

export default function Header() {

    return (
        <div style={styles.header}>
            <input style={styles.search} placeholder='Что ищем?'/>
            <div style={styles.buttons}>
                <Link to={"/my"} style={styles.buttonSearch}>
                    <img src={require("./../../img/user.png")} alt="profile" style={styles.icon}/>
                </Link>
                <Link to={"/cart"} style={styles.buttonSearch}>
                    <img src={require("./../../img/cart.png")} alt="search" style={styles.icon}/>
                </Link>
            </div>
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
    buttonSearch: {
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        borderRadius: '12px',
        height: 50,
        width: 50,
        boxSizing: 'border-box',
        border: 'none',
        boxShadow: '0 8px 8px 0 rgb(0 0 0 / 4%), 0px -2px 8px 0px rgb(0 0 0 / 4%)',
    },
    icon: {
        width: 24,
        height: 24,
    }


}