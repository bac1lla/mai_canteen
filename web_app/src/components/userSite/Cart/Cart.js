import {Link} from 'react-router-dom';
import CartItem from "../CartItem/CartItem";
import CartEmpty from "../CartEmpty/CartEmpty";
import GoHomeBtn from "../GoHomeBtn/GoHomeBtn";


export default function Cart({cart, setCart}) {

    if (cart.length === 0 ) return <CartEmpty />

    return (
        <div>
            <GoHomeBtn />
            <div>
                {cart.map(meal => <CartItem meal={meal} setCart={setCart} cart={cart} />)}
            </div>
            <strong>Итоговая стоимость: {cart.reduce((acc, e) => acc + e.totalPrice, 0)}</strong>
            <button style={styles.btn_createOrder} onClick={() => setCart([])}>Заказать</button>
        </div>
    )
}
const styles = {
    cart_mealImg: {
        width: 50,
    },
    btn_close: {
        boxShadow: '0 8px 8px 0 rgb(0 0 0 / 4%), 0px -2px 8px 0px rgb(0 0 0 / 4%)',
        padding: "1px 6px",
        borderRadius: "50%",
        background: "rgba(255, 53, 53, 0.67)",
        border: "none",
    },
    btn_createOrder: {
        boxShadow: '0 8px 8px 0 rgb(0 0 0 / 4%), 0px -2px 8px 0px rgb(0 0 0 / 4%)',
        padding: "1px 6px",
        borderRadius: 18,
        border: "none",
    }
}
