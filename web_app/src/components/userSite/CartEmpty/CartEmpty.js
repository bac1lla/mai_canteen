import GoHomeBtn from "../GoHomeBtn/GoHomeBtn";

export default function CartEmpty () {
    return (
        <div>
            <GoHomeBtn />
            <h4 style={styles.cart_empty_text}>Корзина пуста</h4>
            <img style={styles.imgEmpty} src={require("./../../../img/box.png")} alt=""/>
        </div>
    )
}

const styles = {
    cart_empty_text: {
        marginBottom: "10%",
    },
    imgEmpty: {
        width: 100,
    },
}