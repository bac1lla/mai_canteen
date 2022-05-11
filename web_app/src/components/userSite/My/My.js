import GoHomeBtn from "../GoHomeBtn/GoHomeBtn";

export default function My ({setToken, setSite}) {

    return (
        <div>
            <GoHomeBtn />
            <button onClick={() => setToken('')}>Выход здесь епта</button>
        </div>
    )
}