import {Link} from "react-router-dom";

export default function GoHomeBtn() {

    return (
        <Link to={"/"} style={styles.goBack}>
            <img src={require("../../../img/left.png")} alt="go back" style={styles.icon}/>
            Все рестораны
        </Link>
    )
}

const styles = {
    goBack: {
        marginTop: 20,
        justifyContent: "left",
        alignItems: "center",
        textAlign: "left",
        display: "flex",
        textDecoration: "none",
        color: "#000",
        marginBottom: 20,
    },
    icon: {
        width: 24,
        height: 24,
        color: "#fff",
    },
}