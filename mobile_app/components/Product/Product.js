import {View, Image, Text} from "react-native";


export default function Product(props) {

    const product = props.route.params

    // console.log(product)

    return (
        <View>
            <Image source={product.img}/>
            <Text>{product.name.toUpperCase()}</Text>
            <Text>СОСТАВ: {product.ingredients.toUpperCase()}</Text>
        </View>
    )
}