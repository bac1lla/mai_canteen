import {Link} from 'react-router-dom';
import {addNewToCart, deleteFromCart, deleteFromCartAtAll} from "./cartFunctions"

function showCart(cart, setCart) {
    if (cart.length > 0) {
        return cart.map(meal => {
            return (
                <div key={meal.id} style={styles.cart_list_item}>
                    <div style={styles.cart_list_item__header}>
                        <div style={styles.cart_list_item__image}>
                            <img style={styles.cart_mealImg}src={meal.img} alt="Телефон" />
                        </div>
                        <h4 style={styles.cart_list_item__name}>{meal.name}</h4>
                    </div>
                    <div style={styles.cart_buttons}>
                        <button style={styles.button_cart} onClick={() => deleteFromCart(meal, cart, setCart)}>-</button>
                        <span style={styles.cart_list_item__count}>{meal.count}</span>
                        <button style={styles.button_cart} onClick={() => addNewToCart(meal, cart, setCart)}>+</button>
                    </div>
                    <span>{meal.totalPrice}</span>
                    <button onClick={() => deleteFromCartAtAll(meal, cart, setCart)}>Удалить</button>
                </div>
            )
        })
    } else {
        return (
            <div>
                <strong>Ты ничего не выбрал, мудила</strong>
            </div>
        )
    }
}

export default function Cart({cart, setCart}) {

    return (
        <div style={styles.container}>
            <Link to={"/"} style={styles.goBack}>
                <img src={require("./../../img/left.png")} alt="go back" style={styles.icon}/>
                Все рестораны
            </Link>
            <div>
                {showCart(cart, setCart)}
            </div>
            <p>{cart.length !== 0 ? cart.reduce((acc, e) => acc + e.totalPrice, 0) : false}</p>
            <button onClick={() => setCart([])}>Заказать</button>
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
        justifyContent: "left",
        alignItems: "center",
        textAlign: "left",
        display: "flex",
        textDecoration: "none",
        color: "#000",
        marginBottom: 20,
        // border: "1px solid black"
    },
    icon: {
        width: 24,
        height: 24,
        color: "#fff",
    },
    cart_mealImg: {
        width: 50,
    },
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
        paddingLeft: "10px"
    },
    button_cart: {
        cursor: "pointer"
    },
    cart_list_item__count: {
        padding: "0 5px"
    },
    cart_buttons: {
        width: 90,
    }
}
