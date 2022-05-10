import {Link, useParams} from "react-router-dom";
import {useEffect, useState} from "react";
import {dataCafes, dataMenu} from "../../api/getData";
import Modal from "../Modal/Modal";





function showMenu(dataMenu, setModal) {

    return dataMenu.map(meal => {
        return (
            <button key={meal.id} style={styles.mealCard} onClick={() => setModal({visible: true, data: meal})}>
                <div style={{...styles.mealImg, backgroundImage: `url(${meal.img})`}} />
                <div style={styles.mealInfo}>
                    <span style={styles.cafeTitle}>{meal.name}</span>
                    <strong style={styles.mealPrice}>{meal.price}&#8381;</strong>
                </div>
            </button>
        )
    })
}

export default function Cafe({cart, setCart}) {


    const {cafeId} = useParams()
    const [cafe, setCafe] = useState(dataCafes.find(e => cafeId === e.id))

    useEffect(() => {
        updateCafe()
    }, [cafeId])

    const updateCafe = () => {
        setCafe(dataCafes.find(e => cafeId === e.id))
    }



    const [isModal, setModal] = useState({visible: false, data: null})
    const onClose = () => setModal({visible: false, data: isModal.data})



    return (
        <div style={styles.container}>
            <Link to={"/"} style={styles.goBack}>
                <img src={require("./../../img/left.png")} alt="go back" style={styles.icon}/>
                Все рестораны
            </Link>
            <div style={styles.cafeDescription}>
                <h2 style={styles.pageTitle}>{cafe.name}</h2>
                <div style={{...styles.cafeImg, backgroundImage: `url(${cafe.img})`}}/>
            </div>
            <div style={styles.menuList}>
                {showMenu(dataMenu[cafeId], setModal)}
            </div>
            <Modal
                visible={isModal.visible}
                data={isModal.data}
                onClose={onClose}
                cart={cart}
                setCart={setCart}
            />
        </div>
    )
}

const styles = {
    container: {
        // margin: "0 50px 0 50px",
        // background: '#fff',
        // boxSizing: 'border-box',
    },
    goBack: {
        marginTop: 20,
        textAlign: "left",
        display: "flex",
        textDecoration: "none",
        color: "#000"
        // border: "1px solid black"
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
        border: "none",
        background: "#fff",
        margin: 10,
        boxSizing: 'border-box',
        borderRadius: 16,
        boxShadow: '0 8px 8px 0 rgb(0 0 0 / 4%), 0px -2px 8px 0px rgb(0 0 0 / 4%)',
        width: 360,
    },
    cafeDescription: {
        display: "flex",
        justifyContent: "space-between",
        alignItems: "center",
    },
    cafeImg: {
        height: 70,
        width: 70,
        backgroundPosition: 'center',
        backgroundSize: 'cover',
        backgroundRepeat: 'no-repeat',
        borderRadius: 16,
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
        justifyContent: "space-between",
        margin: 20,
    },
    mealPrice: {
        // fontWeight: 10000,
        fontSize: 22,
        fontWeight: 500,
    },
    icon: {
        width: 24,
        height: 24,
        color: "#fff",
    },
}