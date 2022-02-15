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
    TouchableOpacity
} from 'react-native';
import Header from "./components/Header/Header";
import Map from "./components/Map/Map";
import CafeCards from "./components/CafeCards/CafeCards";
import LogIn from "./components/LogIn/LogIn";
import {NavigationContainer} from '@react-navigation/native';
import {createNativeStackNavigator} from '@react-navigation/native-stack';


const Teremok = ({navigation, route}) => {
    return (

        <ScrollView style={styles.growContainer}>
            <View style={styles.container}>
                <Header navigation={navigation}/>

                <Image source={dataRestaurants[0].imgUrl}>
                </Image>


            </View>
        </ScrollView>

    );
};

const Elochka = ({navigation, route}) => {
    return (

        <ScrollView style={styles.growContainer}>
            <View style={styles.container}>

                <Image source={dataRestaurants[1].imgUrl}>

                </Image>

            </View>
        </ScrollView>

    );
};

const dataRestaurants = [
    {
        key: "1",
        name: "Теремок",
        engName: "Teremok",
        screenName: Teremok,
        imgUrl: require("./examples/teremok_cafe.jpg"),
    },
    {
        key: "2",
        name: "Елочка",
        engName: "Elochka",
        screenName: Elochka,
        imgUrl: require("./examples/christmas-tree.png"),
    }
]


const HomeScreen = ({navigation}) => {
    return (

        <ScrollView style={styles.growContainer}>
            <View style={styles.container}>

                <Header
                    navigation={navigation}
                />
                <Map
                />
                <CafeCards
                    navigation={navigation}
                />

            </View>
        </ScrollView>

    );
};

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
                />
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

                {cafeScreens(dataRestaurants)}

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
    }
});
