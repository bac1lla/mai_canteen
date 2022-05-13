import {Link, useParams} from "react-router-dom";
import {useEffect, useState} from "react";
import {dataCafes, dataMenu} from "../../../api/getData";
import Modal from "../Modal/Modal";
import MenuItem from "../MenuItem/MenuItem";
import GoHomeBtn from "../GoHomeBtn/GoHomeBtn";
import MealModalItem from "../MealModalItem/MealModalItem";


export default function Cafe({cart, setCart}) {

    const {cafeId} = useParams()
    const [cafe, setCafe] = useState(dataCafes[cafeId])

    useEffect(() => {
        updateCafe()
    }, [cafeId])

    const updateCafe = () => {
        setCafe(dataCafes[cafeId])
    }


    const [isModalCafeCard, setModalCafeCard] = useState({visible: false, data: null})
    const onClose = () => setModalCafeCard({visible: false, data: isModalCafeCard.data})


    return (
        <div style={styles.container}>
            <GoHomeBtn />
            <div style={styles.cafeDescription}>
                <h2 style={styles.pageTitle}>{cafe.name}</h2>
                <div style={{...styles.cafeImg, backgroundImage: `url(${cafe.img})`}}/>
            </div>
            <div style={styles.menuList}>
                {dataMenu[cafeId].map(meal => <MenuItem meal={meal} setModal={setModalCafeCard}/>)}
            </div>
            <Modal
                visible={isModalCafeCard.visible}
                onClose={onClose}
                component={<MealModalItem data={isModalCafeCard.data}
                                          onClose={onClose}
                                          cart={cart}
                                          setCart={setCart}/>}
            />
        </div>
    )
}

const styles = {
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

    cafeDescription: {
        display: "flex",
        justifyContent: "space-between",
        alignItems: "center",
    },
    cafeImg: {
        height: 70,
        width: 70,
        backgroundPosition: 'center',
        backgroundSize: 'contain',
        backgroundRepeat: 'no-repeat',
        borderRadius: 16,
    },
}