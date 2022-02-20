import {NavigationContainer} from '@react-navigation/native';
import {createNativeStackNavigator} from '@react-navigation/native-stack';
import LogIn from "./components/LogIn/LogIn";
import HomeScreen from "./components/Home/Home";
import CafeScreen from "./components/CafeSreen/CafeScreen";
import Cart from "./components/Cart/Cart";
import SignUp from "./components/SignUp/SignUp"
import Product from "./components/Product/Product";


export default function App() {

    const Stack = createNativeStackNavigator();

    return (
        <NavigationContainer>
            <Stack.Navigator>
                <Stack.Screen name="Home" component={HomeScreen} options={{headerShown: false}} />
                <Stack.Screen name="LogIn" component={LogIn} options={{title: ""}} />
                <Stack.Screen name="SignUp" component={SignUp} options={{title: ""}} />
                <Stack.Screen name="CafeScreen" component={CafeScreen} />
                <Stack.Screen name="Cart" component={Cart} />
                <Stack.Screen name="Product" component={Product} />
            </Stack.Navigator>
        </NavigationContainer>
    );

}
