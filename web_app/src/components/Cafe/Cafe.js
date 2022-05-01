import {Link, useParams} from "react-router-dom";
import {useEffect, useState} from "react";
import {dataCafes, dataMenu} from "../../api/getData";
import {logDOM} from "@testing-library/react";


function showMenu(dataMenu) {
    return dataMenu.map(meal => {
        return (
            <div key={meal.id} style={styles.mealCard}>
                <div style={{...styles.mealImg, backgroundImage: `url(${meal.img})`}} />
                <div style={styles.mealInfo}>
                    <span style={styles.cafeTitle}>{meal.name}</span>
                </div>
            </div>
        )
    })
}

export default function Cafe() {


    const {cafeId} = useParams()
    const [cafe, setCafe] = useState(dataCafes.find(e => cafeId === e.id))

    useEffect(() => {
        updateCafe()
    }, [cafeId])

    const updateCafe = () => {
        setCafe(dataCafes.find(e => cafeId === e.id))
    }



    return (
        <div style={styles.container}>
            <Link to={"/"}>Все рестораны</Link>
            <div style={styles.cafeDescription}>
                <h2 style={styles.pageTitle}>{cafe.name}</h2>
                <div style={{...styles.cafeImg, backgroundImage: `url(${cafe.img})`}}/>
            </div>
            <div style={styles.menuList}>
                {showMenu(dataMenu[cafeId])}
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
    menuList: {
        display: 'flex',
        flexWrap: 'wrap',
        alignItems: 'center',
        justifyContent: 'center',
    },
    mealCard: {
        margin: 20,
        boxSizing: 'border-box',
        borderRadius: 16,
        boxShadow: '0 8px 8px 0 rgb(0 0 0 / 4%), 0px -2px 8px 0px rgb(0 0 0 / 4%)',
        width: 360,
    },
    cafeDescription: {
        display: "flex",
        justifyContent: "space-between",
    },
    cafeImg: {
        height: 164,
        width: 164,
        // width: '100%',
        backgroundPosition: 'center',
        backgroundSize: 'cover',
        backgroundRepeat: 'no-repeat',
        borderRadius: "16px 16px 0px 0px",
    },
    mealImg: {
        height: 164,
        // width: '100%',
        backgroundPosition: 'center',
        backgroundSize: 'cover',
        backgroundRepeat: 'no-repeat',
        borderRadius: "16px 16px 0px 0px",

    },
    mealInfo: {
        display: "flex",
        alignContent: "left",
        margin: 40,
    }
}