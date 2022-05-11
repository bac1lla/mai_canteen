import {addNewToCart, deleteFromCart, deleteFromCartAtAll} from "../Cart/cartFunctions";

export default function CartItem ({meal, cart, setCart}) {
    return (
        //fix key id
        <div key={meal.id + 1000} style={styles.cart_list_item}>
            <div style={styles.cart_list_item__header}>
                <div style={styles.cart_list_item__image}>
                    <img style={styles.cart_mealImg} src={meal.img} alt="Телефон"/>
                </div>
                <span style={styles.cart_list_item__name}>{meal.name}</span>
            </div>
            <div style={styles.cart_buttons}>
                <button style={styles.button_cart} onClick={() => deleteFromCart(meal, cart, setCart)}>-</button>
                <span style={styles.cart_list_item__count}>{meal.count}</span>
                <button style={styles.button_cart} onClick={() => addNewToCart(meal, cart, setCart)}>+</button>
            </div>
            <span>{meal.totalPrice}</span>
            <button style={styles.btn_close} onClick={() => deleteFromCartAtAll(meal, cart, setCart)}>&times;</button>
        </div>
    )
}

const styles = {
    cart_list_item: {
        display: "flex",
        alignItems: "center",
        width: "100%",
        padding: 5,
        justifyContent: "space-between",
        marginBottom: 10
    },
    cart_list_item__header: {
        display: "flex",
        alignItems: "center"
    },
    cart_list_item__image: {
        display: "flex",
        alignItems: "center",
        marginRight: 30,
    },
    cart_list_item__name: {
        width: 100,
        textAlign: "left",
        marginRight: 30,
        paddingLeft: "10px",
        // fontSize: "5vw",
    },
    button_cart: {
        cursor: "pointer"
    },
    cart_list_item__count: {
        padding: "0 5px"
    },
    cart_buttons: {
        width: 90,
    },
    cart_mealImg: {
        width: 50,
    },
}