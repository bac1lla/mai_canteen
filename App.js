
import LogIn from "./components/LogIn/LogIn";
import {NavigationContainer} from '@react-navigation/native';
import {createNativeStackNavigator} from '@react-navigation/native-stack';
import HomeScreen from "./components/Home/Home";
import CafeScreen from "./components/CafeSreen/CafeScreen";



export default function App() {

    const Stack = createNativeStackNavigator();

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

                <Stack.Screen
                    name={"CafeScreen"}
                    component={CafeScreen}
                />

            </Stack.Navigator>
        </NavigationContainer>
    );

}
