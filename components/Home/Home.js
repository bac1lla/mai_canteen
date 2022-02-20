import {ScrollView, StyleSheet, View} from "react-native";
import Header from "../Header/Header";
import Map from "../Map/Map";
import CafeCards from "../CafeCards/CafeCards";

const data = [
    {
        id: 6,
        imgUrl: require("./../../examples/teremok.jpg"),
        style: {
            width: 126,
            height: 126,
            borderRadius: 30,
        },
        name: "Теремок",
        engName: "Teremok",
        description: "Пельмени с говном"
    },
    {
        id: 1,
        imgUrl: require('./../../examples/christmas-tree.png'),
        name: "Елочка",
        engName: "Elochka",
        description: "Пельмени с говном"
    },
    {
        id: 2,
        // imgUrl: "https://sun9-24.userapi.com/impf/c846520/v846520864/1054c/zjPoFoWXIT4.jpg?size=640x640&quality=96&sign=9e1bbc52e63719fcf1a88ea01f12704e&type=album",
        imgUrl: require("./../../examples/takeoff.png"),
        name: "Взлёт",
        engName: "Vzlet",
        description: "Пельмени с говном"
    },
    {
        id: 3,
        imgUrl: require("./../../examples/6_icon.png"),
        name: "Буфет №6>",
        engName: "Bufet",
        description: "Пельмени с говном"
    },
    {
        id: 4,
        imgUrl: require("./../../examples/planet.png"),
        name: "Космос",
        engName: "Kosmos",
        description: "Пельмени с говном"
    },
    {
        id: 5,
        imgUrl: require("./../../examples/icebreaker.png"),
        name: "Ледокол",
        engName: "Ledokol",
        description: "Пельмени с говном"
    },
]

export default function HomeScreen ({navigation}) {
    return (

        <ScrollView style={styles.growContainer}>
            <View style={styles.container}>

                <Header
                    navigation={navigation}
                />
                <Map/>
                <CafeCards
                    navigation={navigation}
                    data={data}
                />

            </View>
        </ScrollView>

    );
};

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
})
