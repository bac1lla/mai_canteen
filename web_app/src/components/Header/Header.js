export default function Header() {

    return (
        <div style={styles.container}>
            <input style={styles.search} placeholder='Что ищем?'/>
            <button style={styles.buttonSearch}>
                <img src='./img/search.svg' alt="search" style={styles.searchIcon}/>
            </button>
        </div>
    )
}


const styles = {
    container: {
        margin: "0 50px 0 50px",
        display: 'flex',
        // position: 'relative',
        // width: '100%',
        height: '72px',
        background: '#fff',
        justifyContent: 'space-between',
        alignItems: 'center',
        padding: '12px 16px',
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
    buttonSearch: {
        background: 'green',
        borderRadius: '12px',
        height: 50,
        width: 50,
        boxSizing: 'border-box',
        border: 'none',
    },
    searchIcon: {
        width: "24",
        height: "24",
    }


}