import {View, Text, Image, ScrollView, StyleSheet, TouchableOpacity, Modal, Alert, Pressable} from "react-native";
import {useState} from "react";



export default function CafeScreen({navigation, route}) {

    const cafe = route.params;
    const menu = dataFood.teremok

    return (
        <ScrollView style={styles.growContainer}>
            <View style={styles.container}>
                <View style={styles.container_img_cafe}>
                    <Image
                        style={styles.img_main_cafe}
                        source={cafe.imgUrl}
                        resizeMode="contain"
                    >
                    </Image>
                </View>

                <Text>{cafe.name.toUpperCase()}</Text>
                <View style={styles.food_container}>
                    {foodCards(menu, navigation)}
                </View>
            </View>
        </ScrollView>
    )
}

function foodCards(data, navigation) {

    return data.map(product => {
        return (
            <TouchableOpacity style={styles.food_card} key={product.id} onPress={() => navigation.navigate("Product", product)}>
                <Text style={styles.text_food_card}>{product.name.toUpperCase()}</Text>
                <Image source={product.img} style={styles.img_food_card} resizeMode="contain"/>
                <TouchableOpacity style={styles.price_btn}>
                    <Text>{product.price}</Text>
                </TouchableOpacity>
            </TouchableOpacity>
        )
    })
}

const dataFood = {

    "teremok": [
        {
            id: 10,
            name: "БЛИН E-MAIL С ГРИБАМИ И СЫРОМ",
            price: 100,
            img: require("./../../examples/planet.png"),
            ingredients: "грибы, сыр, сливочный соус, говно",
        },
        {
            id: 11,
            name: "БЛИН с сыром",
            price: 200,
            img: require("./../../examples/map_example.png"),
            ingredients: "грибы, сыр, сливочный соус, говно",

        },
        {
            id: 12,
            name: "БЛИН богатырь",
            price: 200,
            img: require("./../../examples/planet.png"),
            ingredients: "грибы, сыр, сливочный соус, говно",

        },
        {
            id: 13,
            name: "БЛИН",
            price: 200,
            img: require("./../../examples/planet.png"),
            ingredients: "грибы, сыр, сливочный соус, говно",

        },
        {
            id: 14,
            name: "крем-суп",
            price: 200,
            img: require("./../../examples/planet.png"),
            ingredients: "грибы, сыр, сливочный соус, говно",

        },
        {
            id: 15,
            name: "морс",
            price: 200,
            img: require("./../../examples/fir_92.png"),
            ingredients: "грибы, сыр, сливочный соус, говно",

        }
    ],
    "elochka": [
        {
            id: 21,
            name: "Суп",
            price: 200,
            img: require("./../../examples/planet.png"),
            ingredients: "грибы, сыр, сливочный соус, говно",

        },
        {
            id: 22,
            name: "Пирожок",
            price: 200,
            img: require("./../../examples/map_example.png"),
            ingredients: "грибы, сыр, сливочный соус, говно",

        },
        {
            id: 23,
            name: "Желе",
            price: 200,
            img: require("./../../examples/planet.png"),
            ingredients: "грибы, сыр, сливочный соус, говно",

        },
        {
            id: 24,
            name: "Подлива",
            price: 200,
            img: require("./../../examples/planet.png"),
            ingredients: "грибы, сыр, сливочный соус, говно",

        },
        {
            id: 25,
            name: "Рис",
            price: 200,
            img: require("./../../examples/planet.png"),
            ingredients: "грибы, сыр, сливочный соус, говно",

        },
        {
            id: 26,
            name: "Котлета",
            price: 200,
            img: require("./../../examples/fir_92.png"),
            ingredients: "грибы, сыр, сливочный соус, говно",

        }
    ],


}

const styles = StyleSheet.create({
    growContainer: {
        // flexGrow: 1,
    },
    container: {
        margin: 5,
        // flex: 1,
        alignItems: 'center',
        // justifyContent: 'center',
        // flexGrow: 1,
        // flexDirection: "column",
    },
    img_main_cafe: {
        //Below lines will help to set the border radius
        height: 100,
        borderBottomLeftRadius: 70,
        borderBottomRightRadius: 70,
        borderTopRightRadius: 70,
        borderTopLeftRadius: 70,
        overflow: 'hidden',
    },
    container_img_cafe: {
        flex: 1,
        // justifyContent: 'center',
        // alignItems: 'center',
        // backgroundColor: '#606070',
        // borderBottomLeftRadius: 40,
        // borderBottomRightRadius: 40,
    },
    food_container: {
        flex: 1,
        flexDirection: "row",
        flexWrap: "wrap",
        alignItems: "center",
        justifyContent: "center",
    },
    food_card: {
        // flex: 1,
        justifyContent: "center",
        alignItems: "center",
        width: 115,
        height: 170,
        borderWidth: 1,
        borderRadius: 15,
        borderColor: "#000",
        margin: 5,
        padding: 5,
    },
    img_food_card: {
        height: 100,
        width: 75,
    },
    text_food_card: {
        fontSize: 10,
    },
    price_btn: {
        backgroundColor: "rgba(0, 136, 235, 0.4)",

    }
});