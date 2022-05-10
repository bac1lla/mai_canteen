
export default function MenuItem ({meal, setModal}) {
    return (
        <button key={meal.id} style={styles.mealCard} onClick={() => setModal({visible: true, data: meal})}>
            <div style={{...styles.mealImg, backgroundImage: `url(${meal.img})`}}/>
            <div style={styles.mealInfo}>
                <span style={styles.cafeTitle}>{meal.name}</span>
                <strong style={styles.mealPrice}>{meal.price}&#8381;</strong>
            </div>
        </button>
    )
}

const styles = {
    mealCard: {
        border: "none",
        background: "#fff",
        margin: 10,
        boxSizing: 'border-box',
        borderRadius: 16,
        boxShadow: '0 8px 8px 0 rgb(0 0 0 / 4%), 0px -2px 8px 0px rgb(0 0 0 / 4%)',
        width: 360,
    },
    mealImg: {
        height: 164,
        backgroundPosition: 'center',
        backgroundSize: 'contain',
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
        fontSize: 22,
        fontWeight: 500,
    },
    cafeTitle: {
        fontSize: 22,
        fontWeight: 500,
        textAlign: "left",
    },
}