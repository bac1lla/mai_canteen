import {StatusBar} from 'expo-status-bar';
import {
    StyleSheet,
    Text,
    View,
    TextInput,
    Button,
    Alert,
    Image,
    Pressable,
    ScrollView,
    TouchableOpacity,
    Modal
} from 'react-native';
import LogIn from "./components/LogIn/LogIn";
import {NavigationContainer} from '@react-navigation/native';
import {createNativeStackNavigator} from '@react-navigation/native-stack';
import {useState} from "react";
import HomeScreen from "./components/Home/Home";




function eachCafeScreen() {

    return data.map( e => {
        return (<ScrollView style={styles.growContainer}>
            <View style={styles.container}>
                <View style={styles.container_img_cafe}>
                    <Image
                        style={styles.img_main_cafe}
                        source={data.imgUrl}
                        resizeMode="contain"
                    >
                    </Image></View>

                <Text>{e.name}</Text>
                <View style={styles.food_container}>
                    {foodCards(dataFood)}
                </View>
            </View>
        </ScrollView>
        )
    }
    )

}

const Teremok = ({navigation, route}) => {

    return (

        <ScrollView style={styles.growContainer}>
            <View style={styles.container}>
                <View style={styles.container_img_cafe}>
                    <Image
                        style={styles.img_main_cafe}
                        source={dataRestaurants[0].imgUrl}
                        resizeMode="contain"
                    >
                    </Image></View>

                <Text>Теремок</Text>
                <View style={styles.food_container}>
                    {foodCards(dataFood)}
                </View>
            </View>

        </ScrollView>

    );
};



const data = [
    {
        id: 6,
        key: 6,
        imgUrl: require("./examples/teremok.jpg"),
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
        key: 1,
        imgUrl: require('./examples/christmas-tree.png'),
        name: "Елочка",
        engName: "Elochka",
        description: "Пельмени с говном"
    },
    {
        id: 2,
        key: 2,
        // imgUrl: "https://sun9-24.userapi.com/impf/c846520/v846520864/1054c/zjPoFoWXIT4.jpg?size=640x640&quality=96&sign=9e1bbc52e63719fcf1a88ea01f12704e&type=album",
        imgUrl: require("./examples/takeoff.png"),
        name: "Взлёт",
        description: "Пельмени с говном"
    },
    {
        id: 3,
        key: 3,
        imgUrl: require("./examples/6_icon.png"),
        name: "Буфет №6>",
        description: "Пельмени с говном"
    },
    {
        id: 4,
        key: 4,
        imgUrl: require("./examples/planet.png"),
        name: "Космос",
        description: "Пельмени с говном"
    },
    {
        id: 5,
        key: 5,
        imgUrl: require("./examples/icebreaker.png"),
        name: "Ледокол",
        description: "Пельмени с говном"
    },
]

function foodCards(data) {

    const [modalVisible, setModalVisible] = useState(false);

    return data.map(e => {
        return (
            <TouchableOpacity style={styles.food_card} key={e.key} onPress={() => setModalVisible(!modalVisible)}>
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

const dataFood = [
    {
        key: "1",
        name: "БЛИН E-MAIL С ГРИБАМИ И СЫРОМ",
        price: 200,
        img: require("./examples/planet.png")
    },
    {
        key: "2",
        name: "БЛИН E-MAIL С ГРИБАМИ И СЫРОМ",
        price: 200,
        img: require("./examples/map_example.png")
    },
    {
        key: "3",
        name: "БЛИН E-MAIL С ГРИБАМИ И СЫРОМ",
        price: 200,
        img: require("./examples/planet.png")
    },
    {
        key: "4",
        name: "БЛИН E-MAIL С ГРИБАМИ И СЫРОМ",
        price: 200,
        img: require("./examples/planet.png")
    },
    {
        key: "5",
        name: "БЛИН E-MAIL С ГРИБАМИ И СЫРОМ",
        price: 200,
        img: require("./examples/planet.png")
    },
    {
        key: "6",
        name: "БЛИН E-MAIL С ГРИБАМИ И СЫРОМ",
        price: 200,
        img: require("./examples/fir_92.png")
    },

]



export default function App() {


    const Stack = createNativeStackNavigator();

    function cafeScreens(data) {

        return data.map(e => {

            return (
                <Stack.Screen
                    key={e.key}
                    name={e.engName}
                    component={e.screenName}
                    options={{title: e.name}}
                >

                </Stack.Screen>
            )
        })
    }

    return (
        <NavigationContainer>
            <Stack.Navigator>
                <Stack.Screen
                    name="Home"
                    component={HomeScreen}
                    options={{headerShown: false}}
                />

                <Stack.Screen
                    name="LogIn"
                    component={LogIn}
                    options={{title: ""}}
                />

                {/*<Stack.Screen*/}
                {/*    name={data.id}*/}
                {/*    component={data.id}*/}
                {/*/>*/}

            </Stack.Navigator>
        </NavigationContainer>
    );

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
