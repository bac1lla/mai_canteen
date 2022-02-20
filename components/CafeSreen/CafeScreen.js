import {View, Text, Image, ScrollView, StyleSheet, TouchableOpacity, Modal, Alert, Pressable} from "react-native";
import {useState} from "react";



export default function CafeScreen(props) {

    const cafe = props.route.params;
    const food = dataFood.teremok

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

                <Text>{cafe.name}</Text>
                <View style={styles.food_container}>
                    {foodCards(food)}
                </View>
            </View>
        </ScrollView>
    )
}

function foodCards(data) {

    const [modalVisible, setModalVisible] = useState(false);

    return data.map(e => {
        return (
            <TouchableOpacity style={styles.food_card} key={e.id} onPress={() => setModalVisible(!modalVisible)}>
                <Text style={styles.text_food_card}>{e.name}</Text>
                <Image source={e.img} style={styles.img_food_card} resizeMode="contain"/>
                <TouchableOpacity>
                    <Text>{e.price}</Text>
                </TouchableOpacity>
                <Modal
                    animationType="slide"
                    transparent={true}
                    visible={modalVisible}
                    onRequestClose={() => {
                        Alert.alert("Modal has been closed.");
                        setModalVisible(!modalVisible);
                    }}
                >
                    <View style={styles.centeredView}>
                        <View style={styles.modalView}>
                            <Pressable
                                style={[styles.button, styles.buttonClose]}
                                onPress={() => setModalVisible(!modalVisible)}
                            >
                                <Text style={styles.textStyle}>Hide Modal</Text>
                            </Pressable>
                            <Image source={e.img}/>
                        </View>
                    </View>
                </Modal>
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
            img: require("./../../examples/planet.png")
        },
        {
            id: 11,
            name: "БЛИН с сыром",
            price: 200,
            img: require("./../../examples/map_example.png")
        },
        {
            id: 12,
            name: "БЛИН богатырь",
            price: 200,
            img: require("./../../examples/planet.png")
        },
        {
            id: 13,
            name: "БЛИН",
            price: 200,
            img: require("./../../examples/planet.png")
        },
        {
            id: 14,
            name: "крем-суп",
            price: 200,
            img: require("./../../examples/planet.png")
        },
        {
            id: 15,
            name: "морс",
            price: 200,
            img: require("./../../examples/fir_92.png")
        }
    ],
    "elochka": [
        {
            id: 21,
            name: "Суп",
            price: 200,
            img: require("./../../examples/planet.png")
        },
        {
            id: 22,
            name: "Пирожок",
            price: 200,
            img: require("./../../examples/map_example.png")
        },
        {
            id: 23,
            name: "Желе",
            price: 200,
            img: require("./../../examples/planet.png")
        },
        {
            id: 24,
            name: "Подлива",
            price: 200,
            img: require("./../../examples/planet.png")
        },
        {
            id: 25,
            name: "Рис",
            price: 200,
            img: require("./../../examples/planet.png")
        },
        {
            id: 26,
            name: "Котлета",
            price: 200,
            img: require("./../../examples/fir_92.png")
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
    //----------------------------------------------------------------------
    centeredView: {
        flex: 1,
        // justifyContent: "center",
        alignItems: "center",
        marginTop: 100,
    },
    modalView: {
        margin: 20,
        width: "100%",
        height: "100%",
        backgroundColor: "white",
        borderRadius: 70,
        padding: 35,
        alignItems: "center",
        shadowColor: "#000",
        shadowOffset: {
            width: 0,
            height: 2
        },
        shadowOpacity: 0.25,
        shadowRadius: 4,
        elevation: 5
    },
    button: {
        borderRadius: 20,
        padding: 10,
        elevation: 2
    },
    buttonOpen: {
        backgroundColor: "#F194FF",
    },
    buttonClose: {
        backgroundColor: "#2196F3",
    },
    textStyle: {
        color: "white",
        fontWeight: "bold",
        textAlign: "center"
    },
    modalText: {
        marginBottom: 15,
        textAlign: "center"
    },
    //===============================================================
});