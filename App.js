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




export default function App() {

    const Stack = createNativeStackNavigator();

    const HomeScreen = ({ navigation }) => {
        return (

            <ScrollView style={styles.growContainer}>
                <View style={styles.container}>

                    <Header
                        navigation={navigation}
                    />
                    <Map/>
                    <CafeCards/>

                </View>
            </ScrollView>

        );
    };



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
        flex: 1,
        alignItems: 'center',
        justifyContent: 'center',
        flexGrow: 1,
        flexDirection: "column",
    }
});
