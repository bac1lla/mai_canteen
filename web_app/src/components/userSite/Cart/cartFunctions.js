function checkCart(product, cart, setCart) {
    if (cart.length === 0) return true

    if (cart[0].idCafe === product.idCafe) {
        return true
    } else {
        if (window.confirm("В корзине содержатся позиции из другого ресторана, для продолжения необходимо очистить корзину. Очистить корзину?")) {
            setCart([])
        } else return false
    }
}

function addNewToCart(product, cart, setCart) {
    if (!checkCart(product, cart, setCart)) {
        return false
    }
    if (cart.find(e => e.id === product.id)) {
        setCart(cart.map(e => {
            if (e.id === product.id) {
                e.count += 1
                e.totalPrice += e.price
            }
            return e
        }))
    } else {
        product.count = 1
        product.totalPrice = product.price
        setCart([...cart, product])
    }
}

function deleteFromCart(product, cart, setCart) {
    if (cart.find(e => e.id === product.id)) {
        setCart(cart.map(e => {
            if (e.id === product.id) {
                if (e.count >= 1) {
                    e.count -= 1
                    e.totalPrice -= e.price
                }
            }
            return e
        }).filter(e => e.count > 0))
    }
}

function deleteFromCartAtAll(product, cart, setCart) {
    setCart(cart.filter(e => e.id !== product.id))
}



export {deleteFromCart, addNewToCart, deleteFromCartAtAll}