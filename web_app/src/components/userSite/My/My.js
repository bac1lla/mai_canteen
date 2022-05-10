export default function My ({setToken, setSite}) {

    return (
        <button onClick={() => {
            setToken('')
            setSite(true)
        }}>Выход здесь епта</button>
    )
}