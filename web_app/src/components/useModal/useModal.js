import {useState} from "react";

export default function useModal() {

const [isModal, setModal] = useState({visible: false, data: {}})
const onClose = () => setModal({visible: false, data: isModal.data})

    return {
        onClose: onClose,
        isModal
    }
}
