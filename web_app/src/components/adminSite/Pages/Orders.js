
import { Container } from 'react-bootstrap'

const dataOrders = [
    {
        id: 1,
        timeStart: "12:00",
        timeEnd: "13:00",
        meals: [
            {
                id: 1,
                count: 1,
                name: "Подлива",
                price: 1234,
            },
            {
                id: 2,
                count: 1,
                name: "Щи",
                price: 1234,
            },
            {
                id: 3,
                count: 3,
                name: "Слива",
                price: 1234,
            },
        ],

    },
    {
        id: 2,
        timeStart: "12:00",
        timeEnd: "13:00",
        meals: [
            {
                id: 1,
                count: 1,
                name: "Жижа",
                price: 1234,
            },
            {
                id: 2,
                count: 1,
                name: "Сок",
                price: 1234,
            },
        ],

    },
    {
        id: 3,
        timeStart: "12:00",
        timeEnd: "13:00",
        meals: [
            {
                id: 1,
                count: 1,
                name: "Жижа",
                price: 1234,
            },
            {
                id: 2,
                count: 1,
                name: "Сок",
                price: 1234,
            },
            {
                id: 3,
                count: 1,
                name: "Жижа",
                price: 1234,
            },
            {
                id: 4,
                count: 1,
                name: "Жижа",
                price: 1234,
            },
            {
                id: 5,
                count: 1,
                name: "Жижа",
                price: 1234,
            },
        ],
    },
    {
        id: 1,
        timeStart: "12:00",
        timeEnd: "13:00",
        meals: [
            {
                id: 1,
                count: 1,
                name: "Подлива",
                price: 1234,
            },
            {
                id: 2,
                count: 1,
                name: "Щи",
                price: 1234,
            },
            {
                id: 3,
                count: 3,
                name: "Слива",
                price: 1234,
            },
        ],

    },
    {
        id: 1,
        timeStart: "12:00",
        timeEnd: "13:00",
        meals: [
            {
                id: 1,
                count: 1,
                name: "Подлива",
                price: 1234,
            },
            {
                id: 2,
                count: 1,
                name: "Щи",
                price: 1234,
            },
            {
                id: 3,
                count: 3,
                name: "Слива",
                price: 1234,
            },
        ],

    },
    {
        id: 1,
        timeStart: "12:00",
        timeEnd: "13:00",
        meals: [
            {
                id: 1,
                count: 1,
                name: "Подлива",
                price: 1234,
            },
            {
                id: 2,
                count: 1,
                name: "Щи",
                price: 1234,
            },
            {
                id: 3,
                count: 3,
                name: "Слива",
                price: 1234,
            },
        ],

    },
    {
        id: 1,
        timeStart: "12:00",
        timeEnd: "13:00",
        meals: [
            {
                id: 1,
                count: 1,
                name: "Подлива",
                price: 1234,
            },
            {
                id: 2,
                count: 1,
                name: "Щи",
                price: 1234,
            },
            {
                id: 3,
                count: 3,
                name: "Слива",
                price: 1234,
            },
        ],

    },
    {
        id: 1,
        timeStart: "12:00",
        timeEnd: "13:00",
        meals: [
            {
                id: 1,
                count: 1,
                name: "Подлива",
                price: 1234,
            },
            {
                id: 2,
                count: 1,
                name: "Щи",
                price: 1234,
            },
            {
                id: 3,
                count: 3,
                name: "Слива",
                price: 1234,
            },
        ],

    },
]

function mealsInOrder(meals) {
    return meals.map( (meal, i) => {
        return (
            <p key={i} className="card-text text-start">{meal.name} {meal.price}</p>
        )
    })
}

function createOrder(ordersArr) {
    return ordersArr.map((order, i) => {
        return (
            <div key={i} className="card text-center bg-light mb-3" style={{"width": 500}}>
                        <div className="card-body">
                            <h5 className="card-header bg-warning text-center">ЗАКАЗ {order.id} {order.timeStart}</h5>
                            {mealsInOrder(order.meals)}
                            <button className="btn btn-outline-success me-md-4">ПРИНЯТЬ</button>
                            <button className="btn btn-secondary me-md-4">ЗАКАЗ ГОТОВ</button>
                            <button className="btn btn-outline-danger me-md-4">ОТКЛОНИТЬ</button>
                        </div>
            </div>
        )
    })
}

export default function Orders ({site, setSite}) {
        return (
            <Container className='mt-5' style={{minHeight: "100vh"}}>
                {/*<button onClick={() => setSite(!site)} >МЕНЯЙ</button>*/}
                <h5 className="card-header bg-light text-center">ЗАКАЗЫ</h5>
                <div className="d-flex form-control flex-wrap" style={{justifyContent: "space-around"}}>
                    {createOrder(dataOrders)}
                </div>
            </Container>
        )
    }

