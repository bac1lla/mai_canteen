import {StatusBar} from 'expo-status-bar';
import {StyleSheet, Text, View, TextInput, Button, Alert, Image, Pressable, ScrollView, TouchableOpacity} from 'react-native';

export default function App() {
    return (
        <ScrollView>
            <View style={styles.container}>
                <View style={styles.header}>
                    <TextInput
                        style={[styles.input, styles.text]}
                        // onChangeText={onChangeText}
                        value={"Поиск"}
                    />
                    <View style={styles.login}>
                        <Pressable
                            style={styles.login_btn}
                            onPress={() => Alert.alert('Cannot press this one')}
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

                <TouchableOpacity style={styles.map}/>

                <View style={styles.container_cards}>
                    <TouchableOpacity style={styles.cafe_card} />
                    <TouchableOpacity style={styles.cafe_card} />
                    <TouchableOpacity style={styles.cafe_card} />
                    <TouchableOpacity style={styles.cafe_card} />
                    <TouchableOpacity style={styles.cafe_card} />
                    <TouchableOpacity style={styles.cafe_card} />
                    <TouchableOpacity style={styles.cafe_card} />
                    <TouchableOpacity style={styles.cafe_card} />
                </View>


            </View>
        </ScrollView>
    );
}

const styles = StyleSheet.create({
    container: {
        flex: 1,
        backgroundColor: '#fff',
        alignItems: 'center',
        justifyContent: 'center',
        flexDirection: "column",
    },
    container_cards: {
        flex: 10,
        flexDirection: "row",
        justifyContent: 'center',
        flexWrap: "wrap",
        margin: 5,
    },
    header: {
        flex: 1,
        flexDirection: "row",
        alignItems: 'center',
        alignContent: "space-between",
        justifyContent: 'center',
        marginTop: 15,
    },
    map: {
        height: 150,
        width: 350,
        backgroundColor: "rgba(38, 35, 205, 0.47)",
        marginBottom: 20,
    },
    login: {
        flex: 1,
        flexDirection: "row",
        alignItems: 'center',
        justifyContent: 'center',
        marginLeft: 20
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
        width: 175,
        borderWidth: 1,
        borderRadius: 10,
        padding: 10,
    },
    cafe_card: {
        width: 160,
        height: 160,
        backgroundColor: "rgba(38, 35, 205, 0.29)",
        borderRadius: 30,
        margin: 5,
    },
    tinyLogo: {
        width: 30,
        height: 30,
        margin: 10,
    },
});
