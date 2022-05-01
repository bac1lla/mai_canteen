import {Link} from "react-router-dom";

function cafeCards(data) {
    return data.map(cafe => {
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
                {cafeCards(data)}
            </div>
        </div>
    )
}

const styles = {
    container: {
        margin: "0 50px 0 50px",
        // display: 'flex',
        // position: 'relative',
        // width: '100%',
        marginTop: 0,
        height: 72,
        background: '#fff',
        justifyContent: 'space-between',
        alignItems: 'center',
        padding: '12px 16px',
        boxSizing: 'border-box',
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
        margin: 40,
    }
}

const data = [
    {
        id: 1,
        name: "Теремок",
        img: "https://eda.yandex/images/3784951/4b6e99209a20e7342d482f7356d0ec5d-1100x825.jpg",
    },
    {
        id: 2,
        name: "Vibe",
        img: "https://primemeat.ru/about/shayrma.jpg",
    },
    {
        id: 3,
        name: "Kebab",
        img: "https://sun9-28.userapi.com/s/v1/if1/Ojx42V1fOupAyzLEIwqqkDzn7ZPd7ZU2EgRGimTJgU8wR3GFTR8U10EKbQZ83G1qbS7W4nrL.jpg?size=1280x1278&quality=96&type=album",
    },
    {
        id: 4,
        name: "Космос",
        img: "https://i12.fotocdn.net/s115/0059f5dfafa4d52a/public_pin_l/2619612489.jpg",
    },
]