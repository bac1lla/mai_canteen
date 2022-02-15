import {
    StyleSheet,
    TouchableOpacity,
    Image
} from 'react-native';

export default function Map() {
    return (
        <TouchableOpacity style={styles.map}>
            <Image
                style={styles.map}
                source={require('../../examples/map_example.png')}
            />


        </TouchableOpacity>
    );
}
const styles = StyleSheet.create({
    map: {
        height: 150,
        width: 370,
        backgroundColor: "rgba(38, 35, 205, 0.47)",
        marginBottom: 20,
        borderRadius: 30,
    },
});