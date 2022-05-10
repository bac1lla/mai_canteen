import {dataCafes} from "../../../api/getData";
import CafeCard from "../CafeCard/CafeCard";


export default function Home({site, setSite}) {

    return (
        <div style={styles.container}>
            <button onClick={() => setSite(!site)} >МЕНЯЙ</button>
            <h2 style={styles.pageTitle}>Рестораны</h2>
            <div style={styles.cafesList}>
                {dataCafes.map(cafe => <CafeCard cafe={cafe}/>)}
            </div>
        </div>
    )
}

const styles = {
    header: {
        marginTop: 0,
        height: 72,
        justifyContent: 'space-between',
        alignItems: 'center',
        padding: '12px 16px',
    },
    pageTitle: {
        fontSize: 46,
        textAlign: "left",
    },
    cafesList: {
        display: 'flex',
        flexWrap: 'wrap',
        alignItems: 'center',
        justifyContent: 'center',
    },

}
