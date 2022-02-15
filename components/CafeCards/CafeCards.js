import {StyleSheet, TouchableOpacity, View, Image, Text} from "react-native";


export default function CafeCards() {

    function showCards(data) {
         return data.map( e => {

            return (
                <TouchableOpacity key={e.key} style={styles.cafe_card} >
                    <Text>{e.name}</Text>
                    <Image
                        source={{uri: e.imgUrl}}
                        style={styles.cafe_img}
                    />
                </TouchableOpacity>
            )
        })
    }


    return (
        <View style={styles.container_cards}>
            {showCards(data)}
        </View>
    );
}

const styles = StyleSheet.create({
    container_cards: {
        flex: 10,
        flexDirection: "row",
        justifyContent: 'center',
        flexWrap: "wrap",
    },
    cafe_card: {
        width: 180,
        // height: 200,
        // backgroundColor: "rgba(38, 35, 205, 0.29)",
        borderRadius: 30,
        margin: 5,
        // -------------------------
        borderWidth: 1,
        borderStyle: "solid",
        borderColor: "black",
        //--------------------------
    },
    cafe_img: {
        width: 180,
        height: 160,
        borderRadius: 30,
    },
    cafe_description: {

    },
});

const data = [
    {
        id: 1,
        key: 1,
        imgUrl: 'https://images11.popmeh.ru/upload/img_cache/8cc/8cc283485a0c81ab9d43e6b075bc5d21_cropped_1332x890.jpg',
        name: "Елочка",
        description: "Пельмени с говном"
    },
    {
        id: 2,
        key: 2,
        imgUrl: "https://postila.ru/data/f3/09/5a/08/f3095a081f12da0071db3cc02f28155066f91edc51cab2751dafc2c08f044c3c.jpg",
        name: "Буфет №6",
        description: "Пельмени с говном"
    },
    {
        id: 3,
        key: 3,
        imgUrl: "https://pbs.twimg.com/media/EjegCXcXcAEKbAg.jpg",
        name: "Ледокол",
        description: "Пельмени с говном"
    },
    {
        id: 4,
        key: 4,
        imgUrl: "https://s.fishki.net/upload/users/2017/12/24/384391/541973357424a473ec7f7d63a110eb8a.jpg",
        name: "Космос",
        description: "Пельмени с говном"
    },
    {
        id: 5,
        key: 5,
        imgUrl: 'https://images11.popmeh.ru/upload/img_cache/8cc/8cc283485a0c81ab9d43e6b075bc5d21_cropped_1332x890.jpg',
        name: "Елочка",
        description: "Пельмени с говном"
    },
    {
        id: 6,
        key: 6,
        imgUrl: "https://postila.ru/data/f3/09/5a/08/f3095a081f12da0071db3cc02f28155066f91edc51cab2751dafc2c08f044c3c.jpg",
        name: "Буфет №6",
        description: "Пельмени с говном"
    },
    {
        id: 7,
        key: 7,
        imgUrl: "https://pbs.twimg.com/media/EjegCXcXcAEKbAg.jpg",
        name: "Ледокол",
        description: "Пельмени с говном"
    },
    {
        id: 8,
        key: 8,
        imgUrl: "https://s.fishki.net/upload/users/2017/12/24/384391/541973357424a473ec7f7d63a110eb8a.jpg",
        name: "Космос",
        description: "Пельмени с говном"
    },
]