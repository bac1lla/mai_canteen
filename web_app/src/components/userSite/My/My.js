import GoHomeBtn from "../GoHomeBtn/GoHomeBtn";
import Modal from "../Modal/Modal";
import {useState} from "react";
import {useNavigate} from "react-router-dom";
import ChangeNameForm from "../ChangeModalForm/ChangeNameForm";
import ChangeEmailForm from "../ChangeModalForm/ChangeEmailForm";
import ChangePasswordForm from "../ChangeModalForm/ChangePasswordForm";


export default function My({setToken, setSite, user, setUser}) {

    const [isModalChangeUsername, setModalChangeUsername] = useState({visible: false, data: null})
    const [isModalChangeEmail, setModalChangeEmail] = useState({visible: false, data: null})
    const [isModalChangePassword, setModalChangePassword] = useState({visible: false, data: null})
    const onCloseUsername = () => setModalChangeUsername({visible: false, data: isModalChangeUsername.data})
    const onCloseEmail = () => setModalChangeEmail({visible: false, data: isModalChangeEmail.data})
    const onClosePassword = () => setModalChangePassword({visible: false, data: isModalChangePassword.data})

    const navigate = useNavigate()

    return (
        <div>
            <GoHomeBtn/>
            <div style={styles.user_info}>
                <div>
                    <img style={styles.user_img} src={require("./../../../img/user-circle.png")}/>
                </div>
                <p style={styles.title}>Имя профиля:</p>
                <div style={styles.box}>
                    <strong>{user.name}</strong>
                    <button style={styles.changeName}
                            onClick={() => setModalChangeUsername({visible: true, data: null})}>Изменить имя
                    </button>
                </div>
                <p style={styles.title}>Почта:</p>
                <div style={styles.box}>
                    <strong>{user.login}</strong>
                    <button style={styles.changeName}
                            onClick={() => setModalChangeEmail({visible: true, data: null})}>Изменить почту
                    </button>
                    {/*<button style={styles.changeName} onClick={() => setModalChangeEmail({visible: true, data: null})}>Изменить почту</button>*/}
                </div>

                <button style={styles.showHistory} onClick={() => navigate("/orderhistory")}>История заказов</button>
                <button style={styles.showHistory} onClick={() => setModalChangePassword({visible: true, data: null})}>Изменить пароль</button>


            </div>
            <button style={styles.exit_btn} onClick={() => setToken('')}>Выйти</button>
            <Modal
                visible={isModalChangeUsername.visible}
                onClose={onCloseUsername}
                component={<ChangeNameForm user={user} setUser={setUser} onClose={onCloseUsername}/>}
            />
            <Modal
                visible={isModalChangeEmail.visible}
                onClose={onCloseEmail}
                component={<ChangeEmailForm user={user} setUser={setUser} onClose={onCloseEmail}/>}
            />
            <Modal
                visible={isModalChangePassword.visible}
                onClose={onClosePassword}
                component={<ChangePasswordForm user={user} setUser={setUser} onClose={onClosePassword}/>}
            />
        </div>
    )
}

const styles = {
    user_info: {
        // display: "flex",
        // flexDirection: "column",
        // justifyContent: "center",
        // alignItems: "center"
    },
    user_img: {
        height: 50,
        width: 50,
        marginBottom: 15,
    },
    title: {
        fontSize: 24,
        textAlign: "left"
    },
    box: {
        display: "flex",
        justifyContent: "space-between",
        alignItems: "center",
        padding: 12,
        borderRadius: 18,
        border: "1px solid #dbdbdb",
        marginBottom: 20,
    },
    changeName: {
        border: "none",
        // background: "#dbdbdb",
        padding: 12,
        borderRadius: 18
    },
    showHistory: {
        display: "block",
        width: "100%",
        border: "none",
        // background: "#dbdbdb",
        padding: 18,
        borderRadius: 18,
        marginBottom: 20,

    },
    exit_btn: {
        padding: 18,
        borderRadius: 18,
        border: "none",
        // background: "rgba(250, 250, 250, 0.7)"
    }
}