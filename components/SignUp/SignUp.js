import {StyleSheet, Text, TextInput, TouchableOpacity, View} from "react-native";


export default function SignUp() {


    return (
        <View style={styles.container}>
            <Text style={styles.heading}>Регистрация</Text>

            <View style={styles.inputView}>


                <TextInput
                    style={styles.input}
                    // onChangeText={onChangeUsername}
                    // value={username}
                    placeholder={"Имя"}
                />
                <TextInput
                    style={styles.input}
                    // onChangeText={onChangePassword}
                    // value={password}
                    placeholder={"Фамилия"}
                />

            </View>

            <View style={styles.buttonsView}>
                <TouchableOpacity style={[styles.buttonLogIn, styles.button]} >
                    <Text style={[styles.text, styles.textWhite]}>Зарегистрироваться</Text>
                </TouchableOpacity>
            </View>

        </View>
    )
}

const styles = StyleSheet.create({
    container: {
        margin: 5,
        flex: 1,
        alignItems: "center",
        justifyContent: 'center',
    },
    input: {
        height: 40,
        width: 200,
        margin: 12,
        borderWidth: 1,
        borderRadius: 15,
        padding: 10,
        backgroundColor: "#eee"
    },
    heading: {
        fontWeight: "bold",
        fontSize: 30,
        marginBottom: 60,
    },
    button: {
        alignItems: "center",
        padding: 10,
        marginBottom: 15,
        height: 40,
        borderRadius: 15,
        width: 200,
    },
    buttonLogIn: {
        backgroundColor: "rgb(0, 136, 235)",
    },
    buttonSignUp: {
        backgroundColor: "#fff",
        borderColor: "rgb(0, 136, 235)",
        borderWidth: 1,
    },
    textWhite: {
        color: "#fff",
    },
    textMain: {
        color: "rgb(0, 136, 235)",
    },
    buttonsView: {},
    inputView: {
        marginBottom: 30
    },

});