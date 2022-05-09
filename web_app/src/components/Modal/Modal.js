import {useEffect, useState} from "react";


export default function Modal({
                                  visible = false,
                                  data = {},
                                  onClose,
                              }) {

    const [cart, setCart] = useState([])

    const onKeydown = ({key}) => {
        switch (key) {
            case 'Escape':
                onClose()
                break
            default:
                break
        }
    }

    useEffect(() => {
        document.addEventListener('keydown', onKeydown)
        return () => document.removeEventListener('keydown', onKeydown)
    })


    function addNewToCart(product, cart, setCart) {
        if (cart.find(e => e.id === product.id)) {
            setCart(cart.map(e => {
                if (e.id === product.id) {
                    e.count += 1
                }
                return e
            }))
        } else {
            product.count = 1
            setCart([...cart, product])
        }
        console.log(cart)
    }

    function deleteFromCart(product, cart, setCart) {
        if (cart.find(e => e.id === product.id)) {
            setCart(cart.map(e => {
                if (e.id === product.id) {
                    if (e.count > 1) {
                        e.count -=1
                    } else {
                        return false
                    }
                }
                return true
            }))
        }
        console.log(cart)

    }


    if (!visible) return null

    data.count = 0
    return (

        <div style={styles.modal} onClick={onClose}>
            <div style={styles.modal_dialog} onClick={e => e.stopPropagation()}>
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
                                <span style={styles.modal_count}></span>
                                <strong style={styles.modal_price}>{data.price} P</strong>
                            </div>
                            <div style={styles.modal_btns}>
                                <button style={styles.btn_deleteFromCart} onClick={() => deleteFromCart(data, cart, setCart)}> &#8722; </button>
                                <button style={styles.btn_addToCart} onClick={() => addNewToCart(data, cart, setCart)}> &#43; </button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}

const styles = {
    modal: {
        position: "fixed",
        top: "0",
        bottom: "0",
        left: "0",
        right: "0",
        width: "100%",
        zIndex: "9999",
        display: "flex",
        alignItems: "center",
        justifyContent: "center",
        backgroundColor: "rgba(0, 0, 0, 0.25)",
    },
    modal_dialog: {
        width: "100%",
        maxWidth: "550px",
        background: "white",
        position: "relative",
        margin: "0 10px",
        padding: "10px 20px 0px 20px",
        maxHeight: "calc(100vh - 40px)",
        textAlign: "left",
        display: "flex",
        flexDirection: "column",
        overflow: "hidden",
        boxShadow: "0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19)",
        borderRadius: 16,
    },
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
        height: "max-content",
        width: "50%",
        // marginBottom: 10,
        marginRight: 10,
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
    }
}