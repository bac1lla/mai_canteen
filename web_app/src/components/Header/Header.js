export default function Header() {

    return (
        <div style={styles.header}>
            <input style={styles.search} placeholder='Что ищем?'/>
            <div style={styles.buttons}>
                <button style={styles.buttonSearch}>
                    <img src={require("./../../img/search.png")} alt="search" style={styles.icon}/>
                </button>
                <button style={styles.buttonSearch}>
                    <img src={require("./../../img/user.png")} alt="profile" style={styles.icon}/>
                </button>
            </div>
        </div>
    )
}


const styles = {
    header: {
        margin: "0 50px",
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
        borderRadius: '12px',
        height: 50,
        width: 50,
        boxSizing: 'border-box',
        border: 'none',
    },
    icon: {
        width: 24,
        height: 24,
    }


}