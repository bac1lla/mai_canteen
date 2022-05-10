import {Link} from "react-router-dom";

import {dataCafes} from "../../api/getData";

function cafeCards(dataCafes) {
    return dataCafes.map(cafe => {
        return (
            <Link to={`/cafe/${cafe.id}`} key={cafe.id} style={styles.cafeCard}>
                <div style={{...styles.cardImg, backgroundImage: `url(${cafe.img})`}} />
                <div style={styles.cardInfo}>
                    <span style={styles.cafeTitle}>{cafe.name}</span>
                </div>
            </Link>
        )
    })
}

export default function Home() {

    return (
        <div style={styles.container}>
            <h2 style={styles.pageTitle}>Рестораны</h2>
            <div style={styles.cafesList}>
                {cafeCards(dataCafes)}
            </div>
        </div>
    )
}

const styles = {
    container: {
        // margin: "0 50px 0 50px",
        // background: '#fff',
        // boxSizing: 'border-box',
    },
    header: {
        marginTop: 0,
        height: 72,
        justifyContent: 'space-between',
        alignItems: 'center',
        padding: '12px 16px',
    },
    pageTitle: {
        fontSize: 46,
        textAlign: "left",
    },
    cafeTitle: {
        fontSize: 22,
        fontWeight: 500,
        textAlign: "left",
    },
    cafesList: {
        display: 'flex',
        flexWrap: 'wrap',
        alignItems: 'center',
        justifyContent: 'center',
    },
    cafeCard: {
        margin: 20,
        boxSizing: 'border-box',
        borderRadius: 16,
        boxShadow: '0 8px 8px 0 rgb(0 0 0 / 4%), 0px -2px 8px 0px rgb(0 0 0 / 4%)',
        width: 360,
        textDecoration: "none",
        color: "#000",

    },
    cardImg: {
        height: 164,
        // width: '100%',
        backgroundPosition: 'center',
        backgroundSize: 'cover',
        backgroundRepeat: 'no-repeat',
        borderRadius: "16px 16px 0px 0px",

    },
    cardInfo: {
        display: "flex",
        alignContent: "left",
        margin: 20,
    }
}
