import {StyleSheet, TouchableOpacity, View, Image, Text} from "react-native";


export default function CafeCards({navigation, data}) {

    return (
        <View style={styles.container_cards}>
            {showCards(navigation, data)}
        </View>
    );
}

function showCards(navigation, data) {

    return data.map(eachCafe => {

        return (
            <TouchableOpacity
                key={eachCafe.id}
                style={styles.cafe_card}
                onPress={() =>
                    navigation.navigate("CafeScreen", eachCafe)
                }
            >
                <Image
                    source={eachCafe.imgUrl}
                    style={[styles.cafe_img, eachCafe.style]}
                    resizeMode="contain"
                />
                <View style={styles.transparentView}/>
                <Text style={styles.textCard}>{eachCafe.name}</Text>
            </TouchableOpacity>
        )
    })
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

