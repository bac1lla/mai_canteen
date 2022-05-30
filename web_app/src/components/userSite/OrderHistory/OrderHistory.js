import GoHomeBtn from "../GoHomeBtn/GoHomeBtn";


function showOrders(arr) {
    // if (arr === undefined) {
    //     console.log(arr)
    //     return
    // }
    return arr.map(e => {
        return (
            <div style={styles.pastOrder}>
                {e.map(item => {
                    return (
                        <div style={styles.meal}>
                            <span>{item.name}</span>
                            <span>Количество: {item.count}</span>
                            <strong>Цена: {item.price}</strong>
                        </div>
                    )
                })}
            </div>
        )
    })
}

export default function OrderHistory({orderHistory}) {



    return (
        <div>
            <GoHomeBtn/>
            {showOrders(orderHistory)}
        </div>
    )
}

const styles = {
    pastOrder: {
        border: "1px solid black"
    },
    meal: {
        display: "flex",
        justifyContent: "space-between",
        alignItems: "center",
        // gap: 10
    }
}