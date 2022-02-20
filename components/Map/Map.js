import {
    StyleSheet,
    View,
} from 'react-native';
import {useState} from "react";
import MapView  from "react-native-maps";
import {Marker} from "react-native-maps";

export default function Map() {


    const [region, setRegion] = useState({
        latitude: 55.810880121446665,
        longitude: 37.4993526070918,
        latitudeDelta: 0.00350,
        longitudeDelta: 0.0035,
    });
    return (
        <View style={styles.map_container}>
            <MapView
                style={styles.map}
                initialRegion={{
                    latitude: 55.810880121446665,
                    longitude: 37.4993526070918,
                    latitudeDelta: 0.0035,
                    longitudeDelta: 0.0035,
                }}
                //onRegionChangeComplete runs when the user stops dragging MapView
                onRegionChangeComplete={(region) => setRegion(region)}
            >
                <Marker
                    coordinate={{
                        latitude: 55.810630,
                        longitude: 37.500729,
                    }}
                    image={require("./../../examples/fir_92.png")}
                />
                <Marker
                    coordinate={{
                        latitude: 55.81093136633548,
                        longitude: 37.49903610642653,
                    }}
                    image={require("./../../examples/6_icon.png")}

                />
            </MapView>
            {/*Display user's current region:*/}
            {/*<Text style={styles.text}>Current latitude: {region.latitude}</Text>*/}
            {/*<Text style={styles.text}>Current longitude: {region.longitude}</Text>*/}
            {/*<Text style={styles.text}>Current longitude: {region.latitudeDelta}</Text>*/}
            {/*<Text style={styles.text}>Current longitude: {region.longitudeDelta}</Text>*/}
        </View>
    );
}
const styles = StyleSheet.create({
    map: {
        height: 190,
        width: 370,
        backgroundColor: "rgba(38, 35, 205, 0.47)",
        marginBottom: 20,
        borderRadius: 30,
        borderColor: "rgba(200, 200, 200, .4)",
        borderWidth: 1,
    },
    map_container: {
        borderRadius: 30,
    }
});