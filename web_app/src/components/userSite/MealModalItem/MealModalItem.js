import {addNewToCart, deleteFromCart} from "../Cart/cartFunctions";
import {Link} from "react-router-dom";

export default function MealModalItem ({data, onClose, cart, setCart}) {

    return (
        <>
            <div style={styles.modal_header}>
                <h3 style={styles.modal_title}>{data.name}</h3>
                <span style={styles.modal_close} onClick={onClose}> &times; </span>
            </div>
            <div style={styles.modal_body}>
                <div style={styles.modal_content}>
                    <img style={styles.modal_img} src={data.img} alt=""/>
                    <div style={styles.modal_column}>
                        <strong style={styles.modal_ingredients}>Состав: <br/>{data.ingredients}</strong>
                        <div style={styles.modal_mealInfo}>
                                <span
                                    style={styles.modal_count}>{cart.find(e => data.id === e.id && data.idCafe === e.idCafe) ? cart.find(e => data.id === e.id).count : 0}</span>
                            <strong style={styles.modal_price}>{data.price} &#8381;</strong>
                        </div>
                        <div style={styles.modal_btns}>
                            <button style={styles.btn_deleteFromCart}
                                    onClick={() => deleteFromCart(data, cart, setCart)}> &#8722; </button>
                            <button style={styles.btn_addToCart}
                                    onClick={() => addNewToCart(data, cart, setCart)}> &#43; </button>
                        </div>
                    </div>
                </div>
                <div style={styles.modal_toCart}>
                    <Link to={"/cart"} style={styles.modal_toCart}>
                        <img src={require("../../../img/left.png")} alt="go back" style={styles.icon}/>
                        Перейти в корзину
                    </Link>
                </div>
            </div>
        </>
    )
}

const styles = {
    modal_header: {
        display: "flex",
        borderBottom: "1px solid #dbdbdb",
        justifyContent: "space-between",
        alignItems: "center",

    },
    modal_footer: {
        borderTop: "1px solid #dbdbdb",
        justifyContent: "flex-end"
    },
    modal_close: {
        cursor: "pointer",
        padding: "1rem",
        margin: "-1rem -1rem -1rem auto",
        color: "#000",
        fontSize: 24,
    },
    modal_body: {
        overflow: "auto"
    },
    modal_title: {
        margin: "0"
    },
    modal_content: {
        display: "flex",
        // flexDirection: "column",
        justifyContent: "space-between",
        // alignItems: "center",
        padding: "1rem 0",
    },
    modal_img: {
        margin: "auto",
        height: "max-content",
        width: "50%",
        // marginBottom: 10,
        // marginRight: 10,
        borderRadius: 12,

    },
    modal_ingredients: {
        display: "block",
        marginBottom: 15,
    },
    modal_mealInfo: {
        display: "flex",
        width: "100%",
        alignItems: "center",
        justifyContent: "space-around",
        marginBottom: 15,

    },
    btn_deleteFromCart: {
        width: "40%",
        padding: "7px 7px",
        background: "#f84353",
        border: "none",
        borderRadius: "12px 0 0 12px",
        fontSize: 18,
    },
    btn_addToCart: {
        width: "40%",
        padding: "7px 7px",
        background: "#7cf66f",
        border: "none",
        borderRadius: "0 12px 12px 0",
        fontSize: 18,
    },
    modal_column: {
        display: "flex",
        flexDirection: "column",
        justifyContent: "space-around",
        alignItems: "center",
        borderLeft: "1px solid #dbdbdb",
        padding: 10,
    },
    modal_count: {
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        background: "#7cf66f",
        border: "none",
        borderRadius: "100%",
        width: 35,
        height: 35,
        // marginRight: 10
        fontSize: 18,

    },
    modal_btns: {
        display: "flex",
        minWidth: "100%",
        alignItems: "center",
        justifyContent: "center",
    },
    modal_price: {
        fontSize: 24,
    },
    modal_toCart: {
        marginBottom: 10,
        display: "flex",
        alignItems: "center",
        justifyContent: "left",
    },
    icon: {
        width: 24,
        height: 24,
        color: "#fff",
        transform: "rotate(180deg)",
    },
}