
import {View, Text, Image, Button} from "react-native";

export default function Cart(orderedFood) {



    return (
        <View>
            <Text>Здесь когда нибудь будет корзина, честно</Text>
            {showCart(orderedFood)}
        </View>
    )
}

function showCart (order) {
    return order.map( (meal) => {
        return (
            <View key={meal.id}>
                <Image src={meal.img} />
                <Text>Count: {"СДАЕЛАТЬ"}</Text>
                <Button />
            </View>
        )
    })
}