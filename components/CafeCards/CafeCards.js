import {StyleSheet, TouchableOpacity, View, Image, Text, SafeAreaView} from "react-native";
import {createNativeStackNavigator} from "@react-navigation/native-stack";


export default function CafeCards({navigation, data}) {


    function CafeScreen(data) {

        return (
            <View>
                <Text>mnnn</Text>

            </View>
        )
    }

    return (
        <View style={styles.container_cards}>
            {showCards(navigation,data, CafeScreen)}
        </View>
    );
}



function showCards(navigation, data, cafeScreen) {
    const Stack = createNativeStackNavigator();

    return data.map(e => {

        return (
            <>
                {console.log(e.engName)}
                <TouchableOpacity
                    key={e.id}
                    style={styles.cafe_card}
                    onPress={(e) =>
                        navigation.navigate(e.engName)
                    }
                >
                    <Image
                        source={e.imgUrl}
                        // source={{uri: "https://teremok.ru/images/logo/desktop-red.svg"}}
                        style={[styles.cafe_img, e.style]}
                        resizeMode="contain"

                    />
                    <View style={styles.transparentView}/>
                    <Text style={styles.textCard}>{e.name}</Text>
                </TouchableOpacity>
                <Stack.Screen name={e.engName}
                              component={(e) => {
                                  return (
                                      <View>
                                          {e.key}
                                      </View>
                                  )
                              }}>
                </Stack.Screen>
            </>
        )
    })
}

const styles = StyleSheet.create({
    container_cards: {
        flex: 10,
        flexDirection: "row",
        justifyContent: 'center',
        flexWrap: "wrap",
    },
    cafe_card: {
        width: 160,
        height: 160,
        backgroundColor: "#fff",
        borderRadius: 30,
        margin: 10,
        alignItems: "center",
        justifyContent: "center",

        // -------------------------
        // borderWidth: 1,
        // borderStyle: "solid",
        // borderColor: "black",
        //--------------------------
    },
    transparentView: {
        position: "absolute",
        width: 160,
        height: 160,
        backgroundColor: "rgba(220, 220, 220, 0.20)",
        borderRadius: 30,
    },
    cafe_img: {
        // width: 160,
        // height: 160,
        borderRadius: 30,
        backgroundColor: "#fff"

    },
    cafe_description: {},
    textCard: {
        position: "absolute",
        fontSize: 14,
        fontWeight: "bold",
        top: 12,
        left: 12,
        color: "#fff",
        padding: 3,
        borderRadius: 7,
        backgroundColor: "rgba(0, 136, 235, 0.4)",
    },
});

