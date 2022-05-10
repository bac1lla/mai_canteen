import {Link} from "react-router-dom";

export default function CafeCard({cafe}) {

    return (
        <Link to={`/cafe/${cafe.id}`} key={cafe.id} style={styles.cafeCard}>
            <div style={{...styles.cardImg, backgroundImage: `url(${cafe.img})`}} />
            <div style={styles.cardInfo}>
                <span style={styles.cafeTitle}>{cafe.name}</span>
            </div>
        </Link>
    )
}

const styles = {
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
        backgroundSize: 'contain',
        backgroundRepeat: 'no-repeat',
        borderRadius: "16px 16px 0px 0px",

    },
    cardInfo: {
        display: "flex",
        alignContent: "left",
        margin: 20,
    },
    cafeTitle: {
        fontSize: 22,
        fontWeight: 500,
        textAlign: "left",
    },
}