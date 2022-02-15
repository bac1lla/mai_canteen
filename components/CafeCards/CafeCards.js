import {StyleSheet, TouchableOpacity, View, Image, Text} from "react-native";


export default function CafeCards(navigation) {

    function showCards(data) {
        return data.map(e => {

            return (
                <TouchableOpacity
                    key={e.key}
                    style={styles.cafe_card}
                    onPress={() =>
                        navigation.navigation.navigate('Teremok')
                    }
                >
                    <Image
                        source={e.imgUrl}
                        // source={{uri: "https://teremok.ru/images/logo/desktop-red.svg"}}
                        style={[styles.cafe_img, e.style]}
                        resizeMode="contain"

                    />
                    <View style={styles.transparentView}/>
                    <Text style={styles.textCard}>{e.name}</Text>
                </TouchableOpacity>
            )
        })
    }


    return (
        <View style={styles.container_cards}>
            {showCards(data)}
        </View>
    );
}

const styles = StyleSheet.create({
    container_cards: {
        flex: 10,
        flexDirection: "row",
        justifyContent: 'center',
        flexWrap: "wrap",
    },
    cafe_card: {
        width: 160,
        height: 160,
        backgroundColor: "#fff",
        borderRadius: 30,
        margin: 10,
        alignItems: "center",
        justifyContent: "center",

        // -------------------------
        // borderWidth: 1,
        // borderStyle: "solid",
        // borderColor: "black",
        //--------------------------
    },
    transparentView: {
        position: "absolute",
        width: 160,
        height: 160,
        backgroundColor: "rgba(220, 220, 220, 0.20)",
        borderRadius: 30,
    },
    cafe_img: {
        // width: 160,
        // height: 160,
        borderRadius: 30,
        backgroundColor: "#fff"

    },
    cafe_description: {},
    textCard: {
        position: "absolute",
        fontSize: 14,
        fontWeight: "bold",
        top: 12,
        left: 12,
        color: "#fff",
        padding: 3,
        borderRadius: 7,
        backgroundColor: "rgba(0, 136, 235, 0.4)",
    },
});

const data = [
    {
        id: 6,
        key: 6,
        imgUrl: require("./../../examples/teremok.jpg"),
        style: {
            width: 126,
            height: 126,
            borderRadius: 30,
        },
        name: "Теремок",
        description: "Пельмени с говном"
    },
    {
        id: 1,
        key: 1,
        imgUrl: require('./../../examples/christmas-tree.png'),
        name: "Елочка",
        description: "Пельмени с говном"
    },
    {
        id: 2,
        key: 2,
        // imgUrl: "https://sun9-24.userapi.com/impf/c846520/v846520864/1054c/zjPoFoWXIT4.jpg?size=640x640&quality=96&sign=9e1bbc52e63719fcf1a88ea01f12704e&type=album",
        imgUrl: require("./../../examples/takeoff.png"),
        name: "Взлёт",
        description: "Пельмени с говном"
    },
    {
        id: 3,
        key: 3,
        imgUrl: require("./../../examples/6_icon.png"),
        name: "Буфет №6>",
        description: "Пельмени с говном"
    },
    {
        id: 4,
        key: 4,
        imgUrl: require("./../../examples/planet.png"),
        name: "Космос",
        description: "Пельмени с говном"
    },
    {
        id: 5,
        key: 5,
        imgUrl: require("./../../examples/icebreaker.png"),
        name: "Ледокол",
        description: "Пельмени с говном"
    },
]