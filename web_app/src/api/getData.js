const dataCafes = [
    {
        id: "1",
        name: "Теремок",
        img: require("./../img/empty.png"),
    },
    {
        id: "2",
        name: "Vibe",
        img: require("./../img/empty.png"),
    },
    {
        id: "3",
        name: "Kebab",
        img: require("./../img/empty.png"),
    },
    {
        id: "4",
        name: "Космос",
        img: require("./../img/empty.png"),
    },
    {
        id: "5",
        name: "Буфет №6",
        img: require("./../img/empty.png"),
    },
    {
        id: "6",
        name: "Столовая",
        img: require("./../img/empty.png"),
    },
    {
        id: "7",
        name: "Ледокол",
        img: require("./../img/empty.png"),
    },
]

const dataMenu = {
    "1": [
        {
            id: "1",
            name: "Круассан",
            ingredients: "Мука, вода, сахар",
            img: require("./../img/empty.png"),
            price: 400,
            idCafe: 1,
        },
        {
            id: "2",
            name: "Борщ",
            ingredients: "Сахар, мука, вода",
            price: 200,
            idCafe: 1,
            img: require("./../img/empty.png"),
        },
        {
            id: "3",
            name: "Шаурма",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 100,
            idCafe: 1,
        },
        {
            id: "4",
            name: "Карбонара",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 1,
        },
        {
            id: "5",
            name: "Суп",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 1,
        },
        {
            id: "6",
            name: "Морс",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 1,
        },
        {
            id: "7",
            name: "Блин",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 1,
        },
        {
            id: "8",
            name: "Селедка",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 1,
        },
    ],
    "2": [
        {
            id: "1",
            name: "Багет",
            ingredients: "Мука, вода, сахар",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 2,
        },
        {
            id: "2",
            name: "Картофель фри",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 2,
        },
        {
            id: "3",
            name: "Креветки",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 2,
        },
        {
            id: "4",
            name: "Мидии",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 2,
        },
        {
            id: "5",
            name: "Фаланга краба",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 2,
        },
        {
            id: "6",
            name: "Филадельфия",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 2,
        },
        {
            id: "7",
            name: "Сяке с лососем",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 2,
        },
        {
            id: "8",
            name: "Энергетик",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 2,
        },
    ],
    "3": [        {
            id: "1",
            name: "Круассан",
            ingredients: "Мука, вода, сахар",
            img: require("./../img/empty.png"),
        price: 200,
        idCafe: 3,
        },
        {
            id: "2",
            name: "Борщ",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 3,
        },
        {
            id: "3",
            name: "Шаурма",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 3,
        },
        {
            id: "4",
            name: "Карбонара",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 3,
        },
        {
            id: "5",
            name: "Суп",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 3,
        },
        {
            id: "6",
            name: "Морс",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 3,
        },
        {
            id: "7",
            name: "Блин",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 3,
        },
        {
            id: "8",
            name: "Селедка",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 3,
        },],
    "4": [        {
            id: "1",
            name: "Круассан",
            ingredients: "Мука, вода, сахар",
            img: require("./../img/empty.png"),
        price: 200,
        idCafe: 4,
        },
        {
            id: "2",
            name: "Борщ",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 4,
        },
        {
            id: "3",
            name: "Шаурма",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 4,
        },
        {
            id: "4",
            name: "Карбонара",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 4,
        },
        {
            id: "5",
            name: "Суп",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 4,
        },
        {
            id: "6",
            name: "Морс",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 4,
        },
        {
            id: "7",
            name: "Блин",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 4,
        },
        {
            id: "8",
            name: "Селедка",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 4,
        },],
    "5": [        {
            id: "1",
            name: "Круассан",
            ingredients: "Мука, вода, сахар",
            img: require("./../img/empty.png"),
        price: 200,
        idCafe: 5,
        },
        {
            id: "2",
            name: "Борщ",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 5,
        },
        {
            id: "3",
            name: "Шаурма",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 5,
        },
        {
            id: "4",
            name: "Карбонара",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 5,
        },
        {
            id: "5",
            name: "Суп",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 5,
        },
        {
            id: "6",
            name: "Морс",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 5,
        },
        {
            id: "7",
            name: "Блин",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 5,
        },
        {
            id: "8",
            name: "Селедка",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 5,
        },],
    "6": [        {
            id: "1",
            name: "Круассан",
            ingredients: "Мука, вода, сахар",
            img: require("./../img/empty.png"),
        price: 200,
        idCafe: 6,
        },
        {
            id: "2",
            name: "Борщ",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 6,
        },
        {
            id: "3",
            name: "Шаурма",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 6,
        },
        {
            id: "4",
            name: "Карбонара",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 6,
        },
        {
            id: "5",
            name: "Суп",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 6,
        },
        {
            id: "6",
            name: "Морс",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 6,
        },
        {
            id: "7",
            name: "Блин",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 6,
        },
        {
            id: "8",
            name: "Селедка",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 6,
        },],
    "7": [        {
            id: "1",
            name: "Круассан",
            ingredients: "Мука, вода, сахар",
            img: require("./../img/empty.png"),
        price: 200,
        idCafe: 7,
        },
        {
            id: "2",
            name: "Борщ",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 7,
        },
        {
            id: "3",
            name: "Шаурма",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 7,
        },
        {
            id: "4",
            name: "Карбонара",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 7,
        },
        {
            id: "5",
            name: "Суп",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 7,
        },
        {
            id: "6",
            name: "Морс",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 7,
        },
        {
            id: "7",
            name: "Блин",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 7,
        },
        {
            id: "8",
            name: "Селедка",
            ingredients: "Сахар, мука, вода",
            img: require("./../img/empty.png"),
            price: 200,
            idCafe: 7,
        },
    ],
}

const users = [
    {
        id: "1",
        login: "qwerty",
        password: "qwerty",
    }
]

export {dataMenu, dataCafes, users}