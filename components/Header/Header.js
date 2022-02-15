import React from "react";
import {Alert, Image, Pressable, StyleSheet, Text, TextInput, View} from "react-native";
import LogIn from "../LogIn/LogIn";
import {NavigationContainer} from '@react-navigation/native';
import {createNativeStackNavigator} from '@react-navigation/native-stack';



export default function Header(navigation) {


    const Stack = createNativeStackNavigator();
    const [text, onChangeText] = React.useState("");
    console.log(navigation)
    return (
        <View style={styles.header}>
            <TextInput
                style={[styles.input, styles.text]}
                onChangeText={onChangeText}
                value={text}
                placeholder={"Поиск"}
            />
            <View style={styles.login}>
                <Pressable
                    style={styles.login_btn}
                    onPress={() =>
                        navigation.navigation.navigate('LogIn', { name: 'Jane' })
                    }
                >
                    <Text style={styles.text}>
                        Вход/регистрация
                    </Text>
                </Pressable>
                <Image
                    style={styles.tinyLogo}
                    source={{uri: 'https://uprostim.com/wp-content/uploads/2021/04/62_krug-png_-2-tys-izobrazhenij-najdeno-v-YAndeks.Kartinkah.png'}}
                />
            </View>
        </View>
    );
}


const styles = StyleSheet.create({
    header: {
        flex: 1,
        flexDirection: "row",
        alignItems: 'center',
        alignContent: "space-between",
        justifyContent: 'center',
        marginBottom: 20,
        marginTop: 20,
        // width: 330,
    },
    login: {
        flex: 1,
        flexDirection: "row",
        alignItems: 'center',
        justifyContent: 'center',
    },
    text: {
        fontSize: 12,
    },
    login_btn: {
        width: 100,
        fontSize: 12,
    },
    input: {
        height: 40,
        width: 180,
        borderWidth: 1,
        borderRadius: 10,
        padding: 10,
    },
    tinyLogo: {
        width: 30,
        height: 30,
        margin: 10,
    },
});
